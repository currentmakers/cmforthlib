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
    \ @brief RCC source control register
    \ Address offset: 0x00
    \ Reset value: 0x00000025
    \
    $00 constant RCC_HSION                      \ [0x00] HSI clock enable Set and cleared by software. Set by hardware to force the HSI to ON when the product leaves Stop mode, if STOPWUCK = 0 or STOPKERWUCK = 0. Set by hardware to force the HSI to ON when the product leaves Standby mode or in case of a failure of the HSE which is used as the system clock source. This bit cannot be cleared if the HSI is used directly (via SW switch) as system clock, or if the HSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1) or if FMCCKP = 1, or if XSPICKP = 1.
    $01 constant RCC_HSIKERON                   \ [0x01] HSI clock enable in Stop mode Set and reset by software to force the HSI to ON, even in Stop mode, in order to be quickly available as kernel clock for peripherals. This bit has no effect on the value of HSION.
    $02 constant RCC_HSIRDY                     \ [0x02] HSI clock ready flag Set by hardware to indicate that the HSI oscillator is stable.
    $03 constant RCC_HSIDIV                     \ [0x03 : 2] HSI clock divider Set and reset by software. These bits allow selecting a division ratio in order to configure the wanted HSI clock frequency. The HSIDIV cannot be changed if the HSI is selected as reference clock for at least one enabled PLL (PLLxON bit set to 1). In that case, the new HSIDIV value is ignored.
    $05 constant RCC_HSIDIVF                    \ [0x05] HSI divider flag Set and reset by hardware. As a write operation to HSIDIV has not an immediate effect on the frequency, this flag indicates the current status of the HSI divider. HSIDIVF goes immediately to 0 when HSIDIV value is changed, and is set back to 1 when the output frequency matches the value programmed into HSIDIV. clock setting is completed)
    $07 constant RCC_CSION                      \ [0x07] CSI clock enable Set and reset by software to enable/disable CSI clock for system and/or peripheral. Set by hardware to force the CSI to ON when the system leaves Stop mode, if STOPWUCK = 1 or STOPKERWUCK = 1. This bit cannot be cleared if the CSI is used directly (via SW mux) as system clock, or if the CSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1) or if FMCCKP = 1, or if XSPICKP = 1.
    $08 constant RCC_CSIRDY                     \ [0x08] CSI clock ready flag Set by hardware to indicate that the CSI oscillator is stable. This bit is activated only if the RC is enabled by CSION (it is not activated if the CSI is enabled by CSIKERON or by a peripheral request).
    $09 constant RCC_CSIKERON                   \ [0x09] CSI clock enable in Stop mode Set and reset by software to force the CSI to ON, even in Stop mode, in order to be quickly available as kernel clock for some peripherals. This bit has no effect on the value of CSION.
    $0c constant RCC_HSI48ON                    \ [0x0c] HSI48 clock enable Set by software and cleared by software or by the hardware when the system enters to Stop or Standby mode.
    $0d constant RCC_HSI48RDY                   \ [0x0d] HSI48 clock ready flag Set by hardware to indicate that the HSI48 oscillator is stable.
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable Set and cleared by software. Cleared by hardware to stop the HSE when entering Stop or Standby mode. This bit cannot be cleared if the HSE is used directly (via SW mux) as system clock, or if the HSE is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1) or if FMCCKP = 1, or if XSPICKP = 1.
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable.
    $12 constant RCC_HSEBYP                     \ [0x12] HSE clock bypass Set and cleared by software to bypass the oscillator with an external clock. The external clock must be enabled with the HSEON bit to be used by the device. The HSEBYP bit can be written only if the HSE oscillator is disabled.
    $13 constant RCC_HSEEXT                     \ [0x13] external high speed clock type in Bypass mode Set and reset by software to select the external clock type (analog or digital). The external clock must be enabled with the HSEON bit to be used by the device. The HSEEXT bit can be written only if the HSE oscillator is disabled.
    $14 constant RCC_HSECSSON                   \ [0x14] HSE clock security system enable Set by software to enable clock security system on HSE. This bit is set only (disabled by a system reset or when the system enters in Standby mode). When HSECSSON is set, the clock detector is enabled by hardware when the HSE is ready and disabled by hardware if an oscillator failure is detected.
    $18 constant RCC_PLL1ON                     \ [0x18] PLL1 enable Set and cleared by software to enable PLL1. Cleared by hardware when entering Stop or Standby mode. Note that the hardware prevents writing this bit to 0, if the PLL1 output is used as the system clock (SW=3) or if FMCCKP = 1, or if XSPICKP = 1.
    $19 constant RCC_PLL1RDY                    \ [0x19] PLL1 clock ready flag Set by hardware to indicate that the PLL1 is locked.
    $1a constant RCC_PLL2ON                     \ [0x1a] PLL2 enable Set and cleared by software to enable PLL2. Cleared by hardware when entering Stop or Standby mode. Note that the hardware prevents writing this bit to 0, if FMCCKP = 1, or XSPICKP = 1.
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
    $00 constant RCC_HSICAL                     \ [0x00 : 12] HSI clock calibration Set by hardware by option byte loading. Adjusted by software through trimming bits HSITRIM. This field represents the sum of engineering option byte calibration value and HSITRIM bits value.
    $18 constant RCC_HSITRIM                    \ [0x18 : 7] HSI clock trimming Set by software to adjust calibration. HSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_HSI_opt) in order to form the calibration trimming value. HSICAL = HSITRIM + FLASH_HSI_opt. Note: The reset value of the field is 0x40.
  [then]


  [ifdef] RCC_RCC_CRRCR_DEF
    \
    \ @brief RCC clock recovery RC register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSI48CAL                   \ [0x00 : 10] Internal RC 48 MHz clock calibration Set by hardware by option byte loading. Read-only.
  [then]


  [ifdef] RCC_RCC_CSICFGR_DEF
    \
    \ @brief RCC CSI calibration register
    \ Address offset: 0x0C
    \ Reset value: 0x20000000
    \
    $00 constant RCC_CSICAL                     \ [0x00 : 8] CSI clock calibration Set by hardware by option byte loading. Adjusted by software through trimming bits CSITRIM. This field represents the sum of engineering option byte calibration value and CSITRIM bits value.
    $18 constant RCC_CSITRIM                    \ [0x18 : 6] CSI clock trimming Set by software to adjust calibration. CSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_CSI_opt) in order to form the calibration trimming value. CSICAL = CSITRIM + FLASH_CSI_opt. Note: The reset value of the field is 0x20.
  [then]


  [ifdef] RCC_RCC_CFGR_DEF
    \
    \ @brief RCC clock configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW                         \ [0x00 : 3] system clock switch Set and reset by software to select system clock source (sys_ck). Set by hardware in order to force the selection of the HSI or CSI (depending on STOPWUCK selection) when leaving a system Stop mode or in case of failure of the HSE when used directly or indirectly as system clock. others: reserved
    $03 constant RCC_SWS                        \ [0x03 : 3] system clock switch status Set and reset by hardware to indicate which clock source is used as system clock. others: reserved
    $06 constant RCC_STOPWUCK                   \ [0x06] system clock selection after a wake up from system Stop Set and reset by software to select the system wakeup clock from system Stop. The selected clock is also used as emergency clock for the clock security system (CSS) on HSE. See Section 1.: Dividers values can be changed on-the-fly. All dividers provide have 50% duty-cycles. for details. STOPWUCK must not be modified when CSS is enabled (by HSECSSON bit) and the system clock is HSE (SWS = 10) or a switch on HSE is requested (SW =10).
    $07 constant RCC_STOPKERWUCK                \ [0x07] kernel clock selection after a wake up from system Stop Set and reset by software to select the kernel wakeup clock from system Stop. See Section 1.: Dividers values can be changed on-the-fly. All dividers provide have 50% duty-cycles. for details.
    $08 constant RCC_RTCPRE                     \ [0x08 : 6] HSE division factor for RTC clock Set and cleared by software to divide the HSE to generate a clock for RTC. Caution: The software must set these bits correctly to ensure that the clock supplied to the RTC is lower than 1 MHz. These bits must be configured if needed before selecting the RTC clock source. ...
    $0f constant RCC_TIMPRE                     \ [0x0f] timers clocks prescaler selection This bit is set and reset by software to control the clock frequency of all the timers connected to APB1 and APB2 domains. or 4, else it is equal to 4 x F<sub>rcc_pclkx_d2</sub> Refer to Table 64: Ratio between clock timer and pclk for more details.
    $12 constant RCC_MCO1PRE                    \ [0x12 : 4] MCO1 prescaler Set and cleared by software to configure the prescaler of the MCO1. Modification of this prescaler may generate glitches on MCO1. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. ...
    $16 constant RCC_MCO1SEL                    \ [0x16 : 3] Microcontroller clock output 1 Set and cleared by software. Clock source selection may generate glitches on MCO1. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved
    $19 constant RCC_MCO2PRE                    \ [0x19 : 4] MCO2 prescaler Set and cleared by software to configure the prescaler of the MCO2. Modification of this prescaler may generate glitches on MCO2. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. ...
    $1d constant RCC_MCO2SEL                    \ [0x1d : 3] microcontroller clock output 2 Set and cleared by software. Clock source selection may generate glitches on MCO2. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved
  [then]


  [ifdef] RCC_RCC_CDCFGR_DEF
    \
    \ @brief RCC CPU domain clock configuration register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_CPRE                       \ [0x00 : 4] CPU domain core prescaler Set and reset by software to control the CPU clock division factor. Changing this division ratio has an impact on the frequency of the CPU clock and all bus matrix clocks. After changing this prescaler value, it takes up to 16 periods of the slowest APB clock before the new division ratio is taken into account. The application can check if the new division factor is taken into account by reading back this register. 0xxx: sys_ck not divided (default after reset)
  [then]


  [ifdef] RCC_RCC_BMCFGR_DEF
    \
    \ @brief RCC AHB clock configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_BMPRE                      \ [0x00 : 4] Bus matrix clock prescaler Set and reset by software to control the division factor of rcc_hclk[5:1] and rcc_aclk. This group of clocks is also named sys_bus_ck. Changing this division ratio has an impact on the frequency of all bus matrix clocks. 0xxx: sys_bus_ck= sys_cpu_ck (default after reset) Note: The clocks are divided by the new prescaler factor from 1 to 16 periods of the slowest APB clock among rcc_pclk1,2,4,5 after BMPRE update. Note: Note also that frequency of rcc_hclk[5:1] = rcc_aclk = sys_bus_ck.
  [then]


  [ifdef] RCC_RCC_APBCFGR_DEF
    \
    \ @brief RCC APB clocks configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PPRE1                      \ [0x00 : 3] CPU domain APB1 prescaler Set and reset by software to control the division factor of rcc_pclk1. The clock is divided by the new prescaler factor from 1 to 16 cycles of sys_bus_ck after PPRE1 write. 0xx: rcc_pclk1 = sys_bus_ck (default after reset)
    $04 constant RCC_PPRE2                      \ [0x04 : 3] CPU domain APB2 prescaler Set and reset by software to control the division factor of rcc_pclk2. The clock is divided by the new prescaler factor from 1 to 16 cycles of sys_bus_ck after PPRE2 write. 0xx: rcc_pclk2 = sys_bus_ck (default after reset)
    $08 constant RCC_PPRE4                      \ [0x08 : 3] CPU domain APB4 prescaler Set and reset by software to control the division factor of rcc_pclk4. The clock is divided by the new prescaler factor from 1 to 16 cycles of sys_bus_ck after PPRE4 write. 0xx: rcc_pclk4 = sys_bus_ck (default after reset)
    $0c constant RCC_PPRE5                      \ [0x0c : 3] CPU domain APB5 prescaler Set and reset by software to control the division factor of rcc_pclk5. The clock is divided by the new prescaler factor from 1 to 16 cycles of sys_bus_ck after PPRE5 write. 0xx: rcc_pclk5 = sys_bus_ck (default after reset)
  [then]


  [ifdef] RCC_RCC_PLLCKSELR_DEF
    \
    \ @brief RCC PLLs clock source selection register
    \ Address offset: 0x28
    \ Reset value: 0x02020200
    \
    $00 constant RCC_PLLSRC                     \ [0x00 : 2] DIVMx and PLLs clock source selection Set and reset by software to select the PLL clock source. These bits can be written only when all PLLs are disabled. In order to save power, when no PLL is used, PLLSRC must be set to 11.
    $04 constant RCC_DIVM1                      \ [0x04 : 6] prescaler for PLL1 Set and cleared by software to configure the prescaler of the PLL1. The hardware does not allow any modification of this prescaler when PLL1 is enabled (PLL1ON = 1). In order to save power when PLL1 is not used, the value of DIVM1 must be set to 0. ... ...
    $0c constant RCC_DIVM2                      \ [0x0c : 6] prescaler for PLL2 Set and cleared by software to configure the prescaler of the PLL2. The hardware does not allow any modification of this prescaler when PLL2 is enabled (PLL2ON = 1). In order to save power when PLL2 is not used, the value of DIVM2 must be set to 0. ... ...
    $14 constant RCC_DIVM3                      \ [0x14 : 6] prescaler for PLL3 Set and cleared by software to configure the prescaler of the PLL3. The hardware does not allow any modification of this prescaler when PLL3 is enabled (PLL3ON = 1). In order to save power when PLL3 is not used, the value of DIVM3 must be set to 0. ... ...
  [then]


  [ifdef] RCC_RCC_PLLCFGR_DEF
    \
    \ @brief RCC PLLs configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL1FRACLE                 \ [0x00] PLL1 fractional latch enable Set and reset by software to latch the content of FRACN into the sigma-delta modulator. In order to latch the FRACN value into the sigma-delta modulator, PLL1FRACLE must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN into the modulator. Refer to PLL initialization procedure on page 444 for additional information.
    $01 constant RCC_PLL1VCOSEL                 \ [0x01] PLL1 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL1. This bit must be written before enabling the PLL1. It allows the application to select the VCO range: VCOH: working from 400 to 1600 MHz (F<sub>ref1_ck</sub> must be between 2 and 16 MHz) VCOL: working from 150 to 420 MHz (F<sub>ref1_ck</sub> must be between 1 and 2 MHz)
    $02 constant RCC_PLL1SSCGEN                 \ [0x02] PLL1 SSCG enable Set and reset by software to enable the Spread Spectrum Clock Generator of PLL1, in order to reduce the amount of EMI peaks.
    $03 constant RCC_PLL1RGE                    \ [0x03 : 2] PLL1 input frequency range Set and reset by software to select the proper reference frequency range used for PLL1. This bit must be written before enabling the PLL1.
    $05 constant RCC_PLL1DIVPEN                 \ [0x05] PLL1 DIVP divider output enable Set and reset by software to enable the pll1_p_ck output of the PLL1. The hardware prevents writing this bit to 0, if the PLL1 output is used as the system clock (SW=3). In order to save power, when the pll1_p_ck output of the PLL1 is not used, the pll1_p_ck must be disabled.
    $06 constant RCC_PLL1DIVQEN                 \ [0x06] PLL1 DIVQ divider output enable Set and reset by software to enable the pll1_q_ck output of the PLL1. The hardware prevents writing this bit if FMCCKP = 1. In order to save power, when the pll1_q_ck output of the PLL1 is not used, the pll1_q_ck must be disabled.
    $07 constant RCC_PLL1DIVREN                 \ [0x07] PLL1 DIVR divider output enable Set and reset by software to enable the pll1_r_ck output of the PLL1. To save power, PLL1DIVREN and DIVR1 bits must be set to 0 when the pll1_r_ck is not used.
    $08 constant RCC_PLL1DIVSEN                 \ [0x08] PLL1 DIVS divider output enable Set and reset by software to enable the pll1_s_ck output of the PLL1. To save power, PLL1DIVSEN must be set to 0 when the pll1_s_ck is not used.
    $09 constant RCC_PLL1DIVTEN                 \ [0x09] PLL1 DIVT divider output enable Set and reset by software to enable the pll1_t_ck output of the PLL1. To save power, PLL1DIVTEN must be set to 0 when the pll1_t_ck is not used.
    $0b constant RCC_PLL2FRACLE                 \ [0x0b] PLL2 fractional latch enable Set and reset by software to latch the content of FRACN into the sigma-delta modulator. In order to latch the FRACN value into the sigma-delta modulator, PLL2FRACLE must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN into the modulator. Refer to PLL initialization procedure on page 444 for additional information.
    $0c constant RCC_PLL2VCOSEL                 \ [0x0c] PLL2 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL2. This bit must be written before enabling the PLL2. It allows the application to select the VCO range: VCOH: working from 400 to 1600 MHz (F<sub>ref2_ck</sub> must be between 2 and 16 MHz) VCOL: working from 150 to 420 MHz (F<sub>ref2_ck</sub> must be between 1 and 2 MHz)
    $0d constant RCC_PLL2SSCGEN                 \ [0x0d] PLL2 SSCG enable Set and reset by software to enable the Spread Spectrum Clock Generator of PLL2, in order to reduce the amount of EMI peaks.
    $0e constant RCC_PLL2RGE                    \ [0x0e : 2] PLL2 input frequency range Set and reset by software to select the proper reference frequency range used for PLL2. These bits must be written before enabling the PLL2.
    $10 constant RCC_PLL2DIVPEN                 \ [0x10] PLL2 DIVP divider output enable Set and reset by software to enable the pll2_p_ck output of the PLL2. To save power, PLL2DIVPEN and DIVP bits must be set to 0 when the pll2_p_ck is not used.
    $11 constant RCC_PLL2DIVQEN                 \ [0x11] PLL2 DIVQ divider output enable Set and reset by software to enable the pll2_q_ck output of the PLL2. To save power, PLL3DIVQEN and DIVQ bits must be set to 0 when the pll2_q_ck is not used.
    $12 constant RCC_PLL2DIVREN                 \ [0x12] PLL2 DIVR divider output enable Set and reset by software to enable the pll2_r_ck output of the PLL2. The hardware prevents writing this bit if FMCCKP = 1. To save power, PLL3DIVREN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used.
    $13 constant RCC_PLL2DIVSEN                 \ [0x13] PLL2 DIVS divider output enable Set and reset by software to enable the pll2_s_ck output of the PLL2. To save power, PLL2DIVSEN must be set to 0 when the pll2_s_ck is not used. The hardware prevents writing this bit if XSPICKP = 1.
    $14 constant RCC_PLL2DIVTEN                 \ [0x14] PLL2 DIVT divider output enable Set and reset by software to enable the pll2_t_ck output of the PLL2. To save power, PLL2DIVTEN must be set to 0 when the pll2_t_ck is not used. The hardware prevents writing this bit if XSPICKP = 1.
    $16 constant RCC_PLL3FRACLE                 \ [0x16] PLL3 fractional latch enable Set and reset by software to latch the content of FRACN into the sigma-delta modulator. In order to latch the FRACN value into the sigma-delta modulator, PLL3FRACLE must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN into the modulator. Refer to PLL initialization procedure on page 444 for additional information.
    $17 constant RCC_PLL3VCOSEL                 \ [0x17] PLL3 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL3. This bit must be written before enabling the PLL3. It allows the application to select the VCO range: VCOH: working from 400 to 1600 MHz (F<sub>ref2_ck</sub> must be between 2 and 16 MHz) VCOL: working from 150 to 420 MHz (F<sub>ref2_ck</sub> must be between 1 and 2 MHz)
    $18 constant RCC_PLL3SSCGEN                 \ [0x18] PLL3 SSCG enable Set and reset by software to enable the Spread Spectrum Clock Generator of PLL3, in order to reduce the amount of EMI peaks.
    $19 constant RCC_PLL3RGE                    \ [0x19 : 2] PLL3 input frequency range Set and reset by software to select the proper reference frequency range used for PLL3. These bits must be written before enabling the PLL3.
    $1b constant RCC_PLL3DIVPEN                 \ [0x1b] PLL3 DIVP divider output enable Set and reset by software to enable the pll3_p_ck output of the PLL3. To save power, PLL3DIVREN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used.
    $1c constant RCC_PLL3DIVQEN                 \ [0x1c] PLL3 DIVQ divider output enable Set and reset by software to enable the pll3_q_ck output of the PLL3. To save power, PLL3DIVREN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used.
    $1d constant RCC_PLL3DIVREN                 \ [0x1d] PLL3 DIVR divider output enable Set and reset by software to enable the pll3_r_ck output of the PLL3. To save power, PLL3DIVREN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used.
    $1e constant RCC_PLL3DIVSEN                 \ [0x1e] PLL3 DIVS divider output enable Set and reset by software to enable the pll3_s_ck output of the PLL3. To save power, PLL3DIVSEN must be set to 0 when the pll3_s_ck is not used.
    $1f constant RCC_PLL3DIVTEN                 \ [0x1f] PLL3 DIVT divider output enable Set and reset by software to enable the pll3_t_ck output of the PLL3. To save power, PLL1DIVTEN must be set to 0 when the pll3_t_ck is not used.
  [then]


  [ifdef] RCC_RCC_PLL1DIVR1_DEF
    \
    \ @brief RCC PLL1 dividers configuration register 1
    \ Address offset: 0x30
    \ Reset value: 0x01010280
    \
    $00 constant RCC_DIVN1                      \ [0x00 : 9] multiplication factor for PLL1 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL1ON = PLL1RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 544MHz if PLL1VCOSEL = 0 150 to 420 MHz if PLL1VCOSEL = 1 VCO output frequency = F<sub>ref1_ck</sub> x DIVN1, when fractional value 0 has been loaded into FRACN, with: DIVN1 between 8 and 420 The input frequency F<sub>ref1_ck</sub> must be between 1 and 16 MHz.
    $09 constant RCC_DIVP                       \ [0x09 : 7] PLL1 DIVP division factor Set and reset by software to control the frequency of the pll1_p_ck clock. These bits can be written only when the PLL1DIVPEN = 0. ...
    $10 constant RCC_DIVQ                       \ [0x10 : 7] PLL1 DIVQ division factor Set and reset by software to control the frequency of the pll1_q_ck clock. These bits can be written only when the PLL1DIVQEN = 0. ...
    $18 constant RCC_DIVR1                      \ [0x18 : 7] PLL1 DIVR division factor Set and reset by software to control the frequency of the pll1_r_ck clock. These bits can be written only when the PLL1DIVREN = 0. ...
  [then]


  [ifdef] RCC_RCC_PLL1FRACR_DEF
    \
    \ @brief RCC PLL1 fractional divider register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACN                      \ [0x03 : 13] fractional part of the multiplication factor for PLL1 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 544 MHz if PLL1VCOSEL = 0 150 to 420 MHz if PLL1VCOSEL = 1 VCO output frequency = F<sub>ref1_ck</sub> x (DIVN1 + (FRACN / 2<sup>13</sup>)), with DIVN1 between 8 and 420 FRACN can be between 0 and 2<sup>13</sup>- 1 The input frequency F<sub>ref1_ck</sub> must be between 1 and 16 MHz. To change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACLE to 0. Write the new fractional value into FRACN. Set the bit PLL1FRACLE to 1.
  [then]


  [ifdef] RCC_RCC_PLL2DIVR1_DEF
    \
    \ @brief RCC PLL2 dividers configuration register 1
    \ Address offset: 0x38
    \ Reset value: 0x01010280
    \
    $00 constant RCC_DIVN2                      \ [0x00 : 9] multiplication factor for PLL2 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL2ON = PLL2RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 544 MHz if PLL2VCOSEL = 0 150 to 420 MHz if PLL2VCOSEL = 1 VCO output frequency = F<sub>ref2_ck</sub> x DIVN2, when fractional value 0 has been loaded into FRACN, with DIVN2 between 8 and 420 The input frequency F<sub>ref2_ck</sub> must be between 1 and 16MHz.
    $09 constant RCC_DIVP                       \ [0x09 : 7] PLL2 DIVP division factor Set and reset by software to control the frequency of the pll2_p_ck clock. These bits can be written only when the PLL2DIVPEN = 0. ...
    $10 constant RCC_DIVQ                       \ [0x10 : 7] PLL2 DIVQ division factor Set and reset by software to control the frequency of the pll2_q_ck clock. These bits can be written only when the PLL2DIVQEN = 0. ...
    $18 constant RCC_DIVR2                      \ [0x18 : 7] PLL2 DIVR division factor Set and reset by software to control the frequency of the pll2_r_ck clock. These bits can be written only when the PLL2DIVREN = 0. ...
  [then]


  [ifdef] RCC_RCC_PLL2FRACR_DEF
    \
    \ @brief RCC PLL2 fractional divider register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACN                      \ [0x03 : 13] fractional part of the multiplication factor for PLL2 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 544 MHz if PLL2VCOSEL = 0 150 to 420 MHz if PLL2VCOSEL = 1 VCO output frequency = F<sub>ref2_ck</sub> x (DIVN2 + (FRACN / 2<sup>13</sup>)), with DIVN2 between 8 and 420 FRACN can be between 0 and 2<sup>13 </sup>- 1 The input frequency F<sub>ref2_ck</sub> must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL2FRACLE to 0. Write the new fractional value into FRACN. Set the bit PLL2FRACLE to 1.
  [then]


  [ifdef] RCC_RCC_PLL3DIVR1_DEF
    \
    \ @brief RCC PLL3 dividers configuration register 1
    \ Address offset: 0x40
    \ Reset value: 0x01010280
    \
    $00 constant RCC_DIVN3                      \ [0x00 : 9] Multiplication factor for PLL3 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL3ON = PLL3RDY = 0). ...........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 544 MHz if PLL3VCOSEL = 0 150 to 420 MHz if PLL3VCOSEL = 1 VCO output frequency = F<sub>ref3_ck</sub> x DIVN3, when fractional value 0 has been loaded into FRACN, with: DIVN3 between 8 and 420 The input frequency F<sub>ref3_ck</sub> must be between 1 and 16MHz
    $09 constant RCC_DIVP                       \ [0x09 : 7] PLL3 DIVP division factor Set and reset by software to control the frequency of the pll3_p_ck clock. These bits can be written only when the PLL3DIVPEN = 0. ...
    $10 constant RCC_DIVQ                       \ [0x10 : 7] PLL3 DIVQ division factor Set and reset by software to control the frequency of the pll3_q_ck clock. These bits can be written only when the PLL3DIVQEN = 0. ...
    $18 constant RCC_DIVR3                      \ [0x18 : 7] PLL3 DIVR division factor Set and reset by software to control the frequency of the pll3_r_ck clock. These bits can be written only when the PLL3DIVREN = 0. ...
  [then]


  [ifdef] RCC_RCC_PLL3FRACR_DEF
    \
    \ @brief RCC PLL3 fractional divider register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACN                      \ [0x03 : 13] fractional part of the multiplication factor for PLL3 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL3 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 544 MHz if PLL3VCOSEL = 0 150 to 420 MHz if PLL3VCOSEL = 1 VCO output frequency = F<sub>ref3_ck</sub> x (DIVN3 + (FRACN / 2<sup>13</sup>)), with DIVN3 between 8 and 420 FRACN can be between 0 and 2<sup>13 </sup>- 1 The input frequency F<sub>ref3_ck</sub> must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACLE to 0. Write the new fractional value into FRACN. Set the bit PLL1FRACLE to 1.
  [then]


  [ifdef] RCC_RCC_AHBPERCKSELR_DEF
    \
    \ @brief RCC AHB peripheral kernel clock selection register
    \ Address offset: 0x4C
    \ Reset value: 0x00000A00
    \
    $00 constant RCC_FMCSEL                     \ [0x00 : 2] FMC kernel clock source selection Set and reset by software.
    $02 constant RCC_SDMMCSEL                   \ [0x02] SDMMC1 and SDMMC2 kernel clock source selection Set and reset by software.
    $04 constant RCC_OCTOSPI1SEL                \ [0x04 : 2] XSPI1 kernel clock source selection Set and reset by software. 1x: pll2_t_ck selected as kernel peripheral clock
    $06 constant RCC_OCTOSPI2SEL                \ [0x06 : 2] XSPI2 kernel clock source selection Set and reset by software. 1x: pll2_t_ck selected as kernel peripheral clock
    $08 constant RCC_USBREFCKSEL                \ [0x08 : 4] USBPHYC kernel clock frequency selection Set and reset by software. This field is used to indicate to the USBPHYC, the frequency of the reference kernel clock provided to the USBPHYC. others: reserved
    $0c constant RCC_USBPHYCSEL                 \ [0x0c : 2] USBPHYC kernel clock source selection Set and reset by software.
    $0e constant RCC_OTGFSSEL                   \ [0x0e : 2] OTGFS kernel clock source selection Set and reset by software.
    $10 constant RCC_ETH1_REF_CLK_SEL           \ [0x10 : 2] Ethernet reference clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $12 constant RCC_ETHPHY_CLK_SEL             \ [0x12] Clock source selection for external Ethernet PHY Set and reset by software.
    $14 constant RCC_ADFSEL                     \ [0x14 : 3] ADF kernel clock source selection Set and reset by software. Note: I2S_CKIN is an external clock taken from a pin.
    $18 constant RCC_ADCSEL                     \ [0x18 : 2] SAR ADC kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $1b constant RCC_PSSISEL                    \ [0x1b] PSSI kernel clock source selection Set and reset by software.
    $1c constant RCC_CKPERSEL                   \ [0x1c : 2] per_ck clock source selection
  [then]


  [ifdef] RCC_RCC_APB1PERCKSELR_DEF
    \
    \ @brief RCC APB1 peripherals kernel clock selection register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART234578SEL              \ [0x00 : 3] USART2,3, UART4,5,7,8 (APB1) kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $04 constant RCC_SPI23SEL                   \ [0x04 : 3] SPI/I2S2 and SPI/I2S3 kernel clock source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not be possible to switch to another clock. Refer to Clock switches and gating on page 437 for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin.
    $08 constant RCC_I2C23SEL                   \ [0x08 : 2] I2C2, I2C3 kernel clock source selection Set and reset by software.
    $0c constant RCC_I2C1_I3C1SEL               \ [0x0c : 2] I2C1 or I3C1 kernel clock source selection Set and reset by software.
    $10 constant RCC_LPTIM1SEL                  \ [0x10 : 3] LPTIM1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $16 constant RCC_FDCANSEL                   \ [0x16 : 2] FDCAN kernel clock source selection
    $18 constant RCC_SPDIFRXSEL                 \ [0x18 : 2] SPDIFRX kernel clock source selection
    $1c constant RCC_CECSEL                     \ [0x1c : 2] HDMI-CEC kernel clock source selection Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB2PERCKSELR_DEF
    \
    \ @brief RCC APB2 peripherals kernel clock selection register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL                  \ [0x00 : 3] USART1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $04 constant RCC_SPI45SEL                   \ [0x04 : 3] SPI4 and 5 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $08 constant RCC_SPI1SEL                    \ [0x08 : 3] SPI/I2S1 kernel clock source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not be possible to switch to another clock. Refer to Clock switches and gating on page 437 for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin.
    $10 constant RCC_SAI1SEL                    \ [0x10 : 3] SAI1 kernel clock source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not possible to switch to another clock. Refer to Clock switches and gating on page 437 for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin.
    $14 constant RCC_SAI2SEL                    \ [0x14 : 3] SAI2 kernel clock source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not possible to switch to another clock. Refer to Clock switches and gating on page 437 for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin. spdifrx_symb_ck is the symbol clock generated by the spdifrx (see Figure 51).
  [then]


  [ifdef] RCC_RCC_APB45PERCKSELR_DEF
    \
    \ @brief RCC APB4,5 peripherals kernel clock selection register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPUART1SEL                 \ [0x00 : 3] LPUART1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $04 constant RCC_SPI6SEL                    \ [0x04 : 3] SPI/I2S6 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $08 constant RCC_LPTIM23SEL                 \ [0x08 : 3] LPTIM2 and LPTIM3 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $0c constant RCC_LPTIM45SEL                 \ [0x0c : 3] LPTIM4, and LPTIM5 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_CIER_DEF
    \
    \ @brief RCC clock source interrupt enable register
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
    \ @brief RCC clock source interrupt flag register
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
    \ @brief RCC clock source interrupt clear register
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
    \ Reset value: 0x00000010
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enabled Set and reset by software.
    $01 constant RCC_LSERDY                     \ [0x01] LSE oscillator ready Set and reset by hardware to indicate when the LSE is stable. This bit needs 6 cycles of lse_ck clock to fall down after LSEON has been set to 0.
    $02 constant RCC_LSEBYP                     \ [0x02] LSE oscillator bypass Set and reset by software to bypass oscillator in debug mode. This bit must not be written when the LSE is enabled (by LSEON) or ready (LSERDY = 1)
    $03 constant RCC_LSEDRV                     \ [0x03 : 2] LSE oscillator driving capability Set by software to select the driving capability of the LSE oscillator.
    $05 constant RCC_LSECSSON                   \ [0x05] LSE clock security system enable Set by software to enable the clock security system on 32 kHz oscillator. LSECSSON must be enabled after LSE is enabled (LSEON enabled) and ready (LSERDY set by hardware) and after RTCSEL is selected. Once enabled, this bit can only be disabled, After a LSE failure detection (LSECSSD = 1). In that case the software must disable LSECSSON. After a back-up domain reset
    $06 constant RCC_LSECSSD                    \ [0x06] LSE clock security system failure detection Set by hardware to indicate when a failure has been detected by the clock security system on the external 32 kHz oscillator.
    $07 constant RCC_LSEEXT                     \ [0x07] low-speed external clock type in Bypass mode Set and reset by software to select the external clock type (analog or digital). The external clock must be enabled with the LSEON bit, to be used by the device. The LSEEXT bit can be written only if the LSE oscillator is disabled.
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC clock source selection Set by software to select the clock source for the RTC. These bits can be written only one time (except in case of failure detection on LSE). These bits must be written before LSECSSON is enabled. The VSWRST bit can be used to reset them, then it can be written one time again. If HSE is selected as RTC clock, this clock is lost when the system is in Stop mode or in case of a pin reset (NRST).
    $0c constant RCC_LSECSSRA                   \ [0x0c] Re-Arm the LSECSS function Set by software. After a LSE failure detection, the software application can re-enable the LSECSS by writing this bit to 1. Reading this bit returns the written value. Prior to set this bit to 1, LSECSSON must be set to 0. Please refer to Section : CSS on LSE for details.
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable Set and reset by software.
    $10 constant RCC_VSWRST                     \ [0x10] VSwitch domain software reset Set and reset by software. To generate a VSW reset, it is recommended to write this bit to 1, then back to 0.
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


  [ifdef] RCC_RCC_AHB5RSTR_DEF
    \
    \ @brief RCC AHB5 peripheral reset register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPDMA1RST                  \ [0x00] HPDMA1 block reset Set and reset by software.
    $01 constant RCC_DMA2DRST                   \ [0x01] DMA2D block reset Set and reset by software.
    $03 constant RCC_JPEGRST                    \ [0x03] JPEG block reset Set and reset by software.
    $04 constant RCC_FMCRST                     \ [0x04] FMC and MCE3 blocks reset Set and reset by software. The hardware prevents writing this bit if FMCCKP = 1.
    $05 constant RCC_XSPI1RST                   \ [0x05] XSPI1 and MCE1 blocks reset Set and reset by software. The hardware prevents writing this bit if XSPICKP = 1.
    $08 constant RCC_SDMMC1RST                  \ [0x08] SDMMC1 and DB_SDMMC1 blocks reset Set and reset by software.
    $0c constant RCC_XSPI2RST                   \ [0x0c] XSPI2 and MCE2 blocks reset Set and reset by software. The hardware prevents writing this bit if XSPICKP = 1.
    $0e constant RCC_IOMNGRRST                  \ [0x0e] XSPIM reset Set and reset by software.
    $13 constant RCC_GFXMMURST                  \ [0x13] GFXMMU block reset Set and reset by software.
    $14 constant RCC_GPURST                     \ [0x14] GPU block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB1RSTR_DEF
    \
    \ @brief RCC AHB1 peripheral reset register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $04 constant RCC_GPDMA1RST                  \ [0x04] GPDMA1 blocks reset Set and reset by software.
    $05 constant RCC_ADC12RST                   \ [0x05] ADC1 and 2 blocks reset Set and reset by software.
    $0f constant RCC_ETH1RST                    \ [0x0f] ETH1 block reset Set and reset by software.
    $19 constant RCC_OTGHSRST                   \ [0x19] OTGHS block reset Set and reset by software.
    $1a constant RCC_USBPHYCRST                 \ [0x1a] USBPHYC block reset Set and reset by software.
    $1b constant RCC_OTGFSRST                   \ [0x1b] OTGFS block reset Set and reset by software.
    $1f constant RCC_ADFRST                     \ [0x1f] ADF block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB2RSTR_DEF
    \
    \ @brief RCC AHB2 peripheral reset register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $01 constant RCC_PSSIRST                    \ [0x01] PSSI block reset Set and reset by software.
    $09 constant RCC_SDMMC2RST                  \ [0x09] SDMMC2 and SDMMC2 delay blocks reset Set and reset by software.
    $0e constant RCC_CORDICRST                  \ [0x0e] CORDIC reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB4RSTR_DEF
    \
    \ @brief RCC AHB4 peripheral reset register
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
    $0c constant RCC_GPIOMRST                   \ [0x0c] GPIOM block reset Set and reset by software.
    $0d constant RCC_GPIONRST                   \ [0x0d] GPION block reset Set and reset by software.
    $0e constant RCC_GPIOORST                   \ [0x0e] GPIOO block reset Set and reset by software.
    $0f constant RCC_GPIOPRST                   \ [0x0f] GPIOP block reset Set and reset by software.
    $13 constant RCC_CRCRST                     \ [0x13] CRC block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB5RSTR_DEF
    \
    \ @brief RCC APB5 peripheral reset register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_LTDCRST                    \ [0x01] LTDC block reset Set and reset by software.
    $02 constant RCC_DCMIPPRST                  \ [0x02] DCMIPP block reset Set and reset by software.
    $04 constant RCC_GFXTIMRST                  \ [0x04] GFXTIM block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1RSTR1_DEF
    \
    \ @brief RCC APB1 peripheral reset register 1
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
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2S2 block reset Set and reset by software.
    $0f constant RCC_SPI3RST                    \ [0x0f] SPI2S3 block reset Set and reset by software.
    $10 constant RCC_SPDIFRXRST                 \ [0x10] SPDIFRX block reset Set and reset by software.
    $11 constant RCC_USART2RST                  \ [0x11] USART2 block reset Set and reset by software.
    $12 constant RCC_USART3RST                  \ [0x12] USART3 block reset Set and reset by software.
    $13 constant RCC_UART4RST                   \ [0x13] UART4 block reset Set and reset by software.
    $14 constant RCC_UART5RST                   \ [0x14] UART5 block reset Set and reset by software.
    $15 constant RCC_I2C1_I3C1RST               \ [0x15] I2C1/I3C1 block reset Set and reset by software.
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 block reset Set and reset by software.
    $17 constant RCC_I2C3RST                    \ [0x17] I2C3 block reset Set and reset by software.
    $1b constant RCC_HDMICECRST                 \ [0x1b] HDMI-CEC block reset Set and reset by software.
    $1e constant RCC_UART7RST                   \ [0x1e] UART7 block reset Set and reset by software.
    $1f constant RCC_UART8RST                   \ [0x1f] UART8 block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1RSTR2_DEF
    \
    \ @brief RCC APB1 peripheral reset register 2
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $01 constant RCC_CRSRST                     \ [0x01] clock recovery system reset Set and reset by software.
    $05 constant RCC_MDIOSRST                   \ [0x05] MDIOS block reset Set and reset by software.
    $08 constant RCC_FDCANRST                   \ [0x08] FDCAN block reset Set and reset by software.
    $1b constant RCC_UCPDRST                    \ [0x1b] UCPD block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB2RSTR_DEF
    \
    \ @brief RCC APB2 peripheral reset register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1RST                    \ [0x00] TIM1 block reset Set and reset by software.
    $04 constant RCC_USART1RST                  \ [0x04] USART1 block reset Set and reset by software.
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI2S1 block reset Set and reset by software.
    $0d constant RCC_SPI4RST                    \ [0x0d] SPI4 block reset Set and reset by software.
    $10 constant RCC_TIM15RST                   \ [0x10] TIM15 block reset Set and reset by software.
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 block reset Set and reset by software.
    $12 constant RCC_TIM17RST                   \ [0x12] TIM17 block reset Set and reset by software.
    $13 constant RCC_TIM9RST                    \ [0x13] TIM9 block reset Set and reset by software.
    $14 constant RCC_SPI5RST                    \ [0x14] SPI5 block reset Set and reset by software.
    $16 constant RCC_SAI1RST                    \ [0x16] SAI1 block reset Set and reset by software.
    $17 constant RCC_SAI2RST                    \ [0x17] SAI2 block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB4RSTR_DEF
    \
    \ @brief RCC APB4 peripheral reset register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SBSRST                     \ [0x01] SBS block reset Set and reset by software.
    $03 constant RCC_LPUART1RST                 \ [0x03] LPUART1 block reset Set and reset by software.
    $05 constant RCC_SPI6RST                    \ [0x05] SPI/I2S6 block reset Set and reset by software.
    $09 constant RCC_LPTIM2RST                  \ [0x09] LPTIM2 block reset Set and reset by software.
    $0a constant RCC_LPTIM3RST                  \ [0x0a] LPTIM3 block reset Set and reset by software.
    $0b constant RCC_LPTIM4RST                  \ [0x0b] LPTIM4 block reset Set and reset by software.
    $0c constant RCC_LPTIM5RST                  \ [0x0c] LPTIM5 block reset Set and reset by software.
    $0f constant RCC_VREFRST                    \ [0x0f] VREF block reset Set and reset by software.
    $1a constant RCC_TMPSENSRST                 \ [0x1a] TMPSENS block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB3RSTR_DEF
    \
    \ @brief RCC AHB3 peripheral reset register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RNGRST                     \ [0x00] random number generator block reset Set and reset by software.
    $01 constant RCC_HASHRST                    \ [0x01] HASH block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_CKGDISR_DEF
    \
    \ @brief RCC AXI clocks gating disable register
    \ Address offset: 0xB0
    \ Reset value: 0x80000000
    \
    $00 constant RCC_AXICKG                     \ [0x00] AXI interconnect matrix clock gating disable This bit is set and reset by software.
    $01 constant RCC_AHBMCKG                    \ [0x01] AXI master AHB clock gating disable This bit is set and reset by software.
    $02 constant RCC_SDMMC1CKG                  \ [0x02] AXI master SDMMC1 clock gating disable This bit is set and reset by software.
    $03 constant RCC_HPDMA1CKG                  \ [0x03] AXI master HPDMA1 clock gating disable This bit is set and reset by software.
    $04 constant RCC_CPUCKG                     \ [0x04] AXI master CPU clock gating disable This bit is set and reset by software.
    $05 constant RCC_GPUS0CKG                   \ [0x05] AXI master 0 GPU clock gating disable This bit is set and reset by software.
    $06 constant RCC_GPUS1CKG                   \ [0x06] AXI master 1 GPU clock gating disable This bit is set and reset by software.
    $07 constant RCC_GPUCLCKG                   \ [0x07] AXI master cache GPU clock gating disable This bit is set and reset by software.
    $08 constant RCC_DCMIPPCKG                  \ [0x08] AXI master DCMIPP clock gating disable This bit is set and reset by software.
    $09 constant RCC_DMA2DCKG                   \ [0x09] AXI master DMA2D clock gating disable This bit is set and reset by software.
    $0a constant RCC_GFXMMUSCKG                 \ [0x0a] AXI matrix slave GFXMMU clock gating disable This bit is set and reset by software.
    $0b constant RCC_LTDCCKG                    \ [0x0b] AXI master LTDC clock gating disable This bit is set and reset by software.
    $0c constant RCC_GFXMMUMCKG                 \ [0x0c] AXI master GFXMMU clock gating disable This bit is set and reset by software.
    $0d constant RCC_AHBSCKG                    \ [0x0d] AXI slave AHB clock gating disable This bit is set and reset by software.
    $0e constant RCC_FMCCKG                     \ [0x0e] AXI slave FMC and MCE3 clock gating disable This bit is set and reset by software.
    $0f constant RCC_XSPI1CKG                   \ [0x0f] AXI slave XSPI1 and MCE1 clock gating disable This bit is set and reset by software.
    $10 constant RCC_XSPI2CKG                   \ [0x10] AXI slave XSPI2 and MCE2 clock gating disable This bit is set and reset by software.
    $11 constant RCC_AXIRAM4CKG                 \ [0x11] AXI matrix slave SRAM4 clock gating disable This bit is set and reset by software.
    $12 constant RCC_AXIRAM3CKG                 \ [0x12] AXI matrix slave SRAM3 clock gating disable This bit is set and reset by software.
    $13 constant RCC_AXIRAM2CKG                 \ [0x13] AXI slave SRAM2 clock gating disable This bit is set and reset by software.
    $14 constant RCC_AXIRAM1CKG                 \ [0x14] AXI slave SRAM1 / error code correction (ECC) clock gating disable This bit is set and reset by software.
    $15 constant RCC_FLITFCKG                   \ [0x15] AXI slave Flash interface (FLIFT) clock gating disable This bit is set and reset by software.
    $1e constant RCC_EXTICKG                    \ [0x1e] EXTI clock gating disable This bit is set and reset by software.
    $1f constant RCC_JTAGCKG                    \ [0x1f] JTAG automatic clock gating disabling This bit is set and reset by software.
  [then]


  [ifdef] RCC_RCC_PLL1DIVR2_DEF
    \
    \ @brief RCC PLL1 dividers configuration register 2
    \ Address offset: 0xC0
    \ Reset value: 0x00000101
    \
    $00 constant RCC_DIVS                       \ [0x00 : 3] PLL1 DIVS division factor Set and reset by software to control the frequency of the pll1_s_ck clock. This post-divider performs divisions with 50% duty-cycle. The duty-cycle of 50% is guaranteed only in the following conditions: With VCOL, if (DIVS+1) is even, With VCOH, for all DIVS values These bits can be written only when the PLL1DIVSEN = 0.
    $08 constant RCC_DIVT                       \ [0x08 : 3] PLL1 DIVT division factor Set and reset by software to control the frequency of the pll1_t_ck clock. This post-divider performs divisions with 50% duty-cycle. The duty-cycle of 50% is guaranteed only in the following conditions: With VCOL, if (DIVT+1) is even, With VCOH, for all DIVT values These bits can be written only when the PLL1DIVTEN = 0.
  [then]


  [ifdef] RCC_RCC_PLL2DIVR2_DEF
    \
    \ @brief RCC PLL2 dividers configuration register 2
    \ Address offset: 0xC4
    \ Reset value: 0x00000101
    \
    $00 constant RCC_DIVS                       \ [0x00 : 3] PLL2 DIVS division factor Set and reset by software to control the frequency of the pll2_s_ck clock. This post-divider performs divisions with 50% duty-cycle. The duty-cycle of 50% is guaranteed only in the following conditions: With VCOL, if (DIVS+1) is even, With VCOH, for all DIVS values These bits can be written only when the PLL2DIVSEN = 0.
    $08 constant RCC_DIVT                       \ [0x08 : 3] PLL2 DIVT division factor Set and reset by software to control the frequency of the pll2_t_ck clock. This post-divider performs divisions with 50% duty-cycle. The duty-cycle of 50% is guaranteed only in the following conditions: With VCOL, if (DIVT+1) is even, With VCOH, for all DIVT values These bits can be written only when the PLL2DIVTEN = 0.
  [then]


  [ifdef] RCC_RCC_PLL3DIVR2_DEF
    \
    \ @brief RCC PLL3 dividers configuration register 2
    \ Address offset: 0xC8
    \ Reset value: 0x00000101
    \
    $00 constant RCC_DIVS                       \ [0x00 : 3] PLL3 DIVS division factor Set and reset by software to control the frequency of the pll3_s_ck clock. This post-divider performs divisions with 50% duty-cycle. The duty-cycle of 50% is guaranteed only in the following conditions: With VCOL, if (DIVS+1) is even, With VCOH, for all DIVS values These bits can be written only when the PLL3DIVSEN = 0.
    $08 constant RCC_DIVT                       \ [0x08 : 3] PLL3 DIVT division factor Set and reset by software to control the frequency of the pll3_t_ck clock. This post-divider performs divisions with 50% duty-cycle. The duty-cycle of 50% is guaranteed only in the following conditions: With VCOL, if (DIVT+1) is even, With VCOH, for all DIVT values These bits can be written only when the PLL3DIVTEN = 0.
  [then]


  [ifdef] RCC_RCC_PLL1SSCGR_DEF
    \
    \ @brief RCC PLL1 Spread Spectrum Clock Generator register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MOD_PER                    \ [0x00 : 13] Modulation Period Adjustment for PLL1 Set and reset by software to adjust the modulation period of the clock spreading generator.
    $0d constant RCC_TPDFN_DIS1                 \ [0x0d] Dithering TPDF noise control for PLL1 Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
    $0e constant RCC_RPDFN_DIS1                 \ [0x0e] Dithering RPDF noise control for PLL1 Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
    $0f constant RCC_DWNSPREAD1                 \ [0x0f] Spread spectrum clock generator mode for PLL1 Set and reset by software to select the clock spreading mode.
    $10 constant RCC_INC_STEP                   \ [0x10 : 15] Modulation Depth Adjustment for PLL1 Set and reset by software to adjust the modulation depth of the clock spreading generator.
  [then]


  [ifdef] RCC_RCC_PLL2SSCGR_DEF
    \
    \ @brief RCC PLL2 Spread Spectrum Clock Generator register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MOD_PER                    \ [0x00 : 13] Modulation Period Adjustment for PLL2 Set and reset by software to adjust the modulation period of the clock spreading generator.
    $0d constant RCC_TPDFN_DIS2                 \ [0x0d] Dithering TPDF noise control for PLL2 Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
    $0e constant RCC_RPDFN_DIS2                 \ [0x0e] Dithering RPDF noise control for PLL2 Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
    $0f constant RCC_DWNSPREAD2                 \ [0x0f] Spread spectrum clock generator mode for PLL2 Set and reset by software to select the clock spreading mode.
    $10 constant RCC_INC_STEP                   \ [0x10 : 15] Modulation Depth Adjustment for PLL2 Set and reset by software to adjust the modulation depth of the clock spreading generator.
  [then]


  [ifdef] RCC_RCC_PLL3SSCGR_DEF
    \
    \ @brief RCC PLL3 Spread Spectrum Clock Generator register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MOD_PER                    \ [0x00 : 13] Modulation Period Adjustment for PLL3 Set and reset by software to adjust the modulation period of the clock spreading generator.
    $0d constant RCC_TPDFN_DIS3                 \ [0x0d] Dithering TPDF noise control for PLL3 Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
    $0e constant RCC_RPDFN_DIS3                 \ [0x0e] Dithering RPDF noise control for PLL3 Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
    $0f constant RCC_DWNSPREAD3                 \ [0x0f] Spread spectrum clock generator mode for PLL3 Set and reset by software to select the clock spreading mode.
    $10 constant RCC_INC_STEP                   \ [0x10 : 15] Modulation Depth Adjustment for PLL3 Set and reset by software to adjust the modulation depth of the clock spreading generator.
  [then]


  [ifdef] RCC_RCC_CKPROTR_DEF
    \
    \ @brief RCC clock protection register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant RCC_XSPICKP                    \ [0x00] XSPI clock protection Set and cleared by software. When set to 1, this bit prevents disabling accidentally the XSPIs. The following fields cannot be modified when this bit is set to 1: PLL2ON, PLL2DIVSEN, PLL2DIVTEN, HSEON, HSION, CSION, XSPIxEN, OCTOSPIxLPEN, OCTOSPIxRST.
    $01 constant RCC_FMCCKP                     \ [0x01] FMC clock protection Set and cleared by software. When set to 1, this bit prevents disabling accidentally the FMC. The following fields cannot be modified when this bit is set to 1: PLL1ON, PLL2ON, PLL1DIVQEN, PLL2DIVREN, HSEON, HSION, CSION, FMCEN, FMCLPEN, FMCRST.
    $04 constant RCC_XSPI1SWP                   \ [0x04 : 3] XSPI1 kernel clock switch position Set by hardware. This field can be used to verify the real position of XSPI2 kernel switch selector.
    $08 constant RCC_XSPI2SWP                   \ [0x08 : 3] XSPI2 kernel clock switch position Set by hardware. This field can be used to verify the real position of XSPI2 kernel switch selector.
    $0c constant RCC_FMCSWP                     \ [0x0c : 3] FMC kernel clock switch position Set by hardware. This field can be used to verify the real position of FMC kernel switch selector.
  [then]


  [ifdef] RCC_RCC_RSR_DEF
    \
    \ @brief RCC Reset status register
    \ Address offset: 0x130
    \ Reset value: 0x00E00000
    \
    $10 constant RCC_RMVF                       \ [0x10] remove reset flag Set and reset by software to reset the value of the reset flags.
    $11 constant RCC_OBLRSTF                    \ [0x11] Option byte loading reset flag <sup>(1)</sup> Reset by software by the RMVF bit. Set by hardware when a reset from the option byte loading occurs.
    $15 constant RCC_BORRSTF                    \ [0x15] BOR reset flag <sup>(1)</sup> Reset by software by writing the RMVF bit. Set by hardware when a BOR reset occurs (pwr_bor_rst).
    $16 constant RCC_PINRSTF                    \ [0x16] pin reset flag (NRST) <sup>(1)</sup> Reset by software by writing the RMVF bit. Set by hardware when a reset from pin occurs.
    $17 constant RCC_PORRSTF                    \ [0x17] POR/PDR reset flag <sup>(1)</sup> Reset by software by writing the RMVF bit. Set by hardware when a POR/PDR reset occurs.
    $18 constant RCC_SFTRSTF                    \ [0x18] system reset from CPU reset flag <sup>(1)</sup> Reset by software by writing the RMVF bit. Set by hardware when the system reset is due to CPU.The CPU can generate a system reset by writing SYSRESETREQ bit of AIRCR register of the core M7.
    $1a constant RCC_IWDGRSTF                   \ [0x1a] independent watchdog reset flag <sup>(1)</sup> Reset by software by writing the RMVF bit. Set by hardware when an independent watchdog reset occurs.
    $1c constant RCC_WWDGRSTF                   \ [0x1c] window watchdog reset flag <sup>(1)</sup> Reset by software by writing the RMVF bit. Set by hardware when a window watchdog reset occurs.
    $1e constant RCC_LPWRRSTF                   \ [0x1e] reset due to illegal Stop or Standby flag Reset by software by writing the RMVF bit. Set by hardware when the CPU goes erroneously in Stop or Standby mode,
  [then]


  [ifdef] RCC_RCC_AHB5ENR_DEF
    \
    \ @brief RCC AHB5 clock enable register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPDMA1EN                   \ [0x00] HPDMA1 peripheral clock enable Set and reset by software.
    $01 constant RCC_DMA2DEN                    \ [0x01] DMA2D peripheral clock enable Set and reset by software.
    $03 constant RCC_JPEGEN                     \ [0x03] JPEG peripheral clock enable Set and reset by software.
    $04 constant RCC_FMCEN                      \ [0x04] FMC and MCE3 peripheral clocks enable Set and reset by software. The hardware prevents writing this bit if FMCCKP = 1. The peripheral clocks of the FMC are the kernel clock selected by FMCSEL, and the hclk5 bus interface clock.
    $05 constant RCC_XSPI1EN                    \ [0x05] XSPI1 and MCE1 peripheral clocks enable Set and reset by software. The hardware prevents writing this bit if XSPICKP = 1.
    $08 constant RCC_SDMMC1EN                   \ [0x08] SDMMC1 and DB_SDMMC1 peripheral clocks enable Set and reset by software.
    $0c constant RCC_XSPI2EN                    \ [0x0c] XSPI2 and MCE2 peripheral clocks enable Set and reset by software. The hardware prevents writing this bit if XSPICKP = 1.
    $0e constant RCC_IOMNGREN                   \ [0x0e] XSPIM peripheral clock enable Set and reset by software.
    $13 constant RCC_GFXMMUEN                   \ [0x13] GFXMMU peripheral clock enable Set and reset by software.
    $14 constant RCC_GPUEN                      \ [0x14] GPU peripheral clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB1ENR_DEF
    \
    \ @brief RCC AHB1 clock enable register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $04 constant RCC_GPDMA1EN                   \ [0x04] GPDMA1 clock enable Set and reset by software.
    $05 constant RCC_ADC12EN                    \ [0x05] ADC1 and 2 peripheral clocks enable Set and reset by software. The peripheral clocks of the ADC1 and 2 are the kernel clock selected by ADCSEL and provided to ADCx_CK input, and the hclk1 bus interface clock.
    $0f constant RCC_ETH1MACEN                  \ [0x0f] ETH1 MAC peripheral clock enable Set and reset by software.
    $10 constant RCC_ETH1TXEN                   \ [0x10] ETH1 transmission clock enable Set and reset by software.
    $11 constant RCC_ETH1RXEN                   \ [0x11] ETH1 reception clock enable Set and reset by software.
    $19 constant RCC_OTGHSEN                    \ [0x19] OTGHS clocks enable Set and reset by software.
    $1a constant RCC_USBPHYCEN                  \ [0x1a] USBPHYC clocks enable Set and reset by software.
    $1b constant RCC_OTGFSEN                    \ [0x1b] OTGFS peripheral clocks enable Set and reset by software.
    $1f constant RCC_ADFEN                      \ [0x1f] ADF clocks enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB2ENR_DEF
    \
    \ @brief RCC AHB2 clock enable register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_PSSIEN                     \ [0x01] PSSI peripheral clocks enable Set and reset by software.
    $09 constant RCC_SDMMC2EN                   \ [0x09] SDMMC2 and SDMMC2 delay clock enable Set and reset by software.
    $0e constant RCC_CORDICEN                   \ [0x0e] CORDIC clock enable Set and reset by software.
    $1d constant RCC_SRAM1EN                    \ [0x1d] SRAM1 clock enable Set and reset by software.
    $1e constant RCC_SRAM2EN                    \ [0x1e] SRAM2 clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB4ENR_DEF
    \
    \ @brief RCC AHB4 clock enable register
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
    $0c constant RCC_GPIOMEN                    \ [0x0c] GPIOM peripheral clock enable Set and reset by software.
    $0d constant RCC_GPIONEN                    \ [0x0d] GPION peripheral clock enable Set and reset by software.
    $0e constant RCC_GPIOOEN                    \ [0x0e] GPIOO peripheral clock enable Set and reset by software.
    $0f constant RCC_GPIOPEN                    \ [0x0f] GPIOP peripheral clock enable Set and reset by software.
    $13 constant RCC_CRCEN                      \ [0x13] CRC clock enable Set and reset by software.
    $1c constant RCC_BKPRAMEN                   \ [0x1c] Backup RAM clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB5ENR_DEF
    \
    \ @brief RCC APB5 clock enable register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $01 constant RCC_LTDCEN                     \ [0x01] LTDC peripheral clock enable Provides the pixel clock (ltdc_clk) to the LTDC block. Set and reset by software.
    $02 constant RCC_DCMIPPEN                   \ [0x02] DCMIPP peripheral clock enable Set and reset by software.
    $04 constant RCC_GFXTIMEN                   \ [0x04] GFXTIM peripheral clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1ENR1_DEF
    \
    \ @brief RCC APB1 clock enable register 1
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
    $09 constant RCC_LPTIM1EN                   \ [0x09] LPTIM1 peripheral clocks enable Set and reset by software. The peripheral clocks of the LPTIM1 are the kernel clock selected by LPTIM1SEL and provided to clk_lpt input, and the rcc_pclk1 bus interface clock.
    $0b constant RCC_WWDGEN                     \ [0x0b] WWDG clock enable Set by software, and reset by hardware when a system reset occurs.
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI2 are the kernel clock selected by I2S123SRC and provided to com_clk input, and the rcc_pclk1 bus interface clock.
    $0f constant RCC_SPI3EN                     \ [0x0f] SPI3 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI3 are the kernel clock selected by I2S123SRC and provided to com_clk input, and the rcc_pclk1 bus interface clock.
    $10 constant RCC_SPDIFRXEN                  \ [0x10] SPDIFRX peripheral clocks enable Set and reset by software. The peripheral clocks of the SPDIFRX are the kernel clock selected by SPDIFRXSEL and provided to SPDIFRX_CLK input, and the rcc_pclk1 bus interface clock.
    $11 constant RCC_USART2EN                   \ [0x11] USART2peripheral clocks enable Set and reset by software. The peripheral clocks of the USART2 are the kernel clock selected by USART234578SEL and provided to UCLK input, and the rcc_pclk1 bus interface clock.
    $12 constant RCC_USART3EN                   \ [0x12] USART3 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART3 are the kernel clock selected by USART234578SEL and provided to UCLK input, and the rcc_pclk1 bus interface clock.
    $13 constant RCC_UART4EN                    \ [0x13] UART4 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART4 are the kernel clock selected by USART234578SEL and provided to UCLK input, and the rcc_pclk1 bus interface clock.
    $14 constant RCC_UART5EN                    \ [0x14] UART5 peripheral clocks enable Set and reset by software.
    $15 constant RCC_I2C1_I3C1EN                \ [0x15] I2C1/I3C1 peripheral clocks enable Set and reset by software.
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 peripheral clocks enable Set and reset by software.
    $17 constant RCC_I2C3EN                     \ [0x17] I2C3 peripheral clocks enable Set and reset by software.
    $1b constant RCC_HDMICECEN                  \ [0x1b] HDMI-CEC peripheral clock enable Set and reset by software.
    $1e constant RCC_UART7EN                    \ [0x1e] UART7 peripheral clocks enable Set and reset by software.
    $1f constant RCC_UART8EN                    \ [0x1f] UART8 peripheral clocks enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1ENR2_DEF
    \
    \ @brief RCC APB1 clock enable register 2
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_CRSEN                      \ [0x01] clock recovery system peripheral clock enable Set and reset by software.
    $05 constant RCC_MDIOSEN                    \ [0x05] MDIOS peripheral clock enable Set and reset by software.
    $08 constant RCC_FDCANEN                    \ [0x08] FDCAN peripheral clock enable Set and reset by software.
    $1b constant RCC_UCPDEN                     \ [0x1b] UCPD peripheral clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB2ENR_DEF
    \
    \ @brief RCC APB2 clock enable register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1EN                     \ [0x00] TIM1 peripheral clock enable Set and reset by software.
    $04 constant RCC_USART1EN                   \ [0x04] USART1 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART1 are the kernel clock selected by USART1SEL, and the pclk2 bus interface clock.
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI2S1 Peripheral Clocks Enable Set and reset by software. The peripheral clocks of the SPI2S1 are: the kernel clock selected by SPI1SEL, and the pclk2 bus interface clock.
    $0d constant RCC_SPI4EN                     \ [0x0d] SPI4 Peripheral Clocks Enable Set and reset by software. The peripheral clocks of the SPI4 are: the kernel clock selected by SPI45SEL, and the pclk2 bus interface clock.
    $10 constant RCC_TIM15EN                    \ [0x10] TIM15 peripheral clock enable Set and reset by software.
    $11 constant RCC_TIM16EN                    \ [0x11] TIM16 peripheral clock enable Set and reset by software.
    $12 constant RCC_TIM17EN                    \ [0x12] TIM17 peripheral clock enable Set and reset by software.
    $13 constant RCC_TIM9EN                     \ [0x13] TIM9 peripheral clock enable Set and reset by software.
    $14 constant RCC_SPI5EN                     \ [0x14] SPI5 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI5 are the kernel clock selected by SPI45SEL, and the pclk2 bus interface clock.
    $16 constant RCC_SAI1EN                     \ [0x16] SAI1 peripheral clocks enable Set and reset by software. The peripheral clocks of the SAI1 are the kernel clock selected by SAI1SEL, and the pclk2 bus interface clock.
    $17 constant RCC_SAI2EN                     \ [0x17] SAI2 peripheral clocks enable Set and reset by software. The peripheral clocks of the SAI2 are the kernel clock selected by SAI2SEL, and the pclk2 bus interface clock.
  [then]


  [ifdef] RCC_RCC_APB4ENR_DEF
    \
    \ @brief RCC APB4 clock enable register
    \ Address offset: 0x154
    \ Reset value: 0x00010000
    \
    $01 constant RCC_SBSEN                      \ [0x01] SBS peripheral clock enable Set and reset by software.
    $03 constant RCC_LPUART1EN                  \ [0x03] LPUART1 peripheral clocks enable Set and reset by software. The peripheral clocks of the LPUART1 are the kernel clock selected by LPUART1SEL and provided to UCLK input, and the pclk4 bus interface clock.
    $05 constant RCC_SPI6EN                     \ [0x05] SPI/I2S6 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI/I2S6 are the kernel clock selected by SPI6SEL and provided to com_clk input, and the pclk4 bus interface clock.
    $09 constant RCC_LPTIM2EN                   \ [0x09] LPTIM2 peripheral clocks enable Set and reset by software. The LPTIM2 kernel clock can be selected by LPTIM23SEL.
    $0a constant RCC_LPTIM3EN                   \ [0x0a] LPTIM3 peripheral clocks enable Set and reset by software. The LPTIM3 kernel clock can be selected by LPTIM23SEL.
    $0b constant RCC_LPTIM4EN                   \ [0x0b] LPTIM4 peripheral clocks enable Set and reset by software. The LPTIM4 kernel clock can be selected by LPTIM45SEL.
    $0c constant RCC_LPTIM5EN                   \ [0x0c] LPTIM5 peripheral clocks enable Set and reset by software. The LPTIM5 kernel clock can be selected by LPTIM45SEL.
    $0f constant RCC_VREFEN                     \ [0x0f] VREF peripheral clock enable Set and reset by software.
    $10 constant RCC_RTCAPBEN                   \ [0x10] RTC APB clock enable Set and reset by software.
    $1a constant RCC_TMPSENSEN                  \ [0x1a] Temperature Sensor peripheral clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB3ENR_DEF
    \
    \ @brief RCC AHB3 clock enable register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RNGEN                      \ [0x00] RNG peripheral clocks enable Set and reset by software.
    $01 constant RCC_HASHEN                     \ [0x01] HASH peripheral clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB5LPENR_DEF
    \
    \ @brief RCC AHB5 low-power clock enable register
    \ Address offset: 0x15C
    \ Reset value: 0xF018513F
    \
    $00 constant RCC_HPDMA1LPEN                 \ [0x00] HPDMA1 low-power peripheral clock enable Set and reset by software.
    $01 constant RCC_DMA2DLPEN                  \ [0x01] DMA2D low-power peripheral clock enable Set and reset by software.
    $02 constant RCC_FLITFLPEN                  \ [0x02] FLITF low-power peripheral clock enable Set and reset by software.
    $03 constant RCC_JPEGLPEN                   \ [0x03] JPEG clock enable during Sleep mode Set and reset by software.
    $04 constant RCC_FMCLPEN                    \ [0x04] FMC and MCE3 peripheral clocks enable during Sleep mode Set and reset by software. The hardware prevents writing this bit if FMCCKP = 1. The peripheral clocks of the FMC are the kernel clock selected by FMCSEL, and the hclk5 bus interface clock.
    $05 constant RCC_XSPI1LPEN                  \ [0x05] XSPI1 and MCE1 low-power peripheral clock enable Set and reset by software. The hardware prevents writing this bit if XSPICKP = 1.
    $08 constant RCC_SDMMC1LPEN                 \ [0x08] SDMMC1 and SDMMC1 delay low-power peripheral clock enable Set and reset by software.
    $0c constant RCC_XSPI2LPEN                  \ [0x0c] XSPI2 and MCE2 low-power peripheral clock enable Set and reset by software. The hardware prevents writing this bit if XSPICKP = 1.
    $0e constant RCC_XSPIMLPEN                  \ [0x0e] XSPIM low-power peripheral clock enable Set and reset by software.
    $13 constant RCC_GFXMMULPEN                 \ [0x13] GFXMMU low-power peripheral clock enable Set and reset by software.
    $14 constant RCC_GPULPEN                    \ [0x14] GPU low-power peripheral clock enable Set and reset by software.
    $1c constant RCC_DTCM1LPEN                  \ [0x1c] DTCM1 low-power peripheral clock enable Set and reset by software.
    $1d constant RCC_DTCM2LPEN                  \ [0x1d] DTCM2 low-power peripheral clock enable Set and reset by software.
    $1e constant RCC_ITCMLPEN                   \ [0x1e] ITCM low-power peripheral clock enable Set and reset by software.
    $1f constant RCC_AXISRAMLPEN                \ [0x1f] AXISRAM[4:1] low-power peripheral clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB1LPENR_DEF
    \
    \ @brief RCC AHB1 low-power clock enable register
    \ Address offset: 0x160
    \ Reset value: 0x8E038030
    \
    $04 constant RCC_GPDMA1LPEN                 \ [0x04] GPDMA1 clock enable in low-power mode Set and reset by software.
    $05 constant RCC_ADC12LPEN                  \ [0x05] ADC1 and 2 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the ADC1 and 2 are the kernel clock selected by ADCSEL and provided to ADCx_CK input, and the rcc_hclk1 bus interface clock.
    $0f constant RCC_ETH1MACLPEN                \ [0x0f] ETH1 MAC peripheral clock enable in low-power mode Set and reset by software.
    $10 constant RCC_ETH1TXLPEN                 \ [0x10] ETH1 transmission peripheral clock enable in low-power mode Set and reset by software.
    $11 constant RCC_ETH1RXLPEN                 \ [0x11] ETH1 reception peripheral clock enable in low-power mode Set and reset by software.
    $18 constant RCC_USBPDCTRL                  \ [0x18] USBPHYC common block power-down control Set and reset by software.
    $19 constant RCC_OTGHSLPEN                  \ [0x19] OTGHS peripheral clock enable in low-power mode Set and reset by software.
    $1a constant RCC_USBPHYCLPEN                \ [0x1a] USBPHYC peripheral clock enable in low-power mode Set and reset by software.
    $1b constant RCC_OTGFSLPEN                  \ [0x1b] OTGFS clock enable in low-power mode Set and reset by software.
    $1f constant RCC_ADFLPEN                    \ [0x1f] ADF clock enable in low-power mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB2LPENR_DEF
    \
    \ @brief RCC AHB2 low-power clock enable register
    \ Address offset: 0x164
    \ Reset value: 0x60004202
    \
    $01 constant RCC_PSSILPEN                   \ [0x01] PSSI peripheral clock enable in low-power mode Set and reset by software.
    $09 constant RCC_SDMMC2LPEN                 \ [0x09] SDMMC2 and SDMMC2 delay clock enable in low-power mode Set and reset by software.
    $0e constant RCC_CORDICLPEN                 \ [0x0e] CORDIC clock enable in low-power mode Set and reset by software.
    $1d constant RCC_SRAM1LPEN                  \ [0x1d] SRAM1 clock enable in low-power mode Set and reset by software.
    $1e constant RCC_SRAM2LPEN                  \ [0x1e] SRAM2 clock enable in low-power mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB4LPENR_DEF
    \
    \ @brief RCC AHB4 low-power clock enable register
    \ Address offset: 0x168
    \ Reset value: 0x1008F0FF
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIOA peripheral clock enable in low-power mode Set and reset by software.
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIOB peripheral clock enable in low-power mode Set and reset by software.
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIOC peripheral clock enable in low-power mode Set and reset by software.
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIOD peripheral clock enable in low-power mode Set and reset by software.
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIOE peripheral clock enable in low-power mode Set and reset by software.
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIOF peripheral clock enable in low-power mode Set and reset by software.
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIOG peripheral clock enable in low-power mode Set and reset by software.
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIOH peripheral clock enable in low-power mode Set and reset by software.
    $0c constant RCC_GPIOMLPEN                  \ [0x0c] GPIOM peripheral clock enable in low-power mode Set and reset by software.
    $0d constant RCC_GPIONLPEN                  \ [0x0d] GPION peripheral clock enable in low-power mode Set and reset by software.
    $0e constant RCC_GPIOOLPEN                  \ [0x0e] GPIOO peripheral clock enable in low-power mode Set and reset by software.
    $0f constant RCC_GPIOPLPEN                  \ [0x0f] GPIOP peripheral clock enable in low-power mode Set and reset by software.
    $13 constant RCC_CRCLPEN                    \ [0x13] CRC clock enable in low-power mode Set and reset by software.
    $1c constant RCC_BKPRAMLPEN                 \ [0x1c] Backup RAM clock enable in low-power mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB3LPENR_DEF
    \
    \ @brief RCC AHB3 low-power clock enable register
    \ Address offset: 0x16C
    \ Reset value: 0x00000057
    \
    $00 constant RCC_RNGLPEN                    \ [0x00] RNG peripheral clock enable in low-power mode Set and reset by software.
    $01 constant RCC_HASHLPEN                   \ [0x01] HASH peripheral clock enable in low-power mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1LPENR1_DEF
    \
    \ @brief RCC APB1 low-power clock enable register 1
    \ Address offset: 0x170
    \ Reset value: 0xC8FFCBFF
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2 peripheral clock enable in low-power mode Set and reset by software.
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3 peripheral clock enable in low-power mode Set and reset by software.
    $02 constant RCC_TIM4LPEN                   \ [0x02] TIM4 peripheral clock enable in low-power mode Set and reset by software.
    $03 constant RCC_TIM5LPEN                   \ [0x03] TIM5 peripheral clock enable in low-power mode Set and reset by software.
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6 peripheral clock enable in low-power mode Set and reset by software.
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7 peripheral clock enable in low-power mode Set and reset by software.
    $06 constant RCC_TIM12LPEN                  \ [0x06] TIM12 peripheral clock enable in low-power mode Set and reset by software.
    $07 constant RCC_TIM13LPEN                  \ [0x07] TIM13 peripheral clock enable in low-power mode Set and reset by software.
    $08 constant RCC_TIM14LPEN                  \ [0x08] TIM14 peripheral clock enable in low-power mode Set and reset by software.
    $09 constant RCC_LPTIM1LPEN                 \ [0x09] LPTIM1 peripheral clocks enable in low-power mode Set and reset by software.
    $0b constant RCC_WWDGLPEN                   \ [0x0b] WWDG clock enable in low-power mode Set and reset by software.
    $0e constant RCC_SPI2LPEN                   \ [0x0e] SPI2 peripheral clocks enable in low-power mode Set and reset by software.
    $0f constant RCC_SPI3LPEN                   \ [0x0f] SPI3 peripheral clocks enable in low-power mode Set and reset by software.
    $10 constant RCC_SPDIFRXLPEN                \ [0x10] SPDIFRX peripheral clocks enable in low-power mode Set and reset by software.
    $11 constant RCC_USART2LPEN                 \ [0x11] USART2 peripheral clocks enable in low-power mode Set and reset by software.
    $12 constant RCC_USART3LPEN                 \ [0x12] USART3 peripheral clocks enable in low-power mode Set and reset by software.
    $13 constant RCC_UART4LPEN                  \ [0x13] UART4 peripheral clocks enable in low-power mode Set and reset by software.
    $14 constant RCC_UART5LPEN                  \ [0x14] UART5 peripheral clocks enable in low-power mode Set and reset by software.
    $15 constant RCC_I2C1_I3C1LPEN              \ [0x15] I2C1/I3C1 peripheral clocks enable in low-power mode Set and reset by software.
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2 peripheral clocks enable in low-power mode Set and reset by software.
    $17 constant RCC_I2C3LPEN                   \ [0x17] I2C3 peripheral clocks enable in low-power mode Set and reset by software.
    $1b constant RCC_HDMICECLPEN                \ [0x1b] HDMI-CEC peripheral clocks enable in low-power mode Set and reset by software.
    $1e constant RCC_UART7LPEN                  \ [0x1e] UART7 peripheral clocks enable in low-power mode Set and reset by software.
    $1f constant RCC_UART8LPEN                  \ [0x1f] UART8 peripheral clocks enable in low-power mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1LPENR2_DEF
    \
    \ @brief RCC APB1 low-power clock enable register 2
    \ Address offset: 0x174
    \ Reset value: 0x08000122
    \
    $01 constant RCC_CRSLPEN                    \ [0x01] clock recovery system peripheral clock enable in low-power mode Set and reset by software.
    $05 constant RCC_MDIOSLPEN                  \ [0x05] MDIOS peripheral clock enable in low-power mode Set and reset by software.
    $08 constant RCC_FDCANLPEN                  \ [0x08] FDCAN peripheral clock enable in low-power mode Set and reset by software.
    $1b constant RCC_UCPDLPEN                   \ [0x1b] UCPD peripheral clock enable in low-power mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB2LPENR_DEF
    \
    \ @brief RCC APB2 low-power clock enable register
    \ Address offset: 0x178
    \ Reset value: 0x00DF3011
    \
    $00 constant RCC_TIM1LPEN                   \ [0x00] TIM1 peripheral clock enable in low-power mode Set and reset by software.
    $04 constant RCC_USART1LPEN                 \ [0x04] USART1 peripheral clock enable in low-power mode Set and reset by software. The peripheral clocks of the USART1 are the kernel clock selected by USART169SEL and provided to UCLK inputs, and the pclk2 bus interface clock.
    $0c constant RCC_SPI1LPEN                   \ [0x0c] SPI2S1 peripheral clock enable in low-power mode Set and reset by software. The peripheral clocks of the SPI2S1 are: the kernel clock selected by I2S1SEL and provided to spi_ker_ck input, and the pclk2 bus interface clock.
    $0d constant RCC_SPI4LPEN                   \ [0x0d] SPI4 peripheral clock enable in low-power mode Set and reset by software. The peripheral clocks of the SPI4 are: the kernel clock selected by SPI45SEL and provided to com_clk input, and the pclk2 bus interface clock.
    $10 constant RCC_TIM15LPEN                  \ [0x10] TIM15 peripheral clock enable in low-power mode Set and reset by software.
    $11 constant RCC_TIM16LPEN                  \ [0x11] TIM16 peripheral clock enable in low-power mode Set and reset by software.
    $12 constant RCC_TIM17LPEN                  \ [0x12] TIM17 peripheral clock enable in low-power mode Set and reset by software.
    $13 constant RCC_TIM9LPEN                   \ [0x13] TIM9 peripheral clock enable in low-power mode Set and reset by software.
    $14 constant RCC_SPI5LPEN                   \ [0x14] SPI5 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the SPI5 are the kernel clock selected by SPI45SEL and provided to com_clk input, and the pclk2 bus interface clock.
    $16 constant RCC_SAI1LPEN                   \ [0x16] SAI1 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the SAI1 are: the kernel clock selected by SAI1SEL and provided to SAI_CK_A and SAI_CK_B inputs, and the pclk2 bus interface clock.
    $17 constant RCC_SAI2LPEN                   \ [0x17] SAI2 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the SAI2 are: the kernel clock selected by SAI2SEL and provided to SAI_CK_A and SAI_CK_B inputs, and the pclk2 bus interface clock.
  [then]


  [ifdef] RCC_RCC_APB4LPENR_DEF
    \
    \ @brief RCC APB4 low-power clock enable register
    \ Address offset: 0x17C
    \ Reset value: 0x04019E2A
    \
    $01 constant RCC_SBSLPEN                    \ [0x01] SBS peripheral clock enable in low-power mode Set and reset by software.
    $03 constant RCC_LPUART1LPEN                \ [0x03] LPUART1 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the LPUART1 are the kernel clock selected by LPUART1SEL and provided to UCLK input, and the rcc_pclk4 bus interface clock.
    $05 constant RCC_SPI6LPEN                   \ [0x05] SPI/I2S6 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the SPI/I2S6 are the kernel clock selected by SPI6SEL and provided to com_ck input, and the rcc_pclk4 bus interface clock.
    $09 constant RCC_LPTIM2LPEN                 \ [0x09] LPTIM2 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the LPTIM2 are the kernel clock selected by LPTIM23SEL and provided to clk_lpt input, and the pclk4 bus interface clock.
    $0a constant RCC_LPTIM3LPEN                 \ [0x0a] LPTIM3 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the LPTIM3 are the kernel clock selected by LPTIM23SEL and provided to clk_lpt input, and the pclk4 bus interface clock.
    $0b constant RCC_LPTIM4LPEN                 \ [0x0b] LPTIM4 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the LPTIM4 are the kernel clock selected by LPTIM45SEL and provided to clk_lpt input, and the pclk4 bus interface clock.
    $0c constant RCC_LPTIM5LPEN                 \ [0x0c] LPTIM5 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the LPTIM5 are the kernel clock selected by LPTIM45SEL and provided to clk_lpt input, and the pclk4 bus interface clock.
    $0f constant RCC_VREFLPEN                   \ [0x0f] VREF peripheral clock enable in low-power mode Set and reset by software.
    $10 constant RCC_RTCAPBLPEN                 \ [0x10] RTC APB clock enable in low-power mode Set and reset by software.
    $1a constant RCC_TMPSENSLPEN                \ [0x1a] temperature sensor peripheral clock enable in low-power mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB5LPENR_DEF
    \
    \ @brief RCC APB5 sleep clock register
    \ Address offset: 0x180
    \ Reset value: 0x00000016
    \
    $01 constant RCC_LTDCLPEN                   \ [0x01] LTDC peripheral clock enable in low-power mode Set and reset by software.
    $02 constant RCC_DCMIPPLPEN                 \ [0x02] DCMIPP peripheral clock enable in low-power mode Set and reset by software.
    $04 constant RCC_GFXTIMLPEN                 \ [0x04] GFXTIM peripheral clock enable in low-power mode Set and reset by software.
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_RCC_CR               \ RCC source control register
  $04 constant RCC_RCC_HSICFGR          \ RCC HSI calibration register
  $08 constant RCC_RCC_CRRCR            \ RCC clock recovery RC register
  $0C constant RCC_RCC_CSICFGR          \ RCC CSI calibration register
  $10 constant RCC_RCC_CFGR             \ RCC clock configuration register
  $18 constant RCC_RCC_CDCFGR           \ RCC CPU domain clock configuration register
  $1C constant RCC_RCC_BMCFGR           \ RCC AHB clock configuration register
  $20 constant RCC_RCC_APBCFGR          \ RCC APB clocks configuration register
  $28 constant RCC_RCC_PLLCKSELR        \ RCC PLLs clock source selection register
  $2C constant RCC_RCC_PLLCFGR          \ RCC PLLs configuration register
  $30 constant RCC_RCC_PLL1DIVR1        \ RCC PLL1 dividers configuration register 1
  $34 constant RCC_RCC_PLL1FRACR        \ RCC PLL1 fractional divider register
  $38 constant RCC_RCC_PLL2DIVR1        \ RCC PLL2 dividers configuration register 1
  $3C constant RCC_RCC_PLL2FRACR        \ RCC PLL2 fractional divider register
  $40 constant RCC_RCC_PLL3DIVR1        \ RCC PLL3 dividers configuration register 1
  $44 constant RCC_RCC_PLL3FRACR        \ RCC PLL3 fractional divider register
  $4C constant RCC_RCC_AHBPERCKSELR     \ RCC AHB peripheral kernel clock selection register
  $50 constant RCC_RCC_APB1PERCKSELR    \ RCC APB1 peripherals kernel clock selection register
  $54 constant RCC_RCC_APB2PERCKSELR    \ RCC APB2 peripherals kernel clock selection register
  $58 constant RCC_RCC_APB45PERCKSELR   \ RCC APB4,5 peripherals kernel clock selection register
  $60 constant RCC_RCC_CIER             \ RCC clock source interrupt enable register
  $64 constant RCC_RCC_CIFR             \ RCC clock source interrupt flag register
  $68 constant RCC_RCC_CICR             \ RCC clock source interrupt clear register
  $70 constant RCC_RCC_BDCR             \ RCC Backup domain control register
  $74 constant RCC_RCC_CSR              \ RCC clock control and status register
  $7C constant RCC_RCC_AHB5RSTR         \ RCC AHB5 peripheral reset register
  $80 constant RCC_RCC_AHB1RSTR         \ RCC AHB1 peripheral reset register
  $84 constant RCC_RCC_AHB2RSTR         \ RCC AHB2 peripheral reset register
  $88 constant RCC_RCC_AHB4RSTR         \ RCC AHB4 peripheral reset register
  $8C constant RCC_RCC_APB5RSTR         \ RCC APB5 peripheral reset register
  $90 constant RCC_RCC_APB1RSTR1        \ RCC APB1 peripheral reset register 1
  $94 constant RCC_RCC_APB1RSTR2        \ RCC APB1 peripheral reset register 2
  $98 constant RCC_RCC_APB2RSTR         \ RCC APB2 peripheral reset register
  $9C constant RCC_RCC_APB4RSTR         \ RCC APB4 peripheral reset register
  $A4 constant RCC_RCC_AHB3RSTR         \ RCC AHB3 peripheral reset register
  $B0 constant RCC_RCC_CKGDISR          \ RCC AXI clocks gating disable register
  $C0 constant RCC_RCC_PLL1DIVR2        \ RCC PLL1 dividers configuration register 2
  $C4 constant RCC_RCC_PLL2DIVR2        \ RCC PLL2 dividers configuration register 2
  $C8 constant RCC_RCC_PLL3DIVR2        \ RCC PLL3 dividers configuration register 2
  $CC constant RCC_RCC_PLL1SSCGR        \ RCC PLL1 Spread Spectrum Clock Generator register
  $D0 constant RCC_RCC_PLL2SSCGR        \ RCC PLL2 Spread Spectrum Clock Generator register
  $D4 constant RCC_RCC_PLL3SSCGR        \ RCC PLL3 Spread Spectrum Clock Generator register
  $100 constant RCC_RCC_CKPROTR         \ RCC clock protection register
  $130 constant RCC_RCC_RSR             \ RCC Reset status register
  $134 constant RCC_RCC_AHB5ENR         \ RCC AHB5 clock enable register
  $138 constant RCC_RCC_AHB1ENR         \ RCC AHB1 clock enable register
  $13C constant RCC_RCC_AHB2ENR         \ RCC AHB2 clock enable register
  $140 constant RCC_RCC_AHB4ENR         \ RCC AHB4 clock enable register
  $144 constant RCC_RCC_APB5ENR         \ RCC APB5 clock enable register
  $148 constant RCC_RCC_APB1ENR1        \ RCC APB1 clock enable register 1
  $14C constant RCC_RCC_APB1ENR2        \ RCC APB1 clock enable register 2
  $150 constant RCC_RCC_APB2ENR         \ RCC APB2 clock enable register
  $154 constant RCC_RCC_APB4ENR         \ RCC APB4 clock enable register
  $158 constant RCC_RCC_AHB3ENR         \ RCC AHB3 clock enable register
  $15C constant RCC_RCC_AHB5LPENR       \ RCC AHB5 low-power clock enable register
  $160 constant RCC_RCC_AHB1LPENR       \ RCC AHB1 low-power clock enable register
  $164 constant RCC_RCC_AHB2LPENR       \ RCC AHB2 low-power clock enable register
  $168 constant RCC_RCC_AHB4LPENR       \ RCC AHB4 low-power clock enable register
  $16C constant RCC_RCC_AHB3LPENR       \ RCC AHB3 low-power clock enable register
  $170 constant RCC_RCC_APB1LPENR1      \ RCC APB1 low-power clock enable register 1
  $174 constant RCC_RCC_APB1LPENR2      \ RCC APB1 low-power clock enable register 2
  $178 constant RCC_RCC_APB2LPENR       \ RCC APB2 low-power clock enable register
  $17C constant RCC_RCC_APB4LPENR       \ RCC APB4 low-power clock enable register
  $180 constant RCC_RCC_APB5LPENR       \ RCC APB5 sleep clock register

: RCC_DEF ; [then]
