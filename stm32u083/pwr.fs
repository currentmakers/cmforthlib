\
\ @file pwr.fs
\ @brief PWR register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Power control register 1
\ Address offset: 0x00
\ Reset value: 0x00000208
\

$00000007 constant PWR_PWR_CR1_LPMS                                 \ Low-power mode selection These bits select the low-power mode entered when CPU enters the deepsleep mode. 1xx: Shutdown mode Note: If LPR bit is set, Stop 2 mode cannot be selected and Stop 1 mode shall be entered instead of Stop 2. Note: In Standby mode, SRAM2 can be preserved or not, depending on RRS bit configuration in PWR_CR3.
$00000008 constant PWR_PWR_CR1_FPD_STOP                             \ Flash memory powered down during Stop mode. This bit determines whether the flash memory is put in power-down mode or remains in idle mode when the device enters Stop mode.
$00000010 constant PWR_PWR_CR1_FPD_LPRUN                            \ Flash memory powered down during Low-power run mode. This bit determines whether the flash memory is put in power-down mode or remains in idle mode when the device enters Low-power sleep mode.
$00000020 constant PWR_PWR_CR1_FPD_LPSLP                            \ Flash memory powered down during Low-power sleep mode. This bit determines whether the flash memory is put in power-down mode or remains in idle mode when the device enters Low-power sleep mode.
$00000100 constant PWR_PWR_CR1_DBP                                  \ Disable backup domain write protection In reset state, the RTC and backup registers are protected against parasitic write access. This bit must be set to enable write access to these registers.
$00000600 constant PWR_PWR_CR1_VOS                                  \ Voltage scaling range selection
$00004000 constant PWR_PWR_CR1_LPR                                  \ Low-power run When this bit is set, the regulator is switched from main mode (MR) to low-power mode (LPR). Note: Stop 2 mode cannot be entered when LPR bit is set. Stop 1 is entered instead.


\
\ @brief Power control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CR2_PVDE                                 \ Programmable voltage detector enable Note: This bit is write-protected when the bit PVDL (PVD Lock) is set in the SYSCFG_CBR register. Note: This bit is reset only by a system reset.
$0000000e constant PWR_PWR_CR2_PLS                                  \ Programmable voltage detector level selection. These bits select the voltage threshold detected by the programmable voltage detector: Note: These bits are write-protected when the bit PVDL (PVD Lock) is set in the SYSCFG_CBR register. Note: These bits are reset only by a system reset.
$00000010 constant PWR_PWR_CR2_PVME1                                \ Peripheral voltage monitoring 1 enable: V<sub>DDUSB</sub> vs. 1.21V
$00000020 constant PWR_PWR_CR2_PVME3                                \ Peripheral voltage monitoring 3 enable: V<sub>DDA</sub> vs. 1.621V
$00000040 constant PWR_PWR_CR2_PVME4                                \ Peripheral voltage monitoring 4 enable: V<sub>DDA</sub> vs. 1.861V
$00000400 constant PWR_PWR_CR2_USV                                  \ V<sub>DDUSB</sub> USB supply valid This bit is used to validate the V<sub>DDUSB</sub> supply for electrical and logical isolation purpose. Setting this bit is mandatory to use the USB FS peripheral. If V<sub>DDUSB</sub> is not always present in the application, the PVM can be used to determine whether this supply is ready or not.


\
\ @brief Power control register 3
\ Address offset: 0x08
\ Reset value: 0x00008000
\

$00000001 constant PWR_PWR_CR3_EWUP1                                \ Enable Wake-up pin WKUP1 When this bit is set, the external wake-up pin WKUP1 is enabled and triggers a wake-up from Standby or Shutdown event when a rising or a falling edge occurs. The active edge is configured via the WP1 bit in the PWR_CR4 register.
$00000002 constant PWR_PWR_CR3_EWUP2                                \ Enable Wake-up pin WKUP2 When this bit is set, the external wake-up pin WKUP2 is enabled and triggers a wake-up from Standby or Shutdown event when a rising or a falling edge occurs. The active edge is configured via the WP2 bit in the PWR_CR4 register.
$00000004 constant PWR_PWR_CR3_EWUP3                                \ Enable Wake-up pin WKUP3 When this bit is set, the external wake-up pin WKUP3 is enabled and triggers a wake-up from Standby or Shutdown event when a rising or a falling edge occurs. The active edge is configured via the WP3 bit in the PWR_CR4 register.
$00000008 constant PWR_PWR_CR3_EWUP4                                \ Enable Wake-up pin WKUP4 When this bit is set, the external wake-up pin WKUP4 is enabled and triggers a wake-up from Standby or Shutdown event when a rising or a falling edge occurs. The active edge is configured via the WP4 bit in the PWR_CR4 register.
$00000010 constant PWR_PWR_CR3_EWUP5                                \ Enable Wake-up pin WKUP5 When this bit is set, the external wake-up pin WKUP5 is enabled and triggers a wake-up from Standby or Shutdown event when a rising or a falling edge occurs.The active edge is configured via the WP5 bit in the PWR_CR4 register.
$00000040 constant PWR_PWR_CR3_EWUP7                                \ Enable Wake-up pin WKUP7. When this bit is set, the external wake-up pin WKUP7 is enabled and triggers a wake-up from Standby or Shutdown event when a rising or a falling edge occurs.The active edge is configured via the WP7 bit in the PWR_CR4 register.
$00000100 constant PWR_PWR_CR3_RRS                                  \ SRAM2 retention in Standby mode
$00000200 constant PWR_PWR_CR3_ENULP                                \ Enable ULP sampling When this bit is set, the BORL, BORH and PVD are periodically sampled instead continuous monitoring to reduce power consumption. Fast supply drop between two sample/compare phases is not detected in this mode. This bit has impact only on STOP2, Standby and shutdown low power modes.
$00000400 constant PWR_PWR_CR3_APC                                  \ Apply pull-up and pull-down configuration When this bit is set, the I/O pull-up and pull-down configurations defined in the PWR_PUCRx and PWR_PDCRx registers are applied. When this bit is cleared, the PWR_PUCRx and PWR_PDCRx registers are not applied to the I/Os, instead the I/Os are in floating mode during Standby or configured according GPIO controller GPIOx_PUPDR register during RUN mode.
$00008000 constant PWR_PWR_CR3_EIWUL                                \ Enable internal wake-up line


\
\ @brief Power control register 4
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CR4_WP1                                  \ Wake-up pin WKUP1 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP1
$00000002 constant PWR_PWR_CR4_WP2                                  \ Wake-up pin WKUP2 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP2
$00000004 constant PWR_PWR_CR4_WP3                                  \ Wake-up pin WKUP3 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP3
$00000008 constant PWR_PWR_CR4_WP4                                  \ Wake-up pin WKUP4 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP4
$00000010 constant PWR_PWR_CR4_WP5                                  \ Wake-up pin WKUP5 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP5
$00000040 constant PWR_PWR_CR4_WP7                                  \ Wake-up pin WKUP7 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP7
$00000100 constant PWR_PWR_CR4_VBE                                  \ V<sub>BAT</sub> battery charging enable
$00000200 constant PWR_PWR_CR4_VBRS                                 \ V<sub>BAT</sub> battery charging resistor selection


\
\ @brief Power status register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SR1_WUF1                                 \ Wake-up flag 1 This bit is set when a wake-up event is detected on wake-up pin, WKUP1. It is cleared by writing 1 in the CWUF1 bit of the PWR_SCR register.
$00000002 constant PWR_PWR_SR1_WUF2                                 \ Wake-up flag 2 This bit is set when a wake-up event is detected on wake-up pin, WKUP2. It is cleared by writing 1 in the CWUF2 bit of the PWR_SCR register.
$00000004 constant PWR_PWR_SR1_WUF3                                 \ Wake-up flag 3 This bit is set when a wake-up event is detected on wake-up pin, WKUP3. It is cleared by writing 1 in the CWUF3 bit of the PWR_SCR register.
$00000008 constant PWR_PWR_SR1_WUF4                                 \ Wake-up flag 4 This bit is set when a wake-up event is detected on wake-up pin,WKUP4. It is cleared by writing 1 in the CWUF4 bit of the PWR_SCR register.
$00000010 constant PWR_PWR_SR1_WUF5                                 \ Wake-up flag 5 This bit is set when a wake-up event is detected on wake-up pin, WKUP5. It is cleared by writing 1 in the CWUF5 bit of the PWR_SCR register.
$00000040 constant PWR_PWR_SR1_WUF7                                 \ Wake-up flag 7 This bit is set when a wake-up event is detected on wake-up pin, WKUP7. It is cleared by writing 1 in the CWUF7 bit of the PWR_SCR register.
$00000100 constant PWR_PWR_SR1_SBF                                  \ Standby flag This bit is set by hardware when the device enters the Standby mode and is cleared by setting the CSBF bit in the PWR_SCR register, or by a power-on reset. It is not cleared by the system reset.
$00000e00 constant PWR_PWR_SR1_STOPF                                \ Stop Flags These bits are set by hardware when the device enters any stop mode and are cleared by setting the CSBF bit in the PWR_SCR register, or by a power-on reset. It is not cleared by the system reset.
$00008000 constant PWR_PWR_SR1_WUFI                                 \ Wake-up flag internal This bit is set when a wake-up is detected on the internal wake-up line. It is cleared when all internal wake-up sources are cleared.


\
\ @brief Power status register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000080 constant PWR_PWR_SR2_FLASH_RDY                            \ Flash ready flag This bit is set by hardware to indicate when the flash memory is readey to be accessed after wake-up from power-down. To place the flash memory in power-down, set either FPD_LPRUN, FPD_LPSLP or FPD_STP bits. Note : If the system boots from SRAM, the user application must wait until the FLASH_RDY bit is set, prior to jumping to flash memory.
$00000100 constant PWR_PWR_SR2_REGLPS                               \ Low-power regulator started This bit provides the information whether the low-power regulator is ready after a power-on reset or a Standby/Shutdown. If the Standby mode is entered while REGLPS bit is still cleared, the wake-up from Standby mode time may be increased.
$00000200 constant PWR_PWR_SR2_REGLPF                               \ Low-power regulator flag This bit is set by hardware when the MCU is in Low-power run mode. When the MCU exits from the Low-power run mode, this bit remains at 1 until the regulator is ready in main mode. A polling on this bit must be done before increasing the product frequency. This bit is cleared by hardware when the regulator is ready.
$00000400 constant PWR_PWR_SR2_VOSF                                 \ Voltage scaling flag A delay is required for the internal regulator to be ready after the voltage scaling has been changed. VOSF indicates that the regulator reached the voltage level defined with VOS bits of the PWR_CR1 register.
$00000800 constant PWR_PWR_SR2_PVDO                                 \ Programmable voltage detector output
$00001000 constant PWR_PWR_SR2_PVMO1                                \ Peripheral voltage monitoring output: V<sub>DDUSB</sub> vs. 1.2 V Note: PVMO1 is cleared when PVM1 is disabled (PVME1 = 0). After enabling PVM1, the PVM1 output is valid after the PVM1 wake-up time.
$00004000 constant PWR_PWR_SR2_PVMO3                                \ Peripheral voltage monitoring output: V<sub>DDA</sub> vs. 1.621V Note: PVMO3 is cleared when PVM3 is disabled (PVME3 = 0). After enabling PVM3, the PVM3 output is valid after the PVM3 wake-up time.
$00008000 constant PWR_PWR_SR2_PVMO4                                \ Peripheral voltage monitoring output: V<sub>DDA</sub> vs. 2.21V Note: PVMO4 is cleared when PVM4 is disabled (PVME4 = 0). After enabling PVM4, the PVM4 output is valid after the PVM4 wake-up time.


\
\ @brief Power status clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SCR_CWUF1                                \ Clear wake-up flag 1 Setting this bit clears the WUF1 flag in the PWR_SR1 register.
$00000002 constant PWR_PWR_SCR_CWUF2                                \ Clear wake-up flag 2 Setting this bit clears the WUF2 flag in the PWR_SR1 register.
$00000004 constant PWR_PWR_SCR_CWUF3                                \ Clear wake-up flag 3 Setting this bit clears the WUF3 flag in the PWR_SR1 register.
$00000008 constant PWR_PWR_SCR_CWUF4                                \ Clear wake-up flag 4 Setting this bit clears the WUF4 flag in the PWR_SR1 register.
$00000010 constant PWR_PWR_SCR_CWUF5                                \ Clear wake-up flag 5 Setting this bit clears the WUF5 flag in the PWR_SR1 register.
$00000040 constant PWR_PWR_SCR_CWUF7                                \ Clear wake-up flag 7 Setting this bit clears the WUF7 flag in the PWR_SR1 register.
$00000100 constant PWR_PWR_SCR_CSBF                                 \ Clear standby flag Setting this bit clears the SBF flag in the PWR_SR1 register.


\
\ @brief Power Port A pull-up control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRA_PU0                                \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000002 constant PWR_PWR_PUCRA_PU1                                \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000004 constant PWR_PWR_PUCRA_PU2                                \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000008 constant PWR_PWR_PUCRA_PU3                                \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000010 constant PWR_PWR_PUCRA_PU4                                \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000020 constant PWR_PWR_PUCRA_PU5                                \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000040 constant PWR_PWR_PUCRA_PU6                                \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000080 constant PWR_PWR_PUCRA_PU7                                \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000100 constant PWR_PWR_PUCRA_PU8                                \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000200 constant PWR_PWR_PUCRA_PU9                                \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000400 constant PWR_PWR_PUCRA_PU10                               \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000800 constant PWR_PWR_PUCRA_PU11                               \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00001000 constant PWR_PWR_PUCRA_PU12                               \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00002000 constant PWR_PWR_PUCRA_PU13                               \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00004000 constant PWR_PWR_PUCRA_PU14                               \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00008000 constant PWR_PWR_PUCRA_PU15                               \ Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.


\
\ @brief Power Port A pull-down control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRA_PD0                                \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000002 constant PWR_PWR_PDCRA_PD1                                \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000004 constant PWR_PWR_PDCRA_PD2                                \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000008 constant PWR_PWR_PDCRA_PD3                                \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000010 constant PWR_PWR_PDCRA_PD4                                \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000020 constant PWR_PWR_PDCRA_PD5                                \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000040 constant PWR_PWR_PDCRA_PD6                                \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000080 constant PWR_PWR_PDCRA_PD7                                \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000100 constant PWR_PWR_PDCRA_PD8                                \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000200 constant PWR_PWR_PDCRA_PD9                                \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000400 constant PWR_PWR_PDCRA_PD10                               \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00000800 constant PWR_PWR_PDCRA_PD11                               \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00001000 constant PWR_PWR_PDCRA_PD12                               \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00002000 constant PWR_PWR_PDCRA_PD13                               \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00004000 constant PWR_PWR_PDCRA_PD14                               \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
$00008000 constant PWR_PWR_PDCRA_PD15                               \ Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.


\
\ @brief Power Port B pull-up control register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRB_PU0                                \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00000002 constant PWR_PWR_PUCRB_PU1                                \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00000004 constant PWR_PWR_PUCRB_PU2                                \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00000008 constant PWR_PWR_PUCRB_PU3                                \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00000010 constant PWR_PWR_PUCRB_PU4                                \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00000020 constant PWR_PWR_PUCRB_PU5                                \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00000040 constant PWR_PWR_PUCRB_PU6                                \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00000080 constant PWR_PWR_PUCRB_PU7                                \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00000100 constant PWR_PWR_PUCRB_PU8                                \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00000200 constant PWR_PWR_PUCRB_PU9                                \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00000400 constant PWR_PWR_PUCRB_PU10                               \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00000800 constant PWR_PWR_PUCRB_PU11                               \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00001000 constant PWR_PWR_PUCRB_PU12                               \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00002000 constant PWR_PWR_PUCRB_PU13                               \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00004000 constant PWR_PWR_PUCRB_PU14                               \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
$00008000 constant PWR_PWR_PUCRB_PU15                               \ Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.


\
\ @brief Power Port B pull-down control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRB_PD0                                \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000002 constant PWR_PWR_PDCRB_PD1                                \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000004 constant PWR_PWR_PDCRB_PD2                                \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000008 constant PWR_PWR_PDCRB_PD3                                \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000010 constant PWR_PWR_PDCRB_PD4                                \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000020 constant PWR_PWR_PDCRB_PD5                                \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000040 constant PWR_PWR_PDCRB_PD6                                \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000080 constant PWR_PWR_PDCRB_PD7                                \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000100 constant PWR_PWR_PDCRB_PD8                                \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000200 constant PWR_PWR_PDCRB_PD9                                \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000400 constant PWR_PWR_PDCRB_PD10                               \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00000800 constant PWR_PWR_PDCRB_PD11                               \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00001000 constant PWR_PWR_PDCRB_PD12                               \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00002000 constant PWR_PWR_PDCRB_PD13                               \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00004000 constant PWR_PWR_PDCRB_PD14                               \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
$00008000 constant PWR_PWR_PDCRB_PD15                               \ Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.


\
\ @brief Power Port C pull-up control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRC_PU0                                \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000002 constant PWR_PWR_PUCRC_PU1                                \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000004 constant PWR_PWR_PUCRC_PU2                                \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000008 constant PWR_PWR_PUCRC_PU3                                \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000010 constant PWR_PWR_PUCRC_PU4                                \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000020 constant PWR_PWR_PUCRC_PU5                                \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000040 constant PWR_PWR_PUCRC_PU6                                \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000080 constant PWR_PWR_PUCRC_PU7                                \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000100 constant PWR_PWR_PUCRC_PU8                                \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000200 constant PWR_PWR_PUCRC_PU9                                \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000400 constant PWR_PWR_PUCRC_PU10                               \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000800 constant PWR_PWR_PUCRC_PU11                               \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00001000 constant PWR_PWR_PUCRC_PU12                               \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00002000 constant PWR_PWR_PUCRC_PU13                               \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00004000 constant PWR_PWR_PUCRC_PU14                               \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00008000 constant PWR_PWR_PUCRC_PU15                               \ Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.


\
\ @brief Power Port C pull-down control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRC_PD0                                \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000002 constant PWR_PWR_PDCRC_PD1                                \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000004 constant PWR_PWR_PDCRC_PD2                                \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000008 constant PWR_PWR_PDCRC_PD3                                \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000010 constant PWR_PWR_PDCRC_PD4                                \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000020 constant PWR_PWR_PDCRC_PD5                                \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000040 constant PWR_PWR_PDCRC_PD6                                \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000080 constant PWR_PWR_PDCRC_PD7                                \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000100 constant PWR_PWR_PDCRC_PD8                                \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000200 constant PWR_PWR_PDCRC_PD9                                \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000400 constant PWR_PWR_PDCRC_PD10                               \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00000800 constant PWR_PWR_PDCRC_PD11                               \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00001000 constant PWR_PWR_PDCRC_PD12                               \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00002000 constant PWR_PWR_PDCRC_PD13                               \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00004000 constant PWR_PWR_PDCRC_PD14                               \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
$00008000 constant PWR_PWR_PDCRC_PD15                               \ Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.


\
\ @brief Power Port D pull-up control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRD_PU0                                \ Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000002 constant PWR_PWR_PUCRD_PU1                                \ Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000004 constant PWR_PWR_PUCRD_PU2                                \ Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000008 constant PWR_PWR_PUCRD_PU3                                \ Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000010 constant PWR_PWR_PUCRD_PU4                                \ Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000020 constant PWR_PWR_PUCRD_PU5                                \ Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000040 constant PWR_PWR_PUCRD_PU6                                \ Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000100 constant PWR_PWR_PUCRD_PU8                                \ Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000200 constant PWR_PWR_PUCRD_PU9                                \ Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000400 constant PWR_PWR_PUCRD_PU10                               \ Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000800 constant PWR_PWR_PUCRD_PU11                               \ Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00001000 constant PWR_PWR_PUCRD_PU12                               \ Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00002000 constant PWR_PWR_PUCRD_PU13                               \ Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.


\
\ @brief Power Port D pull-down control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRD_PD0                                \ Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000002 constant PWR_PWR_PDCRD_PD1                                \ Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000004 constant PWR_PWR_PDCRD_PD2                                \ Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000008 constant PWR_PWR_PDCRD_PD3                                \ Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000010 constant PWR_PWR_PDCRD_PD4                                \ Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000020 constant PWR_PWR_PDCRD_PD5                                \ Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000040 constant PWR_PWR_PDCRD_PD6                                \ Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000100 constant PWR_PWR_PDCRD_PD8                                \ Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000200 constant PWR_PWR_PDCRD_PD9                                \ Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000400 constant PWR_PWR_PDCRD_PD10                               \ Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00000800 constant PWR_PWR_PDCRD_PD11                               \ Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00001000 constant PWR_PWR_PDCRD_PD12                               \ Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
$00002000 constant PWR_PWR_PDCRD_PD13                               \ Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.


\
\ @brief Power Port E pull-up control register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000008 constant PWR_PWR_PUCRE_PU3                                \ Port E pull-up bit 3 When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000080 constant PWR_PWR_PUCRE_PU7                                \ Port E pull-up bit y When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000100 constant PWR_PWR_PUCRE_PU8                                \ Port E pull-up bit y When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000200 constant PWR_PWR_PUCRE_PU9                                \ Port E pull-up bit y When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.


\
\ @brief Power Port E pull-down control register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000008 constant PWR_PWR_PDCRE_PD3                                \ Port E pull-down bit 3 When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000080 constant PWR_PWR_PDCRE_PD7                                \ Port E pull-down bit y When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000100 constant PWR_PWR_PDCRE_PD8                                \ Port E pull-down bit y When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
$00000200 constant PWR_PWR_PDCRE_PD9                                \ Port E pull-down bit y When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.


\
\ @brief Power Port F pull-up control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRF_PU0                                \ Port F pull-up bit y When set, this bit activates the pull-up on PH[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000002 constant PWR_PWR_PUCRF_PU1                                \ Port F pull-up bit y When set, this bit activates the pull-up on PH[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000004 constant PWR_PWR_PUCRF_PU2                                \ Port F pull-up bit y When set, this bit activates the pull-up on PH[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
$00000008 constant PWR_PWR_PUCRF_PU3                                \ Port F pull-up bit y When set, this bit activates the pull-up on PH[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.


\
\ @brief Power Port F pull-down control register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRF_PD0                                \ Port F pull-down bit y When set, this bit activates the pull-down on PH[y] when APC bit is set in PWR_CR3 register.
$00000002 constant PWR_PWR_PDCRF_PD1                                \ Port F pull-down bit y When set, this bit activates the pull-down on PH[y] when APC bit is set in PWR_CR3 register.
$00000004 constant PWR_PWR_PDCRF_PD2                                \ Port F pull-down bit y When set, this bit activates the pull-down on PH[y] when APC bit is set in PWR_CR3 register.
$00000008 constant PWR_PWR_PDCRF_PD3                                \ Port F pull-down bit y When set, this bit activates the pull-down on PH[y] when APC bit is set in PWR_CR3 register.


\
\ @brief PWR register block
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

