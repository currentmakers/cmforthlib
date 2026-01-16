\
\ @file pwr.fs
\ @brief PWR address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PWR control register 1
\ Address offset: 0x00
\ Reset value: 0x00000208
\

$00000007 constant PWR_PWR_CR1_LPMS                                 \ Low-power mode selection These bits select the low-power mode entered when CPU enters deepsleep mode. 1XX: Shutdown mode
$00000008 constant PWR_PWR_CR1_FPD_STOP                             \ Flash memory powered down during Stop mode This bit determines whether the Flash memory is put in power-down mode or remains in idle mode when the device enters Stop mode.
$00000020 constant PWR_PWR_CR1_FPD_SLP                              \ Flash memory powered down during Sleep mode This bit determines whether the Flash memory is put in power-down mode or remains in idle mode when the device enters Sleep mode.


\
\ @brief PWR control register 3
\ Address offset: 0x08
\ Reset value: 0x00008000
\

$00000001 constant PWR_PWR_CR3_EWUP1                                \ Enable WKUP1 wakeup pin When this bit is set, the WKUP1 external wakeup pin is enabled and triggers a wakeup event when a rising or a falling edge occurs. The active edge is configured via the WP1 bit of the PWR_CR4 register.
$00000002 constant PWR_PWR_CR3_EWUP2                                \ Enable WKUP2 wakeup pin When this bit is set, the WKUP2 external wakeup pin is enabled and triggers a wakeup event when a rising or a falling edge occurs. The active edge is configured via the WP2 bit of the PWR_CR4 register.
$00000004 constant PWR_PWR_CR3_EWUP3                                \ Enable WKUP3 wakeup pin When this bit is set, the WKUP3 external wakeup pin is enabled and triggers a wakeup event when a rising or a falling edge occurs. The active edge is configured via the WP3 bit of the PWR_CR4 register.
$00000008 constant PWR_PWR_CR3_EWUP4                                \ Enable WKUP4 wakeup pin When this bit is set, the WKUP4 external wakeup pin is enabled and triggers a wakeup event when a rising or a falling edge occurs. The active edge is configured via the WP4 bit in the PWR_CR4 register.
$00000020 constant PWR_PWR_CR3_EWUP6                                \ Enable WKUP6 wakeup pin When this bit is set, the WKUP6 external wakeup pin is enabled and triggers a wakeup event when a rising or a falling edge occurs. The active edge is configured through WP6 bit in the PWR_CR4 register.
$00000400 constant PWR_PWR_CR3_APC                                  \ Apply pull-up and pull-down configuration This bit determines whether the I/O pull-up and pull-down configurations defined in the PWR_PUCRx and PWR_PDCRx registers are applied.
$00008000 constant PWR_PWR_CR3_EIWUL                                \ Enable internal wakeup line When set, a rising edge on the internal wakeup line triggers a wakeup event.


\
\ @brief PWR control register 4
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CR4_WP1                                  \ WKUP1 wakeup pin polarity WKUP1 external wakeup signal polarity (level or edge) to generate wakeup condition:
$00000002 constant PWR_PWR_CR4_WP2                                  \ WKUP2 wakeup pin polarity WKUP2 external wakeup signal polarity (level or edge) to generate wakeup condition:
$00000004 constant PWR_PWR_CR4_WP3                                  \ WKUP3 wakeup pin polarity WKUP3 external wakeup signal polarity (level or edge) to generate wakeup condition:
$00000008 constant PWR_PWR_CR4_WP4                                  \ WKUP4 wakeup pin polarity WKUP4 external wakeup signal polarity (level or edge) to generate wakeup condition:
$00000020 constant PWR_PWR_CR4_WP6                                  \ WKUP6 wakeup pin polarity WKUP6 external wakeup signal polarity (level or edge) to generate wakeup condition:


\
\ @brief PWR status register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SR1_WUF1                                 \ Wakeup flag 1 This bit is set when a wakeup condition is detected on WKUP1 wakeup pin. It is cleared by setting the CWUF1 bit of the PWR_SCR register.
$00000002 constant PWR_PWR_SR1_WUF2                                 \ Wakeup flag 2 This bit is set when a wakeup condition is detected on WKUP2 wakeup pin. It is cleared by setting the CWUF2 bit of the PWR_SCR register.
$00000004 constant PWR_PWR_SR1_WUF3                                 \ Wakeup flag 3 This bit is set when a wakeup condition is detected on WKUP3 wakeup pin. It is cleared by setting the CWUF3 bit of the PWR_SCR register.
$00000008 constant PWR_PWR_SR1_WUF4                                 \ Wakeup flag 4 This bit is set when a wakeup condition is detected on WKUP4 wakeup pin. It is cleared by setting the CWUF4 bit of the PWR_SCR register.
$00000020 constant PWR_PWR_SR1_WUF6                                 \ Wakeup flag 6 This bit is set when a wakeup condition is detected on WKUP6 wakeup pin. It is cleared by setting the CWUF6 bit of the PWR_SCR register.
$00000100 constant PWR_PWR_SR1_SBF                                  \ Standby/Shutdown flag This bit is set by hardware when the device enters Standby or Shutdown mode and is cleared by setting the CSBF bit in the PWR_SCR register, or by a power-on reset. It is not cleared by the system reset.
$00008000 constant PWR_PWR_SR1_WUFI                                 \ Wakeup flag internal This bit is set when a wakeup condition is detected on the internal wakeup line. It is cleared when all internal wakeup sources are cleared.


\
\ @brief PWR status register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000080 constant PWR_PWR_SR2_FLASH_RDY                            \ Flash ready flag This bit is set by hardware to indicate when the Flash memory is ready to be accessed after wakeup from power-down. To place the Flash memory in power-down, set either FPD_SLP or FPD_STP bit. Note: If the system boots from SRAM, the user application must wait till FLASH_RDY bit is set, prior to jumping to Flash memory.


\
\ @brief PWR status clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SCR_CWUF1                                \ Clear wakeup flag 1 Setting this bit clears the WUF1 flag in the PWR_SR1 register.
$00000002 constant PWR_PWR_SCR_CWUF2                                \ Clear wakeup flag 2 Setting this bit clears the WUF2 flag in the PWR_SR1 register.
$00000004 constant PWR_PWR_SCR_CWUF3                                \ Clear wakeup flag 3 Setting this bit clears the WUF3 flag in the PWR_SR1 register.
$00000008 constant PWR_PWR_SCR_CWUF4                                \ Clear wakeup flag 4 Setting this bit clears the WUF4 flag in the PWR_SR1 register.
$00000020 constant PWR_PWR_SCR_CWUF6                                \ Clear wakeup flag 6 Setting this bit clears the WUF6 flag in the PWR_SR1 register.
$00000100 constant PWR_PWR_SCR_CSBF                                 \ Clear standby flag Setting this bit clears the SBF flag in the PWR_SR1 register.


\
\ @brief PWR Port A pull-up control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRA_PU0                                \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00000002 constant PWR_PWR_PUCRA_PU1                                \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00000004 constant PWR_PWR_PUCRA_PU2                                \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00000008 constant PWR_PWR_PUCRA_PU3                                \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00000010 constant PWR_PWR_PUCRA_PU4                                \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00000020 constant PWR_PWR_PUCRA_PU5                                \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00000040 constant PWR_PWR_PUCRA_PU6                                \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00000080 constant PWR_PWR_PUCRA_PU7                                \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00000100 constant PWR_PWR_PUCRA_PU8                                \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00000200 constant PWR_PWR_PUCRA_PU9                                \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00000400 constant PWR_PWR_PUCRA_PU10                               \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00000800 constant PWR_PWR_PUCRA_PU11                               \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00001000 constant PWR_PWR_PUCRA_PU12                               \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00002000 constant PWR_PWR_PUCRA_PU13                               \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00004000 constant PWR_PWR_PUCRA_PU14                               \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.
$00008000 constant PWR_PWR_PUCRA_PU15                               \ Port A pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PA[i] I/O.


\
\ @brief PWR Port A pull-down control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRA_PD0                                \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00000002 constant PWR_PWR_PDCRA_PD1                                \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00000004 constant PWR_PWR_PDCRA_PD2                                \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00000008 constant PWR_PWR_PDCRA_PD3                                \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00000010 constant PWR_PWR_PDCRA_PD4                                \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00000020 constant PWR_PWR_PDCRA_PD5                                \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00000040 constant PWR_PWR_PDCRA_PD6                                \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00000080 constant PWR_PWR_PDCRA_PD7                                \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00000100 constant PWR_PWR_PDCRA_PD8                                \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00000200 constant PWR_PWR_PDCRA_PD9                                \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00000400 constant PWR_PWR_PDCRA_PD10                               \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00000800 constant PWR_PWR_PDCRA_PD11                               \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00001000 constant PWR_PWR_PDCRA_PD12                               \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00002000 constant PWR_PWR_PDCRA_PD13                               \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00004000 constant PWR_PWR_PDCRA_PD14                               \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.
$00008000 constant PWR_PWR_PDCRA_PD15                               \ Port A pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PA[i] I/O.


\
\ @brief PWR Port B pull-up control register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000040 constant PWR_PWR_PUCRB_PU6                                \ Port B pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available
$00000080 constant PWR_PWR_PUCRB_PU7                                \ Port B pull-up bit i (i = 15 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PB[i] I/O. On STM32C011xx, only PU7 and PU6 are available


\
\ @brief PWR Port B pull-down control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000040 constant PWR_PWR_PDCRB_PD6                                \ Port B pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available
$00000080 constant PWR_PWR_PDCRB_PD7                                \ Port B pull-down bit i (i = 15 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PB[i] I/O. On STM32C011xx, only PD7 and PD6 are available


\
\ @brief PWR Port C pull-up control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00004000 constant PWR_PWR_PUCRC_PU14                               \ Port C pull-up bit i (i = 15 to 13, 7 to 6) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available
$00008000 constant PWR_PWR_PUCRC_PU15                               \ Port C pull-up bit i (i = 15 to 13, 7 to 6) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PC[i] I/O. On STM32C011xx, only PU15 and PU14 are available


\
\ @brief PWR Port C pull-down control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00004000 constant PWR_PWR_PDCRC_PD14                               \ Port C pull-down bit i (i = 15, 14, 13, 7, 6) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available.
$00008000 constant PWR_PWR_PDCRC_PD15                               \ Port C pull-down bit i (i = 15, 14, 13, 7, 6) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PC[i] I/O. On STM32C011xx, only PD15 and PD14 are available.


\
\ @brief PWR Port D pull-up control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRD_PU0                                \ Port D pull-up bit i (i = 3 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PD[i] I/O.
$00000002 constant PWR_PWR_PUCRD_PU1                                \ Port D pull-up bit i (i = 3 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PD[i] I/O.
$00000004 constant PWR_PWR_PUCRD_PU2                                \ Port D pull-up bit i (i = 3 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PD[i] I/O.
$00000008 constant PWR_PWR_PUCRD_PU3                                \ Port D pull-up bit i (i = 3 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PD[i] I/O.


\
\ @brief PWR Port D pull-down control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRD_PD0                                \ Port D pull-down bit i (i = 3 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PD[i] I/O.
$00000002 constant PWR_PWR_PDCRD_PD1                                \ Port D pull-down bit i (i = 3 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PD[i] I/O.
$00000004 constant PWR_PWR_PDCRD_PD2                                \ Port D pull-down bit i (i = 3 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PD[i] I/O.
$00000008 constant PWR_PWR_PDCRD_PD3                                \ Port D pull-down bit i (i = 3 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PD[i] I/O.


\
\ @brief PWR Port F pull-up control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000004 constant PWR_PWR_PUCRF_PU2                                \ Port F pull-up bit i (i = 2 to 0) Setting PUi bit while the corresponding PDi bit is zero and the APC bit of the PWR_CR3 register is set activates a pull-up device on the PF[i] I/O. On STM32C011xx, only PU2 is available.


\
\ @brief PWR Port F pull-down control register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000004 constant PWR_PWR_PDCRF_PD2                                \ Port F pull-down bit i (i = 2 to 0) Setting PDi bit while the APC bit of the PWR_CR3 register is set activates a pull-down device on the PF[i] I/O. On STM32C011xx, only PD2 is available.


\
\ @brief PWR address block description
\
$40007000 constant PWR_PWR_CR1    \ offset: 0x00 : PWR control register 1
$40007008 constant PWR_PWR_CR3    \ offset: 0x08 : PWR control register 3
$4000700c constant PWR_PWR_CR4    \ offset: 0x0C : PWR control register 4
$40007010 constant PWR_PWR_SR1    \ offset: 0x10 : PWR status register 1
$40007014 constant PWR_PWR_SR2    \ offset: 0x14 : PWR status register 2
$40007018 constant PWR_PWR_SCR    \ offset: 0x18 : PWR status clear register
$40007020 constant PWR_PWR_PUCRA  \ offset: 0x20 : PWR Port A pull-up control register
$40007024 constant PWR_PWR_PDCRA  \ offset: 0x24 : PWR Port A pull-down control register
$40007028 constant PWR_PWR_PUCRB  \ offset: 0x28 : PWR Port B pull-up control register
$4000702c constant PWR_PWR_PDCRB  \ offset: 0x2C : PWR Port B pull-down control register
$40007030 constant PWR_PWR_PUCRC  \ offset: 0x30 : PWR Port C pull-up control register
$40007034 constant PWR_PWR_PDCRC  \ offset: 0x34 : PWR Port C pull-down control register
$40007038 constant PWR_PWR_PUCRD  \ offset: 0x38 : PWR Port D pull-up control register
$4000703c constant PWR_PWR_PDCRD  \ offset: 0x3C : PWR Port D pull-down control register
$40007048 constant PWR_PWR_PUCRF  \ offset: 0x48 : PWR Port F pull-up control register
$4000704c constant PWR_PWR_PDCRF  \ offset: 0x4C : PWR Port F pull-down control register

