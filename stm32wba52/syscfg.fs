\
\ @file syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_DEF

  [ifdef] SYSCFG_SYSCFG_SECCFGR_DEF
    \
    \ @brief SYSCFG secure configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SYSCFGSEC               \ [0x00] SYSCFG clock control, memory erase status and compensation cell registers security
    $01 constant SYSCFG_CLASSBSEC               \ [0x01] Class B security
    $03 constant SYSCFG_FPUSEC                  \ [0x03] FPU security
  [then]


  [ifdef] SYSCFG_SYSCFG_CFGR1_DEF
    \
    \ @brief SYSCFG configuration register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $08 constant SYSCFG_BOOSTEN                 \ [0x08] I/O analog switch voltage booster enable Access can be protected by GTZC_TZSC ADC4SEC. Note: Refer to Table121 for setting.
    $09 constant SYSCFG_ANASWVDD                \ [0x09] GPIO analog switch control voltage selection Access can be protected by GTZC_TZSC ADC4SEC. Note: Refer to Table121 for setting.
    $10 constant SYSCFG_PA6_FMP                 \ [0x10] Fast-mode Plus drive capability activation on PA6 This bit can be read and written only with secure access if PA6 is secure in GPIOA. This bit enables the Fast-mode Plus drive mode for PA6 when PA6 is not used by I2C peripheral. This can be used to dive a LED for instance. Access can be protected by GPIOA SEC6.
    $11 constant SYSCFG_PA7_FMP                 \ [0x11] Fast-mode Plus drive capability activation on PA7 This bit can be read and written only with secure access if PA7 is secure in GPIOA. This bit enables the Fast-mode Plus drive mode for PA7 when PA7 is not used by I2C peripheral. This can be used to dive a LED for instance. Access can be protected by GPIOA SEC7.
    $12 constant SYSCFG_PA15_FMP                \ [0x12] Fast-mode Plus drive capability activation on PA15 This bit can be read and written only with secure access if PA15 is secure in GPIOA. This bit enables the Fast-mode Plus drive mode for PA15 when PA15 is not used by I2C peripheral. This can be used to dive a LED for instance. Access can be protected by GPIOA SEC15.
    $13 constant SYSCFG_PB3_FMP                 \ [0x13] Fast-mode Plus drive capability activation on PB3 This bit can be read and written only with secure access if PB3 is secure in GPIOB. This bit enables the Fast-mode Plus drive mode for PB3 when PB3 is not used by I2C peripheral. This can be used to dive a LED for instance. Access can be protected by GPIOB SEC3.
  [then]


  [ifdef] SYSCFG_SYSCFG_FPUIMR_DEF
    \
    \ @brief SYSCFG FPU interrupt mask register
    \ Address offset: 0x08
    \ Reset value: 0x0000003F
    \
    $00 constant SYSCFG_FPU_IE                  \ [0x00 : 6] Floating point unit interrupts enable bits FPU_IE[5]: Inexact interrupt enable (interrupt disable at reset) FPU_IE[4]: Input abnormal interrupt enable FPU_IE[3]: Overflow interrupt enable FPU_IE[2]: Underflow interrupt enable FPU_IE[1]: Divide-by-zero interrupt enable FPU_IE[0]: Invalid operation Interrupt enable
  [then]


  [ifdef] SYSCFG_SYSCFG_CNSLCKR_DEF
    \
    \ @brief SYSCFG CPU non-secure lock register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_LOCKNSVTOR              \ [0x00] VTOR_NS register lock This bit is set by software and cleared only by a system reset.
    $01 constant SYSCFG_LOCKNSMPU               \ [0x01] Non-secure MPU registers lock This bit is set by software and cleared only by a system reset. When set, this bit disables write access to non-secure MPU_CTRL_NS, MPU_RNR_NS and MPU_RBAR_NS registers.
  [then]


  [ifdef] SYSCFG_SYSCFG_CSLOCKR_DEF
    \
    \ @brief SYSCFG CPU secure lock register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_LOCKSVTAIRCR            \ [0x00] VTOR_S register and AIRCR register bits lock This bit is set by software and cleared only by a system reset. When set, it disables write access to VTOR_S register, PRIS and BFHFNMINS bits in the AIRCR register.
    $01 constant SYSCFG_LOCKSMPU                \ [0x01] Secure MPU registers lock This bit is set by software and cleared only by a system reset. When set, it disables write access to secure MPU_CTRL, MPU_RNR and MPU_RBAR registers.
    $02 constant SYSCFG_LOCKSAU                 \ [0x02] SAU registers lock This bit is set by software and cleared only by a system reset. When set, it disables write access to SAU_CTRL, SAU_RNR, SAU_RBAR and SAU_RLAR registers.
  [then]


  [ifdef] SYSCFG_SYSCFG_CFGR2_DEF
    \
    \ @brief SYSCFG configuration register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CLL                     \ [0x00] Cortex-M33 LOCKUP (hardfault) output enable This bit is set by software and cleared only by a system reset. It can be used to enable and lock the connection of Cortex-M33 LOCKUP (hardfault) output to TIM1/16/17 break input.
    $01 constant SYSCFG_SPL                     \ [0x01] SRAM2 parity lock bit This bit is set by software and cleared only by a system reset. It can be used to enable and lock the SRAM2 parity error signal connection to TIM1/16/17 break inputs.
    $02 constant SYSCFG_PVDL                    \ [0x02] PVD lock enable bit This bit is set by software and cleared only by a system reset. It can be used to enable and lock the PVD connection to TIM1/16/17 break input, as well as the PVDE and PVDLS[2:0] in the PWR register.
    $03 constant SYSCFG_ECCL                    \ [0x03] ECC lock This bit is set by software and cleared only by a system reset. It can be used to enable and lock the Flash ECC double error signal connection to TIM1/16/17 break input.
  [then]


  [ifdef] SYSCFG_SYSCFG_MESR_DEF
    \
    \ @brief SYSCFG memory erase status register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_MCLR                    \ [0x00] Device memories erase status This bit is set by hardware when SRAM2, ICACHE, PKA SRAM erase is completed after power-on reset or tamper detection (refer to Section75: Tamper and backup registers (TAMP) for more details). This bit is not reset by system reset and is cleared by software by writing 1 to it.
    $10 constant SYSCFG_IPMEE                   \ [0x10] ICACHE and PKA SRAM erase status This bit is set by hardware when ICACHE and PKA SRAM erase is completed after potential tamper detection (refer to Section75: Tamper and backup registers (TAMP) for more details). This bit is cleared by software by writing 1 to it.
  [then]


  [ifdef] SYSCFG_SYSCFG_CCCSR_DEF
    \
    \ @brief SYSCFG compensation cell control/status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000002
    \
    $00 constant SYSCFG_EN1                     \ [0x00] VDD I/Os compensation cell enable This bit enables the compensation cell of the I/Os supplied by VsubDD/sub.
    $01 constant SYSCFG_CS1                     \ [0x01] VDD I/Os code selection This bit selects the code to be applied for the compensation cell of the I/Os supplied by VsubDD/sub.
    $08 constant SYSCFG_RDY1                    \ [0x08] VDD I/Os compensation cell ready flag This bit provides the compensation cell status of the I/Os supplied by VsubDD/sub. Note: The HSI16 clock is required for the compensation cell to work properly. The compensation cell ready bit (RDY1) is not set if the HSI16 clock is not enabled (HSION).
  [then]


  [ifdef] SYSCFG_SYSCFG_CCVR_DEF
    \
    \ @brief SYSCFG compensation cell value register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_NCV1                    \ [0x00 : 4] NMOS compensation value of the I/Os supplied by VsubDD/sub This value is provided by the cell and can be used by the CPU to compute an I/Os compensation cell code for NMOS transistors. This code is applied to the I/Os compensation cell when the CS1 bit of the SYSCFG_CCCSR is reset.
    $04 constant SYSCFG_PCV1                    \ [0x04 : 4] PMOS compensation value of the I/Os supplied by VsubDD/sub This value is provided by the cell and can be used by the CPU to compute an I/Os compensation cell code for PMOS transistors. This code is applied to the I/Os compensation cell when the CS1 bit of the SYSCFG_CCCSR is reset.
  [then]


  [ifdef] SYSCFG_SYSCFG_CCCR_DEF
    \
    \ @brief SYSCFG compensation cell code register
    \ Address offset: 0x24
    \ Reset value: 0x00000078
    \
    $00 constant SYSCFG_NCC1                    \ [0x00 : 4] NMOS compensation code of the I/Os supplied by VsubDD/sub These bits are written by software to define an I/Os compensation cell code for NMOS transistors. This code is applied to the I/Os compensation cell when the CS1 bit of the SYSCFG_CCCSR is set.
    $04 constant SYSCFG_PCC1                    \ [0x04 : 4] PMOS compensation code of the I/Os supplied by VsubDD/sub These bits are written by software to define an I/Os compensation cell code for PMOS transistors. This code is applied to the I/Os compensation cell when the CS1 bit of the SYSCFG_CCCSR is set.
  [then]


  [ifdef] SYSCFG_SYSCFG_RSSCMDR_DEF
    \
    \ @brief SYSCFG RSS command register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RSSCMD                  \ [0x00 : 16] RSS commands This field defines a command to be executed by the RSS.
  [then]

  \
  \ @brief System configuration controller
  \
  $00 constant SYSCFG_SYSCFG_SECCFGR    \ SYSCFG secure configuration register
  $04 constant SYSCFG_SYSCFG_CFGR1      \ SYSCFG configuration register 1
  $08 constant SYSCFG_SYSCFG_FPUIMR     \ SYSCFG FPU interrupt mask register
  $0C constant SYSCFG_SYSCFG_CNSLCKR    \ SYSCFG CPU non-secure lock register
  $10 constant SYSCFG_SYSCFG_CSLOCKR    \ SYSCFG CPU secure lock register
  $14 constant SYSCFG_SYSCFG_CFGR2      \ SYSCFG configuration register 2
  $18 constant SYSCFG_SYSCFG_MESR       \ SYSCFG memory erase status register
  $1C constant SYSCFG_SYSCFG_CCCSR      \ SYSCFG compensation cell control/status register
  $20 constant SYSCFG_SYSCFG_CCVR       \ SYSCFG compensation cell value register
  $24 constant SYSCFG_SYSCFG_CCCR       \ SYSCFG compensation cell code register
  $2C constant SYSCFG_SYSCFG_RSSCMDR    \ SYSCFG RSS command register

: SYSCFG_DEF ; [then]
