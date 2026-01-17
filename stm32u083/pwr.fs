\
\ @file pwr.fs
\ @brief PWR register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PWR_DEF

  [ifdef] PWR_PWR_CR1_DEF
    \
    \ @brief Power control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000208
    \
    $00 constant PWR_LPMS                       \ [0x00 : 3] Low-power mode selection These bits select the low-power mode entered when CPU enters the deepsleep mode. 1xx: Shutdown mode Note: If LPR bit is set, Stop 2 mode cannot be selected and Stop 1 mode shall be entered instead of Stop 2. Note: In Standby mode, SRAM2 can be preserved or not, depending on RRS bit configuration in PWR_CR3.
    $03 constant PWR_FPD_STOP                   \ [0x03] Flash memory powered down during Stop mode. This bit determines whether the flash memory is put in power-down mode or remains in idle mode when the device enters Stop mode.
    $04 constant PWR_FPD_LPRUN                  \ [0x04] Flash memory powered down during Low-power run mode. This bit determines whether the flash memory is put in power-down mode or remains in idle mode when the device enters Low-power sleep mode.
    $05 constant PWR_FPD_LPSLP                  \ [0x05] Flash memory powered down during Low-power sleep mode. This bit determines whether the flash memory is put in power-down mode or remains in idle mode when the device enters Low-power sleep mode.
    $08 constant PWR_DBP                        \ [0x08] Disable backup domain write protection In reset state, the RTC and backup registers are protected against parasitic write access. This bit must be set to enable write access to these registers.
    $09 constant PWR_VOS                        \ [0x09 : 2] Voltage scaling range selection
    $0e constant PWR_LPR                        \ [0x0e] Low-power run When this bit is set, the regulator is switched from main mode (MR) to low-power mode (LPR). Note: Stop 2 mode cannot be entered when LPR bit is set. Stop 1 is entered instead.
  [then]


  [ifdef] PWR_PWR_CR2_DEF
    \
    \ @brief Power control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PVDE                       \ [0x00] Programmable voltage detector enable Note: This bit is write-protected when the bit PVDL (PVD Lock) is set in the SYSCFG_CBR register. Note: This bit is reset only by a system reset.
    $01 constant PWR_PLS                        \ [0x01 : 3] Programmable voltage detector level selection. These bits select the voltage threshold detected by the programmable voltage detector: Note: These bits are write-protected when the bit PVDL (PVD Lock) is set in the SYSCFG_CBR register. Note: These bits are reset only by a system reset.
    $04 constant PWR_PVME1                      \ [0x04] Peripheral voltage monitoring 1 enable: V<sub>DDUSB</sub> vs. 1.21V
    $05 constant PWR_PVME3                      \ [0x05] Peripheral voltage monitoring 3 enable: V<sub>DDA</sub> vs. 1.621V
    $06 constant PWR_PVME4                      \ [0x06] Peripheral voltage monitoring 4 enable: V<sub>DDA</sub> vs. 1.861V
    $0a constant PWR_USV                        \ [0x0a] V<sub>DDUSB</sub> USB supply valid This bit is used to validate the V<sub>DDUSB</sub> supply for electrical and logical isolation purpose. Setting this bit is mandatory to use the USB FS peripheral. If V<sub>DDUSB</sub> is not always present in the application, the PVM can be used to determine whether this supply is ready or not.
  [then]


  [ifdef] PWR_PWR_CR3_DEF
    \
    \ @brief Power control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00008000
    \
    $00 constant PWR_EWUP1                      \ [0x00] Enable Wake-up pin WKUP1 When this bit is set, the external wake-up pin WKUP1 is enabled and triggers a wake-up from Standby or Shutdown event when a rising or a falling edge occurs. The active edge is configured via the WP1 bit in the PWR_CR4 register.
    $01 constant PWR_EWUP2                      \ [0x01] Enable Wake-up pin WKUP2 When this bit is set, the external wake-up pin WKUP2 is enabled and triggers a wake-up from Standby or Shutdown event when a rising or a falling edge occurs. The active edge is configured via the WP2 bit in the PWR_CR4 register.
    $02 constant PWR_EWUP3                      \ [0x02] Enable Wake-up pin WKUP3 When this bit is set, the external wake-up pin WKUP3 is enabled and triggers a wake-up from Standby or Shutdown event when a rising or a falling edge occurs. The active edge is configured via the WP3 bit in the PWR_CR4 register.
    $03 constant PWR_EWUP4                      \ [0x03] Enable Wake-up pin WKUP4 When this bit is set, the external wake-up pin WKUP4 is enabled and triggers a wake-up from Standby or Shutdown event when a rising or a falling edge occurs. The active edge is configured via the WP4 bit in the PWR_CR4 register.
    $04 constant PWR_EWUP5                      \ [0x04] Enable Wake-up pin WKUP5 When this bit is set, the external wake-up pin WKUP5 is enabled and triggers a wake-up from Standby or Shutdown event when a rising or a falling edge occurs.The active edge is configured via the WP5 bit in the PWR_CR4 register.
    $06 constant PWR_EWUP7                      \ [0x06] Enable Wake-up pin WKUP7. When this bit is set, the external wake-up pin WKUP7 is enabled and triggers a wake-up from Standby or Shutdown event when a rising or a falling edge occurs.The active edge is configured via the WP7 bit in the PWR_CR4 register.
    $08 constant PWR_RRS                        \ [0x08] SRAM2 retention in Standby mode
    $09 constant PWR_ENULP                      \ [0x09] Enable ULP sampling When this bit is set, the BORL, BORH and PVD are periodically sampled instead continuous monitoring to reduce power consumption. Fast supply drop between two sample/compare phases is not detected in this mode. This bit has impact only on STOP2, Standby and shutdown low power modes.
    $0a constant PWR_APC                        \ [0x0a] Apply pull-up and pull-down configuration When this bit is set, the I/O pull-up and pull-down configurations defined in the PWR_PUCRx and PWR_PDCRx registers are applied. When this bit is cleared, the PWR_PUCRx and PWR_PDCRx registers are not applied to the I/Os, instead the I/Os are in floating mode during Standby or configured according GPIO controller GPIOx_PUPDR register during RUN mode.
    $0f constant PWR_EIWUL                      \ [0x0f] Enable internal wake-up line
  [then]


  [ifdef] PWR_PWR_CR4_DEF
    \
    \ @brief Power control register 4
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WP1                        \ [0x00] Wake-up pin WKUP1 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP1
    $01 constant PWR_WP2                        \ [0x01] Wake-up pin WKUP2 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP2
    $02 constant PWR_WP3                        \ [0x02] Wake-up pin WKUP3 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP3
    $03 constant PWR_WP4                        \ [0x03] Wake-up pin WKUP4 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP4
    $04 constant PWR_WP5                        \ [0x04] Wake-up pin WKUP5 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP5
    $06 constant PWR_WP7                        \ [0x06] Wake-up pin WKUP7 polarity This bit defines the polarity used for an event detection on external wake-up pin, WKUP7
    $08 constant PWR_VBE                        \ [0x08] V<sub>BAT</sub> battery charging enable
    $09 constant PWR_VBRS                       \ [0x09] V<sub>BAT</sub> battery charging resistor selection
  [then]


  [ifdef] PWR_PWR_SR1_DEF
    \
    \ @brief Power status register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUF1                       \ [0x00] Wake-up flag 1 This bit is set when a wake-up event is detected on wake-up pin, WKUP1. It is cleared by writing 1 in the CWUF1 bit of the PWR_SCR register.
    $01 constant PWR_WUF2                       \ [0x01] Wake-up flag 2 This bit is set when a wake-up event is detected on wake-up pin, WKUP2. It is cleared by writing 1 in the CWUF2 bit of the PWR_SCR register.
    $02 constant PWR_WUF3                       \ [0x02] Wake-up flag 3 This bit is set when a wake-up event is detected on wake-up pin, WKUP3. It is cleared by writing 1 in the CWUF3 bit of the PWR_SCR register.
    $03 constant PWR_WUF4                       \ [0x03] Wake-up flag 4 This bit is set when a wake-up event is detected on wake-up pin,WKUP4. It is cleared by writing 1 in the CWUF4 bit of the PWR_SCR register.
    $04 constant PWR_WUF5                       \ [0x04] Wake-up flag 5 This bit is set when a wake-up event is detected on wake-up pin, WKUP5. It is cleared by writing 1 in the CWUF5 bit of the PWR_SCR register.
    $06 constant PWR_WUF7                       \ [0x06] Wake-up flag 7 This bit is set when a wake-up event is detected on wake-up pin, WKUP7. It is cleared by writing 1 in the CWUF7 bit of the PWR_SCR register.
    $08 constant PWR_SBF                        \ [0x08] Standby flag This bit is set by hardware when the device enters the Standby mode and is cleared by setting the CSBF bit in the PWR_SCR register, or by a power-on reset. It is not cleared by the system reset.
    $09 constant PWR_STOPF                      \ [0x09 : 3] Stop Flags These bits are set by hardware when the device enters any stop mode and are cleared by setting the CSBF bit in the PWR_SCR register, or by a power-on reset. It is not cleared by the system reset.
    $0f constant PWR_WUFI                       \ [0x0f] Wake-up flag internal This bit is set when a wake-up is detected on the internal wake-up line. It is cleared when all internal wake-up sources are cleared.
  [then]


  [ifdef] PWR_PWR_SR2_DEF
    \
    \ @brief Power status register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $07 constant PWR_FLASH_RDY                  \ [0x07] Flash ready flag This bit is set by hardware to indicate when the flash memory is readey to be accessed after wake-up from power-down. To place the flash memory in power-down, set either FPD_LPRUN, FPD_LPSLP or FPD_STP bits. Note : If the system boots from SRAM, the user application must wait until the FLASH_RDY bit is set, prior to jumping to flash memory.
    $08 constant PWR_REGLPS                     \ [0x08] Low-power regulator started This bit provides the information whether the low-power regulator is ready after a power-on reset or a Standby/Shutdown. If the Standby mode is entered while REGLPS bit is still cleared, the wake-up from Standby mode time may be increased.
    $09 constant PWR_REGLPF                     \ [0x09] Low-power regulator flag This bit is set by hardware when the MCU is in Low-power run mode. When the MCU exits from the Low-power run mode, this bit remains at 1 until the regulator is ready in main mode. A polling on this bit must be done before increasing the product frequency. This bit is cleared by hardware when the regulator is ready.
    $0a constant PWR_VOSF                       \ [0x0a] Voltage scaling flag A delay is required for the internal regulator to be ready after the voltage scaling has been changed. VOSF indicates that the regulator reached the voltage level defined with VOS bits of the PWR_CR1 register.
    $0b constant PWR_PVDO                       \ [0x0b] Programmable voltage detector output
    $0c constant PWR_PVMO1                      \ [0x0c] Peripheral voltage monitoring output: V<sub>DDUSB</sub> vs. 1.2 V Note: PVMO1 is cleared when PVM1 is disabled (PVME1 = 0). After enabling PVM1, the PVM1 output is valid after the PVM1 wake-up time.
    $0e constant PWR_PVMO3                      \ [0x0e] Peripheral voltage monitoring output: V<sub>DDA</sub> vs. 1.621V Note: PVMO3 is cleared when PVM3 is disabled (PVME3 = 0). After enabling PVM3, the PVM3 output is valid after the PVM3 wake-up time.
    $0f constant PWR_PVMO4                      \ [0x0f] Peripheral voltage monitoring output: V<sub>DDA</sub> vs. 2.21V Note: PVMO4 is cleared when PVM4 is disabled (PVME4 = 0). After enabling PVM4, the PVM4 output is valid after the PVM4 wake-up time.
  [then]


  [ifdef] PWR_PWR_SCR_DEF
    \
    \ @brief Power status clear register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant PWR_CWUF1                      \ [0x00] Clear wake-up flag 1 Setting this bit clears the WUF1 flag in the PWR_SR1 register.
    $01 constant PWR_CWUF2                      \ [0x01] Clear wake-up flag 2 Setting this bit clears the WUF2 flag in the PWR_SR1 register.
    $02 constant PWR_CWUF3                      \ [0x02] Clear wake-up flag 3 Setting this bit clears the WUF3 flag in the PWR_SR1 register.
    $03 constant PWR_CWUF4                      \ [0x03] Clear wake-up flag 4 Setting this bit clears the WUF4 flag in the PWR_SR1 register.
    $04 constant PWR_CWUF5                      \ [0x04] Clear wake-up flag 5 Setting this bit clears the WUF5 flag in the PWR_SR1 register.
    $06 constant PWR_CWUF7                      \ [0x06] Clear wake-up flag 7 Setting this bit clears the WUF7 flag in the PWR_SR1 register.
    $08 constant PWR_CSBF                       \ [0x08] Clear standby flag Setting this bit clears the SBF flag in the PWR_SR1 register.
  [then]


  [ifdef] PWR_PWR_PUCRA_DEF
    \
    \ @brief Power Port A pull-up control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $01 constant PWR_PU1                        \ [0x01] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $02 constant PWR_PU2                        \ [0x02] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $03 constant PWR_PU3                        \ [0x03] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $04 constant PWR_PU4                        \ [0x04] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $05 constant PWR_PU5                        \ [0x05] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $06 constant PWR_PU6                        \ [0x06] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $07 constant PWR_PU7                        \ [0x07] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $08 constant PWR_PU8                        \ [0x08] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $09 constant PWR_PU9                        \ [0x09] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0a constant PWR_PU10                       \ [0x0a] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0b constant PWR_PU11                       \ [0x0b] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0c constant PWR_PU12                       \ [0x0c] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0d constant PWR_PU13                       \ [0x0d] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0e constant PWR_PU14                       \ [0x0e] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0f constant PWR_PU15                       \ [0x0f] Port A pull-up bit y (y1=115 to 0) When set, this bit activates the pull-up on PA[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
  [then]


  [ifdef] PWR_PWR_PDCRA_DEF
    \
    \ @brief Power Port A pull-down control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $01 constant PWR_PD1                        \ [0x01] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $02 constant PWR_PD2                        \ [0x02] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $03 constant PWR_PD3                        \ [0x03] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $04 constant PWR_PD4                        \ [0x04] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $05 constant PWR_PD5                        \ [0x05] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $06 constant PWR_PD6                        \ [0x06] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $07 constant PWR_PD7                        \ [0x07] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $08 constant PWR_PD8                        \ [0x08] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $09 constant PWR_PD9                        \ [0x09] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $0a constant PWR_PD10                       \ [0x0a] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $0b constant PWR_PD11                       \ [0x0b] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $0c constant PWR_PD12                       \ [0x0c] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $0d constant PWR_PD13                       \ [0x0d] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $0e constant PWR_PD14                       \ [0x0e] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
    $0f constant PWR_PD15                       \ [0x0f] Port A pull-down bit y When set, this bit activates the pull-down on PA[y] when APC bit is set in PWR_CR3 register.
  [then]


  [ifdef] PWR_PWR_PUCRB_DEF
    \
    \ @brief Power Port B pull-up control register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $01 constant PWR_PU1                        \ [0x01] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $02 constant PWR_PU2                        \ [0x02] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $03 constant PWR_PU3                        \ [0x03] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $04 constant PWR_PU4                        \ [0x04] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $05 constant PWR_PU5                        \ [0x05] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $06 constant PWR_PU6                        \ [0x06] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $07 constant PWR_PU7                        \ [0x07] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $08 constant PWR_PU8                        \ [0x08] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $09 constant PWR_PU9                        \ [0x09] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $0a constant PWR_PU10                       \ [0x0a] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $0b constant PWR_PU11                       \ [0x0b] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $0c constant PWR_PU12                       \ [0x0c] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $0d constant PWR_PU13                       \ [0x0d] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $0e constant PWR_PU14                       \ [0x0e] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
    $0f constant PWR_PU15                       \ [0x0f] Port B pull-up bit y When set, this bit activates the pull-up on PB[y] when APC bit is set in PWR_CR3 register.
  [then]


  [ifdef] PWR_PWR_PDCRB_DEF
    \
    \ @brief Power Port B pull-down control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $01 constant PWR_PD1                        \ [0x01] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $02 constant PWR_PD2                        \ [0x02] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $03 constant PWR_PD3                        \ [0x03] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $04 constant PWR_PD4                        \ [0x04] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $05 constant PWR_PD5                        \ [0x05] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $06 constant PWR_PD6                        \ [0x06] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $07 constant PWR_PD7                        \ [0x07] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $08 constant PWR_PD8                        \ [0x08] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $09 constant PWR_PD9                        \ [0x09] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $0a constant PWR_PD10                       \ [0x0a] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $0b constant PWR_PD11                       \ [0x0b] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $0c constant PWR_PD12                       \ [0x0c] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $0d constant PWR_PD13                       \ [0x0d] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $0e constant PWR_PD14                       \ [0x0e] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
    $0f constant PWR_PD15                       \ [0x0f] Port B pull-down bit y When set, this bit activates the pull-down on PB[y] when APC bit is set in PWR_CR3 register.
  [then]


  [ifdef] PWR_PWR_PUCRC_DEF
    \
    \ @brief Power Port C pull-up control register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $01 constant PWR_PU1                        \ [0x01] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $02 constant PWR_PU2                        \ [0x02] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $03 constant PWR_PU3                        \ [0x03] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $04 constant PWR_PU4                        \ [0x04] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $05 constant PWR_PU5                        \ [0x05] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $06 constant PWR_PU6                        \ [0x06] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $07 constant PWR_PU7                        \ [0x07] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $08 constant PWR_PU8                        \ [0x08] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $09 constant PWR_PU9                        \ [0x09] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0a constant PWR_PU10                       \ [0x0a] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0b constant PWR_PU11                       \ [0x0b] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0c constant PWR_PU12                       \ [0x0c] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0d constant PWR_PU13                       \ [0x0d] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0e constant PWR_PU14                       \ [0x0e] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0f constant PWR_PU15                       \ [0x0f] Port C pull-up bit y When set, this bit activates the pull-up on PC[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
  [then]


  [ifdef] PWR_PWR_PDCRC_DEF
    \
    \ @brief Power Port C pull-down control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $01 constant PWR_PD1                        \ [0x01] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $02 constant PWR_PD2                        \ [0x02] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $03 constant PWR_PD3                        \ [0x03] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $04 constant PWR_PD4                        \ [0x04] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $05 constant PWR_PD5                        \ [0x05] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $06 constant PWR_PD6                        \ [0x06] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $07 constant PWR_PD7                        \ [0x07] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $08 constant PWR_PD8                        \ [0x08] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $09 constant PWR_PD9                        \ [0x09] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $0a constant PWR_PD10                       \ [0x0a] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $0b constant PWR_PD11                       \ [0x0b] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $0c constant PWR_PD12                       \ [0x0c] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $0d constant PWR_PD13                       \ [0x0d] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $0e constant PWR_PD14                       \ [0x0e] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
    $0f constant PWR_PD15                       \ [0x0f] Port C pull-down bit y When set, this bit activates the pull-down on PC[y] when APC bit is set in PWR_CR3 register.
  [then]


  [ifdef] PWR_PWR_PUCRD_DEF
    \
    \ @brief Power Port D pull-up control register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $01 constant PWR_PU1                        \ [0x01] Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $02 constant PWR_PU2                        \ [0x02] Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $03 constant PWR_PU3                        \ [0x03] Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $04 constant PWR_PU4                        \ [0x04] Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $05 constant PWR_PU5                        \ [0x05] Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $06 constant PWR_PU6                        \ [0x06] Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $08 constant PWR_PU8                        \ [0x08] Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $09 constant PWR_PU9                        \ [0x09] Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0a constant PWR_PU10                       \ [0x0a] Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0b constant PWR_PU11                       \ [0x0b] Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0c constant PWR_PU12                       \ [0x0c] Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $0d constant PWR_PU13                       \ [0x0d] Port D pull-up bit y When set, this bit activates the pull-up on PD[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
  [then]


  [ifdef] PWR_PWR_PDCRD_DEF
    \
    \ @brief Power Port D pull-down control register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
    $01 constant PWR_PD1                        \ [0x01] Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
    $02 constant PWR_PD2                        \ [0x02] Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
    $03 constant PWR_PD3                        \ [0x03] Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
    $04 constant PWR_PD4                        \ [0x04] Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
    $05 constant PWR_PD5                        \ [0x05] Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
    $06 constant PWR_PD6                        \ [0x06] Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
    $08 constant PWR_PD8                        \ [0x08] Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
    $09 constant PWR_PD9                        \ [0x09] Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
    $0a constant PWR_PD10                       \ [0x0a] Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
    $0b constant PWR_PD11                       \ [0x0b] Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
    $0c constant PWR_PD12                       \ [0x0c] Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
    $0d constant PWR_PD13                       \ [0x0d] Port D pull-down bit y When set, this bit activates the pull-down on PD[y] when APC bit is set in PWR_CR3 register.
  [then]


  [ifdef] PWR_PWR_PUCRE_DEF
    \
    \ @brief Power Port E pull-up control register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $03 constant PWR_PU3                        \ [0x03] Port E pull-up bit 3 When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $07 constant PWR_PU7                        \ [0x07] Port E pull-up bit y When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $08 constant PWR_PU8                        \ [0x08] Port E pull-up bit y When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $09 constant PWR_PU9                        \ [0x09] Port E pull-up bit y When set, this bit activates the pull-up on PE[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
  [then]


  [ifdef] PWR_PWR_PDCRE_DEF
    \
    \ @brief Power Port E pull-down control register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $03 constant PWR_PD3                        \ [0x03] Port E pull-down bit 3 When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
    $07 constant PWR_PD7                        \ [0x07] Port E pull-down bit y When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
    $08 constant PWR_PD8                        \ [0x08] Port E pull-down bit y When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
    $09 constant PWR_PD9                        \ [0x09] Port E pull-down bit y When set, this bit activates the pull-down on PE[y] when APC bit is set in PWR_CR3 register.
  [then]


  [ifdef] PWR_PWR_PUCRF_DEF
    \
    \ @brief Power Port F pull-up control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port F pull-up bit y When set, this bit activates the pull-up on PH[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $01 constant PWR_PU1                        \ [0x01] Port F pull-up bit y When set, this bit activates the pull-up on PH[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $02 constant PWR_PU2                        \ [0x02] Port F pull-up bit y When set, this bit activates the pull-up on PH[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
    $03 constant PWR_PU3                        \ [0x03] Port F pull-up bit y When set, this bit activates the pull-up on PH[y] when APC bit is set in PWR_CR3 register. If the corresponding PDy bit is also set, the pull-up is not activated and the pull-down is activated instead with highest priority.
  [then]


  [ifdef] PWR_PWR_PDCRF_DEF
    \
    \ @brief Power Port F pull-down control register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port F pull-down bit y When set, this bit activates the pull-down on PH[y] when APC bit is set in PWR_CR3 register.
    $01 constant PWR_PD1                        \ [0x01] Port F pull-down bit y When set, this bit activates the pull-down on PH[y] when APC bit is set in PWR_CR3 register.
    $02 constant PWR_PD2                        \ [0x02] Port F pull-down bit y When set, this bit activates the pull-down on PH[y] when APC bit is set in PWR_CR3 register.
    $03 constant PWR_PD3                        \ [0x03] Port F pull-down bit y When set, this bit activates the pull-down on PH[y] when APC bit is set in PWR_CR3 register.
  [then]

  \
  \ @brief PWR register block
  \
  $00 constant PWR_PWR_CR1              \ Power control register 1
  $04 constant PWR_PWR_CR2              \ Power control register 2
  $08 constant PWR_PWR_CR3              \ Power control register 3
  $0C constant PWR_PWR_CR4              \ Power control register 4
  $10 constant PWR_PWR_SR1              \ Power status register 1
  $14 constant PWR_PWR_SR2              \ Power status register 2
  $18 constant PWR_PWR_SCR              \ Power status clear register
  $20 constant PWR_PWR_PUCRA            \ Power Port A pull-up control register
  $24 constant PWR_PWR_PDCRA            \ Power Port A pull-down control register
  $28 constant PWR_PWR_PUCRB            \ Power Port B pull-up control register
  $2C constant PWR_PWR_PDCRB            \ Power Port B pull-down control register
  $30 constant PWR_PWR_PUCRC            \ Power Port C pull-up control register
  $34 constant PWR_PWR_PDCRC            \ Power Port C pull-down control register
  $38 constant PWR_PWR_PUCRD            \ Power Port D pull-up control register
  $3C constant PWR_PWR_PDCRD            \ Power Port D pull-down control register
  $40 constant PWR_PWR_PUCRE            \ Power Port E pull-up control register
  $44 constant PWR_PWR_PDCRE            \ Power Port E pull-down control register
  $48 constant PWR_PWR_PUCRF            \ Power Port F pull-up control register
  $4C constant PWR_PWR_PDCRF            \ Power Port F pull-down control register

: PWR_DEF ; [then]
