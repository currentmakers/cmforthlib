\
\ @file sec_syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SYSCFG secure configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_SYSCFG_SYSCFG_SECCFGR_SYSCFGSEC              \ SYSCFG clock control, memory erase status and compensation cell registers security
$00000002 constant SEC_SYSCFG_SYSCFG_SECCFGR_CLASSBSEC              \ Class B security
$00000008 constant SEC_SYSCFG_SYSCFG_SECCFGR_FPUSEC                 \ FPU security


\
\ @brief SYSCFG configuration register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000100 constant SEC_SYSCFG_SYSCFG_CFGR1_BOOSTEN                  \ I/O analog switch voltage booster enable Access can be protected by GTZC_TZSC ADC4SEC. Note: Refer to Table121 for setting.
$00000200 constant SEC_SYSCFG_SYSCFG_CFGR1_ANASWVDD                 \ GPIO analog switch control voltage selection Access can be protected by GTZC_TZSC ADC4SEC. Note: Refer to Table121 for setting.
$00010000 constant SEC_SYSCFG_SYSCFG_CFGR1_PA6_FMP                  \ Fast-mode Plus drive capability activation on PA6 This bit can be read and written only with secure access if PA6 is secure in GPIOA. This bit enables the Fast-mode Plus drive mode for PA6 when PA6 is not used by I2C peripheral. This can be used to dive a LED for instance. Access can be protected by GPIOA SEC6.
$00020000 constant SEC_SYSCFG_SYSCFG_CFGR1_PA7_FMP                  \ Fast-mode Plus drive capability activation on PA7 This bit can be read and written only with secure access if PA7 is secure in GPIOA. This bit enables the Fast-mode Plus drive mode for PA7 when PA7 is not used by I2C peripheral. This can be used to dive a LED for instance. Access can be protected by GPIOA SEC7.
$00040000 constant SEC_SYSCFG_SYSCFG_CFGR1_PA15_FMP                 \ Fast-mode Plus drive capability activation on PA15 This bit can be read and written only with secure access if PA15 is secure in GPIOA. This bit enables the Fast-mode Plus drive mode for PA15 when PA15 is not used by I2C peripheral. This can be used to dive a LED for instance. Access can be protected by GPIOA SEC15.
$00080000 constant SEC_SYSCFG_SYSCFG_CFGR1_PB3_FMP                  \ Fast-mode Plus drive capability activation on PB3 This bit can be read and written only with secure access if PB3 is secure in GPIOB. This bit enables the Fast-mode Plus drive mode for PB3 when PB3 is not used by I2C peripheral. This can be used to dive a LED for instance. Access can be protected by GPIOB SEC3.


\
\ @brief SYSCFG FPU interrupt mask register
\ Address offset: 0x08
\ Reset value: 0x0000003F
\

$0000003f constant SEC_SYSCFG_SYSCFG_FPUIMR_FPU_IE                  \ Floating point unit interrupts enable bits FPU_IE[5]: Inexact interrupt enable (interrupt disable at reset) FPU_IE[4]: Input abnormal interrupt enable FPU_IE[3]: Overflow interrupt enable FPU_IE[2]: Underflow interrupt enable FPU_IE[1]: Divide-by-zero interrupt enable FPU_IE[0]: Invalid operation Interrupt enable


\
\ @brief SYSCFG CPU non-secure lock register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_SYSCFG_SYSCFG_CNSLCKR_LOCKNSVTOR             \ VTOR_NS register lock This bit is set by software and cleared only by a system reset.
$00000002 constant SEC_SYSCFG_SYSCFG_CNSLCKR_LOCKNSMPU              \ Non-secure MPU registers lock This bit is set by software and cleared only by a system reset. When set, this bit disables write access to non-secure MPU_CTRL_NS, MPU_RNR_NS and MPU_RBAR_NS registers.


\
\ @brief SYSCFG CPU secure lock register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_SYSCFG_SYSCFG_CSLOCKR_LOCKSVTAIRCR           \ VTOR_S register and AIRCR register bits lock This bit is set by software and cleared only by a system reset. When set, it disables write access to VTOR_S register, PRIS and BFHFNMINS bits in the AIRCR register.
$00000002 constant SEC_SYSCFG_SYSCFG_CSLOCKR_LOCKSMPU               \ Secure MPU registers lock This bit is set by software and cleared only by a system reset. When set, it disables write access to secure MPU_CTRL, MPU_RNR and MPU_RBAR registers.
$00000004 constant SEC_SYSCFG_SYSCFG_CSLOCKR_LOCKSAU                \ SAU registers lock This bit is set by software and cleared only by a system reset. When set, it disables write access to SAU_CTRL, SAU_RNR, SAU_RBAR and SAU_RLAR registers.


\
\ @brief SYSCFG configuration register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_SYSCFG_SYSCFG_CFGR2_CLL                      \ Cortex-M33 LOCKUP (hardfault) output enable This bit is set by software and cleared only by a system reset. It can be used to enable and lock the connection of Cortex-M33 LOCKUP (hardfault) output to TIM1/16/17 break input.
$00000002 constant SEC_SYSCFG_SYSCFG_CFGR2_SPL                      \ SRAM2 parity lock bit This bit is set by software and cleared only by a system reset. It can be used to enable and lock the SRAM2 parity error signal connection to TIM1/16/17 break inputs.
$00000004 constant SEC_SYSCFG_SYSCFG_CFGR2_PVDL                     \ PVD lock enable bit This bit is set by software and cleared only by a system reset. It can be used to enable and lock the PVD connection to TIM1/16/17 break input, as well as the PVDE and PVDLS[2:0] in the PWR register.
$00000008 constant SEC_SYSCFG_SYSCFG_CFGR2_ECCL                     \ ECC lock This bit is set by software and cleared only by a system reset. It can be used to enable and lock the Flash ECC double error signal connection to TIM1/16/17 break input.


\
\ @brief SYSCFG memory erase status register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SEC_SYSCFG_SYSCFG_MESR_MCLR                      \ Device memories erase status This bit is set by hardware when SRAM2, ICACHE, PKA SRAM erase is completed after power-on reset or tamper detection (refer to Section75: Tamper and backup registers (TAMP) for more details). This bit is not reset by system reset and is cleared by software by writing 1 to it.
$00010000 constant SEC_SYSCFG_SYSCFG_MESR_IPMEE                     \ ICACHE and PKA SRAM erase status This bit is set by hardware when ICACHE and PKA SRAM erase is completed after potential tamper detection (refer to Section75: Tamper and backup registers (TAMP) for more details). This bit is cleared by software by writing 1 to it.


\
\ @brief SYSCFG compensation cell control/status register
\ Address offset: 0x1C
\ Reset value: 0x00000002
\

$00000001 constant SEC_SYSCFG_SYSCFG_CCCSR_EN1                      \ VDD I/Os compensation cell enable This bit enables the compensation cell of the I/Os supplied by VsubDD/sub.
$00000002 constant SEC_SYSCFG_SYSCFG_CCCSR_CS1                      \ VDD I/Os code selection This bit selects the code to be applied for the compensation cell of the I/Os supplied by VsubDD/sub.
$00000100 constant SEC_SYSCFG_SYSCFG_CCCSR_RDY1                     \ VDD I/Os compensation cell ready flag This bit provides the compensation cell status of the I/Os supplied by VsubDD/sub. Note: The HSI16 clock is required for the compensation cell to work properly. The compensation cell ready bit (RDY1) is not set if the HSI16 clock is not enabled (HSION).


\
\ @brief SYSCFG compensation cell value register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant SEC_SYSCFG_SYSCFG_CCVR_NCV1                      \ NMOS compensation value of the I/Os supplied by VsubDD/sub This value is provided by the cell and can be used by the CPU to compute an I/Os compensation cell code for NMOS transistors. This code is applied to the I/Os compensation cell when the CS1 bit of the SYSCFG_CCCSR is reset.
$000000f0 constant SEC_SYSCFG_SYSCFG_CCVR_PCV1                      \ PMOS compensation value of the I/Os supplied by VsubDD/sub This value is provided by the cell and can be used by the CPU to compute an I/Os compensation cell code for PMOS transistors. This code is applied to the I/Os compensation cell when the CS1 bit of the SYSCFG_CCCSR is reset.


\
\ @brief SYSCFG compensation cell code register
\ Address offset: 0x24
\ Reset value: 0x00000078
\

$0000000f constant SEC_SYSCFG_SYSCFG_CCCR_NCC1                      \ NMOS compensation code of the I/Os supplied by VsubDD/sub These bits are written by software to define an I/Os compensation cell code for NMOS transistors. This code is applied to the I/Os compensation cell when the CS1 bit of the SYSCFG_CCCSR is set.
$000000f0 constant SEC_SYSCFG_SYSCFG_CCCR_PCC1                      \ PMOS compensation code of the I/Os supplied by VsubDD/sub These bits are written by software to define an I/Os compensation cell code for PMOS transistors. This code is applied to the I/Os compensation cell when the CS1 bit of the SYSCFG_CCCSR is set.


\
\ @brief SYSCFG RSS command register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_SYSCFG_SYSCFG_RSSCMDR_RSSCMD                 \ RSS commands This field defines a command to be executed by the RSS.


\
\ @brief System configuration controller
\
$56000400 constant SEC_SYSCFG_SYSCFG_SECCFGR  \ offset: 0x00 : SYSCFG secure configuration register
$56000404 constant SEC_SYSCFG_SYSCFG_CFGR1  \ offset: 0x04 : SYSCFG configuration register 1
$56000408 constant SEC_SYSCFG_SYSCFG_FPUIMR  \ offset: 0x08 : SYSCFG FPU interrupt mask register
$5600040c constant SEC_SYSCFG_SYSCFG_CNSLCKR  \ offset: 0x0C : SYSCFG CPU non-secure lock register
$56000410 constant SEC_SYSCFG_SYSCFG_CSLOCKR  \ offset: 0x10 : SYSCFG CPU secure lock register
$56000414 constant SEC_SYSCFG_SYSCFG_CFGR2  \ offset: 0x14 : SYSCFG configuration register 2
$56000418 constant SEC_SYSCFG_SYSCFG_MESR  \ offset: 0x18 : SYSCFG memory erase status register
$5600041c constant SEC_SYSCFG_SYSCFG_CCCSR  \ offset: 0x1C : SYSCFG compensation cell control/status register
$56000420 constant SEC_SYSCFG_SYSCFG_CCVR  \ offset: 0x20 : SYSCFG compensation cell value register
$56000424 constant SEC_SYSCFG_SYSCFG_CCCR  \ offset: 0x24 : SYSCFG compensation cell code register
$5600042c constant SEC_SYSCFG_SYSCFG_RSSCMDR  \ offset: 0x2C : SYSCFG RSS command register

