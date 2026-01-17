\
\ @file pwr.fs
\ @brief PWR address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PWR_DEF

  [ifdef] PWR_PWR_CR1_DEF
    \
    \ @brief PWR control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000208
    \
    $00 constant PWR_LPMS                       \ [0x00 : 3] Low-power mode selection These bits select the low-power mode entered when CPU enters deepsleep mode. 1XX: Shutdown mode
    $03 constant PWR_FPD_STOP                   \ [0x03] Flash memory powered down during Stop mode This bit determines whether the Flash memory is put in power-down mode or remains in idle mode when the device enters Stop mode.
    $05 constant PWR_FPD_SLP                    \ [0x05] Flash memory powered down during Sleep mode This bit determines whether the Flash memory is put in power-down mode or remains in idle mode when the device enters Sleep mode.
  [then]


  [ifdef] PWR_PWR_CR2_DEF
    \
    \ @brief PWR control register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000100
    \
    $08 constant PWR_PVM_VDDIO2                 \ [0x08 : 2] supply voltage monitoring
  [then]


  [ifdef] PWR_PWR_CR3_DEF
    \
    \ @brief PWR control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00008000
    \
    $00 constant PWR_EWUP1                      \ [0x00] Enable WKUP1 wakeup pin When this bit is set, the WKUP1 external wakeup pin is enabled and triggers a wakeup event when a rising or a falling edge occurs. The active edge is configured via the WP1 bit of the PWR_CR4 register.
    $01 constant PWR_EWUP2                      \ [0x01] Enable WKUP2 wakeup pin When this bit is set, the WKUP2 external wakeup pin is enabled and triggers a wakeup event when a rising or a falling edge occurs. The active edge is configured via the WP2 bit of the PWR_CR4 register.
    $02 constant PWR_EWUP3                      \ [0x02] Enable WKUP3 wakeup pin When this bit is set, the WKUP3 external wakeup pin is enabled and triggers a wakeup event when a rising or a falling edge occurs. The active edge is configured via the WP3 bit of the PWR_CR4 register.
    $03 constant PWR_EWUP4                      \ [0x03] Enable WKUP4 wakeup pin When this bit is set, the WKUP4 external wakeup pin is enabled and triggers a wakeup event when a rising or a falling edge occurs. The active edge is configured via the WP4 bit in the PWR_CR4 register.
    $04 constant PWR_EWUP5                      \ [0x04] Enable WKUP5 wakeup pin When this bit is set, the WKUP5 external wakeup pin is enabled and triggers a wakeup event when a rising or a falling edge occurs. The active edge is configured through WP5 bit in the PWR_CR4 register.
    $05 constant PWR_EWUP6                      \ [0x05] Enable WKUP6 wakeup pin When this bit is set, the WKUP6 external wakeup pin is enabled and triggers a wakeup event when a rising or a falling edge occurs. The active edge is configured through WP6 bit in the PWR_CR4 register.
    $0a constant PWR_APC                        \ [0x0a] Apply pull-up and pull-down configuration This bit determines whether the I/O pull-up and pull-down configurations defined in the PWR_PUCRx and PWR_PDCRx registers are applied.
    $0f constant PWR_EIWUL                      \ [0x0f] Enable internal wakeup line When set, a rising edge on the internal wakeup line triggers a wakeup event.
  [then]


  [ifdef] PWR_PWR_CR4_DEF
    \
    \ @brief PWR control register 4
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WP1                        \ [0x00] WKUP1 wakeup pin polarity WKUP1 external wakeup signal polarity (level or edge) to generate wakeup condition:
    $01 constant PWR_WP2                        \ [0x01] WKUP2 wakeup pin polarity WKUP2 external wakeup signal polarity (level or edge) to generate wakeup condition:
    $02 constant PWR_WP3                        \ [0x02] WKUP3 wakeup pin polarity WKUP3 external wakeup signal polarity (level or edge) to generate wakeup condition:
    $03 constant PWR_WP4                        \ [0x03] WKUP4 wakeup pin polarity WKUP4 external wakeup signal polarity (level or edge) to generate wakeup condition:
    $04 constant PWR_WP5                        \ [0x04] WKUP5 wakeup pin polarity WKUP5 external wakeup signal polarity (level or edge) to generate wakeup condition:
    $05 constant PWR_WP6                        \ [0x05] WKUP6 wakeup pin polarity WKUP6 external wakeup signal polarity (level or edge) to generate wakeup condition:
  [then]


  [ifdef] PWR_PWR_SR1_DEF
    \
    \ @brief PWR status register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WUF1                       \ [0x00] Wakeup flag 1 This bit is set when a wakeup condition is detected on WKUP1 wakeup pin. It is cleared by setting the CWUF1 bit of the PWR_SCR register.
    $01 constant PWR_WUF2                       \ [0x01] Wakeup flag 2 This bit is set when a wakeup condition is detected on WKUP2 wakeup pin. It is cleared by setting the CWUF2 bit of the PWR_SCR register.
    $02 constant PWR_WUF3                       \ [0x02] Wakeup flag 3 This bit is set when a wakeup condition is detected on WKUP3 wakeup pin. It is cleared by setting the CWUF3 bit of the PWR_SCR register.
    $03 constant PWR_WUF4                       \ [0x03] Wakeup flag 4 This bit is set when a wakeup condition is detected on WKUP4 wakeup pin. It is cleared by setting the CWUF4 bit of the PWR_SCR register.
    $04 constant PWR_WUF5                       \ [0x04] Wakeup flag 5 This bit is set when a wakeup condition is detected on WKUP5 wakeup pin. It is cleared by setting the CWUF5 bit of the PWR_SCR register.
    $05 constant PWR_WUF6                       \ [0x05] Wakeup flag 6 This bit is set when a wakeup condition is detected on WKUP6 wakeup pin. It is cleared by setting the CWUF6 bit of the PWR_SCR register.
    $08 constant PWR_SBF                        \ [0x08] Standby flag This bit is set by hardware when the device enters Standby mode and is cleared by setting the CSBF bit in the PWR_SCR register, or by a power-on reset. It is not cleared by the system reset.
    $0f constant PWR_WUFI                       \ [0x0f] Wakeup flag internal This bit is set when a wakeup condition is detected on the internal wakeup line. It is cleared when all internal wakeup sources are cleared.
  [then]


  [ifdef] PWR_PWR_SR2_DEF
    \
    \ @brief PWR status register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $07 constant PWR_FLASH_RDY                  \ [0x07] Flash ready flag This bit is set by hardware to indicate when the Flash memory is ready to be accessed after wakeup from power-down. To place the Flash memory in power-down, set either FPD_SLP or FPD_STP bit. Note: If the system boots from SRAM, the user application must wait till FLASH_RDY bit is set, prior to jumping to Flash memory.
    $0d constant PWR_PVM_VDDIO2_OUT             \ [0x0d] V<sub>DDIO2</sub> supply voltage monitoring output flag This flag indicates the readiness of the V<sub>DDIO2</sub> supply voltage (excess of 1.2 V). The flag is cleared when the PVM of V<sub>DDIO2</sub> is disabled (PVM_VDDIO2[0] = 0). Note: Only applicable on STM32C071xx, reserved on the other products.
  [then]


  [ifdef] PWR_PWR_SCR_DEF
    \
    \ @brief PWR status clear register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant PWR_CWUF1                      \ [0x00] Clear wakeup flag 1 Setting this bit clears the WUF1 flag in the PWR_SR1 register.
    $01 constant PWR_CWUF2                      \ [0x01] Clear wakeup flag 2 Setting this bit clears the WUF2 flag in the PWR_SR1 register.
    $02 constant PWR_CWUF3                      \ [0x02] Clear wakeup flag 3 Setting this bit clears the WUF3 flag in the PWR_SR1 register.
    $03 constant PWR_CWUF4                      \ [0x03] Clear wakeup flag 4 Setting this bit clears the WUF4 flag in the PWR_SR1 register.
    $04 constant PWR_CWUF5                      \ [0x04] Clear wakeup flag 5 Setting this bit clears the WUF5 flag in the PWR_SR1 register.
    $05 constant PWR_CWUF6                      \ [0x05] Clear wakeup flag 6 Setting this bit clears the WUF6 flag in the PWR_SR1 register.
    $08 constant PWR_CSBF                       \ [0x08] Clear standby flag Setting this bit clears the SBF flag in the PWR_SR1 register.
  [then]


  [ifdef] PWR_PWR_PUCRA_DEF
    \
    \ @brief PWR Port A pull-up control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $01 constant PWR_PU1                        \ [0x01] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $02 constant PWR_PU2                        \ [0x02] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $03 constant PWR_PU3                        \ [0x03] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $04 constant PWR_PU4                        \ [0x04] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $05 constant PWR_PU5                        \ [0x05] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $06 constant PWR_PU6                        \ [0x06] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $07 constant PWR_PU7                        \ [0x07] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $08 constant PWR_PU8                        \ [0x08] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $09 constant PWR_PU9                        \ [0x09] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0a constant PWR_PU10                       \ [0x0a] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0b constant PWR_PU11                       \ [0x0b] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0c constant PWR_PU12                       \ [0x0c] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0d constant PWR_PU13                       \ [0x0d] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0e constant PWR_PU14                       \ [0x0e] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0f constant PWR_PU15                       \ [0x0f] Port A pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
  [then]


  [ifdef] PWR_PWR_PDCRA_DEF
    \
    \ @brief PWR Port A pull-down control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $01 constant PWR_PD1                        \ [0x01] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $02 constant PWR_PD2                        \ [0x02] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $03 constant PWR_PD3                        \ [0x03] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $04 constant PWR_PD4                        \ [0x04] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $05 constant PWR_PD5                        \ [0x05] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $06 constant PWR_PD6                        \ [0x06] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $07 constant PWR_PD7                        \ [0x07] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $08 constant PWR_PD8                        \ [0x08] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $09 constant PWR_PD9                        \ [0x09] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0a constant PWR_PD10                       \ [0x0a] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0b constant PWR_PD11                       \ [0x0b] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0c constant PWR_PD12                       \ [0x0c] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0d constant PWR_PD13                       \ [0x0d] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0e constant PWR_PD14                       \ [0x0e] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0f constant PWR_PD15                       \ [0x0f] Port A pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
  [then]


  [ifdef] PWR_PWR_PUCRB_DEF
    \
    \ @brief PWR Port B pull-up control register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $01 constant PWR_PU1                        \ [0x01] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $02 constant PWR_PU2                        \ [0x02] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $03 constant PWR_PU3                        \ [0x03] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $04 constant PWR_PU4                        \ [0x04] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $05 constant PWR_PU5                        \ [0x05] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $06 constant PWR_PU6                        \ [0x06] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $07 constant PWR_PU7                        \ [0x07] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $08 constant PWR_PU8                        \ [0x08] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $09 constant PWR_PU9                        \ [0x09] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0a constant PWR_PU10                       \ [0x0a] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0b constant PWR_PU11                       \ [0x0b] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0c constant PWR_PU12                       \ [0x0c] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0d constant PWR_PU13                       \ [0x0d] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0e constant PWR_PU14                       \ [0x0e] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0f constant PWR_PU15                       \ [0x0f] Port B pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
  [then]


  [ifdef] PWR_PWR_PDCRB_DEF
    \
    \ @brief PWR Port B pull-down control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $01 constant PWR_PD1                        \ [0x01] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $02 constant PWR_PD2                        \ [0x02] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $03 constant PWR_PD3                        \ [0x03] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $04 constant PWR_PD4                        \ [0x04] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $05 constant PWR_PD5                        \ [0x05] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $06 constant PWR_PD6                        \ [0x06] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $07 constant PWR_PD7                        \ [0x07] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $08 constant PWR_PD8                        \ [0x08] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $09 constant PWR_PD9                        \ [0x09] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0a constant PWR_PD10                       \ [0x0a] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0b constant PWR_PD11                       \ [0x0b] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0c constant PWR_PD12                       \ [0x0c] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0d constant PWR_PD13                       \ [0x0d] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0e constant PWR_PD14                       \ [0x0e] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0f constant PWR_PD15                       \ [0x0f] Port B pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
  [then]


  [ifdef] PWR_PWR_PUCRC_DEF
    \
    \ @brief PWR Port C pull-up control register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $01 constant PWR_PU1                        \ [0x01] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $02 constant PWR_PU2                        \ [0x02] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $03 constant PWR_PU3                        \ [0x03] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $04 constant PWR_PU4                        \ [0x04] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $05 constant PWR_PU5                        \ [0x05] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $06 constant PWR_PU6                        \ [0x06] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $07 constant PWR_PU7                        \ [0x07] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $08 constant PWR_PU8                        \ [0x08] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $09 constant PWR_PU9                        \ [0x09] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0a constant PWR_PU10                       \ [0x0a] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0b constant PWR_PU11                       \ [0x0b] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0c constant PWR_PU12                       \ [0x0c] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0d constant PWR_PU13                       \ [0x0d] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0e constant PWR_PU14                       \ [0x0e] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $0f constant PWR_PU15                       \ [0x0f] Port C pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available. On STM32C031xx, only PU15 to PU13, PU7, and PU6 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
  [then]


  [ifdef] PWR_PWR_PDCRC_DEF
    \
    \ @brief PWR Port C pull-down control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $01 constant PWR_PD1                        \ [0x01] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $02 constant PWR_PD2                        \ [0x02] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $03 constant PWR_PD3                        \ [0x03] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $04 constant PWR_PD4                        \ [0x04] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $05 constant PWR_PD5                        \ [0x05] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $06 constant PWR_PD6                        \ [0x06] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $07 constant PWR_PD7                        \ [0x07] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $08 constant PWR_PD8                        \ [0x08] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $09 constant PWR_PD9                        \ [0x09] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0a constant PWR_PD10                       \ [0x0a] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0b constant PWR_PD11                       \ [0x0b] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0c constant PWR_PD12                       \ [0x0c] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0d constant PWR_PD13                       \ [0x0d] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0e constant PWR_PD14                       \ [0x0e] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $0f constant PWR_PD15                       \ [0x0f] Port C pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available. On STM32C031xx, only PD15 to PD13, PD7, and PD6 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
  [then]


  [ifdef] PWR_PWR_PUCRD_DEF
    \
    \ @brief PWR Port D pull-up control register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port D pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PU3 to PU0 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $01 constant PWR_PU1                        \ [0x01] Port D pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PU3 to PU0 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $02 constant PWR_PU2                        \ [0x02] Port D pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PU3 to PU0 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $03 constant PWR_PU3                        \ [0x03] Port D pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PU3 to PU0 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $04 constant PWR_PU4                        \ [0x04] Port D pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PU3 to PU0 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $05 constant PWR_PU5                        \ [0x05] Port D pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PU3 to PU0 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $06 constant PWR_PU6                        \ [0x06] Port D pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PU3 to PU0 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $08 constant PWR_PU8                        \ [0x08] Port D pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PD[i] I/O. Only available on STM32C071xx. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $09 constant PWR_PU9                        \ [0x09] Port D pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PD[i] I/O. Only available on STM32C071xx. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
  [then]


  [ifdef] PWR_PWR_PDCRD_DEF
    \
    \ @brief PWR Port D pull-down control register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port D pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PD3 to PD0 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $01 constant PWR_PD1                        \ [0x01] Port D pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PD3 to PD0 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $02 constant PWR_PD2                        \ [0x02] Port D pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PD3 to PD0 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $03 constant PWR_PD3                        \ [0x03] Port D pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PD3 to PD0 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $04 constant PWR_PD4                        \ [0x04] Port D pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PD3 to PD0 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $05 constant PWR_PD5                        \ [0x05] Port D pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PD3 to PD0 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $06 constant PWR_PD6                        \ [0x06] Port D pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PD[i] I/O. Not available on STM32C011xx. On STM32C031xx, only PD3 to PD0 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $08 constant PWR_PD8                        \ [0x08] Port D pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PD[i] I/O. Only available on STM32C071xx. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $09 constant PWR_PD9                        \ [0x09] Port D pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PD[i] I/O. Only available on STM32C071xx. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
  [then]


  [ifdef] PWR_PWR_PUCRF_DEF
    \
    \ @brief PWR Port F pull-up control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PU0                        \ [0x00] Port F pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PF[i] I/O. On STM32C011xx, only PU2 is available. On STM32C031xx, only PU2 to PU0 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $01 constant PWR_PU1                        \ [0x01] Port F pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PF[i] I/O. On STM32C011xx, only PU2 is available. On STM32C031xx, only PU2 to PU0 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $02 constant PWR_PU2                        \ [0x02] Port F pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PF[i] I/O. On STM32C011xx, only PU2 is available. On STM32C031xx, only PU2 to PU0 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
    $03 constant PWR_PU3                        \ [0x03] Port F pull-up bit i Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PF[i] I/O. On STM32C011xx, only PU2 is available. On STM32C031xx, only PU2 to PU0 are available. Note: For the same pin, this pull-up device must not be activated when a pull-down device is set through the GPIOx_PUPDR register.
  [then]


  [ifdef] PWR_PWR_PDCRF_DEF
    \
    \ @brief PWR Port F pull-down control register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PD0                        \ [0x00] Port F pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PF[i] I/O. On STM32C011xx, only PD2 is available. On STM32C031xx, only PD2 to PD0 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $01 constant PWR_PD1                        \ [0x01] Port F pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PF[i] I/O. On STM32C011xx, only PD2 is available. On STM32C031xx, only PD2 to PD0 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $02 constant PWR_PD2                        \ [0x02] Port F pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PF[i] I/O. On STM32C011xx, only PD2 is available. On STM32C031xx, only PD2 to PD0 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
    $03 constant PWR_PD3                        \ [0x03] Port F pull-down bit i Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PF[i] I/O. On STM32C011xx, only PD2 is available. On STM32C031xx, only PD2 to PD0 are available. Note: For the same pin, this pull-down device must not be activated when a pull-up device is set through the GPIOx_PUPDR register.
  [then]


  [ifdef] PWR_PWR_BKP0R_DEF
    \
    \ @brief PWR backup 0 register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant PWR_BKP                        \ [0x00 : 16] Backup bitfield This bitfield retains information when the device is in Standby.
  [then]


  [ifdef] PWR_PWR_BKP1R_DEF
    \
    \ @brief PWR backup 1 register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant PWR_BKP                        \ [0x00 : 16] Backup bitfield This bitfield retains information when the device is in Standby.
  [then]


  [ifdef] PWR_PWR_BKP2R_DEF
    \
    \ @brief PWR backup 2 register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant PWR_BKP                        \ [0x00 : 16] Backup bitfield This bitfield retains information when the device is in Standby.
  [then]


  [ifdef] PWR_PWR_BKP3R_DEF
    \
    \ @brief PWR backup 3 register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_BKP                        \ [0x00 : 16] Backup bitfield This bitfield retains information when the device is in Standby.
  [then]

  \
  \ @brief PWR address block description
  \
  $00 constant PWR_PWR_CR1              \ PWR control register 1
  $04 constant PWR_PWR_CR2              \ PWR control register 1
  $08 constant PWR_PWR_CR3              \ PWR control register 3
  $0C constant PWR_PWR_CR4              \ PWR control register 4
  $10 constant PWR_PWR_SR1              \ PWR status register 1
  $14 constant PWR_PWR_SR2              \ PWR status register 2
  $18 constant PWR_PWR_SCR              \ PWR status clear register
  $20 constant PWR_PWR_PUCRA            \ PWR Port A pull-up control register
  $24 constant PWR_PWR_PDCRA            \ PWR Port A pull-down control register
  $28 constant PWR_PWR_PUCRB            \ PWR Port B pull-up control register
  $2C constant PWR_PWR_PDCRB            \ PWR Port B pull-down control register
  $30 constant PWR_PWR_PUCRC            \ PWR Port C pull-up control register
  $34 constant PWR_PWR_PDCRC            \ PWR Port C pull-down control register
  $38 constant PWR_PWR_PUCRD            \ PWR Port D pull-up control register
  $3C constant PWR_PWR_PDCRD            \ PWR Port D pull-down control register
  $48 constant PWR_PWR_PUCRF            \ PWR Port F pull-up control register
  $4C constant PWR_PWR_PDCRF            \ PWR Port F pull-down control register
  $70 constant PWR_PWR_BKP0R            \ PWR backup 0 register
  $74 constant PWR_PWR_BKP1R            \ PWR backup 1 register
  $78 constant PWR_PWR_BKP2R            \ PWR backup 2 register
  $7C constant PWR_PWR_BKP3R            \ PWR backup 3 register

: PWR_DEF ; [then]
