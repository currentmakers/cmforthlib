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

$00000007 constant PWR_PWR_CR1_LPMS                                 \ Low-power mode selection These bits select the low-power mode entered when CPU enters the deepsleep mode. 1xx: Shutdown mode Note: In Standby mode, SRAM2 can be preserved or not, depending on RRS bit configuration in PWR_CR3.
$00000008 constant PWR_PWR_CR1_FPD_STOP                             \ FPD_STOP
$00000100 constant PWR_PWR_CR1_DBP                                  \ Disable backup domain write protection In reset state, the RTC and backup registers are protected against parasitic write access. This bit must be set to enable write access to these registers.
$00000600 constant PWR_PWR_CR1_VOS                                  \ Voltage scaling range selection
$00004000 constant PWR_PWR_CR1_LPR                                  \ Low-power run When this bit is set, the regulator is switched from main mode (MR) to low-power mode (LPR).


\
\ @brief Power control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CR2_PVDE                                 \ Programmable voltage detector enable Note: This bit is write-protected when the PVDL bit is set in the SYSCFG_CFGR2 register. The protection can be reset only by a system reset.
$0000000e constant PWR_PWR_CR2_PVDLS                                \ Programmable voltage detector level selection. These bits select the PVD falling threshold: Note: These bits are write-protected when the PVDL bit is set in the SYSCFG_CFGR2 register. The protection can be reset only by a system reset.
$00000040 constant PWR_PWR_CR2_PVMEN1                               \ Peripheral voltage monitoring 3 enable: V<sub>DDA</sub> vs. ADC/COMP min voltage 1.62V
$00000080 constant PWR_PWR_CR2_PVMEN2                               \ Peripheral voltage monitoring 4 enable: V<sub>DDA</sub> vs. DAC 1MSPS /DAC 15MSPS min voltage.


\
\ @brief Power control register 3
\ Address offset: 0x08
\ Reset value: 0x00008000
\

$00000001 constant PWR_PWR_CR3_EWUP1                                \ Enable Wakeup pin WKUP1 When this bit is set, the external wakeup pin WKUP1 is enabled and triggers a wakeup from Standby or Shutdown event when a rising or a falling edge occurs. The active edge is configured via the WP1 bit in the PWR_CR4 register.
$00000002 constant PWR_PWR_CR3_EWUP2                                \ Enable Wakeup pin WKUP2 When this bit is set, the external wakeup pin WKUP2 is enabled and triggers a wakeup from Standby or Shutdown event when a rising or a falling edge occurs. The active edge is configured via the WP2 bit in the PWR_CR4 register.
$00000004 constant PWR_PWR_CR3_EWUP3                                \ Enable Wakeup pin WKUP3 When this bit is set, the external wakeup pin WKUP3 is enabled and triggers a wakeup from Standby or Shutdown event when a rising or a falling edge occurs. The active edge is configured via the WP3 bit in the PWR_CR4 register.
$00000008 constant PWR_PWR_CR3_EWUP4                                \ Enable Wakeup pin WKUP4 When this bit is set, the external wakeup pin WKUP4 is enabled and triggers a wakeup from Standby or Shutdown event when a rising or a falling edge occurs. The active edge is configured via the WP4 bit in the PWR_CR4 register.
$00000010 constant PWR_PWR_CR3_EWUP5                                \ Enable Wakeup pin WKUP5 When this bit is set, the external wakeup pin WKUP5 is enabled and triggers a wakeup from Standby or Shutdown event when a rising or a falling edge occurs.The active edge is configured via the WP5 bit in the PWR_CR4 register.
$00000100 constant PWR_PWR_CR3_RRS                                  \ SRAM2 retention in Standby mode
$00000400 constant PWR_PWR_CR3_APC                                  \ Apply pull-up and pull-down configuration When this bit is set, the I/O pull-up and pull-down configurations defined in the PWR_PUCRx and PWR_PDCRx registers are applied. When this bit is cleared, the PWR_PUCRx and PWR_PDCRx registers are not applied to the I/Os.
$00002000 constant PWR_PWR_CR3_UCPD1_STDBY                          \ UCPD1_STDBY USB Type-C and Power Delivery standby mode.
$00004000 constant PWR_PWR_CR3_UCPD1_DBDIS                          \ USB Type-C and Power Delivery Dead Battery disable. After exiting reset, the USB Type-C dead battery behavior is enabled, which may have a pull-down effect on CC1 and CC2 pins. It is recommended to disable it in all cases, either to stop this pull-down or to hand over control to the UCPD1 (which should therefore be initialized before doing the disable).
$00008000 constant PWR_PWR_CR3_EIWUL                                \ Enable internal wakeup line


\
\ @brief Power control register 4
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CR4_WP1                                  \ Wakeup pin WKUP1 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP1
$00000002 constant PWR_PWR_CR4_WP2                                  \ Wakeup pin WKUP2 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP2
$00000004 constant PWR_PWR_CR4_WP3                                  \ Wakeup pin WKUP3 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP3
$00000008 constant PWR_PWR_CR4_WP4                                  \ Wakeup pin WKUP4 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP4
$00000010 constant PWR_PWR_CR4_WP5                                  \ Wakeup pin WKUP5 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP5
$00000100 constant PWR_PWR_CR4_VBE                                  \ V<sub>BAT</sub> battery charging enable
$00000200 constant PWR_PWR_CR4_VBRS                                 \ V<sub>BAT</sub> battery charging resistor selection


\
\ @brief Power status register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SR1_WUF1                                 \ Wakeup flag 1 This bit is set when a wakeup event is detected on wakeup pin, WKUP1. It is cleared by writing 1 in the CWUF1 bit of the PWR_SCR register.
$00000002 constant PWR_PWR_SR1_WUF2                                 \ Wakeup flag 2 This bit is set when a wakeup event is detected on wakeup pin, WKUP2. It is cleared by writing 1 in the CWUF2 bit of the PWR_SCR register.
$00000004 constant PWR_PWR_SR1_WUF3                                 \ Wakeup flag 3 This bit is set when a wakeup event is detected on wakeup pin, WKUP3. It is cleared by writing 1 in the CWUF3 bit of the PWR_SCR register.
$00000008 constant PWR_PWR_SR1_WUF4                                 \ Wakeup flag 4 This bit is set when a wakeup event is detected on wakeup pin,WKUP4. It is cleared by writing 1 in the CWUF4 bit of the PWR_SCR register.
$00000010 constant PWR_PWR_SR1_WUF5                                 \ Wakeup flag 5 This bit is set when a wakeup event is detected on wakeup pin, WKUP5. It is cleared by writing 1 in the CWUF5 bit of the PWR_SCR register.
$00000100 constant PWR_PWR_SR1_SBF                                  \ Standby flag This bit is set by hardware when the device enters the Standby mode and is cleared by setting the CSBF bit in the PWR_SCR register, or by a power-on reset. It is not cleared by the system reset.
$00008000 constant PWR_PWR_SR1_WUFI                                 \ Wakeup flag internal This bit is set when a wakeup is detected on the internal wakeup line. It is cleared when all internal wakeup sources are cleared.


\
\ @brief Power status register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000100 constant PWR_PWR_SR2_REGLPS                               \ Low-power regulator started This bit provides the information whether the low-power regulator is ready after a power-on reset or a Standby/Shutdown. If the Standby mode is entered while REGLPS bit is still cleared, the wakeup from Standby mode time may be increased.
$00000200 constant PWR_PWR_SR2_REGLPF                               \ Low-power regulator flag This bit is set by hardware when the MCU is in Low-power run mode. When the MCU exits the Low-power run mode, this bit remains at 1 until the regulator is ready in main mode. A polling on this bit must be done before increasing the product frequency. This bit is cleared by hardware when the regulator is ready.
$00000400 constant PWR_PWR_SR2_VOSF                                 \ Voltage scaling flag A delay is required for the internal regulator to be ready after the voltage scaling has been changed. VOSF indicates that the regulator reached the voltage level defined with VOS bits of the PWR_CR1 register.
$00000800 constant PWR_PWR_SR2_PVDO                                 \ Programmable voltage detector output
$00004000 constant PWR_PWR_SR2_PVMO1                                \ Peripheral voltage monitoring output: V<sub>DDA</sub> vs. 1.62 V Note: PVMO1 is cleared when PVM1 is disabled (PVME = 0). After enabling PVM1, the PVM1 output is valid after the PVM1 wakeup time.
$00008000 constant PWR_PWR_SR2_PVMO2                                \ Peripheral voltage monitoring output: V<sub>DDA</sub> vs. 1.8 V Note: PVMO2 is cleared when PVM2 is disabled (PVME = 0). After enabling PVM2, the PVM2 output is valid after the PVM2 wakeup time.


\
\ @brief Power status clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SCR_CWUF1                                \ Clear wakeup flag 1 Setting this bit clears the WUF1 flag in the PWR_SR1 register.
$00000002 constant PWR_PWR_SCR_CWUF2                                \ Clear wakeup flag 2 Setting this bit clears the WUF2 flag in the PWR_SR1 register.
$00000004 constant PWR_PWR_SCR_CWUF3                                \ Clear wakeup flag 3 Setting this bit clears the WUF3 flag in the PWR_SR1 register.
$00000008 constant PWR_PWR_SCR_CWUF4                                \ Clear wakeup flag 4 Setting this bit clears the WUF4 flag in the PWR_SR1 register.
$00000010 constant PWR_PWR_SCR_CWUF5                                \ Clear wakeup flag 5 Setting this bit clears the WUF5 flag in the PWR_SR1 register.
$00000100 constant PWR_PWR_SCR_CSBF                                 \ Clear standby flag Setting this bit clears the SBF flag in the PWR_SR1 register.


\
\ @brief Power Port A pull-up control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRA_PU0                                \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000002 constant PWR_PWR_PUCRA_PU1                                \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000004 constant PWR_PWR_PUCRA_PU2                                \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000008 constant PWR_PWR_PUCRA_PU3                                \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000010 constant PWR_PWR_PUCRA_PU4                                \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000020 constant PWR_PWR_PUCRA_PU5                                \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000040 constant PWR_PWR_PUCRA_PU6                                \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000080 constant PWR_PWR_PUCRA_PU7                                \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000100 constant PWR_PWR_PUCRA_PU8                                \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000200 constant PWR_PWR_PUCRA_PU9                                \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000400 constant PWR_PWR_PUCRA_PU10                               \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000800 constant PWR_PWR_PUCRA_PU11                               \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00001000 constant PWR_PWR_PUCRA_PU12                               \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00002000 constant PWR_PWR_PUCRA_PU13                               \ Port A pull-up bit y (y=0..13) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00008000 constant PWR_PWR_PUCRA_PU15                               \ Port A pull-up bit 15 When set, this bit activates the pull-up on PA[15] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PD15 bit is also set.


\
\ @brief Power Port A pull-down control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRA_PD0                                \ Port A pull-down bit y (y=0..12) When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000002 constant PWR_PWR_PDCRA_PD1                                \ Port A pull-down bit y (y=0..12) When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000004 constant PWR_PWR_PDCRA_PD2                                \ Port A pull-down bit y (y=0..12) When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000008 constant PWR_PWR_PDCRA_PD3                                \ Port A pull-down bit y (y=0..12) When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000010 constant PWR_PWR_PDCRA_PD4                                \ Port A pull-down bit y (y=0..12) When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000020 constant PWR_PWR_PDCRA_PD5                                \ Port A pull-down bit y (y=0..12) When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000040 constant PWR_PWR_PDCRA_PD6                                \ Port A pull-down bit y (y=0..12) When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000080 constant PWR_PWR_PDCRA_PD7                                \ Port A pull-down bit y (y=0..12) When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000100 constant PWR_PWR_PDCRA_PD8                                \ Port A pull-down bit y (y=0..12) When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000200 constant PWR_PWR_PDCRA_PD9                                \ Port A pull-down bit y (y=0..12) When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000400 constant PWR_PWR_PDCRA_PD10                               \ Port A pull-down bit y (y=0..12) When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000800 constant PWR_PWR_PDCRA_PD11                               \ Port A pull-down bit y (y=0..12) When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00001000 constant PWR_PWR_PDCRA_PD12                               \ Port A pull-down bit y (y=0..12) When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00004000 constant PWR_PWR_PDCRA_PD14                               \ Port A pull-down bit 14 When set, this bit activates the pull-down on PA[14] when APC bit is set in PWR_CR3 register.


\
\ @brief Power Port B pull-up control register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRB_PU0                                \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000002 constant PWR_PWR_PUCRB_PU1                                \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000004 constant PWR_PWR_PUCRB_PU2                                \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000008 constant PWR_PWR_PUCRB_PU3                                \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000010 constant PWR_PWR_PUCRB_PU4                                \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000020 constant PWR_PWR_PUCRB_PU5                                \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000040 constant PWR_PWR_PUCRB_PU6                                \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000080 constant PWR_PWR_PUCRB_PU7                                \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000100 constant PWR_PWR_PUCRB_PU8                                \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000200 constant PWR_PWR_PUCRB_PU9                                \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000400 constant PWR_PWR_PUCRB_PU10                               \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000800 constant PWR_PWR_PUCRB_PU11                               \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00001000 constant PWR_PWR_PUCRB_PU12                               \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00002000 constant PWR_PWR_PUCRB_PU13                               \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00004000 constant PWR_PWR_PUCRB_PU14                               \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00008000 constant PWR_PWR_PUCRB_PU15                               \ Port B pull-up bit y (y=0..15) When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.


\
\ @brief Power Port B pull-down control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRB_PD0                                \ Port B pull-down bit y (y=0..3) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000002 constant PWR_PWR_PDCRB_PD1                                \ Port B pull-down bit y (y=0..3) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000004 constant PWR_PWR_PDCRB_PD2                                \ Port B pull-down bit y (y=0..3) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000008 constant PWR_PWR_PDCRB_PD3                                \ Port B pull-down bit y (y=0..3) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000020 constant PWR_PWR_PDCRB_PD5                                \ Port B pull-down bit y (y=5..15) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000040 constant PWR_PWR_PDCRB_PD6                                \ Port B pull-down bit y (y=5..15) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000080 constant PWR_PWR_PDCRB_PD7                                \ Port B pull-down bit y (y=5..15) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000100 constant PWR_PWR_PDCRB_PD8                                \ Port B pull-down bit y (y=5..15) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000200 constant PWR_PWR_PDCRB_PD9                                \ Port B pull-down bit y (y=5..15) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000400 constant PWR_PWR_PDCRB_PD10                               \ Port B pull-down bit y (y=5..15) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000800 constant PWR_PWR_PDCRB_PD11                               \ Port B pull-down bit y (y=5..15) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00001000 constant PWR_PWR_PDCRB_PD12                               \ Port B pull-down bit y (y=5..15) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00002000 constant PWR_PWR_PDCRB_PD13                               \ Port B pull-down bit y (y=5..15) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00004000 constant PWR_PWR_PDCRB_PD14                               \ Port B pull-down bit y (y=5..15) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00008000 constant PWR_PWR_PDCRB_PD15                               \ Port B pull-down bit y (y=5..15) When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.


\
\ @brief Power Port C pull-up control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRC_PU0                                \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000002 constant PWR_PWR_PUCRC_PU1                                \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000004 constant PWR_PWR_PUCRC_PU2                                \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000008 constant PWR_PWR_PUCRC_PU3                                \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000010 constant PWR_PWR_PUCRC_PU4                                \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000020 constant PWR_PWR_PUCRC_PU5                                \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000040 constant PWR_PWR_PUCRC_PU6                                \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000080 constant PWR_PWR_PUCRC_PU7                                \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000100 constant PWR_PWR_PUCRC_PU8                                \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000200 constant PWR_PWR_PUCRC_PU9                                \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000400 constant PWR_PWR_PUCRC_PU10                               \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000800 constant PWR_PWR_PUCRC_PU11                               \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00001000 constant PWR_PWR_PUCRC_PU12                               \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00002000 constant PWR_PWR_PUCRC_PU13                               \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00004000 constant PWR_PWR_PUCRC_PU14                               \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00008000 constant PWR_PWR_PUCRC_PU15                               \ Port C pull-up bit y (y=0..15) When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.


\
\ @brief Power Port C pull-down control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRC_PD0                                \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000002 constant PWR_PWR_PDCRC_PD1                                \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000004 constant PWR_PWR_PDCRC_PD2                                \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000008 constant PWR_PWR_PDCRC_PD3                                \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000010 constant PWR_PWR_PDCRC_PD4                                \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000020 constant PWR_PWR_PDCRC_PD5                                \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000040 constant PWR_PWR_PDCRC_PD6                                \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000080 constant PWR_PWR_PDCRC_PD7                                \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000100 constant PWR_PWR_PDCRC_PD8                                \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000200 constant PWR_PWR_PDCRC_PD9                                \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000400 constant PWR_PWR_PDCRC_PD10                               \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000800 constant PWR_PWR_PDCRC_PD11                               \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00001000 constant PWR_PWR_PDCRC_PD12                               \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00002000 constant PWR_PWR_PDCRC_PD13                               \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00004000 constant PWR_PWR_PDCRC_PD14                               \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00008000 constant PWR_PWR_PDCRC_PD15                               \ Port C pull-down bit y (y=0..15) When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.


\
\ @brief Power Port D pull-up control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRD_PU0                                \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000002 constant PWR_PWR_PUCRD_PU1                                \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000004 constant PWR_PWR_PUCRD_PU2                                \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000008 constant PWR_PWR_PUCRD_PU3                                \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000010 constant PWR_PWR_PUCRD_PU4                                \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000020 constant PWR_PWR_PUCRD_PU5                                \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000040 constant PWR_PWR_PUCRD_PU6                                \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000080 constant PWR_PWR_PUCRD_PU7                                \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000100 constant PWR_PWR_PUCRD_PU8                                \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000200 constant PWR_PWR_PUCRD_PU9                                \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000400 constant PWR_PWR_PUCRD_PU10                               \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000800 constant PWR_PWR_PUCRD_PU11                               \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00001000 constant PWR_PWR_PUCRD_PU12                               \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00002000 constant PWR_PWR_PUCRD_PU13                               \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00004000 constant PWR_PWR_PUCRD_PU14                               \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00008000 constant PWR_PWR_PUCRD_PU15                               \ Port D pull-up bit y (y=0..15) When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.


\
\ @brief Power Port D pull-down control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRD_PD0                                \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000002 constant PWR_PWR_PDCRD_PD1                                \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000004 constant PWR_PWR_PDCRD_PD2                                \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000008 constant PWR_PWR_PDCRD_PD3                                \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000010 constant PWR_PWR_PDCRD_PD4                                \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000020 constant PWR_PWR_PDCRD_PD5                                \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000040 constant PWR_PWR_PDCRD_PD6                                \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000080 constant PWR_PWR_PDCRD_PD7                                \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000100 constant PWR_PWR_PDCRD_PD8                                \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000200 constant PWR_PWR_PDCRD_PD9                                \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000400 constant PWR_PWR_PDCRD_PD10                               \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000800 constant PWR_PWR_PDCRD_PD11                               \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00001000 constant PWR_PWR_PDCRD_PD12                               \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00002000 constant PWR_PWR_PDCRD_PD13                               \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00004000 constant PWR_PWR_PDCRD_PD14                               \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00008000 constant PWR_PWR_PDCRD_PD15                               \ Port D pull-down bit y (y=0..15) When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.


\
\ @brief Power Port E pull-up control register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRE_PU0                                \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000002 constant PWR_PWR_PUCRE_PU1                                \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000004 constant PWR_PWR_PUCRE_PU2                                \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000008 constant PWR_PWR_PUCRE_PU3                                \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000010 constant PWR_PWR_PUCRE_PU4                                \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000020 constant PWR_PWR_PUCRE_PU5                                \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000040 constant PWR_PWR_PUCRE_PU6                                \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000080 constant PWR_PWR_PUCRE_PU7                                \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000100 constant PWR_PWR_PUCRE_PU8                                \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000200 constant PWR_PWR_PUCRE_PU9                                \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000400 constant PWR_PWR_PUCRE_PU10                               \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000800 constant PWR_PWR_PUCRE_PU11                               \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00001000 constant PWR_PWR_PUCRE_PU12                               \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00002000 constant PWR_PWR_PUCRE_PU13                               \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00004000 constant PWR_PWR_PUCRE_PU14                               \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00008000 constant PWR_PWR_PUCRE_PU15                               \ Port E pull-up bit y (y=0..15) When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.


\
\ @brief Power Port E pull-down control register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRE_PD0                                \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000002 constant PWR_PWR_PDCRE_PD1                                \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000004 constant PWR_PWR_PDCRE_PD2                                \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000008 constant PWR_PWR_PDCRE_PD3                                \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000010 constant PWR_PWR_PDCRE_PD4                                \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000020 constant PWR_PWR_PDCRE_PD5                                \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000040 constant PWR_PWR_PDCRE_PD6                                \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000080 constant PWR_PWR_PDCRE_PD7                                \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000100 constant PWR_PWR_PDCRE_PD8                                \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000200 constant PWR_PWR_PDCRE_PD9                                \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000400 constant PWR_PWR_PDCRE_PD10                               \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000800 constant PWR_PWR_PDCRE_PD11                               \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00001000 constant PWR_PWR_PDCRE_PD12                               \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00002000 constant PWR_PWR_PDCRE_PD13                               \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00004000 constant PWR_PWR_PDCRE_PD14                               \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00008000 constant PWR_PWR_PDCRE_PD15                               \ Port E pull-down bit y (y=0..15) When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.


\
\ @brief Power Port F pull-up control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRF_PU0                                \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000002 constant PWR_PWR_PUCRF_PU1                                \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000004 constant PWR_PWR_PUCRF_PU2                                \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000008 constant PWR_PWR_PUCRF_PU3                                \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000010 constant PWR_PWR_PUCRF_PU4                                \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000020 constant PWR_PWR_PUCRF_PU5                                \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000040 constant PWR_PWR_PUCRF_PU6                                \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000080 constant PWR_PWR_PUCRF_PU7                                \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000100 constant PWR_PWR_PUCRF_PU8                                \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000200 constant PWR_PWR_PUCRF_PU9                                \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000400 constant PWR_PWR_PUCRF_PU10                               \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000800 constant PWR_PWR_PUCRF_PU11                               \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00001000 constant PWR_PWR_PUCRF_PU12                               \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00002000 constant PWR_PWR_PUCRF_PU13                               \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00004000 constant PWR_PWR_PUCRF_PU14                               \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00008000 constant PWR_PWR_PUCRF_PU15                               \ Port F pull-up bit y (y=0..15) When set, this bit activates the pull-up on PF[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.


\
\ @brief Power Port F pull-down control register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRF_PD0                                \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00000002 constant PWR_PWR_PDCRF_PD1                                \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00000004 constant PWR_PWR_PDCRF_PD2                                \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00000008 constant PWR_PWR_PDCRF_PD3                                \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00000010 constant PWR_PWR_PDCRF_PD4                                \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00000020 constant PWR_PWR_PDCRF_PD5                                \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00000040 constant PWR_PWR_PDCRF_PD6                                \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00000080 constant PWR_PWR_PDCRF_PD7                                \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00000100 constant PWR_PWR_PDCRF_PD8                                \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00000200 constant PWR_PWR_PDCRF_PD9                                \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00000400 constant PWR_PWR_PDCRF_PD10                               \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00000800 constant PWR_PWR_PDCRF_PD11                               \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00001000 constant PWR_PWR_PDCRF_PD12                               \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00002000 constant PWR_PWR_PDCRF_PD13                               \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00004000 constant PWR_PWR_PDCRF_PD14                               \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.
$00008000 constant PWR_PWR_PDCRF_PD15                               \ Port F pull-down bit y (y=0..15) When set, this bit activates the pull-down on PF[y] when APC bit is set in PWR_CR3 register.


\
\ @brief Power Port G pull-up control register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRG_PU0                                \ Port G pull-up bit y (y=0..10) When set, this bit activates the pull-up on PG[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000002 constant PWR_PWR_PUCRG_PU1                                \ Port G pull-up bit y (y=0..10) When set, this bit activates the pull-up on PG[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000004 constant PWR_PWR_PUCRG_PU2                                \ Port G pull-up bit y (y=0..10) When set, this bit activates the pull-up on PG[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000008 constant PWR_PWR_PUCRG_PU3                                \ Port G pull-up bit y (y=0..10) When set, this bit activates the pull-up on PG[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000010 constant PWR_PWR_PUCRG_PU4                                \ Port G pull-up bit y (y=0..10) When set, this bit activates the pull-up on PG[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000020 constant PWR_PWR_PUCRG_PU5                                \ Port G pull-up bit y (y=0..10) When set, this bit activates the pull-up on PG[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000040 constant PWR_PWR_PUCRG_PU6                                \ Port G pull-up bit y (y=0..10) When set, this bit activates the pull-up on PG[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000080 constant PWR_PWR_PUCRG_PU7                                \ Port G pull-up bit y (y=0..10) When set, this bit activates the pull-up on PG[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000100 constant PWR_PWR_PUCRG_PU8                                \ Port G pull-up bit y (y=0..10) When set, this bit activates the pull-up on PG[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000200 constant PWR_PWR_PUCRG_PU9                                \ Port G pull-up bit y (y=0..10) When set, this bit activates the pull-up on PG[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.
$00000400 constant PWR_PWR_PUCRG_PU10                               \ Port G pull-up bit y (y=0..10) When set, this bit activates the pull-up on PG[y] when APC bit is set in PWR_CR3 register. The pull-up is not activated if the corresponding PDy bit is also set.


\
\ @brief Power Port G pull-down control register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRG_PD0                                \ Port G pull-down bit y (y=0..10) When set, this bit activates the pull-down on PG[y] when APC bit is set in PWR_CR3 register.
$00000002 constant PWR_PWR_PDCRG_PD1                                \ Port G pull-down bit y (y=0..10) When set, this bit activates the pull-down on PG[y] when APC bit is set in PWR_CR3 register.
$00000004 constant PWR_PWR_PDCRG_PD2                                \ Port G pull-down bit y (y=0..10) When set, this bit activates the pull-down on PG[y] when APC bit is set in PWR_CR3 register.
$00000008 constant PWR_PWR_PDCRG_PD3                                \ Port G pull-down bit y (y=0..10) When set, this bit activates the pull-down on PG[y] when APC bit is set in PWR_CR3 register.
$00000010 constant PWR_PWR_PDCRG_PD4                                \ Port G pull-down bit y (y=0..10) When set, this bit activates the pull-down on PG[y] when APC bit is set in PWR_CR3 register.
$00000020 constant PWR_PWR_PDCRG_PD5                                \ Port G pull-down bit y (y=0..10) When set, this bit activates the pull-down on PG[y] when APC bit is set in PWR_CR3 register.
$00000040 constant PWR_PWR_PDCRG_PD6                                \ Port G pull-down bit y (y=0..10) When set, this bit activates the pull-down on PG[y] when APC bit is set in PWR_CR3 register.
$00000080 constant PWR_PWR_PDCRG_PD7                                \ Port G pull-down bit y (y=0..10) When set, this bit activates the pull-down on PG[y] when APC bit is set in PWR_CR3 register.
$00000100 constant PWR_PWR_PDCRG_PD8                                \ Port G pull-down bit y (y=0..10) When set, this bit activates the pull-down on PG[y] when APC bit is set in PWR_CR3 register.
$00000200 constant PWR_PWR_PDCRG_PD9                                \ Port G pull-down bit y (y=0..10) When set, this bit activates the pull-down on PG[y] when APC bit is set in PWR_CR3 register.
$00000400 constant PWR_PWR_PDCRG_PD10                               \ Port G pull-down bit y (y=0..10) When set, this bit activates the pull-down on PG[y] when APC bit is set in PWR_CR3 register.


\
\ @brief Power control register
\ Address offset: 0x80
\ Reset value: 0x00000100
\

$00000100 constant PWR_PWR_CR5_R1MODE                               \ Main regular range 1 mode This bit is only valid for the main regulator in range 1 and has no effect on range 2. It is recommended to reset this bit when the system frequency is greater than 150 MHz. Refer to


\
\ @brief Power control
\
$40007000 constant PWR_PWR_CR1    \ offset: 0x00 : Power control register 1
$40007004 constant PWR_PWR_CR2    \ offset: 0x04 : Power control register 2
$40007008 constant PWR_PWR_CR3    \ offset: 0x08 : Power control register 3
$4000700c constant PWR_PWR_CR4    \ offset: 0x0C : Power control register 4
$40007010 constant PWR_PWR_SR1    \ offset: 0x10 : Power status register 1
$40007014 constant PWR_PWR_SR2    \ offset: 0x14 : Power status register 2
$40007018 constant PWR_PWR_SCR    \ offset: 0x18 : Power status clear register
$40007020 constant PWR_PWR_PUCRA  \ offset: 0x20 : Power Port A pull-up control register
$40007024 constant PWR_PWR_PDCRA  \ offset: 0x24 : Power Port A pull-down control register
$40007028 constant PWR_PWR_PUCRB  \ offset: 0x28 : Power Port B pull-up control register
$4000702c constant PWR_PWR_PDCRB  \ offset: 0x2C : Power Port B pull-down control register
$40007030 constant PWR_PWR_PUCRC  \ offset: 0x30 : Power Port C pull-up control register
$40007034 constant PWR_PWR_PDCRC  \ offset: 0x34 : Power Port C pull-down control register
$40007038 constant PWR_PWR_PUCRD  \ offset: 0x38 : Power Port D pull-up control register
$4000703c constant PWR_PWR_PDCRD  \ offset: 0x3C : Power Port D pull-down control register
$40007040 constant PWR_PWR_PUCRE  \ offset: 0x40 : Power Port E pull-up control register
$40007044 constant PWR_PWR_PDCRE  \ offset: 0x44 : Power Port E pull-down control register
$40007048 constant PWR_PWR_PUCRF  \ offset: 0x48 : Power Port F pull-up control register
$4000704c constant PWR_PWR_PDCRF  \ offset: 0x4C : Power Port F pull-down control register
$40007050 constant PWR_PWR_PUCRG  \ offset: 0x50 : Power Port G pull-up control register
$40007054 constant PWR_PWR_PDCRG  \ offset: 0x54 : Power Port G pull-down control register
$40007080 constant PWR_PWR_CR5    \ offset: 0x80 : Power control register

