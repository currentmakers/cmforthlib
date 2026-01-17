\
\ @file rcc.fs
\ @brief Reset and clock control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RCC_DEF

  [ifdef] RCC_RCC_CR_DEF
    \
    \ @brief HSI clock enable Set and cleared by software. Set by hardware to force the HSI to ON when the product leaves Stop mode, if STOPWUCK = 0 or STOPKERWUCK = 0. Set by hardware to force the HSI to ON when the product leaves Standby mode or in case of a failure of the HSE which is used as the system clock source. This bit cannot be cleared if the HSI is used directly (via SW mux) as system clock, or if the HSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
    \ Address offset: 0x00
    \ Reset value: 0x00000025
    \
    $00 constant RCC_HSION                      \ [0x00] HSI clock enable Set and cleared by software. Set by hardware to force the HSI to ON when the product leaves Stop mode, if STOPWUCK = 0 or STOPKERWUCK = 0. Set by hardware to force the HSI to ON when the product leaves Standby mode or in case of a failure of the HSE which is used as the system clock source. This bit cannot be cleared if the HSI is used directly (via SW mux) as system clock, or if the HSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
    $01 constant RCC_HSIKERON                   \ [0x01] HSI clock enable in Stop mode Set and reset by software to force the HSI to ON, even in Stop mode, in order to be quickly available as kernel clock for peripherals. This bit has no effect on the value of HSION.
    $02 constant RCC_HSIRDY                     \ [0x02] HSI clock ready flag Set by hardware to indicate that the HSI oscillator is stable.
    $03 constant RCC_HSIDIV                     \ [0x03 : 2] HSI clock divider Set and reset by software. These bits allow selecting a division ratio in order to configure the wanted HSI clock frequency. The HSIDIV cannot be changed if the HSI is selected as reference clock for at least one enabled PLL (PLLxON bit set to 1). In that case, the new HSIDIV value is ignored.
    $05 constant RCC_HSIDIVF                    \ [0x05] HSI divider flag Set and reset by hardware. As a write operation to HSIDIV has not an immediate effect on the frequency, this flag indicates the current status of the HSI divider. HSIDIVF goes immediately to 0 when HSIDIV value is changed, and is set back to 1 when the output frequency matches the value programmed into HSIDIV. clock setting is completed)
    $07 constant RCC_CSION                      \ [0x07] CSI clock enable Set and reset by software to enable/disable CSI clock for system and/or peripheral. Set by hardware to force the CSI to ON when the system leaves Stop mode, if STOPWUCK = 1 or STOPKERWUCK = 1. This bit cannot be cleared if the CSI is used directly (via SW mux) as system clock, or if the CSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
    $08 constant RCC_CSIRDY                     \ [0x08] CSI clock ready flag Set by hardware to indicate that the CSI oscillator is stable. This bit is activated only if the RC is enabled by CSION (it is not activated if the CSI is enabled by CSIKERON or by a peripheral request).
    $09 constant RCC_CSIKERON                   \ [0x09] CSI clock enable in Stop mode Set and reset by software to force the CSI to ON, even in Stop mode, in order to be quickly available as kernel clock for some peripherals. This bit has no effect on the value of CSION.
    $0c constant RCC_HSI48ON                    \ [0x0c] HSI48 clock enable Set by software and cleared by software or by the hardware when the system enters to Stop or Standby mode.
    $0d constant RCC_HSI48RDY                   \ [0x0d] HSI48 clock ready flag Set by hardware to indicate that the HSI48 oscillator is stable.
    $0e constant RCC_CPUCKRDY                   \ [0x0e] CPU related clocks ready flag Set by hardware to indicate that the CPU related clocks (CPU, APB3, AXI bus matrix and related memories) are available.
    $0f constant RCC_CDCKRDY                    \ [0x0f] CPU domain clocks ready flag Set by hardware to indicate that the following CPU domain clocks are available: APB1, APB2, AHB bus matrix.
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable Set and cleared by software. Cleared by hardware to stop the HSE when entering Stop or Standby mode. This bit cannot be cleared if the HSE is used directly (via SW mux) as system clock, or if the HSE is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable.
    $12 constant RCC_HSEBYP                     \ [0x12] HSE clock bypass Set and cleared by software to bypass the oscillator with an external clock. The external clock must be enabled with the HSEON bit to be used by the device. The HSEBYP bit can be written only if the HSE oscillator is disabled.
    $13 constant RCC_HSECSSON                   \ [0x13] HSE clock security system enable Set by software to enable clock security system on HSE. This bit is âset onlyâ (disabled by a system reset or when the system enters in Standby mode). When HSECSSON is set, the clock detector is enabled by hardware when the HSE is ready and disabled by hardware if an oscillator failure is detected.
    $14 constant RCC_HSEEXT                     \ [0x14] external high speed clock type in Bypass mode Set and reset by software to select the external clock type (analog or digital). The external clock must be enabled with the HSEON bit to be used by the device. The HSEEXT bit can be written only if the HSE oscillator is disabled.
    $18 constant RCC_PLL1ON                     \ [0x18] PLL1 enable Set and cleared by software to enable PLL1. Cleared by hardware when entering Stop or Standby mode. Note that the hardware prevents writing this bit to 0, if the PLL1 output is used as the system clock.
    $19 constant RCC_PLL1RDY                    \ [0x19] PLL1 clock ready flag Set by hardware to indicate that the PLL1 is locked.
    $1a constant RCC_PLL2ON                     \ [0x1a] PLL2 enable Set and cleared by software to enable PLL2. Cleared by hardware when entering Stop or Standby mode.
    $1b constant RCC_PLL2RDY                    \ [0x1b] PLL2 clock ready flag Set by hardware to indicate that the PLL2 is locked.
    $1c constant RCC_PLL3ON                     \ [0x1c] PLL3 enable Set and cleared by software to enable PLL3. Cleared by hardware when entering Stop or Standby mode.
    $1d constant RCC_PLL3RDY                    \ [0x1d] PLL3 clock ready flag Set by hardware to indicate that the PLL3 is locked.
  [then]


  [ifdef] RCC_RCC_HSICFGR_DEF
    \
    \ @brief RCC HSI calibration register
    \ Address offset: 0x04
    \ Reset value: 0x40000000
    \
    $00 constant RCC_HSICAL                     \ [0x00 : 12] HSI clock calibration Set by hardware by option byte loading during system reset nreset. Adjusted by software through trimming bits HSITRIM. This field represents the sum of engineering option byte calibration value and HSITRIM bits value.
    $18 constant RCC_HSITRIM                    \ [0x18 : 7] HSI clock trimming Set by software to adjust calibration. HSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_HSI_opt) in order to form the calibration trimming value. HSICALÂ =Â HSITRIMÂ +Â FLASH_HSI_opt. Note: The reset value of the field is 0x40.
  [then]


  [ifdef] RCC_RCC_CRRCR_DEF
    \
    \ @brief RCC clock recovery RC register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSI48CAL                   \ [0x00 : 10] Internal RC 48 MHz clock calibration Set by hardware by option byte loading during system reset nreset. Read-only.
  [then]


  [ifdef] RCC_RCC_CSICFGR_DEF
    \
    \ @brief RCC CSI calibration register
    \ Address offset: 0x0C
    \ Reset value: 0x20000000
    \
    $00 constant RCC_CSICAL                     \ [0x00 : 8] CSI clock calibration Set by hardware by option byte loading during system reset nreset. Adjusted by software through trimming bits CSITRIM. This field represents the sum of engineering option byte calibration value and CSITRIM bits value.
    $18 constant RCC_CSITRIM                    \ [0x18 : 6] CSI clock trimming Set by software to adjust calibration. CSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_CSI_opt) in order to form the calibration trimming value. CSICALÂ =Â CSITRIMÂ +Â FLASH_CSI_opt. Note: The reset value of the field is 0x20.
  [then]


  [ifdef] RCC_RCC_CFGR_DEF
    \
    \ @brief system clock and trace clock switch Set and reset by software to select system clock and trace clock sources (sys_ck and traceclk). Set by hardware in order to: force the selection of the HSI or CSI (depending on STOPWUCK selection) when leaving a system Stop mode force the selection of the HSI in case of failure of the HSE when used directly or indirectly as system clock others: reserved
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW                         \ [0x00 : 3] system clock and trace clock switch Set and reset by software to select system clock and trace clock sources (sys_ck and traceclk). Set by hardware in order to: force the selection of the HSI or CSI (depending on STOPWUCK selection) when leaving a system Stop mode force the selection of the HSI in case of failure of the HSE when used directly or indirectly as system clock others: reserved
    $03 constant RCC_SWS                        \ [0x03 : 3] system clock switch status Set and reset by hardware to indicate which clock source is used as system clock. others: reserved
    $06 constant RCC_STOPWUCK                   \ [0x06] system clock selection after a wake up from system Stop Set and reset by software to select the system wakeup clock from system Stop. The selected clock is also used as emergency clock for the clock security system (CSS) on HSE. See for details. STOPWUCK must not be modified when CSS is enabled (by HSECSSON bit) and the system clock is HSE (SWSÂ =Â 10) or a switch on HSE is requested (SWÂ =10).
    $07 constant RCC_STOPKERWUCK                \ [0x07] kernel clock selection after a wake up from system Stop Set and reset by software to select the kernel wakeup clock from system Stop. See for details.
    $08 constant RCC_RTCPRE                     \ [0x08 : 6] HSE division factor for RTC clock Set and cleared by software to divide the HSE to generate a clock for RTC. Caution: The software must set these bits correctly to ensure that the clock supplied to the RTC is lower than 1Â MHz. These bits must be configured if needed before selecting the RTC clock source. ...
    $0f constant RCC_TIMPRE                     \ [0x0f] timers clocks prescaler selection This bit is set and reset by software to control the clock frequency of all the timers connected to APB1 and APB2 domains. Refer to for more details.
    $12 constant RCC_MCO1PRE                    \ [0x12 : 4] MCO1 prescaler Set and cleared by software to configure the prescaler of the MCO1. Modification of this prescaler may generate glitches on MCO1. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. ...
    $16 constant RCC_MCO1SEL                    \ [0x16 : 3] Microcontroller clock output 1 Set and cleared by software. Clock source selection may generate glitches on MCO1. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved
    $19 constant RCC_MCO2PRE                    \ [0x19 : 4] MCO2 prescaler Set and cleared by software to configure the prescaler of the MCO2. Modification of this prescaler may generate glitches on MCO2. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. ...
    $1d constant RCC_MCO2SEL                    \ [0x1d : 3] microcontroller clock output 2 Set and cleared by software. Clock source selection may generate glitches on MCO2. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved
  [then]


  [ifdef] RCC_RCC_CDCFGR1_DEF
    \
    \ @brief CPU domain AHB prescaler Set and reset by software to control the division factor of rcc_hclk3 and rcc_aclk. Changing this division ratio has an impact on the frequency of all bus matrix clocks. 0xxx: rcc_hclk3 = sys_cdcpre_ck (default after reset) Note: The clocks are divided by the new prescaler factor from1 to 16 periods of the slowest APB clock among rcc_pclk[4:1] after HPRE update. Note: Note also that rcc_hclk3 = rcc_aclk.
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPRE                       \ [0x00 : 4] CPU domain AHB prescaler Set and reset by software to control the division factor of rcc_hclk3 and rcc_aclk. Changing this division ratio has an impact on the frequency of all bus matrix clocks. 0xxx: rcc_hclk3 = sys_cdcpre_ck (default after reset) Note: The clocks are divided by the new prescaler factor from1 to 16 periods of the slowest APB clock among rcc_pclk[4:1] after HPRE update. Note: Note also that rcc_hclk3 = rcc_aclk.
    $04 constant RCC_CDPPRE                     \ [0x04 : 3] CPU domain APB3 prescaler Set and reset by software to control the division factor of rcc_pclk3. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk3 after CDPPRE write. 0xx: rcc_pclk3 = rcc_hclk3 (default after reset)
    $08 constant RCC_CDCPRE                     \ [0x08 : 4] CPU domain core prescaler Set and reset by software to control the CPU domain CPU clock division factor. Changing this division ratio has an impact on the frequency of the CPU clock and all bus matrix clocks. After changing this prescaler value, it takes up to 16 periods of the slowest APB clock before the new division ratio is taken into account. The application can check if the new division factor is taken into account by reading back this register. 0xxx: sys_ck not divided (default after reset)
  [then]


  [ifdef] RCC_RCC_CDCFGR2_DEF
    \
    \ @brief CPU domain APB1 prescaler Set and reset by software to control the CPU domain APB1 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk1 after CDPPRE1 write. 0xx: rcc_pclk1 = rcc_hclk1 (default after reset)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $04 constant RCC_CDPPRE1                    \ [0x04 : 3] CPU domain APB1 prescaler Set and reset by software to control the CPU domain APB1 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk1 after CDPPRE1 write. 0xx: rcc_pclk1 = rcc_hclk1 (default after reset)
    $08 constant RCC_CDPPRE2                    \ [0x08 : 3] CPU domain APB2 prescaler Set and reset by software to control the CPU domain APB2 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk1 after CDPPRE2 write. 0xx: rcc_pclk2 = rcc_hclk1 (default after reset)
  [then]


  [ifdef] RCC_RCC_SRDCFGR_DEF
    \
    \ @brief SmartRun domain APB4 prescaler Set and reset by software to control the SmartRun domain APB4 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk4 after SRDPPRE write. 0xx: rcc_pclk4 = rcc_hclk4 (default after reset)
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $04 constant RCC_SRDPPRE                    \ [0x04 : 3] SmartRun domain APB4 prescaler Set and reset by software to control the SmartRun domain APB4 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk4 after SRDPPRE write. 0xx: rcc_pclk4 = rcc_hclk4 (default after reset)
  [then]


  [ifdef] RCC_RCC_PLLCKSELR_DEF
    \
    \ @brief DIVMx and PLLs clock source selection Set and reset by software to select the PLL clock source. These bits can be written only when all PLLs are disabled. In order to save power, when no PLL is used, the value of PLLSRC must be set to '11â.
    \ Address offset: 0x28
    \ Reset value: 0x02020200
    \
    $00 constant RCC_PLLSRC                     \ [0x00 : 2] DIVMx and PLLs clock source selection Set and reset by software to select the PLL clock source. These bits can be written only when all PLLs are disabled. In order to save power, when no PLL is used, the value of PLLSRC must be set to '11â.
    $04 constant RCC_DIVM1                      \ [0x04 : 6] prescaler for PLL1 Set and cleared by software to configure the prescaler of the PLL1. The hardware does not allow any modification of this prescaler when PLL1 is enabled (PLL1ONÂ =Â 1). In order to save power when PLL1 is not used, the value of DIVM1 must be set to 0. ... ...
    $0c constant RCC_DIVM2                      \ [0x0c : 6] prescaler for PLL2 Set and cleared by software to configure the prescaler of the PLL2. The hardware does not allow any modification of this prescaler when PLL2 is enabled (PLL2ONÂ =Â 1). In order to save power when PLL2 is not used, the value of DIVM2 must be set to 0. ... ...
    $14 constant RCC_DIVM3                      \ [0x14 : 6] prescaler for PLL3 Set and cleared by software to configure the prescaler of the PLL3. The hardware does not allow any modification of this prescaler when PLL3 is enabled (PLL3ONÂ =Â 1). In order to save power when PLL3 is not used, the value of DIVM3 must be set to 0. ... ...
  [then]


  [ifdef] RCC_RCC_PLLCFGR_DEF
    \
    \ @brief PLL1 fractional latch enable Set and reset by software to latch the content of FRACN1 into the sigma-delta modulator. In order to latch the FRACN1 value into the sigma-delta modulator, PLL1FRACEN must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN1 into the modulator. Refer to for additional information.
    \ Address offset: 0x2C
    \ Reset value: 0x01FF0000
    \
    $00 constant RCC_PLL1FRACEN                 \ [0x00] PLL1 fractional latch enable Set and reset by software to latch the content of FRACN1 into the sigma-delta modulator. In order to latch the FRACN1 value into the sigma-delta modulator, PLL1FRACEN must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN1 into the modulator. Refer to for additional information.
    $01 constant RCC_PLL1VCOSEL                 \ [0x01] PLL1 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL1. These bits must be written before enabling the PLL1.
    $02 constant RCC_PLL1RGE                    \ [0x02 : 2] PLL1 input frequency range Set and reset by software to select the proper reference frequency range used for PLL1. This bit must be written before enabling the PLL1.
    $04 constant RCC_PLL2FRACEN                 \ [0x04] PLL2 fractional latch enable Set and reset by software to latch the content of FRACN2 into the sigma-delta modulator. In order to latch the FRACN2 value into the sigma-delta modulator, PLL2FRACEN must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN2 into the modulator. Refer to for additional information.
    $05 constant RCC_PLL2VCOSEL                 \ [0x05] PLL2 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL2. This bit must be written before enabling the PLL2.
    $06 constant RCC_PLL2RGE                    \ [0x06 : 2] PLL2 input frequency range Set and reset by software to select the proper reference frequency range used for PLL2. These bits must be written before enabling the PLL2.
    $08 constant RCC_PLL3FRACEN                 \ [0x08] PLL3 fractional latch enable Set and reset by software to latch the content of FRACN3 into the sigma-delta modulator. In order to latch the FRACN3 value into the sigma-delta modulator, PLL3FRACEN must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN3 into the modulator. Refer to for additional information.
    $09 constant RCC_PLL3VCOSEL                 \ [0x09] PLL3 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL3. This bit must be written before enabling the PLL3.
    $0a constant RCC_PLL3RGE                    \ [0x0a : 2] PLL3 input frequency range Set and reset by software to select the proper reference frequency range used for PLL3. These bits must be written before enabling the PLL3.
    $10 constant RCC_DIVP1EN                    \ [0x10] PLL1 DIVP divider output enable Set and reset by software to enable the pll1_p_ck output of the PLL1. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). In order to save power, when the pll1_p_ck output of the PLL1 is not used, the pll1_p_ck must be disabled.
    $11 constant RCC_DIVQ1EN                    \ [0x11] PLL1 DIVQ divider output enable Set and reset by software to enable the pll1_q_ck output of the PLL1. In order to save power, when the pll1_q_ck output of the PLL1 is not used, the pll1_q_ck must be disabled. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).
    $12 constant RCC_DIVR1EN                    \ [0x12] PLL1 DIVR divider output enable Set and reset by software to enable the pll1_r_ck output of the PLL1. To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).
    $13 constant RCC_DIVP2EN                    \ [0x13] PLL2 DIVP divider output enable Set and reset by software to enable the pll2_p_ck output of the PLL2. This bit can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used.
    $14 constant RCC_DIVQ2EN                    \ [0x14] PLL2 DIVQ divider output enable Set and reset by software to enable the pll2_q_ck output of the PLL2. To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used. This bit can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0).
    $15 constant RCC_DIVR2EN                    \ [0x15] PLL2 DIVR divider output enable Set and reset by software to enable the pll2_r_ck output of the PLL2. To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used. This bit can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0).
    $16 constant RCC_DIVP3EN                    \ [0x16] PLL3 DIVP divider output enable Set and reset by software to enable the pll3_p_ck output of the PLL3. This bit can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0). To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used.
    $17 constant RCC_DIVQ3EN                    \ [0x17] PLL3 DIVQ divider output enable Set and reset by software to enable the pll3_q_ck output of the PLL3. To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used. This bit can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0).
    $18 constant RCC_DIVR3EN                    \ [0x18] PLL3 DIVR divider output enable Set and reset by software to enable the pll3_r_ck output of the PLL3. To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used. This bit can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0).
  [then]


  [ifdef] RCC_RCC_PLL1DIVR_DEF
    \
    \ @brief multiplication factor for PLL1 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL1ON = PLL1RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL1VCOSEL = 0 150 to 420Â MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x DIVN1, when fractional value 0 has been loaded into FRACN1, with: DIVN1 between 8 and 420 The input frequency Fref1_ck must be between 1 and 16Â MHz.
    \ Address offset: 0x30
    \ Reset value: 0x01010280
    \
    $00 constant RCC_DIVN1                      \ [0x00 : 9] multiplication factor for PLL1 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL1ON = PLL1RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL1VCOSEL = 0 150 to 420Â MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x DIVN1, when fractional value 0 has been loaded into FRACN1, with: DIVN1 between 8 and 420 The input frequency Fref1_ck must be between 1 and 16Â MHz.
    $09 constant RCC_DIVP1                      \ [0x09 : 7] PLL1 DIVP division factor Set and reset by software to control the frequency of the pll1_p_ck clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). Note that odd division factors are not allowed. ...
    $10 constant RCC_DIVQ1                      \ [0x10 : 7] PLL1 DIVQ division factor Set and reset by software to control the frequency of the pll1_q_ck clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
    $18 constant RCC_DIVR1                      \ [0x18 : 7] PLL1 DIVR division factor Set and reset by software to control the frequency of the pll1_r_ck clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
  [then]


  [ifdef] RCC_RCC_PLL1FRACR_DEF
    \
    \ @brief fractional part of the multiplication factor for PLL1 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL1VCOSEL = 0 150 to 420Â MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x (DIVN1 + (FRACN1 / 213)), with DIVN1 between 8 and 420 FRACN1 can be between 0 and 213- 1 The input frequency Fref1_ck must be between 1 and 16 MHz. To change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into FRACN1. Set the bit PLL1FRACEN to 1.
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACN1                     \ [0x03 : 13] fractional part of the multiplication factor for PLL1 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL1VCOSEL = 0 150 to 420Â MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x (DIVN1 + (FRACN1 / 213)), with DIVN1 between 8 and 420 FRACN1 can be between 0 and 213- 1 The input frequency Fref1_ck must be between 1 and 16 MHz. To change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into FRACN1. Set the bit PLL1FRACEN to 1.
  [then]


  [ifdef] RCC_RCC_PLL2DIVR_DEF
    \
    \ @brief multiplication factor for PLL2 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL2ON = PLL2RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL2VCOSEL = 0 150 to 420Â MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x DIVN2, when fractional value 0 has been loaded into FRACN2, with DIVN2 between 8 and 420 The input frequency Fref2_ck must be between 1 and 16MHz.
    \ Address offset: 0x38
    \ Reset value: 0x01010280
    \
    $00 constant RCC_DIVN2                      \ [0x00 : 9] multiplication factor for PLL2 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL2ON = PLL2RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL2VCOSEL = 0 150 to 420Â MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x DIVN2, when fractional value 0 has been loaded into FRACN2, with DIVN2 between 8 and 420 The input frequency Fref2_ck must be between 1 and 16MHz.
    $09 constant RCC_DIVP2                      \ [0x09 : 7] PLL2 DIVP division factor Set and reset by software to control the frequency of the pll2_p_ck clock. These bits can be written only when the PLL2 is disabled (PLL2ON = PLL2RDY = 0). ...
    $10 constant RCC_DIVQ2                      \ [0x10 : 7] PLL2 DIVQ division factor Set and reset by software to control the frequency of the pll2_q_ck clock. These bits can be written only when the PLL2 is disabled (PLL2ON = PLL2RDY = 0). ...
    $18 constant RCC_DIVR2                      \ [0x18 : 7] PLL2 DIVR division factor Set and reset by software to control the frequency of the pll2_r_ck clock. These bits can be written only when the PLL2 is disabled (PLL2ON = PLL2RDY = 0). ...
  [then]


  [ifdef] RCC_RCC_PLL2FRACR_DEF
    \
    \ @brief fractional part of the multiplication factor for PLL2 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL2VCOSEL = 0 150 to 420Â MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x (DIVN2 + (FRACN2 / 213)), with DIVN2 between 8 and 420 FRACN2 can be between 0 and 213 - 1 The input frequency Fref2_ck must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL2FRACEN to 0. Write the new fractional value into FRACN2. Set the bit PLL2FRACEN to 1.
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACN2                     \ [0x03 : 13] fractional part of the multiplication factor for PLL2 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL2VCOSEL = 0 150 to 420Â MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x (DIVN2 + (FRACN2 / 213)), with DIVN2 between 8 and 420 FRACN2 can be between 0 and 213 - 1 The input frequency Fref2_ck must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL2FRACEN to 0. Write the new fractional value into FRACN2. Set the bit PLL2FRACEN to 1.
  [then]


  [ifdef] RCC_RCC_PLL3DIVR_DEF
    \
    \ @brief Multiplication factor for PLL3 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL3ON = PLL3RDY = 0). ...........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL3VCOSEL = 0 150 to 420Â MHz if PLL3VCOSEL = 1 VCO output frequency = Fref3_ck x DIVN3, when fractional value 0 has been loaded into FRACN3, with: DIVN3 between 8 and 420 The input frequency Fref3_ck must be between 1 and 16MHz
    \ Address offset: 0x40
    \ Reset value: 0x01010280
    \
    $00 constant RCC_DIVN3                      \ [0x00 : 9] Multiplication factor for PLL3 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL3ON = PLL3RDY = 0). ...........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL3VCOSEL = 0 150 to 420Â MHz if PLL3VCOSEL = 1 VCO output frequency = Fref3_ck x DIVN3, when fractional value 0 has been loaded into FRACN3, with: DIVN3 between 8 and 420 The input frequency Fref3_ck must be between 1 and 16MHz
    $09 constant RCC_DIVP3                      \ [0x09 : 7] PLL3 DIVP division factor Set and reset by software to control the frequency of the pll3_p_ck clock. These bits can be written only when the PLL3 is disabled (PLL3ON = PLL3RDY = 0). ...
    $10 constant RCC_DIVQ3                      \ [0x10 : 7] PLL3 DIVQ division factor Set and reset by software to control the frequency of the pll3_q_ck clock. These bits can be written only when the PLL3 is disabled (PLL3ON = PLL3RDY = 0). ...
    $18 constant RCC_DIVR3                      \ [0x18 : 7] PLL3 DIVR division factor Set and reset by software to control the frequency of the pll3_r_ck clock. These bits can be written only when the PLL3 is disabled (PLL3ON = PLL3RDY = 0). ...
  [then]


  [ifdef] RCC_RCC_PLL3FRACR_DEF
    \
    \ @brief fractional part of the multiplication factor for PLL3 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL3 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL3VCOSEL = 0 150 to 420Â MHz if PLL3VCOSEL = 1 VCO output frequency = Fref3_ck x (DIVN3 + (FRACN3 / 213)), with DIVN3 between 8 and 420 FRACN3 can be between 0 and 213 - 1 The input frequency Fref3_ck must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into FRACN1. Set the bit PLL1FRACEN to 1.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACN3                     \ [0x03 : 13] fractional part of the multiplication factor for PLL3 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL3 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL3VCOSEL = 0 150 to 420Â MHz if PLL3VCOSEL = 1 VCO output frequency = Fref3_ck x (DIVN3 + (FRACN3 / 213)), with DIVN3 between 8 and 420 FRACN3 can be between 0 and 213 - 1 The input frequency Fref3_ck must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into FRACN1. Set the bit PLL1FRACEN to 1.
  [then]


  [ifdef] RCC_RCC_CDCCIPR_DEF
    \
    \ @brief RCC CPU domain kernel clock configuration register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FMCSEL                     \ [0x00 : 2] FMC kernel clock source selection
    $04 constant RCC_OCTOSPISEL                 \ [0x04 : 2] OCTOSPI kernel clock source selection
    $10 constant RCC_SDMMCSEL                   \ [0x10] SDMMC kernel clock source selection
    $1c constant RCC_CKPERSEL                   \ [0x1c : 2] per_ck clock source selection
  [then]


  [ifdef] RCC_RCC_CDCCIP1R_DEF
    \
    \ @brief RCC CPU domain kernel clock configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SAI1SEL                    \ [0x00 : 3] SAI1 and DFSDM1 kernel Aclk clock source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it isnot be possible to switch to another clock. Refer to for additional information. Note: DFSDM1 clock source selection is done by DFSDM1SEL. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin.
    $06 constant RCC_SAI2ASEL                   \ [0x06 : 3] SAI2 kernel clock source A selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not be possible to switch to another clock. Refer to for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin. spdifrx_symb_ck is the symbol clock generated by the SPDIFRX (see ).
    $09 constant RCC_SAI2BSEL                   \ [0x09 : 3] SAI2 kernel clock B source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not be possible to switch to another clock. Refer to for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin. spdifrx_symb_ck is the symbol clock generated by the spdifrx (see ).
    $0c constant RCC_SPI123SEL                  \ [0x0c : 3] SPI/I2S1,2 and 3 kernel clock source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not be possible to switch to another clock. Refer to for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin.
    $10 constant RCC_SPI45SEL                   \ [0x10 : 3] SPI4 and 5 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $14 constant RCC_SPDIFRXSEL                 \ [0x14 : 2] SPDIFRX kernel clock source selection
    $18 constant RCC_DFSDM1SEL                  \ [0x18] DFSDM1 kernel clock Clk source selection Set and reset by software. Note: the DFSDM1 Aclk clock source selection is done by SAI1SEL (see ).
    $1c constant RCC_FDCANSEL                   \ [0x1c : 2] FDCAN kernel clock source selection Set and reset by software.
    $1f constant RCC_SWPMISEL                   \ [0x1f] SWPMI kernel clock source selection Set and reset by software.
  [then]


  [ifdef] RCC_RCC_CDCCIP2R_DEF
    \
    \ @brief RCC CPU domain kernel clock configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART234578SEL             \ [0x00 : 3] USART2/3, UART4,5, 7 and 8 (APB1) kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $03 constant RCC_USART16910SEL              \ [0x03 : 3] USART1, 6, 9 and 10 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $08 constant RCC_RNGSEL                     \ [0x08 : 2] RNG kernel clock source selection Set and reset by software.
    $0c constant RCC_I2C123SEL                  \ [0x0c : 2] I2C1,2,3 kernel clock source selection Set and reset by software.
    $14 constant RCC_USBSEL                     \ [0x14 : 2] USBOTG 1 and 2 kernel clock source selection Set and reset by software.
    $16 constant RCC_CECSEL                     \ [0x16 : 2] HDMI-CEC kernel clock source selection Set and reset by software.
    $1c constant RCC_LPTIM1SEL                  \ [0x1c : 3] LPTIM1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_SRDCCIPR_DEF
    \
    \ @brief RCC SmartRun domain kernel clock configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPUART1SEL                 \ [0x00 : 3] LPUART1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $08 constant RCC_I2C4SEL                    \ [0x08 : 2] I2C4 kernel clock source selection Set and reset by software.
    $0a constant RCC_LPTIM2SEL                  \ [0x0a : 3] LPTIM2 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $0d constant RCC_LPTIM3SEL                  \ [0x0d : 3] LPTIM3 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $10 constant RCC_ADCSEL                     \ [0x10 : 2] SAR ADC kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $1b constant RCC_DFSDM2SEL                  \ [0x1b] DFSDM2 kernel Clk clock source selection Set and reset by software. Note: The DFSDM2 Aclk clock source selection is done by SPI6SEL (see and ).
    $1c constant RCC_SPI6SEL                    \ [0x1c : 3] SPI6 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_CIER_DEF
    \
    \ @brief LSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the LSI oscillator stabilization.
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the LSI oscillator stabilization.
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready interrupt enable Set and reset by software to enable/disable interrupt caused by the LSE oscillator stabilization.
    $02 constant RCC_HSIRDYIE                   \ [0x02] HSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the HSI oscillator stabilization.
    $03 constant RCC_HSERDYIE                   \ [0x03] HSE ready interrupt enable Set and reset by software to enable/disable interrupt caused by the HSE oscillator stabilization.
    $04 constant RCC_CSIRDYIE                   \ [0x04] CSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the CSI oscillator stabilization.
    $05 constant RCC_HSI48RDYIE                 \ [0x05] HSI48 ready interrupt enable Set and reset by software to enable/disable interrupt caused by the HSI48 oscillator stabilization.
    $06 constant RCC_PLL1RDYIE                  \ [0x06] PLL1 ready interrupt enable Set and reset by software to enable/disable interrupt caused by PLL1 lock.
    $07 constant RCC_PLL2RDYIE                  \ [0x07] PLL2 ready interrupt enable Set and reset by software to enable/disable interrupt caused by PLL2 lock.
    $08 constant RCC_PLL3RDYIE                  \ [0x08] PLL3 ready interrupt enable Set and reset by software to enable/disable interrupt caused by PLL3 lock.
    $09 constant RCC_LSECSSIE                   \ [0x09] LSE clock security system interrupt enable Set and reset by software to enable/disable interrupt caused by the clock security system (CSS) on external 32 kHz oscillator.
  [then]


  [ifdef] RCC_RCC_CIFR_DEF
    \
    \ @brief LSI ready interrupt flag Reset by software by writing LSIRDYC bit. Set by hardware when the LSI clock becomes stable and LSIRDYIE is set.
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready interrupt flag Reset by software by writing LSIRDYC bit. Set by hardware when the LSI clock becomes stable and LSIRDYIE is set.
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag Reset by software by writing LSERDYC bit. Set by hardware when the LSE clock becomes stable and LSERDYIE is set.
    $02 constant RCC_HSIRDYF                    \ [0x02] HSI ready interrupt flag Reset by software by writing HSIRDYC bit. Set by hardware when the HSI clock becomes stable and HSIRDYIE is set.
    $03 constant RCC_HSERDYF                    \ [0x03] HSE ready interrupt flag Reset by software by writing HSERDYC bit. Set by hardware when the HSE clock becomes stable and HSERDYIE is set.
    $04 constant RCC_CSIRDYF                    \ [0x04] CSI ready interrupt flag Reset by software by writing CSIRDYC bit. Set by hardware when the CSI clock becomes stable and CSIRDYIE is set.
    $05 constant RCC_HSI48RDYF                  \ [0x05] HSI48 ready interrupt flag Reset by software by writing HSI48RDYC bit. Set by hardware when the HSI48 clock becomes stable and HSI48RDYIE is set.
    $06 constant RCC_PLL1RDYF                   \ [0x06] PLL1 ready interrupt flag Reset by software by writing PLL1RDYC bit. Set by hardware when the PLL1 locks and PLL1RDYIE is set.
    $07 constant RCC_PLL2RDYF                   \ [0x07] PLL2 ready interrupt flag Reset by software by writing PLL2RDYC bit. Set by hardware when the PLL2 locks and PLL2RDYIE is set.
    $08 constant RCC_PLL3RDYF                   \ [0x08] PLL3 ready interrupt flag Reset by software by writing PLL3RDYC bit. Set by hardware when the PLL3 locks and PLL3RDYIE is set.
    $09 constant RCC_LSECSSF                    \ [0x09] LSE clock security system interrupt flag Reset by software by writing LSECSSC bit. Set by hardware when a failure is detected on the external 32 kHz oscillator and LSECSSIE is set.
    $0a constant RCC_HSECSSF                    \ [0x0a] HSE clock security system interrupt flag Reset by software by writing HSECSSC bit. Set by hardware in case of HSE clock failure.
  [then]


  [ifdef] RCC_RCC_CICR_DEF
    \
    \ @brief LSI ready interrupt clear Set by software to clear LSIRDYF. Reset by hardware when clear done.
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYC                    \ [0x00] LSI ready interrupt clear Set by software to clear LSIRDYF. Reset by hardware when clear done.
    $01 constant RCC_LSERDYC                    \ [0x01] LSE ready interrupt clear Set by software to clear LSERDYF. Reset by hardware when clear done.
    $02 constant RCC_HSIRDYC                    \ [0x02] HSI ready interrupt clear Set by software to clear HSIRDYF. Reset by hardware when clear done.
    $03 constant RCC_HSERDYC                    \ [0x03] HSE ready interrupt clear Set by software to clear HSERDYF. Reset by hardware when clear done.
    $04 constant RCC_CSIRDYC                    \ [0x04] CSI ready interrupt clear Set by software to clear CSIRDYF. Reset by hardware when clear done.
    $05 constant RCC_HSI48RDYC                  \ [0x05] HSI48 ready interrupt clear Set by software to clear HSI48RDYF. Reset by hardware when clear done.
    $06 constant RCC_PLL1RDYC                   \ [0x06] PLL1 ready interrupt clear Set by software to clear PLL1RDYF. Reset by hardware when clear done.
    $07 constant RCC_PLL2RDYC                   \ [0x07] PLL2 ready interrupt clear Set by software to clear PLL2RDYF. Reset by hardware when clear done.
    $08 constant RCC_PLL3RDYC                   \ [0x08] PLL3 ready interrupt clear Set by software to clear PLL3RDYF. Reset by hardware when clear done.
    $09 constant RCC_LSECSSC                    \ [0x09] LSE clock security system interrupt clear Set by software to clear LSECSSF. Reset by hardware when clear done.
    $0a constant RCC_HSECSSC                    \ [0x0a] HSE clock security system interrupt clear Set by software to clear HSECSSF. Reset by hardware when clear done.
  [then]


  [ifdef] RCC_RCC_BDCR_DEF
    \
    \ @brief RCC Backup domain control register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enabled Set and reset by software.
    $01 constant RCC_LSERDY                     \ [0x01] LSE oscillator ready Set and reset by hardware to indicate when the LSE is stable. This bit needs 6 cycles of lse_ck clock to fall down after LSEON has been set to 0.
    $02 constant RCC_LSEBYP                     \ [0x02] LSE oscillator bypass Set and reset by software to bypass oscillator in debug mode. This bit must not be written when the LSE is enabled (by LSEON) or ready (LSERDY = 1)
    $03 constant RCC_LSEDRV                     \ [0x03 : 2] LSE oscillator driving capability Set by software to select the driving capability of the LSE oscillator.
    $05 constant RCC_LSECSSON                   \ [0x05] LSE clock security system enable Set by software to enable the clock security system on 32 kHz oscillator. LSECSSON must be enabled after LSE is enabled (LSEON enabled) and ready (LSERDY set by hardware) and after RTCSEL is selected. Once enabled, this bit cannot be disabled, except after a LSE failure detection (LSECSSD = 1). In that case the software must disable LSECSSON.
    $06 constant RCC_LSECSSD                    \ [0x06] LSE clock security system failure detection Set by hardware to indicate when a failure has been detected by the clock security system on the external 32 kHz oscillator.
    $07 constant RCC_LSEEXT                     \ [0x07] low-speed external clock type in Bypass mode Set and reset by software to select the external clock type (analog or digital). The external clock must be enabled with the LSEON bit, to be used by the device. The LSEEXT bit can be written only if the LSE oscillator is disabled.
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC clock source selection Set by software to select the clock source for the RTC. These bits can be written only one time (except in case of failure detection on LSE). These bits must be written before LSECSSON is enabled. The VSWRST bit can be used to reset them, then it can be written one time again. If HSE is selected as RTC clock, this clock is lost when the system is in Stop mode or in case of a pin reset (NRST).
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable Set and reset by software.
    $10 constant RCC_VSWRST                     \ [0x10] VSwitch domain software reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_CSR_DEF
    \
    \ @brief RCC clock control and status register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSION                      \ [0x00] LSI oscillator enable Set and reset by software.
    $01 constant RCC_LSIRDY                     \ [0x01] LSI oscillator ready Set and reset by hardware to indicate when the low-speed internal RC oscillator is stable. This bit needs 3 cycles of lsi_ck clock to fall down after LSION has been set to 0. This bit can be set even when LSION is not enabled if there is a request for LSI clock by the clock security system on LSE or by the low-speed watchdog or by the RTC.
  [then]


  [ifdef] RCC_RCC_AHB3RSTR_DEF
    \
    \ @brief MDMA block reset Set and reset by software.
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMARST                    \ [0x00] MDMA block reset Set and reset by software.
    $04 constant RCC_DMA2DRST                   \ [0x04] DMA2D block reset Set and reset by software.
    $05 constant RCC_JPGDECRST                  \ [0x05] JPGDEC block reset Set and reset by software.
    $0c constant RCC_FMCRST                     \ [0x0c] FMC block reset Set and reset by software.
    $0e constant RCC_OCTOSPI1RST                \ [0x0e] OCTOSPI1 and OCTOSPI1 delay blocks reset Set and reset by software.
    $10 constant RCC_SDMMC1RST                  \ [0x10] SDMMC1 and SDMMC1 delay blocks reset Set and reset by software.
    $13 constant RCC_OCTOSPI2RST                \ [0x13] OCTOSPI2 and OCTOSPI2 delay block reset Set and reset by software
    $15 constant RCC_OCTOSPIMRST                \ [0x15] OCTOSPIM reset Set and reset by software
    $16 constant RCC_OTFD1RST                   \ [0x16] OTFD1 reset Set and reset by software Take care that resetting the OTFD means loosing the decryption key loaded during secure boot.
    $17 constant RCC_OTFD2RST                   \ [0x17] OTFD2 reset Set and reset by software Take care that resetting the OTFD means loosing the decryption key loaded during secure boot.
    $18 constant RCC_GFXMMURST                  \ [0x18] GFXMMU reset Set and reset by software
  [then]


  [ifdef] RCC_RCC_AHB1RSTR_DEF
    \
    \ @brief DMA1 and DMAMUX1 blocks reset Set and reset by software.
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1RST                    \ [0x00] DMA1 and DMAMUX1 blocks reset Set and reset by software.
    $01 constant RCC_DMA2RST                    \ [0x01] DMA2 and DMAMUX2 blocks reset Set and reset by software.
    $05 constant RCC_ADC12RST                   \ [0x05] ADC1 and 2 blocks reset Set and reset by software.
    $09 constant RCC_CRCRST                     \ [0x09] CRC block reset Set and reset by software.
    $19 constant RCC_USB1OTGRST                 \ [0x19] USB1OTG block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB2RSTR_DEF
    \
    \ @brief digital camera interface block reset (DCMI or PSSI depending which IP is active) Set and reset by software.
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DCMI_PSSIRST               \ [0x00] digital camera interface block reset (DCMI or PSSI depending which IP is active) Set and reset by software.
    $02 constant RCC_HSEMRST                    \ [0x02] HSEM block reset Set and reset by software.
    $04 constant RCC_CRYPTRST                   \ [0x04] cryptography block reset Set and reset by software.
    $05 constant RCC_HASHRST                    \ [0x05] hash block reset Set and reset by software.
    $06 constant RCC_RNGRST                     \ [0x06] random number generator block reset Set and reset by software.
    $09 constant RCC_SDMMC2RST                  \ [0x09] SDMMC2 and SDMMC2 delay blocks reset Set and reset by software.
    $0b constant RCC_BDMA1RST                   \ [0x0b] BDMA1 reset (DFSDM dedicated DMA) Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB4RSTR_DEF
    \
    \ @brief GPIOA block reset Set and reset by software.
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] GPIOA block reset Set and reset by software.
    $01 constant RCC_GPIOBRST                   \ [0x01] GPIOB block reset Set and reset by software.
    $02 constant RCC_GPIOCRST                   \ [0x02] GPIOC block reset Set and reset by software.
    $03 constant RCC_GPIODRST                   \ [0x03] GPIOD block reset Set and reset by software.
    $04 constant RCC_GPIOERST                   \ [0x04] GPIOE block reset Set and reset by software.
    $05 constant RCC_GPIOFRST                   \ [0x05] GPIOF block reset Set and reset by software.
    $06 constant RCC_GPIOGRST                   \ [0x06] GPIOG block reset Set and reset by software.
    $07 constant RCC_GPIOHRST                   \ [0x07] GPIOH block reset Set and reset by software.
    $08 constant RCC_GPIOIRST                   \ [0x08] GPIOI block reset Set and reset by software.
    $09 constant RCC_GPIOJRST                   \ [0x09] GPIOJ block reset Set and reset by software.
    $0a constant RCC_GPIOKRST                   \ [0x0a] GPIOK block reset Set and reset by software.
    $15 constant RCC_BDMA2RST                   \ [0x15] SmartRun domain DMA and DMAMUX blocks reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB3RSTR_DEF
    \
    \ @brief LTDC block reset Set and reset by software.
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $03 constant RCC_LTDCRST                    \ [0x03] LTDC block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1LRSTR_DEF
    \
    \ @brief TIM2 block reset Set and reset by software.
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 block reset Set and reset by software.
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 block reset Set and reset by software.
    $02 constant RCC_TIM4RST                    \ [0x02] TIM4 block reset Set and reset by software.
    $03 constant RCC_TIM5RST                    \ [0x03] TIM5 block reset Set and reset by software.
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6 block reset Set and reset by software.
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7 block reset Set and reset by software.
    $06 constant RCC_TIM12RST                   \ [0x06] TIM12 block reset Set and reset by software.
    $07 constant RCC_TIM13RST                   \ [0x07] TIM13 block reset Set and reset by software.
    $08 constant RCC_TIM14RST                   \ [0x08] TIM14 block reset Set and reset by software.
    $09 constant RCC_LPTIM1RST                  \ [0x09] LPTIM1 block reset Set and reset by software.
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 block reset Set and reset by software.
    $0f constant RCC_SPI3RST                    \ [0x0f] SPI3 block reset Set and reset by software.
    $10 constant RCC_SPDIFRXRST                 \ [0x10] SPDIFRX block reset Set and reset by software.
    $11 constant RCC_USART2RST                  \ [0x11] USART2 block reset Set and reset by software.
    $12 constant RCC_USART3RST                  \ [0x12] USART3 block reset Set and reset by software.
    $13 constant RCC_UART4RST                   \ [0x13] UART4 block reset Set and reset by software.
    $14 constant RCC_UART5RST                   \ [0x14] UART5 block reset Set and reset by software.
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 block reset Set and reset by software.
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 block reset Set and reset by software.
    $17 constant RCC_I2C3RST                    \ [0x17] I2C3 block reset Set and reset by software.
    $1b constant RCC_CECRST                     \ [0x1b] HDMI-CEC block reset Set and reset by software.
    $1d constant RCC_DAC1RST                    \ [0x1d] DAC1 (containing two converters) reset Set and reset by software.
    $1e constant RCC_UART7RST                   \ [0x1e] UART7 block reset Set and reset by software.
    $1f constant RCC_UART8RST                   \ [0x1f] UART8 block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1HRSTR_DEF
    \
    \ @brief clock recovery system reset Set and reset by software.
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $01 constant RCC_CRSRST                     \ [0x01] clock recovery system reset Set and reset by software.
    $02 constant RCC_SWPMIRST                   \ [0x02] SWPMI block reset Set and reset by software.
    $04 constant RCC_OPAMPRST                   \ [0x04] OPAMP block reset Set and reset by software.
    $05 constant RCC_MDIOSRST                   \ [0x05] MDIOS block reset Set and reset by software.
    $08 constant RCC_FDCANRST                   \ [0x08] FDCAN block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB2RSTR_DEF
    \
    \ @brief TIM1 block reset Set and reset by software.
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1RST                    \ [0x00] TIM1 block reset Set and reset by software.
    $01 constant RCC_TIM8RST                    \ [0x01] TIM8 block reset Set and reset by software.
    $04 constant RCC_USART1RST                  \ [0x04] USART1 block reset Set and reset by software.
    $05 constant RCC_USART6RST                  \ [0x05] USART6 block reset Set and reset by software.
    $06 constant RCC_UART9RST                   \ [0x06] UART9 block reset Set and reset by software.
    $07 constant RCC_USART10RST                 \ [0x07] USART10 block reset Set and reset by software.
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 block reset Set and reset by software.
    $0d constant RCC_SPI4RST                    \ [0x0d] SPI4 block reset Set and reset by software.
    $10 constant RCC_TIM15RST                   \ [0x10] TIM15 block reset Set and reset by software.
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 block reset Set and reset by software.
    $12 constant RCC_TIM17RST                   \ [0x12] TIM17 block reset Set and reset by software.
    $14 constant RCC_SPI5RST                    \ [0x14] SPI5 block reset Set and reset by software.
    $16 constant RCC_SAI1RST                    \ [0x16] SAI1 block reset Set and reset by software.
    $17 constant RCC_SAI2RST                    \ [0x17] SAI2 block reset Set and reset by software.
    $1e constant RCC_DFSDM1RST                  \ [0x1e] DFSDM1 block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB4RSTR_DEF
    \
    \ @brief SYSCFG block reset Set and reset by software.
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SYSCFGRST                  \ [0x01] SYSCFG block reset Set and reset by software.
    $03 constant RCC_LPUART1RST                 \ [0x03] LPUART1 block reset Set and reset by software.
    $05 constant RCC_SPI6RST                    \ [0x05] SPI6 block reset Set and reset by software.
    $07 constant RCC_I2C4RST                    \ [0x07] I2C4 block reset Set and reset by software.
    $09 constant RCC_LPTIM2RST                  \ [0x09] LPTIM2 block reset Set and reset by software.
    $0a constant RCC_LPTIM3RST                  \ [0x0a] LPTIM3 block reset Set and reset by software.
    $0d constant RCC_DAC2RST                    \ [0x0d] DAC2 (containing one converter) reset Set and reset by software.
    $0e constant RCC_COMP12RST                  \ [0x0e] COMP1 and 2 blocks reset Set and reset by software.
    $0f constant RCC_VREFRST                    \ [0x0f] VREF block reset Set and reset by software.
    $1a constant RCC_DTSRST                     \ [0x1a] Digital temperature sensor block reset Set and reset by software.
    $1b constant RCC_DFSDM2RST                  \ [0x1b] DFSDM2 block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_SRDAMR_DEF
    \
    \ @brief RCC SmartRun domain Autonomous mode register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_BDMA2AMEN                  \ [0x00] SmartRun domain DMA and DMAMUX Autonomous mode enable Set and reset by software. Refer to for additional information.
    $01 constant RCC_GPIOAMEN                   \ [0x01] GPIO Autonomous mode enable Set and reset by software. Refer to for additional information.
    $03 constant RCC_LPUART1AMEN                \ [0x03] LPUART1 Autonomous mode enable Set and reset by software. Refer to for additional information.
    $05 constant RCC_SPI6AMEN                   \ [0x05] SPI6 Autonomous mode enable Set and reset by software. Refer to for additional information.
    $07 constant RCC_I2C4AMEN                   \ [0x07] I2C4 Autonomous mode enable Set and reset by software. Refer to for additional information.
    $09 constant RCC_LPTIM2AMEN                 \ [0x09] LPTIM2 Autonomous mode enable Set and reset by software. Refer to for additional information
    $0a constant RCC_LPTIM3AMEN                 \ [0x0a] LPTIM3 Autonomous mode enable Set and reset by software. Refer to for additional information.
    $0d constant RCC_DAC2AMEN                   \ [0x0d] DAC2 (containing one converter) Autonomous mode enable Set and reset by software. Refer to for additional information.
    $0e constant RCC_COMP12AMEN                 \ [0x0e] COMP1 and 2 Autonomous mode enable Set and reset by software. Refer to for additional information.
    $0f constant RCC_VREFAMEN                   \ [0x0f] VREF Autonomous mode enable Set and reset by software. Refer to for additional information.
    $10 constant RCC_RTCAMEN                    \ [0x10] RTC Autonomous mode enable Set and reset by software. Refer to for additional information.
    $1a constant RCC_DTSAMEN                    \ [0x1a] Digital temperature sensor Autonomous mode enable Set and reset by software. Refer to for additional information.
    $1b constant RCC_DFSDM2AMEN                 \ [0x1b] DFSDM2 Autonomous mode enable Set and reset by software. Refer to for additional information.
    $1c constant RCC_BKPRAMAMEN                 \ [0x1c] Backup RAM Autonomous mode enable Set and reset by software. Refer to for additional information.
    $1d constant RCC_SRDSRAMAMEN                \ [0x1d] SmartRun domain SRAM Autonomous mode enable Set and reset by software. Refer to for additional information.
  [then]


  [ifdef] RCC_RCC_CKGAENR_DEF
    \
    \ @brief RCC AXI clocks gating enable register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_AXICKG                     \ [0x00] AXI interconnect matrix clock gating This bit is set and reset by software.
    $01 constant RCC_AHBCKG                     \ [0x01] AXI master AHB clock gating This bit is set and reset by software.
    $02 constant RCC_CPUCKG                     \ [0x02] AXI master CPU clock gating This bit is set and reset by software.
    $03 constant RCC_SDMMCCKG                   \ [0x03] AXI master SDMMC clock gating This bit is set and reset by software.
    $04 constant RCC_MDMACKG                    \ [0x04] AXI master MDMA clock gating This bit is set and reset by software.
    $05 constant RCC_DMA2DCKG                   \ [0x05] AXI master DMA2D clock gating This bit is set and reset by software.
    $06 constant RCC_LTDCCKG                    \ [0x06] AXI master LTDC clock gating This bit is set and reset by software.
    $07 constant RCC_GFXMMUMCKG                 \ [0x07] AXI master GFXMMU clock gating This bit is set and reset by software.
    $08 constant RCC_AHB12CKG                   \ [0x08] AXI slave AHB12 clock gating This bit is set and reset by software.
    $09 constant RCC_AHB34CKG                   \ [0x09] AXI slave AHB34 clock gating This bit is set and reset by software.
    $0a constant RCC_FLIFTCKG                   \ [0x0a] AXI slave Flash interface (FLIFT) clock gating This bit is set and reset by software.
    $0b constant RCC_OCTOSPI2CKG                \ [0x0b] AXI slave OCTOSPI2 clock gating This bit is set and reset by software.
    $0c constant RCC_FMCCKG                     \ [0x0c] AXI slave FMC clock gating This bit is set and reset by software.
    $0d constant RCC_OCTOSPI1CKG                \ [0x0d] AXI slave OCTOSPI1 clock gating This bit is set and reset by software.
    $0e constant RCC_AXIRAM1CKG                 \ [0x0e] AXI slave SRAM1 clock gating This bit is set and reset by software.
    $0f constant RCC_AXIRAM2CKG                 \ [0x0f] AXI matrix slave SRAM2 clock gating This bit is set and reset by software.
    $10 constant RCC_AXIRAM3CKG                 \ [0x10] AXI matrix slave SRAM3 clock gating This bit is set and reset by software.
    $11 constant RCC_GFXMMUSCKG                 \ [0x11] AXI matrix slave GFXMMU clock gating This bit is set and reset by software.
    $1d constant RCC_ECCRAMCKG                  \ [0x1d] RAM error code correction (ECC) clock gating This bit is set and reset by software.
    $1e constant RCC_EXTICKG                    \ [0x1e] EXTI clock gating This bit is set and reset by software.
    $1f constant RCC_JTAGCKG                    \ [0x1f] JTAG automatic clock gating This bit is set and reset by software.
  [then]


  [ifdef] RCC_RCC_RSR_DEF
    \
    \ @brief RCC reset status register
    \ Address offset: 0x130
    \ Reset value: 0x00E80000
    \
    $10 constant RCC_RMVF                       \ [0x10] remove reset flag Set and reset by software to reset the value of the reset flags.
    $13 constant RCC_CDRSTF                     \ [0x13] CPU domain power-switch reset flag Reset by software by writing the RMVF bit. Set by hardware when a the CPU domain exits from DStop or after of power-on reset. Set also when the CPU domain exists DStop2 but only when a pad reset has occurred during DStop2 (PINRST bit also set by hardware)
    $15 constant RCC_BORRSTF                    \ [0x15] BOR reset flag Reset by software by writing the RMVF bit. Set by hardware when a BOR reset occurs (pwr_bor_rst).
    $16 constant RCC_PINRSTF                    \ [0x16] pin reset flag (NRST) Reset by software by writing the RMVF bit. Set by hardware when a reset from pin occurs.
    $17 constant RCC_PORRSTF                    \ [0x17] POR/PDR reset flag Reset by software by writing the RMVF bit. Set by hardware when a POR/PDR reset occurs.
    $18 constant RCC_SFTRSTF                    \ [0x18] system reset from CPU reset flag Reset by software by writing the RMVF bit. Set by hardware when the system reset is due to CPU.The CPU can generate a system reset by writing SYSRESETREQ bit of AIRCR register of the core M7.
    $1a constant RCC_IWDGRSTF                   \ [0x1a] independent watchdog reset flag Reset by software by writing the RMVF bit. Set by hardware when an independent watchdog reset occurs.
    $1c constant RCC_WWDGRSTF                   \ [0x1c] window watchdog reset flag Reset by software by writing the RMVF bit. Set by hardware when a window watchdog reset occurs.
    $1e constant RCC_LPWRRSTF                   \ [0x1e] reset due to illegal CD DStop or CD DStop2 or CPU CStop flag Reset by software by writing the RMVF bit. Set by hardware when the CPU domain goes erroneously in DStop or DStop2, or when the CPU goes erroneously in CStop.
  [then]


  [ifdef] RCC_RCC_AHB3ENR_DEF
    \
    \ @brief MDMA peripheral clock enable Set and reset by software.
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMAEN                     \ [0x00] MDMA peripheral clock enable Set and reset by software.
    $04 constant RCC_DMA2DEN                    \ [0x04] DMA2D peripheral clock enable Set and reset by software.
    $05 constant RCC_JPGDECEN                   \ [0x05] JPGDEC peripheral clock enable Set and reset by software.
    $0c constant RCC_FMCEN                      \ [0x0c] FMC peripheral clocks enable Set and reset by software. The peripheral clocks of the FMC are the kernel clock selected by FMCSEL and provided to fmc_ker_ck input, and the rcc_hclk3 bus interface clock.
    $0e constant RCC_OCTOSPI1EN                 \ [0x0e] OCTOSPI1 and OCTOSPI1 delay clock enable Set and reset by software.
    $10 constant RCC_SDMMC1EN                   \ [0x10] SDMMC1 and SDMMC1 delay clock enable Set and reset by software.
    $13 constant RCC_OCTOSPI2EN                 \ [0x13] OCTOSPI2 clock enable Set and reset by software.
    $15 constant RCC_OCTOSPIMEN                 \ [0x15] OCTOSPIM clock enable Set and reset by software.
    $16 constant RCC_OTFD1EN                    \ [0x16] OTFD1 clock enable Set and reset by software.
    $17 constant RCC_OTFD2EN                    \ [0x17] OTFD2 clock enable Set and reset by software.
    $18 constant RCC_GFXMMUEN                   \ [0x18] GFXMMU clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB1ENR_DEF
    \
    \ @brief DMA1 clock enable Set and reset by software.
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1 clock enable Set and reset by software.
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2 clock enable Set and reset by software.
    $05 constant RCC_ADC12EN                    \ [0x05] ADC1 and 2 peripheral clocks enable Set and reset by software. The peripheral clocks of the ADC1 and 2 are the kernel clock selected by ADCSEL and provided to adc_ker_ck input, and the rcc_hclk1 bus interface clock.
    $09 constant RCC_CRCEN                      \ [0x09] CRC peripheral clock enable Set and reset by software.
    $19 constant RCC_USB1OTGEN                  \ [0x19] USB1OTG peripheral clocks enable Set and reset by software. The peripheral clocks of the USB1OTG are the kernel clock selected by USBSEL and the rcc_hclk1 bus interface clock.
    $1a constant RCC_USB1ULPIEN                 \ [0x1a] USB_PHY1 clocks enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB2ENR_DEF
    \
    \ @brief digital camera interface peripheral clock enable (DCMI or PSSI depending which IP is active) Set and reset by software.
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DCMI_PSSIEN                \ [0x00] digital camera interface peripheral clock enable (DCMI or PSSI depending which IP is active) Set and reset by software.
    $02 constant RCC_HSEMEN                     \ [0x02] HSEM peripheral clock enable Set and reset by software.
    $04 constant RCC_CRYPTEN                    \ [0x04] CRYPT peripheral clock enable Set and reset by software.
    $05 constant RCC_HASHEN                     \ [0x05] HASH peripheral clock enable Set and reset by software.
    $06 constant RCC_RNGEN                      \ [0x06] RNG peripheral clocks enable Set and reset by software. The peripheral clocks of the RNG are the kernel clock selected by RNGSEL and provided to rng_clk input, and the rcc_hclk2 bus interface clock.
    $09 constant RCC_SDMMC2EN                   \ [0x09] SDMMC2 and SDMMC2 delay clock enable Set and reset by software.
    $0b constant RCC_BDMA1EN                    \ [0x0b] DMA clock enable (DFSDM dedicated DMA) Set and reset by software.
    $1d constant RCC_AHBSRAM1EN                 \ [0x1d] AHBSRAM1 block enable Set and reset by software. When set, this bit indicates that the SRAM1 is allocated by the CPU. It causes the CPU domain to take into account also the CPU operation modes, keeping the CPU domain in DRun when the CPU is in CRun.
    $1e constant RCC_AHBSRAM2EN                 \ [0x1e] AHBSRAM2 block enable Set and reset by software. When set, this bit indicates that the SRAM2 is allocated by the CPU. It causes the CPU domain to take into account also the CPU operation modes, keeping the CPU domain in DRun when the CPU is in CRun.
  [then]


  [ifdef] RCC_RCC_AHB4ENR_DEF
    \
    \ @brief GPIOA peripheral clock enable Set and reset by software.
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] GPIOA peripheral clock enable Set and reset by software.
    $01 constant RCC_GPIOBEN                    \ [0x01] GPIOB peripheral clock enable Set and reset by software.
    $02 constant RCC_GPIOCEN                    \ [0x02] GPIOC peripheral clock enable Set and reset by software.
    $03 constant RCC_GPIODEN                    \ [0x03] GPIOD peripheral clock enable Set and reset by software.
    $04 constant RCC_GPIOEEN                    \ [0x04] GPIOE peripheral clock enable Set and reset by software.
    $05 constant RCC_GPIOFEN                    \ [0x05] GPIOF peripheral clock enable Set and reset by software.
    $06 constant RCC_GPIOGEN                    \ [0x06] GPIOG peripheral clock enable Set and reset by software.
    $07 constant RCC_GPIOHEN                    \ [0x07] GPIOH peripheral clock enable Set and reset by software.
    $08 constant RCC_GPIOIEN                    \ [0x08] GPIOI peripheral clock enable Set and reset by software.
    $09 constant RCC_GPIOJEN                    \ [0x09] GPIOJ peripheral clock enable Set and reset by software.
    $0a constant RCC_GPIOKEN                    \ [0x0a] GPIOK peripheral clock enable Set and reset by software.
    $15 constant RCC_BDMA2EN                    \ [0x15] SmartRun domain DMA and DMAMUX clock enable Set and reset by software.
    $1c constant RCC_BKPRAMEN                   \ [0x1c] Backup RAM clock enable Set and reset by software.
    $1d constant RCC_SRDSRAMEN                  \ [0x1d] SmartRun domain SRAM clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB3ENR_DEF
    \
    \ @brief LTDC clock enable Provides the clock (ltdc_pclk, ltdc_aclk, ltdc_ker_ck) to the LTDC block. Set and reset by software.
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $03 constant RCC_LTDCEN                     \ [0x03] LTDC clock enable Provides the clock (ltdc_pclk, ltdc_aclk, ltdc_ker_ck) to the LTDC block. Set and reset by software.
    $06 constant RCC_WWDGEN                     \ [0x06] WWDG clock enable Set by software, and reset by hardware when a system reset occurs. Note that in order to work properly, before enabling the WWDG, the bit WW1RSC must be set to 1.
  [then]


  [ifdef] RCC_RCC_APB1LENR_DEF
    \
    \ @brief TIM2 peripheral clock enable Set and reset by software.
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2 peripheral clock enable Set and reset by software.
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 peripheral clock enable Set and reset by software.
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4 peripheral clock enable Set and reset by software.
    $03 constant RCC_TIM5EN                     \ [0x03] TIM5 peripheral clock enable Set and reset by software.
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6 peripheral clock enable Set and reset by software.
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7 peripheral clock enable Set and reset by software.
    $06 constant RCC_TIM12EN                    \ [0x06] TIM12 peripheral clock enable Set and reset by software.
    $07 constant RCC_TIM13EN                    \ [0x07] TIM13 peripheral clock enable Set and reset by software.
    $08 constant RCC_TIM14EN                    \ [0x08] TIM14 peripheral clock enable Set and reset by software.
    $09 constant RCC_LPTIM1EN                   \ [0x09] LPTIM1 peripheral clocks enable Set and reset by software. The peripheral clocks of the LPTIM1 are the kernel clock selected by LPTIM1SEL and provided to lptim_ker_ck input, and the rcc_pclk1 bus interface clock.
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI2 are the kernel clock selected by I2S123SRC and provided to spi_ker_ck input, and the rcc_pclk1 bus interface clock.
    $0f constant RCC_SPI3EN                     \ [0x0f] SPI3 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI3 are the kernel clock selected by I2S123SRC and provided to spi_ker_ck input, and the rcc_pclk1 bus interface clock.
    $10 constant RCC_SPDIFRXEN                  \ [0x10] SPDIFRX peripheral clocks enable Set and reset by software. The peripheral clocks of the SPDIFRX are the kernel clock selected by SPDIFRXSEL and provided to spdifrx_ker_ck input, and the rcc_pclk1 bus interface clock.
    $11 constant RCC_USART2EN                   \ [0x11] USART2peripheral clocks enable Set and reset by software. The peripheral clocks of the USART2 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
    $12 constant RCC_USART3EN                   \ [0x12] USART3 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART3 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
    $13 constant RCC_UART4EN                    \ [0x13] UART4 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART4 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
    $14 constant RCC_UART5EN                    \ [0x14] UART5 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART5 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 peripheral clocks enable Set and reset by software. The peripheral clocks of the I2C1 are the kernel clock selected by I2C123SEL and provided to i2C_ker_ck input, and the rcc_pclk1 bus interface clock.
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 peripheral clocks enable Set and reset by software. The peripheral clocks of the I2C2 are the kernel clock selected by I2C123SEL and provided to i2C_ker_ck input, and the rcc_pclk1 bus interface clock.
    $17 constant RCC_I2C3EN                     \ [0x17] I2C3 peripheral clocks enable Set and reset by software. The peripheral clocks of the I2C3 are the kernel clock selected by I2C123SEL and provided to i2C_ker_ck input, and the rcc_pclk1 bus interface clock.
    $1b constant RCC_CECEN                      \ [0x1b] HDMI-CEC peripheral clock enable Set and reset by software. The peripheral clocks of the HDMI-CEC are the kernel clock selected by CECSEL and provided to cec_ker_ck input, and the rcc_pclk1 bus interface clock.
    $1d constant RCC_DAC1EN                     \ [0x1d] DAC1 (containing two converters) peripheral clock enable Set and reset by software.
    $1e constant RCC_UART7EN                    \ [0x1e] UART7 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART7 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
    $1f constant RCC_UART8EN                    \ [0x1f] UART8 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART8 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
  [then]


  [ifdef] RCC_RCC_APB1HENR_DEF
    \
    \ @brief clock recovery system peripheral clock enable Set and reset by software.
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_CRSEN                      \ [0x01] clock recovery system peripheral clock enable Set and reset by software.
    $02 constant RCC_SWPMIEN                    \ [0x02] SWPMI peripheral clocks enable Set and reset by software.
    $04 constant RCC_OPAMPEN                    \ [0x04] OPAMP peripheral clock enable Set and reset by software.
    $05 constant RCC_MDIOSEN                    \ [0x05] MDIOS peripheral clock enable Set and reset by software.
    $08 constant RCC_FDCANEN                    \ [0x08] FDCAN peripheral clocks enable Set and reset by software. The peripheral clocks of the FDCAN are the kernel clock selected by FDCANSEL and provided to fdcan_ker_ck input, and the rcc_pclk1 bus interface clock.
  [then]


  [ifdef] RCC_RCC_APB2ENR_DEF
    \
    \ @brief TIM1 peripheral clock enable Set and reset by software.
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1EN                     \ [0x00] TIM1 peripheral clock enable Set and reset by software.
    $01 constant RCC_TIM8EN                     \ [0x01] TIM8 peripheral clock enable Set and reset by software.
    $04 constant RCC_USART1EN                   \ [0x04] USART1 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART1 are the kernel clock selected by USART16910SEL and provided to UCKL input, and the rcc_pclk2 bus interface clock.
    $05 constant RCC_USART6EN                   \ [0x05] USART6 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART6 are the kernel clock selected by USART16910SEL and provided to UCKL input, and the rcc_pclk2 bus interface clock.
    $06 constant RCC_UART9EN                    \ [0x06] UART9 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART9 are the kernel clock selected by USART16910SEL and provided to UCKL input, and the rcc_pclk2 bus interface clock.
    $07 constant RCC_USART10EN                  \ [0x07] USART10 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART10 are the kernel clock selected by USART16910SEL and provided to UCKL input, and the rcc_pclk2 bus interface clock.
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 Peripheral Clocks Enable Set and reset by software. The peripheral clocks of the SPI1 are: the kernel clock selected by I2S123SRC and provided to spi_ker_ck input, and the rcc_pclk2 bus interface clock.
    $0d constant RCC_SPI4EN                     \ [0x0d] SPI4 Peripheral Clocks Enable Set and reset by software. The peripheral clocks of the SPI4 are: the kernel clock selected by SPI45SEL and provided to spi_ker_ck input, and the rcc_pclk2 bus interface clock.
    $10 constant RCC_TIM15EN                    \ [0x10] TIM15 peripheral clock enable Set and reset by software.
    $11 constant RCC_TIM16EN                    \ [0x11] TIM16 peripheral clock enable Set and reset by software.
    $12 constant RCC_TIM17EN                    \ [0x12] TIM17 peripheral clock enable Set and reset by software.
    $14 constant RCC_SPI5EN                     \ [0x14] SPI5 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI5 are the kernel clock selected by SPI45SEL and provided to spi_ker_ck input, and the rcc_pclk2 bus interface clock.
    $16 constant RCC_SAI1EN                     \ [0x16] SAI1 peripheral clocks enable Set and reset by software. The peripheral clocks of the SAI1 are: the kernel clock selected by SAI1SEL and provided to sai_a_ker_ck and sai_b_ker_ck inputs, and the rcc_pclk2 bus interface clock.
    $17 constant RCC_SAI2EN                     \ [0x17] SAI2 peripheral clocks enable Set and reset by software. The peripheral clocks of the SAI2 are the kernel clock selected by SAI2SEL and provided to sai_a_ker_ck and sai_b_ker_ck inputs, and the rcc_pclk2 bus interface clock.
    $1e constant RCC_DFSDM1EN                   \ [0x1e] DFSDM1 peripheral clocks enable Set and reset by software. DFSDM1 peripheral clocks are the kernel clocks selected by SAI1SEL and DFSDM1SEL and provided to Aclk and clk inputs respectively,
  [then]


  [ifdef] RCC_RCC_APB4ENR_DEF
    \
    \ @brief SYSCFG peripheral clock enable Set and reset by software.
    \ Address offset: 0x154
    \ Reset value: 0x00010000
    \
    $01 constant RCC_SYSCFGEN                   \ [0x01] SYSCFG peripheral clock enable Set and reset by software.
    $03 constant RCC_LPUART1EN                  \ [0x03] LPUART1 peripheral clocks enable Set and reset by software. The peripheral clocks of the LPUART1 are the kernel clock selected by LPUART1SEL and provided to lpuart_ker_ck input, and the rcc_pclk4 bus interface clock.
    $05 constant RCC_SPI6EN                     \ [0x05] SPI6 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI6 are the kernel clock selected by SPI6SEL and provided to spi_ker_ck input, and the rcc_pclk4 bus interface clock.
    $07 constant RCC_I2C4EN                     \ [0x07] I2C4 peripheral clocks enable Set and reset by software. The peripheral clocks of the I2C4 are the kernel clock selected by I2C4SEL and provided to i2C_ker_ck input, and the rcc_pclk4 bus interface clock.
    $09 constant RCC_LPTIM2EN                   \ [0x09] LPTIM2 peripheral clocks enable Set and reset by software. The peripheral clocks of the LPTIM2 are the kernel clock selected by LPTIM2SEL and provided to lptim_ker_ck input, and the rcc_pclk4 bus interface clock.
    $0a constant RCC_LPTIM3EN                   \ [0x0a] LPTIM3 peripheral clocks enable Set and reset by software. The peripheral clocks of the LPTIM3 are the kernel clock selected by LPTIM345SEL and provided to lptim_ker_ck input, and the rcc_pclk4 bus interface clock.
    $0d constant RCC_DAC2EN                     \ [0x0d] DAC2 (containing one converter) peripheral clock enable Set and reset by software.
    $0e constant RCC_COMP12EN                   \ [0x0e] COMP1 and 2 peripheral clock enable Set and reset by software.
    $0f constant RCC_VREFEN                     \ [0x0f] VREF peripheral clock enable Set and reset by software.
    $10 constant RCC_RTCAPBEN                   \ [0x10] RTC APB clock enable Set and reset by software.
    $1a constant RCC_DTSEN                      \ [0x1a] Digital temperature sensor peripheral clock enable Set and reset by software.
    $1b constant RCC_DFSDM2EN                   \ [0x1b] DFSDM2peripheral clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB3LPENR_DEF
    \
    \ @brief MDMA clock enable during CSleep mode Set and reset by software.
    \ Address offset: 0x15C
    \ Reset value: 0xFDE95131
    \
    $00 constant RCC_MDMALPEN                   \ [0x00] MDMA clock enable during CSleep mode Set and reset by software.
    $04 constant RCC_DMA2DLPEN                  \ [0x04] DMA2D clock enable during CSleep mode Set and reset by software.
    $05 constant RCC_JPGDECLPEN                 \ [0x05] JPGDEC clock enable during CSleep mode Set and reset by software.
    $08 constant RCC_FLITFLPEN                  \ [0x08] FLITF clock enable during CSleep mode Set and reset by software.
    $0c constant RCC_FMCLPEN                    \ [0x0c] FMC peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the FMC are the kernel clock selected by FMCSEL and provided to fmc_ker_ck input, and the rcc_hclk3 bus interface clock.
    $0e constant RCC_OCTOSPI1LPEN               \ [0x0e] OCTOSPI1 and OCTOSPI1 delay clock enable during CSleep mode Set and reset by software.
    $10 constant RCC_SDMMC1LPEN                 \ [0x10] SDMMC1 and SDMMC1 delay clock enable during CSleep mode Set and reset by software.
    $13 constant RCC_OCTOSPI2LPEN               \ [0x13] OCTOSPI2 and OCTOSPI2 delay clock enable during CSleep mode Set and reset by software.
    $15 constant RCC_OCTOSPIMLPEN               \ [0x15] OCTOSPIM block clock enable during CSleep mode Set and reset by software.
    $16 constant RCC_OTFD1LPEN                  \ [0x16] OTFD1 block clock enable during CSleep mode Set and reset by software.
    $17 constant RCC_OTFD2LPEN                  \ [0x17] OTFD2 block clock enable during CSleep mode Set and reset by software.
    $18 constant RCC_GFXMMULPEN                 \ [0x18] GFXMMU block clock enable during CSleep mode Set and reset by software.
    $1a constant RCC_AXISRAM2LPEN               \ [0x1a] AXISRAM2 block clock enable during CSleep mode Set and reset by software.
    $1b constant RCC_AXISRAM3LPEN               \ [0x1b] AXISRAM3 block clock enable during CSleep mode Set and reset by software.
    $1c constant RCC_DTCM1LPEN                  \ [0x1c] DTCM1 block clock enable during CSleep mode Set and reset by software.
    $1d constant RCC_DTCM2LPEN                  \ [0x1d] DTCM2 block clock enable during CSleep mode Set and reset by software.
    $1e constant RCC_ITCMLPEN                   \ [0x1e] ITCM block clock enable during CSleep mode Set and reset by software.
    $1f constant RCC_AXISRAM1LPEN               \ [0x1f] AXISRAM1 block clock enable during CSleep mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB1LPENR_DEF
    \
    \ @brief DMA1 clock enable during CSleep mode Set and reset by software.
    \ Address offset: 0x160
    \ Reset value: 0x06000223
    \
    $00 constant RCC_DMA1LPEN                   \ [0x00] DMA1 clock enable during CSleep mode Set and reset by software.
    $01 constant RCC_DMA2LPEN                   \ [0x01] DMA2 clock enable during CSleep mode Set and reset by software.
    $05 constant RCC_ADC12LPEN                  \ [0x05] ADC1 and 2 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the ADC1 and 2 are the kernel clock selected by ADCSEL and provided to adc_ker_ck input, and the rcc_hclk1 bus interface clock.
    $09 constant RCC_CRCLPEN                    \ [0x09] CRC peripheral clock enable during CSleep mode Set and reset by software.
    $19 constant RCC_USB1OTGLPEN                \ [0x19] USB1OTG peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the USB1OTG are the kernel clock selected by USBSEL and the rcc_hclk1 bus interface clock.
    $1a constant RCC_USB1ULPILPEN               \ [0x1a] USB_PHY1 clock enable during CSleep mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB2LPENR_DEF
    \
    \ @brief digital camera interface peripheral clock enable during CSleep mode (DCMI or PSSI depending which IP is active) Set and reset by software.
    \ Address offset: 0x164
    \ Reset value: 0x60000A71
    \
    $00 constant RCC_DCMI_PSSILPEN              \ [0x00] digital camera interface peripheral clock enable during CSleep mode (DCMI or PSSI depending which IP is active) Set and reset by software.
    $04 constant RCC_CRYPTLPEN                  \ [0x04] CRYPT peripheral clock enable during CSleep mode Set and reset by software.
    $05 constant RCC_HASHLPEN                   \ [0x05] HASH peripheral clock enable during CSleep mode Set and reset by software.
    $06 constant RCC_RNGLPEN                    \ [0x06] RNG peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the RNG are the kernel clock selected by RNGSEL and provided to rng_clk input, and the rcc_hclk2 bus interface clock.
    $09 constant RCC_SDMMC2LPEN                 \ [0x09] SDMMC2 and SDMMC2 delay clock enable during CSleep mode Set and reset by software.
    $0b constant RCC_DFSDMDMALPEN               \ [0x0b] DFSDMDMA clock enable during CSleep mode Set and reset by software.
    $1d constant RCC_AHBSRAM1LPEN               \ [0x1d] AHBSRAM1 clock enable during CSleep mode Set and reset by software.
    $1e constant RCC_AHBSRAM2LPEN               \ [0x1e] AHBSRAM2 clock enable during CSleep mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB4LPENR_DEF
    \
    \ @brief GPIOA peripheral clock enable during CSleep mode Set and reset by software.
    \ Address offset: 0x168
    \ Reset value: 0x302007FF
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIOA peripheral clock enable during CSleep mode Set and reset by software.
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIOB peripheral clock enable during CSleep mode Set and reset by software.
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIOC peripheral clock enable during CSleep mode Set and reset by software.
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIOD peripheral clock enable during CSleep mode Set and reset by software.
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIOE peripheral clock enable during CSleep mode Set and reset by software.
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIOF peripheral clock enable during CSleep mode Set and reset by software.
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIOG peripheral clock enable during CSleep mode Set and reset by software.
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIOH peripheral clock enable during CSleep mode Set and reset by software.
    $08 constant RCC_GPIOILPEN                  \ [0x08] GPIOI peripheral clock enable during CSleep mode Set and reset by software.
    $09 constant RCC_GPIOJLPEN                  \ [0x09] GPIOJ peripheral clock enable during CSleep mode Set and reset by software.
    $0a constant RCC_GPIOKLPEN                  \ [0x0a] GPIOK peripheral clock enable during CSleep mode Set and reset by software.
    $15 constant RCC_BDMA2LPEN                  \ [0x15] SmartRun domain DMA and DMAMUX clock enable during CSleep mode Set and reset by software.
    $1c constant RCC_BKPRAMLPEN                 \ [0x1c] Backup RAM clock enable during CSleep mode Set and reset by software.
    $1d constant RCC_SRDSRAMLPEN                \ [0x1d] SmartRun domain SRAM clock enable during CSleep mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB3LPENR_DEF
    \
    \ @brief LTDC peripheral clock enable during CSleep mode Set and reset by software. The LTDC peripheral clocks are the kernel clock provided to ltdc_ker_ck input and the rcc_pclk3 bus interface clock.
    \ Address offset: 0x16C
    \ Reset value: 0x00000048
    \
    $03 constant RCC_LTDCLPEN                   \ [0x03] LTDC peripheral clock enable during CSleep mode Set and reset by software. The LTDC peripheral clocks are the kernel clock provided to ltdc_ker_ck input and the rcc_pclk3 bus interface clock.
    $06 constant RCC_WWDGLPEN                   \ [0x06] WWDG clock enable during CSleep mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1LLPENR_DEF
    \
    \ @brief TIM2 peripheral clock enable during CSleep mode Set and reset by software.
    \ Address offset: 0x170
    \ Reset value: 0xE8FFC3FF
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2 peripheral clock enable during CSleep mode Set and reset by software.
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3 peripheral clock enable during CSleep mode Set and reset by software.
    $02 constant RCC_TIM4LPEN                   \ [0x02] TIM4 peripheral clock enable during CSleep mode Set and reset by software.
    $03 constant RCC_TIM5LPEN                   \ [0x03] TIM5 peripheral clock enable during CSleep mode Set and reset by software.
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6 peripheral clock enable during CSleep mode Set and reset by software.
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7 peripheral clock enable during CSleep mode Set and reset by software.
    $06 constant RCC_TIM12LPEN                  \ [0x06] TIM12 peripheral clock enable during CSleep mode Set and reset by software.
    $07 constant RCC_TIM13LPEN                  \ [0x07] TIM13 peripheral clock enable during CSleep mode Set and reset by software.
    $08 constant RCC_TIM14LPEN                  \ [0x08] TIM14 peripheral clock enable during CSleep mode Set and reset by software.
    $09 constant RCC_LPTIM1LPEN                 \ [0x09] LPTIM1 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the LPTIM1 are the kernel clock selected by LPTIM1SEL and provided to lptim_ker_ck input, and the rcc_pclk1 bus interface clock.
    $0e constant RCC_SPI2LPEN                   \ [0x0e] SPI2 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SPI2 are the kernel clock selected by I2S123SRC and provided to spi_ker_ck input, and the rcc_pclk1 bus interface clock.
    $0f constant RCC_SPI3LPEN                   \ [0x0f] SPI3 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SPI3 are the kernel clock selected by I2S123SRC and provided to spi_ker_ck input, and the rcc_pclk1 bus interface clock.
    $10 constant RCC_SPDIFRXLPEN                \ [0x10] SPDIFRX peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SPDIFRX are: the kernel clock selected by SPDIFRXSEL and provided to spdifrx_ker_ck input, and the rcc_pclk1 bus interface clock.
    $11 constant RCC_USART2LPEN                 \ [0x11] USART2 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the USART2 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
    $12 constant RCC_USART3LPEN                 \ [0x12] USART3 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the USART3 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
    $13 constant RCC_UART4LPEN                  \ [0x13] UART4 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the UART4 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
    $14 constant RCC_UART5LPEN                  \ [0x14] UART5 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the UART5 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C1 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the I2C1 are the kernel clock selected by I2C123SEL and provided to i2C_ker_ck input, and the rcc_pclk1 bus interface clock.
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the I2C2 are the kernel clock selected by I2C123SEL and provided to i2C_ker_ck input, and the rcc_pclk1 bus interface clock.
    $17 constant RCC_I2C3LPEN                   \ [0x17] I2C3 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the I2C3 are the kernel clock selected by I2C123SEL and provided to i2C_ker_ck input, and the rcc_pclk1 bus interface clock.
    $1b constant RCC_CECLPEN                    \ [0x1b] HDMI-CEC peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the HDMI-CEC are the kernel clock selected by CECSEL and provided to cec_ker_ck input, and the rcc_pclk1 bus interface clock.
    $1d constant RCC_DAC1LPEN                   \ [0x1d] DAC1 (containing two converters) peripheral clock enable during CSleep mode Set and reset by software.
    $1e constant RCC_UART7LPEN                  \ [0x1e] UART7 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the UART7 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
    $1f constant RCC_UART8LPEN                  \ [0x1f] UART8 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the UART8 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
  [then]


  [ifdef] RCC_RCC_APB1HLPENR_DEF
    \
    \ @brief clock recovery system peripheral clock enable during CSleep mode Set and reset by software.
    \ Address offset: 0x174
    \ Reset value: 0x00000136
    \
    $01 constant RCC_CRSLPEN                    \ [0x01] clock recovery system peripheral clock enable during CSleep mode Set and reset by software.
    $02 constant RCC_SWPMILPEN                  \ [0x02] SWPMI peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SWPMI are the kernel clock selected by SWPMISEL and provided to swpmi_ker_ck input, and the rcc_pclk1 bus interface clock.
    $04 constant RCC_OPAMPLPEN                  \ [0x04] OPAMP peripheral clock enable during CSleep mode Set and reset by software.
    $05 constant RCC_MDIOSLPEN                  \ [0x05] MDIOS peripheral clock enable during CSleep mode Set and reset by software.
    $08 constant RCC_FDCANLPEN                  \ [0x08] FDCAN peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the FDCAN are: the kernel clock selected by FDCANSEL and provided to fdcan_clk input, and the rcc_pclk1 bus interface clock.
  [then]


  [ifdef] RCC_RCC_APB2LPENR_DEF
    \
    \ @brief TIM1 peripheral clock enable during CSleep mode Set and reset by software.
    \ Address offset: 0x178
    \ Reset value: 0x40D730F3
    \
    $00 constant RCC_TIM1LPEN                   \ [0x00] TIM1 peripheral clock enable during CSleep mode Set and reset by software.
    $01 constant RCC_TIM8LPEN                   \ [0x01] TIM8 peripheral clock enable during CSleep mode Set and reset by software.
    $04 constant RCC_USART1LPEN                 \ [0x04] USART1 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the USART1 are the kernel clock selected by USART16910SEL and provided to usart_ker_ck inputs, and the rcc_pclk2 bus interface clock.
    $05 constant RCC_USART6LPEN                 \ [0x05] USART6 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the USART6 are the kernel clock selected by USART16910SEL and provided to usart_ker_ck input, and the rcc_pclk2 bus interface clock.
    $06 constant RCC_UART9LPEN                  \ [0x06] UART9 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the UART9 are the kernel clock selected by USART16910SEL and provided to usart_ker_ck input, and the rcc_pclk2 bus interface clock.
    $07 constant RCC_USART10LPEN                \ [0x07] USART10 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the USART10 are the kernel clock selected by USART16910SEL and provided to usart_ker_ck input, and the rcc_pclk2 bus interface clock.
    $0c constant RCC_SPI1LPEN                   \ [0x0c] SPI1 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the SPI1 are: the kernel clock selected by I2S123SRC and provided to spi_ker_ck input, and the rcc_pclk2 bus interface clock.
    $0d constant RCC_SPI4LPEN                   \ [0x0d] SPI4 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the SPI4 are: the kernel clock selected by SPI45SEL and provided to spi_ker_ck input, and the rcc_pclk2 bus interface clock.
    $10 constant RCC_TIM15LPEN                  \ [0x10] TIM15 peripheral clock enable during CSleep mode Set and reset by software.
    $11 constant RCC_TIM16LPEN                  \ [0x11] TIM16 peripheral clock enable during CSleep mode Set and reset by software.
    $12 constant RCC_TIM17LPEN                  \ [0x12] TIM17 peripheral clock enable during CSleep mode Set and reset by software.
    $14 constant RCC_SPI5LPEN                   \ [0x14] SPI5 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SPI5 are the kernel clock selected by SPI45SEL and provided to spi_ker_ck input, and the rcc_pclk2 bus interface clock.
    $16 constant RCC_SAI1LPEN                   \ [0x16] SAI1 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SAI1 are: the kernel clock selected by SAI1SEL and provided to sai_a_ker_ck and sai_b_ker_ck inputs, and the rcc_pclk2 bus interface clock.
    $17 constant RCC_SAI2LPEN                   \ [0x17] SAI2 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SAI2 are the kernel clock selected by SAI23EL and provided to sai_a_ker_ck and sai_b_ker_ck inputs, and the rcc_pclk2 bus interface clock.
    $1e constant RCC_DFSDM1LPEN                 \ [0x1e] DFSDM1 peripheral clocks enable during CSleep mode Set and reset by software. DFSDM1 peripheral clocks are the kernel clocks selected by SAI1SEL and DFSDM1SEL and provided to Aclk and clk inputs respectively, and the rcc_pclk2 bus interface clock.
  [then]


  [ifdef] RCC_RCC_APB4LPENR_DEF
    \
    \ @brief SYSCFG peripheral clock enable during CSleep mode Set and reset by software.
    \ Address offset: 0x17C
    \ Reset value: 0x0C01E6AA
    \
    $01 constant RCC_SYSCFGLPEN                 \ [0x01] SYSCFG peripheral clock enable during CSleep mode Set and reset by software.
    $03 constant RCC_LPUART1LPEN                \ [0x03] LPUART1 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the LPUART1 are the kernel clock selected by LPUART1SEL and provided to lpuart_ker_ck input, and the rcc_pclk4 bus interface clock.
    $05 constant RCC_SPI6LPEN                   \ [0x05] SPI6 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SPI6 are the kernel clock selected by SPI6SEL and provided to com_ck input, and the rcc_pclk4 bus interface clock.
    $07 constant RCC_I2C4LPEN                   \ [0x07] I2C4 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the I2C4 are the kernel clock selected by I2C4SEL and provided to i2C_ker_ck input, and the rcc_pclk4 bus interface clock.
    $09 constant RCC_LPTIM2LPEN                 \ [0x09] LPTIM2 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the LPTIM2 are the kernel clock selected by LPTIM2SEL and provided to lptim_ker_ck input, and the rcc_pclk4 bus interface clock.
    $0a constant RCC_LPTIM3LPEN                 \ [0x0a] LPTIM3 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the LPTIM3 are the kernel clock selected by LPTIM345SEL and provided to lptim_ker_ck input, and the rcc_pclk4 bus interface clock.
    $0d constant RCC_DAC2LPEN                   \ [0x0d] DAC2 (containing one converter) peripheral clock enable during CSleep mode Set and reset by software.
    $0e constant RCC_COMP12LPEN                 \ [0x0e] COMP1 and 2 peripheral clock enable during CSleep mode Set and reset by software.
    $0f constant RCC_VREFLPEN                   \ [0x0f] VREF peripheral clock enable during CSleep mode Set and reset by software.
    $10 constant RCC_RTCAPBLPEN                 \ [0x10] RTC APB clock enable during CSleep mode Set and reset by software.
    $1a constant RCC_DTSLPEN                    \ [0x1a] temperature sensor peripheral clock enable during CSleep mode Set and reset by software.
    $1b constant RCC_DFSDM2LPEN                 \ [0x1b] DFSDM2 peripheral clock enable during CSleep mode Set and reset by software.
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_RCC_CR               \ HSI clock enable Set and cleared by software. Set by hardware to force the HSI to ON when the product leaves Stop mode, if STOPWUCK = 0 or STOPKERWUCK = 0. Set by hardware to force the HSI to ON when the product leaves Standby mode or in case of a failure of the HSE which is used as the system clock source. This bit cannot be cleared if the HSI is used directly (via SW mux) as system clock, or if the HSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
  $04 constant RCC_RCC_HSICFGR          \ RCC HSI calibration register
  $08 constant RCC_RCC_CRRCR            \ RCC clock recovery RC register
  $0C constant RCC_RCC_CSICFGR          \ RCC CSI calibration register
  $10 constant RCC_RCC_CFGR             \ system clock and trace clock switch Set and reset by software to select system clock and trace clock sources (sys_ck and traceclk). Set by hardware in order to: force the selection of the HSI or CSI (depending on STOPWUCK selection) when leaving a system Stop mode force the selection of the HSI in case of failure of the HSE when used directly or indirectly as system clock others: reserved
  $18 constant RCC_RCC_CDCFGR1          \ CPU domain AHB prescaler Set and reset by software to control the division factor of rcc_hclk3 and rcc_aclk. Changing this division ratio has an impact on the frequency of all bus matrix clocks. 0xxx: rcc_hclk3 = sys_cdcpre_ck (default after reset) Note: The clocks are divided by the new prescaler factor from1 to 16 periods of the slowest APB clock among rcc_pclk[4:1] after HPRE update. Note: Note also that rcc_hclk3 = rcc_aclk.
  $1C constant RCC_RCC_CDCFGR2          \ CPU domain APB1 prescaler Set and reset by software to control the CPU domain APB1 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk1 after CDPPRE1 write. 0xx: rcc_pclk1 = rcc_hclk1 (default after reset)
  $20 constant RCC_RCC_SRDCFGR          \ SmartRun domain APB4 prescaler Set and reset by software to control the SmartRun domain APB4 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk4 after SRDPPRE write. 0xx: rcc_pclk4 = rcc_hclk4 (default after reset)
  $28 constant RCC_RCC_PLLCKSELR        \ DIVMx and PLLs clock source selection Set and reset by software to select the PLL clock source. These bits can be written only when all PLLs are disabled. In order to save power, when no PLL is used, the value of PLLSRC must be set to '11â.
  $2C constant RCC_RCC_PLLCFGR          \ PLL1 fractional latch enable Set and reset by software to latch the content of FRACN1 into the sigma-delta modulator. In order to latch the FRACN1 value into the sigma-delta modulator, PLL1FRACEN must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN1 into the modulator. Refer to for additional information.
  $30 constant RCC_RCC_PLL1DIVR         \ multiplication factor for PLL1 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL1ON = PLL1RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL1VCOSEL = 0 150 to 420Â MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x DIVN1, when fractional value 0 has been loaded into FRACN1, with: DIVN1 between 8 and 420 The input frequency Fref1_ck must be between 1 and 16Â MHz.
  $34 constant RCC_RCC_PLL1FRACR        \ fractional part of the multiplication factor for PLL1 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL1VCOSEL = 0 150 to 420Â MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x (DIVN1 + (FRACN1 / 213)), with DIVN1 between 8 and 420 FRACN1 can be between 0 and 213- 1 The input frequency Fref1_ck must be between 1 and 16 MHz. To change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into FRACN1. Set the bit PLL1FRACEN to 1.
  $38 constant RCC_RCC_PLL2DIVR         \ multiplication factor for PLL2 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL2ON = PLL2RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL2VCOSEL = 0 150 to 420Â MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x DIVN2, when fractional value 0 has been loaded into FRACN2, with DIVN2 between 8 and 420 The input frequency Fref2_ck must be between 1 and 16MHz.
  $3C constant RCC_RCC_PLL2FRACR        \ fractional part of the multiplication factor for PLL2 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL2VCOSEL = 0 150 to 420Â MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x (DIVN2 + (FRACN2 / 213)), with DIVN2 between 8 and 420 FRACN2 can be between 0 and 213 - 1 The input frequency Fref2_ck must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL2FRACEN to 0. Write the new fractional value into FRACN2. Set the bit PLL2FRACEN to 1.
  $40 constant RCC_RCC_PLL3DIVR         \ Multiplication factor for PLL3 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL3ON = PLL3RDY = 0). ...........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL3VCOSEL = 0 150 to 420Â MHz if PLL3VCOSEL = 1 VCO output frequency = Fref3_ck x DIVN3, when fractional value 0 has been loaded into FRACN3, with: DIVN3 between 8 and 420 The input frequency Fref3_ck must be between 1 and 16MHz
  $44 constant RCC_RCC_PLL3FRACR        \ fractional part of the multiplication factor for PLL3 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL3 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL3VCOSEL = 0 150 to 420Â MHz if PLL3VCOSEL = 1 VCO output frequency = Fref3_ck x (DIVN3 + (FRACN3 / 213)), with DIVN3 between 8 and 420 FRACN3 can be between 0 and 213 - 1 The input frequency Fref3_ck must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into FRACN1. Set the bit PLL1FRACEN to 1.
  $4C constant RCC_RCC_CDCCIPR          \ RCC CPU domain kernel clock configuration register
  $50 constant RCC_RCC_CDCCIP1R         \ RCC CPU domain kernel clock configuration register
  $54 constant RCC_RCC_CDCCIP2R         \ RCC CPU domain kernel clock configuration register
  $58 constant RCC_RCC_SRDCCIPR         \ RCC SmartRun domain kernel clock configuration register
  $60 constant RCC_RCC_CIER             \ LSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the LSI oscillator stabilization.
  $64 constant RCC_RCC_CIFR             \ LSI ready interrupt flag Reset by software by writing LSIRDYC bit. Set by hardware when the LSI clock becomes stable and LSIRDYIE is set.
  $68 constant RCC_RCC_CICR             \ LSI ready interrupt clear Set by software to clear LSIRDYF. Reset by hardware when clear done.
  $70 constant RCC_RCC_BDCR             \ RCC Backup domain control register
  $74 constant RCC_RCC_CSR              \ RCC clock control and status register
  $7C constant RCC_RCC_AHB3RSTR         \ MDMA block reset Set and reset by software.
  $80 constant RCC_RCC_AHB1RSTR         \ DMA1 and DMAMUX1 blocks reset Set and reset by software.
  $84 constant RCC_RCC_AHB2RSTR         \ digital camera interface block reset (DCMI or PSSI depending which IP is active) Set and reset by software.
  $88 constant RCC_RCC_AHB4RSTR         \ GPIOA block reset Set and reset by software.
  $8C constant RCC_RCC_APB3RSTR         \ LTDC block reset Set and reset by software.
  $90 constant RCC_RCC_APB1LRSTR        \ TIM2 block reset Set and reset by software.
  $94 constant RCC_RCC_APB1HRSTR        \ clock recovery system reset Set and reset by software.
  $98 constant RCC_RCC_APB2RSTR         \ TIM1 block reset Set and reset by software.
  $9C constant RCC_RCC_APB4RSTR         \ SYSCFG block reset Set and reset by software.
  $A8 constant RCC_RCC_SRDAMR           \ RCC SmartRun domain Autonomous mode register
  $B0 constant RCC_RCC_CKGAENR          \ RCC AXI clocks gating enable register
  $130 constant RCC_RCC_RSR             \ RCC reset status register
  $134 constant RCC_RCC_AHB3ENR         \ MDMA peripheral clock enable Set and reset by software.
  $138 constant RCC_RCC_AHB1ENR         \ DMA1 clock enable Set and reset by software.
  $13C constant RCC_RCC_AHB2ENR         \ digital camera interface peripheral clock enable (DCMI or PSSI depending which IP is active) Set and reset by software.
  $140 constant RCC_RCC_AHB4ENR         \ GPIOA peripheral clock enable Set and reset by software.
  $144 constant RCC_RCC_APB3ENR         \ LTDC clock enable Provides the clock (ltdc_pclk, ltdc_aclk, ltdc_ker_ck) to the LTDC block. Set and reset by software.
  $148 constant RCC_RCC_APB1LENR        \ TIM2 peripheral clock enable Set and reset by software.
  $14C constant RCC_RCC_APB1HENR        \ clock recovery system peripheral clock enable Set and reset by software.
  $150 constant RCC_RCC_APB2ENR         \ TIM1 peripheral clock enable Set and reset by software.
  $154 constant RCC_RCC_APB4ENR         \ SYSCFG peripheral clock enable Set and reset by software.
  $15C constant RCC_RCC_AHB3LPENR       \ MDMA clock enable during CSleep mode Set and reset by software.
  $160 constant RCC_RCC_AHB1LPENR       \ DMA1 clock enable during CSleep mode Set and reset by software.
  $164 constant RCC_RCC_AHB2LPENR       \ digital camera interface peripheral clock enable during CSleep mode (DCMI or PSSI depending which IP is active) Set and reset by software.
  $168 constant RCC_RCC_AHB4LPENR       \ GPIOA peripheral clock enable during CSleep mode Set and reset by software.
  $16C constant RCC_RCC_APB3LPENR       \ LTDC peripheral clock enable during CSleep mode Set and reset by software. The LTDC peripheral clocks are the kernel clock provided to ltdc_ker_ck input and the rcc_pclk3 bus interface clock.
  $170 constant RCC_RCC_APB1LLPENR      \ TIM2 peripheral clock enable during CSleep mode Set and reset by software.
  $174 constant RCC_RCC_APB1HLPENR      \ clock recovery system peripheral clock enable during CSleep mode Set and reset by software.
  $178 constant RCC_RCC_APB2LPENR       \ TIM1 peripheral clock enable during CSleep mode Set and reset by software.
  $17C constant RCC_RCC_APB4LPENR       \ SYSCFG peripheral clock enable during CSleep mode Set and reset by software.

: RCC_DEF ; [then]
