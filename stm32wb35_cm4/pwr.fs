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
$00000010 constant PWR_CR1_FPDR                                     \ Flash power down mode during LPRun for CPU1
$00000020 constant PWR_CR1_FPDS                                     \ Flash power down mode during LPsSleep for CPU1
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
$00000040 constant PWR_CR2_PVME3                                    \ Peripheral voltage monitoring 3 enable: VDDA vs. 1.62V
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
$00000100 constant PWR_CR3_EBORHSDFB                                \ Enable BORH and Step Down counverter forced in Bypass interrups for CPU1
$00000200 constant PWR_CR3_RRS                                      \ SRAM2a retention in Standby mode
$00000400 constant PWR_CR3_APC                                      \ Apply pull-up and pull-down configuration
$00000800 constant PWR_CR3_EBLEA                                    \ Enable BLE end of activity interrupt for CPU1
$00001000 constant PWR_CR3_ECRPE                                    \ Enable critical radio phase end of activity interrupt for CPU1
$00002000 constant PWR_CR3_E802A                                    \ Enable end of activity interrupt for CPU1
$00004000 constant PWR_CR3_EC2H                                     \ Enable CPU2 Hold interrupt for CPU1
$00008000 constant PWR_CR3_EIWUL                                    \ Enable internal wakeup line for CPU1


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
$00008000 constant PWR_CR4_C2BOOT                                   \ BOOT CPU2 after reset or wakeup from Stop or Standby modes


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
$00000080 constant PWR_SR1_SDFBF                                    \ Step Down converter forced in Bypass interrupt flag
$00000100 constant PWR_SR1_BORHF                                    \ BORH interrupt flag
$00000200 constant PWR_SR1_BLEWUF                                   \ BLE wakeup interrupt flag
$00000400 constant PWR_SR1_WUF802                                   \ 802.15.4 wakeup interrupt flag
$00000800 constant PWR_SR1_CRPEF                                    \ Enable critical radio phase end of activity interrupt flag
$00001000 constant PWR_SR1_BLEAF                                    \ BLE end of activity interrupt flag
$00002000 constant PWR_SR1_AF802                                    \ 802.15.4 end of activity interrupt flag
$00004000 constant PWR_SR1_C2HF                                     \ CPU2 Hold interrupt flag
$00008000 constant PWR_SR1_WUFI                                     \ Internal Wakeup interrupt flag


\
\ @brief Power status register 2
\ Address offset: 0x14
\ Reset value: 0x00000002
\

$00000001 constant PWR_SR2_SDBF                                     \ Step Down converter Bypass mode flag
$00000002 constant PWR_SR2_SDSMPSF                                  \ Step Down converter SMPS mode flag
$00000100 constant PWR_SR2_REGLPS                                   \ Low-power regulator started
$00000200 constant PWR_SR2_REGLPF                                   \ Low-power regulator flag
$00000400 constant PWR_SR2_VOSF                                     \ Voltage scaling flag
$00000800 constant PWR_SR2_PVDO                                     \ Power voltage detector output
$00001000 constant PWR_SR2_PVMO1                                    \ Peripheral voltage monitoring output: VDDUSB vs. 1.2 V
$00004000 constant PWR_SR2_PVMO3                                    \ Peripheral voltage monitoring output: VDDA vs. 1.62 V


\
\ @brief Power status clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant PWR_SCR_CWUF1                                    \ Clear wakeup flag 1
$00000002 constant PWR_SCR_CWUF2                                    \ Clear wakeup flag 2
$00000004 constant PWR_SCR_CWUF3                                    \ Clear wakeup flag 3
$00000008 constant PWR_SCR_CWUF4                                    \ Clear wakeup flag 4
$00000010 constant PWR_SCR_CWUF5                                    \ Clear wakeup flag 5
$00000080 constant PWR_SCR_CSMPSFBF                                 \ Clear SMPS Step Down converter forced in Bypass interrupt flag
$00000100 constant PWR_SCR_CBORHF                                   \ Clear BORH interrupt flag
$00000200 constant PWR_SCR_CBLEWUF                                  \ Clear BLE wakeup interrupt flag
$00000400 constant PWR_SCR_C802WUF                                  \ Clear 802.15.4 wakeup interrupt flag
$00000800 constant PWR_SCR_CCRPEF                                   \ Clear critical radio phase end of activity interrupt flag
$00001000 constant PWR_SCR_CBLEAF                                   \ Clear BLE end of activity interrupt flag
$00002000 constant PWR_SCR_C802AF                                   \ Clear 802.15.4 end of activity interrupt flag
$00004000 constant PWR_SCR_CC2HF                                    \ Clear CPU2 Hold interrupt flag


\
\ @brief Power control register 5
\ Address offset: 0x1C
\ Reset value: 0x00004270
\

$0000000f constant PWR_CR5_SMPSVOS                                  \ SMPS step-down converter voltage output scaling
$00000070 constant PWR_CR5_SMPSSC                                   \ SMPS step-down converter supply startup current selection current selection
$00000100 constant PWR_CR5_BORHC                                    \ BORH configuration selection
$00008000 constant PWR_CR5_SMPSEN                                   \ Enable SMPS step-down converter SMPS mode enabled


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
$00004000 constant PWR_PDCRA_PD14                                   \ Port A pull-down bit y (y=0..15)


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


\
\ @brief Power Port H pull-up control register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant PWR_PUCRH_PU0                                    \ Port H pull-up bit y (y=0..1)
$00000002 constant PWR_PUCRH_PU1                                    \ Port H pull-up bit y (y=0..1)
$00000008 constant PWR_PUCRH_PU3                                    \ Port H pull-up bit y (y=0..1)


\
\ @brief Power Port H pull-down control register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PDCRH_PD0                                    \ Port H pull-down bit y (y=0..1)
$00000002 constant PWR_PDCRH_PD1                                    \ Port H pull-down bit y (y=0..1)
$00000008 constant PWR_PDCRH_PD3                                    \ Port H pull-down bit y (y=0..1)


\
\ @brief CPU2 Power control register 1
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000007 constant PWR_C2CR1_LPMS                                   \ Low-power mode selection for CPU2
$00000010 constant PWR_C2CR1_FPDR                                   \ Flash power down mode during LPRun for CPU2
$00000020 constant PWR_C2CR1_FPDS                                   \ Flash power down mode during LPSleep for CPU2
$00004000 constant PWR_C2CR1_BLEEWKUP                               \ BLE external wakeup signal
$00008000 constant PWR_C2CR1_EWKUP802                               \ 802.15.4 external wakeup signal


\
\ @brief CPU2 Power control register 3
\ Address offset: 0x84
\ Reset value: 0x00008000
\

$00000001 constant PWR_C2CR3_EWUP1                                  \ Enable Wakeup pin WKUP1 for CPU2
$00000002 constant PWR_C2CR3_EWUP2                                  \ Enable Wakeup pin WKUP2 for CPU2
$00000004 constant PWR_C2CR3_EWUP3                                  \ Enable Wakeup pin WKUP3 for CPU2
$00000008 constant PWR_C2CR3_EWUP4                                  \ Enable Wakeup pin WKUP4 for CPU2
$00000010 constant PWR_C2CR3_EWUP5                                  \ Enable Wakeup pin WKUP5 for CPU2
$00000200 constant PWR_C2CR3_EBLEWUP                                \ Enable BLE host wakeup interrupt for CPU2
$00000400 constant PWR_C2CR3_E802WUP                                \ Enable 802.15.4 host wakeup interrupt for CPU2
$00001000 constant PWR_C2CR3_APC                                    \ Apply pull-up and pull-down configuration for CPU2
$00008000 constant PWR_C2CR3_EIWUL                                  \ Enable internal wakeup line for CPU2


\
\ @brief Power status clear register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant PWR_EXTSCR_C1CSSF                                \ Clear CPU1 Stop Standby flags
$00000002 constant PWR_EXTSCR_C2CSSF                                \ Clear CPU2 Stop Standby flags
$00000004 constant PWR_EXTSCR_CCRPF                                 \ Clear Critical Radio system phase
$00000100 constant PWR_EXTSCR_C1SBF                                 \ System Standby flag for CPU1
$00000200 constant PWR_EXTSCR_C1STOPF                               \ System Stop flag for CPU1
$00000400 constant PWR_EXTSCR_C2SBF                                 \ System Standby flag for CPU2
$00000800 constant PWR_EXTSCR_C2STOPF                               \ System Stop flag for CPU2
$00002000 constant PWR_EXTSCR_CRPF                                  \ Critical Radio system phase
$00004000 constant PWR_EXTSCR_C1DS                                  \ CPU1 deepsleep mode
$00008000 constant PWR_EXTSCR_C2DS                                  \ CPU2 deepsleep mode


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
$58000438 constant PWR_PUCRD      \ offset: 0x38 : Power Port D pull-up control register
$5800043c constant PWR_PDCRD      \ offset: 0x3C : Power Port D pull-down control register
$58000440 constant PWR_PUCRE      \ offset: 0x40 : Power Port E pull-up control register
$58000444 constant PWR_PDCRE      \ offset: 0x44 : Power Port E pull-down control register
$58000458 constant PWR_PUCRH      \ offset: 0x58 : Power Port H pull-up control register
$5800045c constant PWR_PDCRH      \ offset: 0x5C : Power Port H pull-down control register
$58000480 constant PWR_C2CR1      \ offset: 0x80 : CPU2 Power control register 1
$58000484 constant PWR_C2CR3      \ offset: 0x84 : CPU2 Power control register 3
$58000488 constant PWR_EXTSCR     \ offset: 0x88 : Power status clear register

