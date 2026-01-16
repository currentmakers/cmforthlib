\
\ @file rcc.fs
\ @brief Reset and clock control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RCC source control register
\ Address offset: 0x00
\ Reset value: 0x00000025
\

$00000001 constant RCC_RCC_CR_HSION                                 \ HSI clock enable Set and cleared by software. Set by hardware to force the HSI to ON when the product leaves Stop mode, if STOPWUCK = 0 or STOPKERWUCK = 0. Set by hardware to force the HSI to ON when the product leaves Standby mode or in case of a failure of the HSE which is used as the system clock source. This bit cannot be cleared if the HSI is used directly (via SW switch) as system clock, or if the HSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1) or if FMCCKP = 1, or if XSPICKP = 1.
$00000002 constant RCC_RCC_CR_HSIKERON                              \ HSI clock enable in Stop mode Set and reset by software to force the HSI to ON, even in Stop mode, in order to be quickly available as kernel clock for peripherals. This bit has no effect on the value of HSION.
$00000004 constant RCC_RCC_CR_HSIRDY                                \ HSI clock ready flag Set by hardware to indicate that the HSI oscillator is stable.
$00000018 constant RCC_RCC_CR_HSIDIV                                \ HSI clock divider Set and reset by software. These bits allow selecting a division ratio in order to configure the wanted HSI clock frequency. The HSIDIV cannot be changed if the HSI is selected as reference clock for at least one enabled PLL (PLLxON bit set to 1). In that case, the new HSIDIV value is ignored.
$00000020 constant RCC_RCC_CR_HSIDIVF                               \ HSI divider flag Set and reset by hardware. As a write operation to HSIDIV has not an immediate effect on the frequency, this flag indicates the current status of the HSI divider. HSIDIVF goes immediately to 0 when HSIDIV value is changed, and is set back to 1 when the output frequency matches the value programmed into HSIDIV. clock setting is completed)
$00000080 constant RCC_RCC_CR_CSION                                 \ CSI clock enable Set and reset by software to enable/disable CSI clock for system and/or peripheral. Set by hardware to force the CSI to ON when the system leaves Stop mode, if STOPWUCK = 1 or STOPKERWUCK = 1. This bit cannot be cleared if the CSI is used directly (via SW mux) as system clock, or if the CSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1) or if FMCCKP = 1, or if XSPICKP = 1.
$00000100 constant RCC_RCC_CR_CSIRDY                                \ CSI clock ready flag Set by hardware to indicate that the CSI oscillator is stable. This bit is activated only if the RC is enabled by CSION (it is not activated if the CSI is enabled by CSIKERON or by a peripheral request).
$00000200 constant RCC_RCC_CR_CSIKERON                              \ CSI clock enable in Stop mode Set and reset by software to force the CSI to ON, even in Stop mode, in order to be quickly available as kernel clock for some peripherals. This bit has no effect on the value of CSION.
$00001000 constant RCC_RCC_CR_HSI48ON                               \ HSI48 clock enable Set by software and cleared by software or by the hardware when the system enters to Stop or Standby mode.
$00002000 constant RCC_RCC_CR_HSI48RDY                              \ HSI48 clock ready flag Set by hardware to indicate that the HSI48 oscillator is stable.
$00010000 constant RCC_RCC_CR_HSEON                                 \ HSE clock enable Set and cleared by software. Cleared by hardware to stop the HSE when entering Stop or Standby mode. This bit cannot be cleared if the HSE is used directly (via SW mux) as system clock, or if the HSE is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1) or if FMCCKP = 1, or if XSPICKP = 1.
$00020000 constant RCC_RCC_CR_HSERDY                                \ HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable.
$00040000 constant RCC_RCC_CR_HSEBYP                                \ HSE clock bypass Set and cleared by software to bypass the oscillator with an external clock. The external clock must be enabled with the HSEON bit to be used by the device. The HSEBYP bit can be written only if the HSE oscillator is disabled.
$00080000 constant RCC_RCC_CR_HSEEXT                                \ external high speed clock type in Bypass mode Set and reset by software to select the external clock type (analog or digital). The external clock must be enabled with the HSEON bit to be used by the device. The HSEEXT bit can be written only if the HSE oscillator is disabled.
$00100000 constant RCC_RCC_CR_HSECSSON                              \ HSE clock security system enable Set by software to enable clock security system on HSE. This bit is set only (disabled by a system reset or when the system enters in Standby mode). When HSECSSON is set, the clock detector is enabled by hardware when the HSE is ready and disabled by hardware if an oscillator failure is detected.
$01000000 constant RCC_RCC_CR_PLL1ON                                \ PLL1 enable Set and cleared by software to enable PLL1. Cleared by hardware when entering Stop or Standby mode. Note that the hardware prevents writing this bit to 0, if the PLL1 output is used as the system clock (SW=3) or if FMCCKP = 1, or if XSPICKP = 1.
$02000000 constant RCC_RCC_CR_PLL1RDY                               \ PLL1 clock ready flag Set by hardware to indicate that the PLL1 is locked.
$04000000 constant RCC_RCC_CR_PLL2ON                                \ PLL2 enable Set and cleared by software to enable PLL2. Cleared by hardware when entering Stop or Standby mode. Note that the hardware prevents writing this bit to 0, if FMCCKP = 1, or XSPICKP = 1.
$08000000 constant RCC_RCC_CR_PLL2RDY                               \ PLL2 clock ready flag Set by hardware to indicate that the PLL2 is locked.
$10000000 constant RCC_RCC_CR_PLL3ON                                \ PLL3 enable Set and cleared by software to enable PLL3. Cleared by hardware when entering Stop or Standby mode.
$20000000 constant RCC_RCC_CR_PLL3RDY                               \ PLL3 clock ready flag Set by hardware to indicate that the PLL3 is locked.


\
\ @brief RCC HSI calibration register
\ Address offset: 0x04
\ Reset value: 0x40000000
\

$00000fff constant RCC_RCC_HSICFGR_HSICAL                           \ HSI clock calibration Set by hardware by option byte loading. Adjusted by software through trimming bits HSITRIM. This field represents the sum of engineering option byte calibration value and HSITRIM bits value.
$7f000000 constant RCC_RCC_HSICFGR_HSITRIM                          \ HSI clock trimming Set by software to adjust calibration. HSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_HSI_opt) in order to form the calibration trimming value. HSICAL = HSITRIM + FLASH_HSI_opt. Note: The reset value of the field is 0x40.


\
\ @brief RCC clock recovery RC register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000003ff constant RCC_RCC_CRRCR_HSI48CAL                           \ Internal RC 48 MHz clock calibration Set by hardware by option byte loading. Read-only.


\
\ @brief RCC CSI calibration register
\ Address offset: 0x0C
\ Reset value: 0x20000000
\

$000000ff constant RCC_RCC_CSICFGR_CSICAL                           \ CSI clock calibration Set by hardware by option byte loading. Adjusted by software through trimming bits CSITRIM. This field represents the sum of engineering option byte calibration value and CSITRIM bits value.
$3f000000 constant RCC_RCC_CSICFGR_CSITRIM                          \ CSI clock trimming Set by software to adjust calibration. CSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_CSI_opt) in order to form the calibration trimming value. CSICAL = CSITRIM + FLASH_CSI_opt. Note: The reset value of the field is 0x20.


\
\ @brief RCC clock configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_CFGR_SW                                  \ system clock switch Set and reset by software to select system clock source (sys_ck). Set by hardware in order to force the selection of the HSI or CSI (depending on STOPWUCK selection) when leaving a system Stop mode or in case of failure of the HSE when used directly or indirectly as system clock. others: reserved
$00000038 constant RCC_RCC_CFGR_SWS                                 \ system clock switch status Set and reset by hardware to indicate which clock source is used as system clock. others: reserved
$00000040 constant RCC_RCC_CFGR_STOPWUCK                            \ system clock selection after a wake up from system Stop Set and reset by software to select the system wakeup clock from system Stop. The selected clock is also used as emergency clock for the clock security system (CSS) on HSE. See Section 1.: Dividers values can be changed on-the-fly. All dividers provide have 50% duty-cycles. for details. STOPWUCK must not be modified when CSS is enabled (by HSECSSON bit) and the system clock is HSE (SWS = 10) or a switch on HSE is requested (SW =10).
$00000080 constant RCC_RCC_CFGR_STOPKERWUCK                         \ kernel clock selection after a wake up from system Stop Set and reset by software to select the kernel wakeup clock from system Stop. See Section 1.: Dividers values can be changed on-the-fly. All dividers provide have 50% duty-cycles. for details.
$00003f00 constant RCC_RCC_CFGR_RTCPRE                              \ HSE division factor for RTC clock Set and cleared by software to divide the HSE to generate a clock for RTC. Caution: The software must set these bits correctly to ensure that the clock supplied to the RTC is lower than 1 MHz. These bits must be configured if needed before selecting the RTC clock source. ...
$00008000 constant RCC_RCC_CFGR_TIMPRE                              \ timers clocks prescaler selection This bit is set and reset by software to control the clock frequency of all the timers connected to APB1 and APB2 domains. or 4, else it is equal to 4 x F<sub>rcc_pclkx_d2</sub> Refer to Table 64: Ratio between clock timer and pclk for more details.
$003c0000 constant RCC_RCC_CFGR_MCO1PRE                             \ MCO1 prescaler Set and cleared by software to configure the prescaler of the MCO1. Modification of this prescaler may generate glitches on MCO1. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. ...
$01c00000 constant RCC_RCC_CFGR_MCO1SEL                             \ Microcontroller clock output 1 Set and cleared by software. Clock source selection may generate glitches on MCO1. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved
$1e000000 constant RCC_RCC_CFGR_MCO2PRE                             \ MCO2 prescaler Set and cleared by software to configure the prescaler of the MCO2. Modification of this prescaler may generate glitches on MCO2. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. ...
$e0000000 constant RCC_RCC_CFGR_MCO2SEL                             \ microcontroller clock output 2 Set and cleared by software. Clock source selection may generate glitches on MCO2. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved


\
\ @brief RCC CPU domain clock configuration register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000000f constant RCC_RCC_CDCFGR_CPRE                              \ CPU domain core prescaler Set and reset by software to control the CPU clock division factor. Changing this division ratio has an impact on the frequency of the CPU clock and all bus matrix clocks. After changing this prescaler value, it takes up to 16 periods of the slowest APB clock before the new division ratio is taken into account. The application can check if the new division factor is taken into account by reading back this register. 0xxx: sys_ck not divided (default after reset)


\
\ @brief RCC AHB clock configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant RCC_RCC_BMCFGR_BMPRE                             \ Bus matrix clock prescaler Set and reset by software to control the division factor of rcc_hclk[5:1] and rcc_aclk. This group of clocks is also named sys_bus_ck. Changing this division ratio has an impact on the frequency of all bus matrix clocks. 0xxx: sys_bus_ck= sys_cpu_ck (default after reset) Note: The clocks are divided by the new prescaler factor from 1 to 16 periods of the slowest APB clock among rcc_pclk1,2,4,5 after BMPRE update. Note: Note also that frequency of rcc_hclk[5:1] = rcc_aclk = sys_bus_ck.


\
\ @brief RCC APB clocks configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_APBCFGR_PPRE1                            \ CPU domain APB1 prescaler Set and reset by software to control the division factor of rcc_pclk1. The clock is divided by the new prescaler factor from 1 to 16 cycles of sys_bus_ck after PPRE1 write. 0xx: rcc_pclk1 = sys_bus_ck (default after reset)
$00000070 constant RCC_RCC_APBCFGR_PPRE2                            \ CPU domain APB2 prescaler Set and reset by software to control the division factor of rcc_pclk2. The clock is divided by the new prescaler factor from 1 to 16 cycles of sys_bus_ck after PPRE2 write. 0xx: rcc_pclk2 = sys_bus_ck (default after reset)
$00000700 constant RCC_RCC_APBCFGR_PPRE4                            \ CPU domain APB4 prescaler Set and reset by software to control the division factor of rcc_pclk4. The clock is divided by the new prescaler factor from 1 to 16 cycles of sys_bus_ck after PPRE4 write. 0xx: rcc_pclk4 = sys_bus_ck (default after reset)
$00007000 constant RCC_RCC_APBCFGR_PPRE5                            \ CPU domain APB5 prescaler Set and reset by software to control the division factor of rcc_pclk5. The clock is divided by the new prescaler factor from 1 to 16 cycles of sys_bus_ck after PPRE5 write. 0xx: rcc_pclk5 = sys_bus_ck (default after reset)


\
\ @brief RCC PLLs clock source selection register
\ Address offset: 0x28
\ Reset value: 0x02020200
\

$00000003 constant RCC_RCC_PLLCKSELR_PLLSRC                         \ DIVMx and PLLs clock source selection Set and reset by software to select the PLL clock source. These bits can be written only when all PLLs are disabled. In order to save power, when no PLL is used, PLLSRC must be set to 11.
$000003f0 constant RCC_RCC_PLLCKSELR_DIVM1                          \ prescaler for PLL1 Set and cleared by software to configure the prescaler of the PLL1. The hardware does not allow any modification of this prescaler when PLL1 is enabled (PLL1ON = 1). In order to save power when PLL1 is not used, the value of DIVM1 must be set to 0. ... ...
$0003f000 constant RCC_RCC_PLLCKSELR_DIVM2                          \ prescaler for PLL2 Set and cleared by software to configure the prescaler of the PLL2. The hardware does not allow any modification of this prescaler when PLL2 is enabled (PLL2ON = 1). In order to save power when PLL2 is not used, the value of DIVM2 must be set to 0. ... ...
$03f00000 constant RCC_RCC_PLLCKSELR_DIVM3                          \ prescaler for PLL3 Set and cleared by software to configure the prescaler of the PLL3. The hardware does not allow any modification of this prescaler when PLL3 is enabled (PLL3ON = 1). In order to save power when PLL3 is not used, the value of DIVM3 must be set to 0. ... ...


\
\ @brief RCC PLLs configuration register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_PLLCFGR_PLL1FRACLE                       \ PLL1 fractional latch enable Set and reset by software to latch the content of FRACN into the sigma-delta modulator. In order to latch the FRACN value into the sigma-delta modulator, PLL1FRACLE must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN into the modulator. Refer to PLL initialization procedure on page 444 for additional information.
$00000002 constant RCC_RCC_PLLCFGR_PLL1VCOSEL                       \ PLL1 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL1. This bit must be written before enabling the PLL1. It allows the application to select the VCO range: VCOH: working from 400 to 1600 MHz (F<sub>ref1_ck</sub> must be between 2 and 16 MHz) VCOL: working from 150 to 420 MHz (F<sub>ref1_ck</sub> must be between 1 and 2 MHz)
$00000004 constant RCC_RCC_PLLCFGR_PLL1SSCGEN                       \ PLL1 SSCG enable Set and reset by software to enable the Spread Spectrum Clock Generator of PLL1, in order to reduce the amount of EMI peaks.
$00000018 constant RCC_RCC_PLLCFGR_PLL1RGE                          \ PLL1 input frequency range Set and reset by software to select the proper reference frequency range used for PLL1. This bit must be written before enabling the PLL1.
$00000020 constant RCC_RCC_PLLCFGR_PLL1DIVPEN                       \ PLL1 DIVP divider output enable Set and reset by software to enable the pll1_p_ck output of the PLL1. The hardware prevents writing this bit to 0, if the PLL1 output is used as the system clock (SW=3). In order to save power, when the pll1_p_ck output of the PLL1 is not used, the pll1_p_ck must be disabled.
$00000040 constant RCC_RCC_PLLCFGR_PLL1DIVQEN                       \ PLL1 DIVQ divider output enable Set and reset by software to enable the pll1_q_ck output of the PLL1. The hardware prevents writing this bit if FMCCKP = 1. In order to save power, when the pll1_q_ck output of the PLL1 is not used, the pll1_q_ck must be disabled.
$00000080 constant RCC_RCC_PLLCFGR_PLL1DIVREN                       \ PLL1 DIVR divider output enable Set and reset by software to enable the pll1_r_ck output of the PLL1. To save power, PLL1DIVREN and DIVR1 bits must be set to 0 when the pll1_r_ck is not used.
$00000100 constant RCC_RCC_PLLCFGR_PLL1DIVSEN                       \ PLL1 DIVS divider output enable Set and reset by software to enable the pll1_s_ck output of the PLL1. To save power, PLL1DIVSEN must be set to 0 when the pll1_s_ck is not used.
$00000200 constant RCC_RCC_PLLCFGR_PLL1DIVTEN                       \ PLL1 DIVT divider output enable Set and reset by software to enable the pll1_t_ck output of the PLL1. To save power, PLL1DIVTEN must be set to 0 when the pll1_t_ck is not used.
$00000800 constant RCC_RCC_PLLCFGR_PLL2FRACLE                       \ PLL2 fractional latch enable Set and reset by software to latch the content of FRACN into the sigma-delta modulator. In order to latch the FRACN value into the sigma-delta modulator, PLL2FRACLE must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN into the modulator. Refer to PLL initialization procedure on page 444 for additional information.
$00001000 constant RCC_RCC_PLLCFGR_PLL2VCOSEL                       \ PLL2 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL2. This bit must be written before enabling the PLL2. It allows the application to select the VCO range: VCOH: working from 400 to 1600 MHz (F<sub>ref2_ck</sub> must be between 2 and 16 MHz) VCOL: working from 150 to 420 MHz (F<sub>ref2_ck</sub> must be between 1 and 2 MHz)
$00002000 constant RCC_RCC_PLLCFGR_PLL2SSCGEN                       \ PLL2 SSCG enable Set and reset by software to enable the Spread Spectrum Clock Generator of PLL2, in order to reduce the amount of EMI peaks.
$0000c000 constant RCC_RCC_PLLCFGR_PLL2RGE                          \ PLL2 input frequency range Set and reset by software to select the proper reference frequency range used for PLL2. These bits must be written before enabling the PLL2.
$00010000 constant RCC_RCC_PLLCFGR_PLL2DIVPEN                       \ PLL2 DIVP divider output enable Set and reset by software to enable the pll2_p_ck output of the PLL2. To save power, PLL2DIVPEN and DIVP bits must be set to 0 when the pll2_p_ck is not used.
$00020000 constant RCC_RCC_PLLCFGR_PLL2DIVQEN                       \ PLL2 DIVQ divider output enable Set and reset by software to enable the pll2_q_ck output of the PLL2. To save power, PLL3DIVQEN and DIVQ bits must be set to 0 when the pll2_q_ck is not used.
$00040000 constant RCC_RCC_PLLCFGR_PLL2DIVREN                       \ PLL2 DIVR divider output enable Set and reset by software to enable the pll2_r_ck output of the PLL2. The hardware prevents writing this bit if FMCCKP = 1. To save power, PLL3DIVREN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used.
$00080000 constant RCC_RCC_PLLCFGR_PLL2DIVSEN                       \ PLL2 DIVS divider output enable Set and reset by software to enable the pll2_s_ck output of the PLL2. To save power, PLL2DIVSEN must be set to 0 when the pll2_s_ck is not used. The hardware prevents writing this bit if XSPICKP = 1.
$00100000 constant RCC_RCC_PLLCFGR_PLL2DIVTEN                       \ PLL2 DIVT divider output enable Set and reset by software to enable the pll2_t_ck output of the PLL2. To save power, PLL2DIVTEN must be set to 0 when the pll2_t_ck is not used. The hardware prevents writing this bit if XSPICKP = 1.
$00400000 constant RCC_RCC_PLLCFGR_PLL3FRACLE                       \ PLL3 fractional latch enable Set and reset by software to latch the content of FRACN into the sigma-delta modulator. In order to latch the FRACN value into the sigma-delta modulator, PLL3FRACLE must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN into the modulator. Refer to PLL initialization procedure on page 444 for additional information.
$00800000 constant RCC_RCC_PLLCFGR_PLL3VCOSEL                       \ PLL3 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL3. This bit must be written before enabling the PLL3. It allows the application to select the VCO range: VCOH: working from 400 to 1600 MHz (F<sub>ref2_ck</sub> must be between 2 and 16 MHz) VCOL: working from 150 to 420 MHz (F<sub>ref2_ck</sub> must be between 1 and 2 MHz)
$01000000 constant RCC_RCC_PLLCFGR_PLL3SSCGEN                       \ PLL3 SSCG enable Set and reset by software to enable the Spread Spectrum Clock Generator of PLL3, in order to reduce the amount of EMI peaks.
$06000000 constant RCC_RCC_PLLCFGR_PLL3RGE                          \ PLL3 input frequency range Set and reset by software to select the proper reference frequency range used for PLL3. These bits must be written before enabling the PLL3.
$08000000 constant RCC_RCC_PLLCFGR_PLL3DIVPEN                       \ PLL3 DIVP divider output enable Set and reset by software to enable the pll3_p_ck output of the PLL3. To save power, PLL3DIVREN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used.
$10000000 constant RCC_RCC_PLLCFGR_PLL3DIVQEN                       \ PLL3 DIVQ divider output enable Set and reset by software to enable the pll3_q_ck output of the PLL3. To save power, PLL3DIVREN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used.
$20000000 constant RCC_RCC_PLLCFGR_PLL3DIVREN                       \ PLL3 DIVR divider output enable Set and reset by software to enable the pll3_r_ck output of the PLL3. To save power, PLL3DIVREN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used.
$40000000 constant RCC_RCC_PLLCFGR_PLL3DIVSEN                       \ PLL3 DIVS divider output enable Set and reset by software to enable the pll3_s_ck output of the PLL3. To save power, PLL3DIVSEN must be set to 0 when the pll3_s_ck is not used.
$80000000 constant RCC_RCC_PLLCFGR_PLL3DIVTEN                       \ PLL3 DIVT divider output enable Set and reset by software to enable the pll3_t_ck output of the PLL3. To save power, PLL1DIVTEN must be set to 0 when the pll3_t_ck is not used.


\
\ @brief RCC PLL1 dividers configuration register 1
\ Address offset: 0x30
\ Reset value: 0x01010280
\

$000001ff constant RCC_RCC_PLL1DIVR1_DIVN1                          \ multiplication factor for PLL1 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL1ON = PLL1RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 544MHz if PLL1VCOSEL = 0 150 to 420 MHz if PLL1VCOSEL = 1 VCO output frequency = F<sub>ref1_ck</sub> x DIVN1, when fractional value 0 has been loaded into FRACN, with: DIVN1 between 8 and 420 The input frequency F<sub>ref1_ck</sub> must be between 1 and 16 MHz.
$0000fe00 constant RCC_RCC_PLL1DIVR1_DIVP                           \ PLL1 DIVP division factor Set and reset by software to control the frequency of the pll1_p_ck clock. These bits can be written only when the PLL1DIVPEN = 0. ...
$007f0000 constant RCC_RCC_PLL1DIVR1_DIVQ                           \ PLL1 DIVQ division factor Set and reset by software to control the frequency of the pll1_q_ck clock. These bits can be written only when the PLL1DIVQEN = 0. ...
$7f000000 constant RCC_RCC_PLL1DIVR1_DIVR1                          \ PLL1 DIVR division factor Set and reset by software to control the frequency of the pll1_r_ck clock. These bits can be written only when the PLL1DIVREN = 0. ...


\
\ @brief RCC PLL1 fractional divider register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL1FRACR_FRACN                          \ fractional part of the multiplication factor for PLL1 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 544 MHz if PLL1VCOSEL = 0 150 to 420 MHz if PLL1VCOSEL = 1 VCO output frequency = F<sub>ref1_ck</sub> x (DIVN1 + (FRACN / 2<sup>13</sup>)), with DIVN1 between 8 and 420 FRACN can be between 0 and 2<sup>13</sup>- 1 The input frequency F<sub>ref1_ck</sub> must be between 1 and 16 MHz. To change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACLE to 0. Write the new fractional value into FRACN. Set the bit PLL1FRACLE to 1.


\
\ @brief RCC PLL2 dividers configuration register 1
\ Address offset: 0x38
\ Reset value: 0x01010280
\

$000001ff constant RCC_RCC_PLL2DIVR1_DIVN2                          \ multiplication factor for PLL2 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL2ON = PLL2RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 544 MHz if PLL2VCOSEL = 0 150 to 420 MHz if PLL2VCOSEL = 1 VCO output frequency = F<sub>ref2_ck</sub> x DIVN2, when fractional value 0 has been loaded into FRACN, with DIVN2 between 8 and 420 The input frequency F<sub>ref2_ck</sub> must be between 1 and 16MHz.
$0000fe00 constant RCC_RCC_PLL2DIVR1_DIVP                           \ PLL2 DIVP division factor Set and reset by software to control the frequency of the pll2_p_ck clock. These bits can be written only when the PLL2DIVPEN = 0. ...
$007f0000 constant RCC_RCC_PLL2DIVR1_DIVQ                           \ PLL2 DIVQ division factor Set and reset by software to control the frequency of the pll2_q_ck clock. These bits can be written only when the PLL2DIVQEN = 0. ...
$7f000000 constant RCC_RCC_PLL2DIVR1_DIVR2                          \ PLL2 DIVR division factor Set and reset by software to control the frequency of the pll2_r_ck clock. These bits can be written only when the PLL2DIVREN = 0. ...


\
\ @brief RCC PLL2 fractional divider register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL2FRACR_FRACN                          \ fractional part of the multiplication factor for PLL2 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 544 MHz if PLL2VCOSEL = 0 150 to 420 MHz if PLL2VCOSEL = 1 VCO output frequency = F<sub>ref2_ck</sub> x (DIVN2 + (FRACN / 2<sup>13</sup>)), with DIVN2 between 8 and 420 FRACN can be between 0 and 2<sup>13 </sup>- 1 The input frequency F<sub>ref2_ck</sub> must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL2FRACLE to 0. Write the new fractional value into FRACN. Set the bit PLL2FRACLE to 1.


\
\ @brief RCC PLL3 dividers configuration register 1
\ Address offset: 0x40
\ Reset value: 0x01010280
\

$000001ff constant RCC_RCC_PLL3DIVR1_DIVN3                          \ Multiplication factor for PLL3 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL3ON = PLL3RDY = 0). ...........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 544 MHz if PLL3VCOSEL = 0 150 to 420 MHz if PLL3VCOSEL = 1 VCO output frequency = F<sub>ref3_ck</sub> x DIVN3, when fractional value 0 has been loaded into FRACN, with: DIVN3 between 8 and 420 The input frequency F<sub>ref3_ck</sub> must be between 1 and 16MHz
$0000fe00 constant RCC_RCC_PLL3DIVR1_DIVP                           \ PLL3 DIVP division factor Set and reset by software to control the frequency of the pll3_p_ck clock. These bits can be written only when the PLL3DIVPEN = 0. ...
$007f0000 constant RCC_RCC_PLL3DIVR1_DIVQ                           \ PLL3 DIVQ division factor Set and reset by software to control the frequency of the pll3_q_ck clock. These bits can be written only when the PLL3DIVQEN = 0. ...
$7f000000 constant RCC_RCC_PLL3DIVR1_DIVR3                          \ PLL3 DIVR division factor Set and reset by software to control the frequency of the pll3_r_ck clock. These bits can be written only when the PLL3DIVREN = 0. ...


\
\ @brief RCC PLL3 fractional divider register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL3FRACR_FRACN                          \ fractional part of the multiplication factor for PLL3 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL3 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 544 MHz if PLL3VCOSEL = 0 150 to 420 MHz if PLL3VCOSEL = 1 VCO output frequency = F<sub>ref3_ck</sub> x (DIVN3 + (FRACN / 2<sup>13</sup>)), with DIVN3 between 8 and 420 FRACN can be between 0 and 2<sup>13 </sup>- 1 The input frequency F<sub>ref3_ck</sub> must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACLE to 0. Write the new fractional value into FRACN. Set the bit PLL1FRACLE to 1.


\
\ @brief RCC AHB peripheral kernel clock selection register
\ Address offset: 0x4C
\ Reset value: 0x00000A00
\

$00000003 constant RCC_RCC_AHBPERCKSELR_FMCSEL                      \ FMC kernel clock source selection Set and reset by software.
$00000004 constant RCC_RCC_AHBPERCKSELR_SDMMCSEL                    \ SDMMC1 and SDMMC2 kernel clock source selection Set and reset by software.
$00000030 constant RCC_RCC_AHBPERCKSELR_OCTOSPI1SEL                 \ XSPI1 kernel clock source selection Set and reset by software. 1x: pll2_t_ck selected as kernel peripheral clock
$000000c0 constant RCC_RCC_AHBPERCKSELR_OCTOSPI2SEL                 \ XSPI2 kernel clock source selection Set and reset by software. 1x: pll2_t_ck selected as kernel peripheral clock
$00000f00 constant RCC_RCC_AHBPERCKSELR_USBREFCKSEL                 \ USBPHYC kernel clock frequency selection Set and reset by software. This field is used to indicate to the USBPHYC, the frequency of the reference kernel clock provided to the USBPHYC. others: reserved
$00003000 constant RCC_RCC_AHBPERCKSELR_USBPHYCSEL                  \ USBPHYC kernel clock source selection Set and reset by software.
$0000c000 constant RCC_RCC_AHBPERCKSELR_OTGFSSEL                    \ OTGFS kernel clock source selection Set and reset by software.
$00030000 constant RCC_RCC_AHBPERCKSELR_ETH1_REF_CLK_SEL            \ Ethernet reference clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00040000 constant RCC_RCC_AHBPERCKSELR_ETHPHY_CLK_SEL              \ Clock source selection for external Ethernet PHY Set and reset by software.
$00700000 constant RCC_RCC_AHBPERCKSELR_ADFSEL                      \ ADF kernel clock source selection Set and reset by software. Note: I2S_CKIN is an external clock taken from a pin.
$03000000 constant RCC_RCC_AHBPERCKSELR_ADCSEL                      \ SAR ADC kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$08000000 constant RCC_RCC_AHBPERCKSELR_PSSISEL                     \ PSSI kernel clock source selection Set and reset by software.
$30000000 constant RCC_RCC_AHBPERCKSELR_CKPERSEL                    \ per_ck clock source selection


\
\ @brief RCC APB1 peripherals kernel clock selection register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_APB1PERCKSELR_UART234578SEL              \ USART2,3, UART4,5,7,8 (APB1) kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000070 constant RCC_RCC_APB1PERCKSELR_SPI23SEL                   \ SPI/I2S2 and SPI/I2S3 kernel clock source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not be possible to switch to another clock. Refer to Clock switches and gating on page 437 for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin.
$00000300 constant RCC_RCC_APB1PERCKSELR_I2C23SEL                   \ I2C2, I2C3 kernel clock source selection Set and reset by software.
$00003000 constant RCC_RCC_APB1PERCKSELR_I2C1_I3C1SEL               \ I2C1 or I3C1 kernel clock source selection Set and reset by software.
$00070000 constant RCC_RCC_APB1PERCKSELR_LPTIM1SEL                  \ LPTIM1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00c00000 constant RCC_RCC_APB1PERCKSELR_FDCANSEL                   \ FDCAN kernel clock source selection
$03000000 constant RCC_RCC_APB1PERCKSELR_SPDIFRXSEL                 \ SPDIFRX kernel clock source selection
$30000000 constant RCC_RCC_APB1PERCKSELR_CECSEL                     \ HDMI-CEC kernel clock source selection Set and reset by software.


\
\ @brief RCC APB2 peripherals kernel clock selection register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_APB2PERCKSELR_USART1SEL                  \ USART1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000070 constant RCC_RCC_APB2PERCKSELR_SPI45SEL                   \ SPI4 and 5 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000700 constant RCC_RCC_APB2PERCKSELR_SPI1SEL                    \ SPI/I2S1 kernel clock source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not be possible to switch to another clock. Refer to Clock switches and gating on page 437 for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin.
$00070000 constant RCC_RCC_APB2PERCKSELR_SAI1SEL                    \ SAI1 kernel clock source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not possible to switch to another clock. Refer to Clock switches and gating on page 437 for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin.
$00700000 constant RCC_RCC_APB2PERCKSELR_SAI2SEL                    \ SAI2 kernel clock source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not possible to switch to another clock. Refer to Clock switches and gating on page 437 for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin. spdifrx_symb_ck is the symbol clock generated by the spdifrx (see Figure 51).


\
\ @brief RCC APB4,5 peripherals kernel clock selection register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_APB45PERCKSELR_LPUART1SEL                \ LPUART1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000070 constant RCC_RCC_APB45PERCKSELR_SPI6SEL                   \ SPI/I2S6 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000700 constant RCC_RCC_APB45PERCKSELR_LPTIM23SEL                \ LPTIM2 and LPTIM3 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00007000 constant RCC_RCC_APB45PERCKSELR_LPTIM45SEL                \ LPTIM4, and LPTIM5 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC clock source interrupt enable register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CIER_LSIRDYIE                            \ LSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the LSI oscillator stabilization.
$00000002 constant RCC_RCC_CIER_LSERDYIE                            \ LSE ready interrupt enable Set and reset by software to enable/disable interrupt caused by the LSE oscillator stabilization.
$00000004 constant RCC_RCC_CIER_HSIRDYIE                            \ HSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the HSI oscillator stabilization.
$00000008 constant RCC_RCC_CIER_HSERDYIE                            \ HSE ready interrupt enable Set and reset by software to enable/disable interrupt caused by the HSE oscillator stabilization.
$00000010 constant RCC_RCC_CIER_CSIRDYIE                            \ CSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the CSI oscillator stabilization.
$00000020 constant RCC_RCC_CIER_HSI48RDYIE                          \ HSI48 ready interrupt enable Set and reset by software to enable/disable interrupt caused by the HSI48 oscillator stabilization.
$00000040 constant RCC_RCC_CIER_PLL1RDYIE                           \ PLL1 ready interrupt enable Set and reset by software to enable/disable interrupt caused by PLL1 lock.
$00000080 constant RCC_RCC_CIER_PLL2RDYIE                           \ PLL2 ready interrupt enable Set and reset by software to enable/disable interrupt caused by PLL2 lock.
$00000100 constant RCC_RCC_CIER_PLL3RDYIE                           \ PLL3 ready interrupt enable Set and reset by software to enable/disable interrupt caused by PLL3 lock.
$00000200 constant RCC_RCC_CIER_LSECSSIE                            \ LSE clock security system interrupt enable Set and reset by software to enable/disable interrupt caused by the clock security system (CSS) on external 32 kHz oscillator.


\
\ @brief RCC clock source interrupt flag register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CIFR_LSIRDYF                             \ LSI ready interrupt flag Reset by software by writing LSIRDYC bit. Set by hardware when the LSI clock becomes stable and LSIRDYIE is set.
$00000002 constant RCC_RCC_CIFR_LSERDYF                             \ LSE ready interrupt flag Reset by software by writing LSERDYC bit. Set by hardware when the LSE clock becomes stable and LSERDYIE is set.
$00000004 constant RCC_RCC_CIFR_HSIRDYF                             \ HSI ready interrupt flag Reset by software by writing HSIRDYC bit. Set by hardware when the HSI clock becomes stable and HSIRDYIE is set.
$00000008 constant RCC_RCC_CIFR_HSERDYF                             \ HSE ready interrupt flag Reset by software by writing HSERDYC bit. Set by hardware when the HSE clock becomes stable and HSERDYIE is set.
$00000010 constant RCC_RCC_CIFR_CSIRDYF                             \ CSI ready interrupt flag Reset by software by writing CSIRDYC bit. Set by hardware when the CSI clock becomes stable and CSIRDYIE is set.
$00000020 constant RCC_RCC_CIFR_HSI48RDYF                           \ HSI48 ready interrupt flag Reset by software by writing HSI48RDYC bit. Set by hardware when the HSI48 clock becomes stable and HSI48RDYIE is set.
$00000040 constant RCC_RCC_CIFR_PLL1RDYF                            \ PLL1 ready interrupt flag Reset by software by writing PLL1RDYC bit. Set by hardware when the PLL1 locks and PLL1RDYIE is set.
$00000080 constant RCC_RCC_CIFR_PLL2RDYF                            \ PLL2 ready interrupt flag Reset by software by writing PLL2RDYC bit. Set by hardware when the PLL2 locks and PLL2RDYIE is set.
$00000100 constant RCC_RCC_CIFR_PLL3RDYF                            \ PLL3 ready interrupt flag Reset by software by writing PLL3RDYC bit. Set by hardware when the PLL3 locks and PLL3RDYIE is set.
$00000200 constant RCC_RCC_CIFR_LSECSSF                             \ LSE clock security system interrupt flag Reset by software by writing LSECSSC bit. Set by hardware when a failure is detected on the external 32 kHz oscillator and LSECSSIE is set.
$00000400 constant RCC_RCC_CIFR_HSECSSF                             \ HSE clock security system interrupt flag Reset by software by writing HSECSSC bit. Set by hardware in case of HSE clock failure.


\
\ @brief RCC clock source interrupt clear register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CICR_LSIRDYC                             \ LSI ready interrupt clear Set by software to clear LSIRDYF. Reset by hardware when clear done.
$00000002 constant RCC_RCC_CICR_LSERDYC                             \ LSE ready interrupt clear Set by software to clear LSERDYF. Reset by hardware when clear done.
$00000004 constant RCC_RCC_CICR_HSIRDYC                             \ HSI ready interrupt clear Set by software to clear HSIRDYF. Reset by hardware when clear done.
$00000008 constant RCC_RCC_CICR_HSERDYC                             \ HSE ready interrupt clear Set by software to clear HSERDYF. Reset by hardware when clear done.
$00000010 constant RCC_RCC_CICR_CSIRDYC                             \ CSI ready interrupt clear Set by software to clear CSIRDYF. Reset by hardware when clear done.
$00000020 constant RCC_RCC_CICR_HSI48RDYC                           \ HSI48 ready interrupt clear Set by software to clear HSI48RDYF. Reset by hardware when clear done.
$00000040 constant RCC_RCC_CICR_PLL1RDYC                            \ PLL1 ready interrupt clear Set by software to clear PLL1RDYF. Reset by hardware when clear done.
$00000080 constant RCC_RCC_CICR_PLL2RDYC                            \ PLL2 ready interrupt clear Set by software to clear PLL2RDYF. Reset by hardware when clear done.
$00000100 constant RCC_RCC_CICR_PLL3RDYC                            \ PLL3 ready interrupt clear Set by software to clear PLL3RDYF. Reset by hardware when clear done.
$00000200 constant RCC_RCC_CICR_LSECSSC                             \ LSE clock security system interrupt clear Set by software to clear LSECSSF. Reset by hardware when clear done.
$00000400 constant RCC_RCC_CICR_HSECSSC                             \ HSE clock security system interrupt clear Set by software to clear HSECSSF. Reset by hardware when clear done.


\
\ @brief RCC Backup domain control register
\ Address offset: 0x70
\ Reset value: 0x00000010
\

$00000001 constant RCC_RCC_BDCR_LSEON                               \ LSE oscillator enabled Set and reset by software.
$00000002 constant RCC_RCC_BDCR_LSERDY                              \ LSE oscillator ready Set and reset by hardware to indicate when the LSE is stable. This bit needs 6 cycles of lse_ck clock to fall down after LSEON has been set to 0.
$00000004 constant RCC_RCC_BDCR_LSEBYP                              \ LSE oscillator bypass Set and reset by software to bypass oscillator in debug mode. This bit must not be written when the LSE is enabled (by LSEON) or ready (LSERDY = 1)
$00000018 constant RCC_RCC_BDCR_LSEDRV                              \ LSE oscillator driving capability Set by software to select the driving capability of the LSE oscillator.
$00000020 constant RCC_RCC_BDCR_LSECSSON                            \ LSE clock security system enable Set by software to enable the clock security system on 32 kHz oscillator. LSECSSON must be enabled after LSE is enabled (LSEON enabled) and ready (LSERDY set by hardware) and after RTCSEL is selected. Once enabled, this bit can only be disabled, After a LSE failure detection (LSECSSD = 1). In that case the software must disable LSECSSON. After a back-up domain reset
$00000040 constant RCC_RCC_BDCR_LSECSSD                             \ LSE clock security system failure detection Set by hardware to indicate when a failure has been detected by the clock security system on the external 32 kHz oscillator.
$00000080 constant RCC_RCC_BDCR_LSEEXT                              \ low-speed external clock type in Bypass mode Set and reset by software to select the external clock type (analog or digital). The external clock must be enabled with the LSEON bit, to be used by the device. The LSEEXT bit can be written only if the LSE oscillator is disabled.
$00000300 constant RCC_RCC_BDCR_RTCSEL                              \ RTC clock source selection Set by software to select the clock source for the RTC. These bits can be written only one time (except in case of failure detection on LSE). These bits must be written before LSECSSON is enabled. The VSWRST bit can be used to reset them, then it can be written one time again. If HSE is selected as RTC clock, this clock is lost when the system is in Stop mode or in case of a pin reset (NRST).
$00001000 constant RCC_RCC_BDCR_LSECSSRA                            \ Re-Arm the LSECSS function Set by software. After a LSE failure detection, the software application can re-enable the LSECSS by writing this bit to 1. Reading this bit returns the written value. Prior to set this bit to 1, LSECSSON must be set to 0. Please refer to Section : CSS on LSE for details.
$00008000 constant RCC_RCC_BDCR_RTCEN                               \ RTC clock enable Set and reset by software.
$00010000 constant RCC_RCC_BDCR_VSWRST                              \ VSwitch domain software reset Set and reset by software. To generate a VSW reset, it is recommended to write this bit to 1, then back to 0.


\
\ @brief RCC clock control and status register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CSR_LSION                                \ LSI oscillator enable Set and reset by software.
$00000002 constant RCC_RCC_CSR_LSIRDY                               \ LSI oscillator ready Set and reset by hardware to indicate when the low-speed internal RC oscillator is stable. This bit needs 3 cycles of lsi_ck clock to fall down after LSION has been set to 0. This bit can be set even when LSION is not enabled if there is a request for LSI clock by the clock security system on LSE or by the low-speed watchdog or by the RTC.


\
\ @brief RCC AHB5 peripheral reset register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB5RSTR_HPDMA1RST                       \ HPDMA1 block reset Set and reset by software.
$00000002 constant RCC_RCC_AHB5RSTR_DMA2DRST                        \ DMA2D block reset Set and reset by software.
$00000008 constant RCC_RCC_AHB5RSTR_JPEGRST                         \ JPEG block reset Set and reset by software.
$00000010 constant RCC_RCC_AHB5RSTR_FMCRST                          \ FMC and MCE3 blocks reset Set and reset by software. The hardware prevents writing this bit if FMCCKP = 1.
$00000020 constant RCC_RCC_AHB5RSTR_XSPI1RST                        \ XSPI1 and MCE1 blocks reset Set and reset by software. The hardware prevents writing this bit if XSPICKP = 1.
$00000100 constant RCC_RCC_AHB5RSTR_SDMMC1RST                       \ SDMMC1 and DB_SDMMC1 blocks reset Set and reset by software.
$00001000 constant RCC_RCC_AHB5RSTR_XSPI2RST                        \ XSPI2 and MCE2 blocks reset Set and reset by software. The hardware prevents writing this bit if XSPICKP = 1.
$00004000 constant RCC_RCC_AHB5RSTR_IOMNGRRST                       \ XSPIM reset Set and reset by software.
$00080000 constant RCC_RCC_AHB5RSTR_GFXMMURST                       \ GFXMMU block reset Set and reset by software.
$00100000 constant RCC_RCC_AHB5RSTR_GPURST                          \ GPU block reset Set and reset by software.


\
\ @brief RCC AHB1 peripheral reset register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000010 constant RCC_RCC_AHB1RSTR_GPDMA1RST                       \ GPDMA1 blocks reset Set and reset by software.
$00000020 constant RCC_RCC_AHB1RSTR_ADC12RST                        \ ADC1 and 2 blocks reset Set and reset by software.
$00008000 constant RCC_RCC_AHB1RSTR_ETH1RST                         \ ETH1 block reset Set and reset by software.
$02000000 constant RCC_RCC_AHB1RSTR_OTGHSRST                        \ OTGHS block reset Set and reset by software.
$04000000 constant RCC_RCC_AHB1RSTR_USBPHYCRST                      \ USBPHYC block reset Set and reset by software.
$08000000 constant RCC_RCC_AHB1RSTR_OTGFSRST                        \ OTGFS block reset Set and reset by software.
$80000000 constant RCC_RCC_AHB1RSTR_ADFRST                          \ ADF block reset Set and reset by software.


\
\ @brief RCC AHB2 peripheral reset register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_AHB2RSTR_PSSIRST                         \ PSSI block reset Set and reset by software.
$00000200 constant RCC_RCC_AHB2RSTR_SDMMC2RST                       \ SDMMC2 and SDMMC2 delay blocks reset Set and reset by software.
$00004000 constant RCC_RCC_AHB2RSTR_CORDICRST                       \ CORDIC reset Set and reset by software.


\
\ @brief RCC AHB4 peripheral reset register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB4RSTR_GPIOARST                        \ GPIOA block reset Set and reset by software.
$00000002 constant RCC_RCC_AHB4RSTR_GPIOBRST                        \ GPIOB block reset Set and reset by software.
$00000004 constant RCC_RCC_AHB4RSTR_GPIOCRST                        \ GPIOC block reset Set and reset by software.
$00000008 constant RCC_RCC_AHB4RSTR_GPIODRST                        \ GPIOD block reset Set and reset by software.
$00000010 constant RCC_RCC_AHB4RSTR_GPIOERST                        \ GPIOE block reset Set and reset by software.
$00000020 constant RCC_RCC_AHB4RSTR_GPIOFRST                        \ GPIOF block reset Set and reset by software.
$00000040 constant RCC_RCC_AHB4RSTR_GPIOGRST                        \ GPIOG block reset Set and reset by software.
$00000080 constant RCC_RCC_AHB4RSTR_GPIOHRST                        \ GPIOH block reset Set and reset by software.
$00001000 constant RCC_RCC_AHB4RSTR_GPIOMRST                        \ GPIOM block reset Set and reset by software.
$00002000 constant RCC_RCC_AHB4RSTR_GPIONRST                        \ GPION block reset Set and reset by software.
$00004000 constant RCC_RCC_AHB4RSTR_GPIOORST                        \ GPIOO block reset Set and reset by software.
$00008000 constant RCC_RCC_AHB4RSTR_GPIOPRST                        \ GPIOP block reset Set and reset by software.
$00080000 constant RCC_RCC_AHB4RSTR_CRCRST                          \ CRC block reset Set and reset by software.


\
\ @brief RCC APB5 peripheral reset register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB5RSTR_LTDCRST                         \ LTDC block reset Set and reset by software.
$00000004 constant RCC_RCC_APB5RSTR_DCMIPPRST                       \ DCMIPP block reset Set and reset by software.
$00000010 constant RCC_RCC_APB5RSTR_GFXTIMRST                       \ GFXTIM block reset Set and reset by software.


\
\ @brief RCC APB1 peripheral reset register 1
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1RSTR1_TIM2RST                        \ TIM2 block reset Set and reset by software.
$00000002 constant RCC_RCC_APB1RSTR1_TIM3RST                        \ TIM3 block reset Set and reset by software.
$00000004 constant RCC_RCC_APB1RSTR1_TIM4RST                        \ TIM4 block reset Set and reset by software.
$00000008 constant RCC_RCC_APB1RSTR1_TIM5RST                        \ TIM5 block reset Set and reset by software.
$00000010 constant RCC_RCC_APB1RSTR1_TIM6RST                        \ TIM6 block reset Set and reset by software.
$00000020 constant RCC_RCC_APB1RSTR1_TIM7RST                        \ TIM7 block reset Set and reset by software.
$00000040 constant RCC_RCC_APB1RSTR1_TIM12RST                       \ TIM12 block reset Set and reset by software.
$00000080 constant RCC_RCC_APB1RSTR1_TIM13RST                       \ TIM13 block reset Set and reset by software.
$00000100 constant RCC_RCC_APB1RSTR1_TIM14RST                       \ TIM14 block reset Set and reset by software.
$00000200 constant RCC_RCC_APB1RSTR1_LPTIM1RST                      \ LPTIM1 block reset Set and reset by software.
$00004000 constant RCC_RCC_APB1RSTR1_SPI2RST                        \ SPI2S2 block reset Set and reset by software.
$00008000 constant RCC_RCC_APB1RSTR1_SPI3RST                        \ SPI2S3 block reset Set and reset by software.
$00010000 constant RCC_RCC_APB1RSTR1_SPDIFRXRST                     \ SPDIFRX block reset Set and reset by software.
$00020000 constant RCC_RCC_APB1RSTR1_USART2RST                      \ USART2 block reset Set and reset by software.
$00040000 constant RCC_RCC_APB1RSTR1_USART3RST                      \ USART3 block reset Set and reset by software.
$00080000 constant RCC_RCC_APB1RSTR1_UART4RST                       \ UART4 block reset Set and reset by software.
$00100000 constant RCC_RCC_APB1RSTR1_UART5RST                       \ UART5 block reset Set and reset by software.
$00200000 constant RCC_RCC_APB1RSTR1_I2C1_I3C1RST                   \ I2C1/I3C1 block reset Set and reset by software.
$00400000 constant RCC_RCC_APB1RSTR1_I2C2RST                        \ I2C2 block reset Set and reset by software.
$00800000 constant RCC_RCC_APB1RSTR1_I2C3RST                        \ I2C3 block reset Set and reset by software.
$08000000 constant RCC_RCC_APB1RSTR1_HDMICECRST                     \ HDMI-CEC block reset Set and reset by software.
$40000000 constant RCC_RCC_APB1RSTR1_UART7RST                       \ UART7 block reset Set and reset by software.
$80000000 constant RCC_RCC_APB1RSTR1_UART8RST                       \ UART8 block reset Set and reset by software.


\
\ @brief RCC APB1 peripheral reset register 2
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB1RSTR2_CRSRST                         \ clock recovery system reset Set and reset by software.
$00000020 constant RCC_RCC_APB1RSTR2_MDIOSRST                       \ MDIOS block reset Set and reset by software.
$00000100 constant RCC_RCC_APB1RSTR2_FDCANRST                       \ FDCAN block reset Set and reset by software.
$08000000 constant RCC_RCC_APB1RSTR2_UCPDRST                        \ UCPD block reset Set and reset by software.


\
\ @brief RCC APB2 peripheral reset register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB2RSTR_TIM1RST                         \ TIM1 block reset Set and reset by software.
$00000010 constant RCC_RCC_APB2RSTR_USART1RST                       \ USART1 block reset Set and reset by software.
$00001000 constant RCC_RCC_APB2RSTR_SPI1RST                         \ SPI2S1 block reset Set and reset by software.
$00002000 constant RCC_RCC_APB2RSTR_SPI4RST                         \ SPI4 block reset Set and reset by software.
$00010000 constant RCC_RCC_APB2RSTR_TIM15RST                        \ TIM15 block reset Set and reset by software.
$00020000 constant RCC_RCC_APB2RSTR_TIM16RST                        \ TIM16 block reset Set and reset by software.
$00040000 constant RCC_RCC_APB2RSTR_TIM17RST                        \ TIM17 block reset Set and reset by software.
$00080000 constant RCC_RCC_APB2RSTR_TIM9RST                         \ TIM9 block reset Set and reset by software.
$00100000 constant RCC_RCC_APB2RSTR_SPI5RST                         \ SPI5 block reset Set and reset by software.
$00400000 constant RCC_RCC_APB2RSTR_SAI1RST                         \ SAI1 block reset Set and reset by software.
$00800000 constant RCC_RCC_APB2RSTR_SAI2RST                         \ SAI2 block reset Set and reset by software.


\
\ @brief RCC APB4 peripheral reset register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB4RSTR_SBSRST                          \ SBS block reset Set and reset by software.
$00000008 constant RCC_RCC_APB4RSTR_LPUART1RST                      \ LPUART1 block reset Set and reset by software.
$00000020 constant RCC_RCC_APB4RSTR_SPI6RST                         \ SPI/I2S6 block reset Set and reset by software.
$00000200 constant RCC_RCC_APB4RSTR_LPTIM2RST                       \ LPTIM2 block reset Set and reset by software.
$00000400 constant RCC_RCC_APB4RSTR_LPTIM3RST                       \ LPTIM3 block reset Set and reset by software.
$00000800 constant RCC_RCC_APB4RSTR_LPTIM4RST                       \ LPTIM4 block reset Set and reset by software.
$00001000 constant RCC_RCC_APB4RSTR_LPTIM5RST                       \ LPTIM5 block reset Set and reset by software.
$00008000 constant RCC_RCC_APB4RSTR_VREFRST                         \ VREF block reset Set and reset by software.
$04000000 constant RCC_RCC_APB4RSTR_TMPSENSRST                      \ TMPSENS block reset Set and reset by software.


\
\ @brief RCC AHB3 peripheral reset register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB3RSTR_RNGRST                          \ random number generator block reset Set and reset by software.
$00000002 constant RCC_RCC_AHB3RSTR_HASHRST                         \ HASH block reset Set and reset by software.


\
\ @brief RCC AXI clocks gating disable register
\ Address offset: 0xB0
\ Reset value: 0x80000000
\

$00000001 constant RCC_RCC_CKGDISR_AXICKG                           \ AXI interconnect matrix clock gating disable This bit is set and reset by software.
$00000002 constant RCC_RCC_CKGDISR_AHBMCKG                          \ AXI master AHB clock gating disable This bit is set and reset by software.
$00000004 constant RCC_RCC_CKGDISR_SDMMC1CKG                        \ AXI master SDMMC1 clock gating disable This bit is set and reset by software.
$00000008 constant RCC_RCC_CKGDISR_HPDMA1CKG                        \ AXI master HPDMA1 clock gating disable This bit is set and reset by software.
$00000010 constant RCC_RCC_CKGDISR_CPUCKG                           \ AXI master CPU clock gating disable This bit is set and reset by software.
$00000020 constant RCC_RCC_CKGDISR_GPUS0CKG                         \ AXI master 0 GPU clock gating disable This bit is set and reset by software.
$00000040 constant RCC_RCC_CKGDISR_GPUS1CKG                         \ AXI master 1 GPU clock gating disable This bit is set and reset by software.
$00000080 constant RCC_RCC_CKGDISR_GPUCLCKG                         \ AXI master cache GPU clock gating disable This bit is set and reset by software.
$00000100 constant RCC_RCC_CKGDISR_DCMIPPCKG                        \ AXI master DCMIPP clock gating disable This bit is set and reset by software.
$00000200 constant RCC_RCC_CKGDISR_DMA2DCKG                         \ AXI master DMA2D clock gating disable This bit is set and reset by software.
$00000400 constant RCC_RCC_CKGDISR_GFXMMUSCKG                       \ AXI matrix slave GFXMMU clock gating disable This bit is set and reset by software.
$00000800 constant RCC_RCC_CKGDISR_LTDCCKG                          \ AXI master LTDC clock gating disable This bit is set and reset by software.
$00001000 constant RCC_RCC_CKGDISR_GFXMMUMCKG                       \ AXI master GFXMMU clock gating disable This bit is set and reset by software.
$00002000 constant RCC_RCC_CKGDISR_AHBSCKG                          \ AXI slave AHB clock gating disable This bit is set and reset by software.
$00004000 constant RCC_RCC_CKGDISR_FMCCKG                           \ AXI slave FMC and MCE3 clock gating disable This bit is set and reset by software.
$00008000 constant RCC_RCC_CKGDISR_XSPI1CKG                         \ AXI slave XSPI1 and MCE1 clock gating disable This bit is set and reset by software.
$00010000 constant RCC_RCC_CKGDISR_XSPI2CKG                         \ AXI slave XSPI2 and MCE2 clock gating disable This bit is set and reset by software.
$00020000 constant RCC_RCC_CKGDISR_AXIRAM4CKG                       \ AXI matrix slave SRAM4 clock gating disable This bit is set and reset by software.
$00040000 constant RCC_RCC_CKGDISR_AXIRAM3CKG                       \ AXI matrix slave SRAM3 clock gating disable This bit is set and reset by software.
$00080000 constant RCC_RCC_CKGDISR_AXIRAM2CKG                       \ AXI slave SRAM2 clock gating disable This bit is set and reset by software.
$00100000 constant RCC_RCC_CKGDISR_AXIRAM1CKG                       \ AXI slave SRAM1 / error code correction (ECC) clock gating disable This bit is set and reset by software.
$00200000 constant RCC_RCC_CKGDISR_FLITFCKG                         \ AXI slave Flash interface (FLIFT) clock gating disable This bit is set and reset by software.
$40000000 constant RCC_RCC_CKGDISR_EXTICKG                          \ EXTI clock gating disable This bit is set and reset by software.
$80000000 constant RCC_RCC_CKGDISR_JTAGCKG                          \ JTAG automatic clock gating disabling This bit is set and reset by software.


\
\ @brief RCC PLL1 dividers configuration register 2
\ Address offset: 0xC0
\ Reset value: 0x00000101
\

$00000007 constant RCC_RCC_PLL1DIVR2_DIVS                           \ PLL1 DIVS division factor Set and reset by software to control the frequency of the pll1_s_ck clock. This post-divider performs divisions with 50% duty-cycle. The duty-cycle of 50% is guaranteed only in the following conditions: With VCOL, if (DIVS+1) is even, With VCOH, for all DIVS values These bits can be written only when the PLL1DIVSEN = 0.
$00000700 constant RCC_RCC_PLL1DIVR2_DIVT                           \ PLL1 DIVT division factor Set and reset by software to control the frequency of the pll1_t_ck clock. This post-divider performs divisions with 50% duty-cycle. The duty-cycle of 50% is guaranteed only in the following conditions: With VCOL, if (DIVT+1) is even, With VCOH, for all DIVT values These bits can be written only when the PLL1DIVTEN = 0.


\
\ @brief RCC PLL2 dividers configuration register 2
\ Address offset: 0xC4
\ Reset value: 0x00000101
\

$00000007 constant RCC_RCC_PLL2DIVR2_DIVS                           \ PLL2 DIVS division factor Set and reset by software to control the frequency of the pll2_s_ck clock. This post-divider performs divisions with 50% duty-cycle. The duty-cycle of 50% is guaranteed only in the following conditions: With VCOL, if (DIVS+1) is even, With VCOH, for all DIVS values These bits can be written only when the PLL2DIVSEN = 0.
$00000700 constant RCC_RCC_PLL2DIVR2_DIVT                           \ PLL2 DIVT division factor Set and reset by software to control the frequency of the pll2_t_ck clock. This post-divider performs divisions with 50% duty-cycle. The duty-cycle of 50% is guaranteed only in the following conditions: With VCOL, if (DIVT+1) is even, With VCOH, for all DIVT values These bits can be written only when the PLL2DIVTEN = 0.


\
\ @brief RCC PLL3 dividers configuration register 2
\ Address offset: 0xC8
\ Reset value: 0x00000101
\

$00000007 constant RCC_RCC_PLL3DIVR2_DIVS                           \ PLL3 DIVS division factor Set and reset by software to control the frequency of the pll3_s_ck clock. This post-divider performs divisions with 50% duty-cycle. The duty-cycle of 50% is guaranteed only in the following conditions: With VCOL, if (DIVS+1) is even, With VCOH, for all DIVS values These bits can be written only when the PLL3DIVSEN = 0.
$00000700 constant RCC_RCC_PLL3DIVR2_DIVT                           \ PLL3 DIVT division factor Set and reset by software to control the frequency of the pll3_t_ck clock. This post-divider performs divisions with 50% duty-cycle. The duty-cycle of 50% is guaranteed only in the following conditions: With VCOL, if (DIVT+1) is even, With VCOH, for all DIVT values These bits can be written only when the PLL3DIVTEN = 0.


\
\ @brief RCC PLL1 Spread Spectrum Clock Generator register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00001fff constant RCC_RCC_PLL1SSCGR_MOD_PER                        \ Modulation Period Adjustment for PLL1 Set and reset by software to adjust the modulation period of the clock spreading generator.
$00002000 constant RCC_RCC_PLL1SSCGR_TPDFN_DIS1                     \ Dithering TPDF noise control for PLL1 Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
$00004000 constant RCC_RCC_PLL1SSCGR_RPDFN_DIS1                     \ Dithering RPDF noise control for PLL1 Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
$00008000 constant RCC_RCC_PLL1SSCGR_DWNSPREAD1                     \ Spread spectrum clock generator mode for PLL1 Set and reset by software to select the clock spreading mode.
$7fff0000 constant RCC_RCC_PLL1SSCGR_INC_STEP                       \ Modulation Depth Adjustment for PLL1 Set and reset by software to adjust the modulation depth of the clock spreading generator.


\
\ @brief RCC PLL2 Spread Spectrum Clock Generator register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00001fff constant RCC_RCC_PLL2SSCGR_MOD_PER                        \ Modulation Period Adjustment for PLL2 Set and reset by software to adjust the modulation period of the clock spreading generator.
$00002000 constant RCC_RCC_PLL2SSCGR_TPDFN_DIS2                     \ Dithering TPDF noise control for PLL2 Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
$00004000 constant RCC_RCC_PLL2SSCGR_RPDFN_DIS2                     \ Dithering RPDF noise control for PLL2 Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
$00008000 constant RCC_RCC_PLL2SSCGR_DWNSPREAD2                     \ Spread spectrum clock generator mode for PLL2 Set and reset by software to select the clock spreading mode.
$7fff0000 constant RCC_RCC_PLL2SSCGR_INC_STEP                       \ Modulation Depth Adjustment for PLL2 Set and reset by software to adjust the modulation depth of the clock spreading generator.


\
\ @brief RCC PLL3 Spread Spectrum Clock Generator register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00001fff constant RCC_RCC_PLL3SSCGR_MOD_PER                        \ Modulation Period Adjustment for PLL3 Set and reset by software to adjust the modulation period of the clock spreading generator.
$00002000 constant RCC_RCC_PLL3SSCGR_TPDFN_DIS3                     \ Dithering TPDF noise control for PLL3 Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a triangular probability density function.
$00004000 constant RCC_RCC_PLL3SSCGR_RPDFN_DIS3                     \ Dithering RPDF noise control for PLL3 Set and reset by software. This bit is used to enable or disable the injection of a dithering noise into the SSCG modulator. This dithering noise is generated using a rectangular probability density function.
$00008000 constant RCC_RCC_PLL3SSCGR_DWNSPREAD3                     \ Spread spectrum clock generator mode for PLL3 Set and reset by software to select the clock spreading mode.
$7fff0000 constant RCC_RCC_PLL3SSCGR_INC_STEP                       \ Modulation Depth Adjustment for PLL3 Set and reset by software to adjust the modulation depth of the clock spreading generator.


\
\ @brief RCC clock protection register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CKPROTR_XSPICKP                          \ XSPI clock protection Set and cleared by software. When set to 1, this bit prevents disabling accidentally the XSPIs. The following fields cannot be modified when this bit is set to 1: PLL2ON, PLL2DIVSEN, PLL2DIVTEN, HSEON, HSION, CSION, XSPIxEN, OCTOSPIxLPEN, OCTOSPIxRST.
$00000002 constant RCC_RCC_CKPROTR_FMCCKP                           \ FMC clock protection Set and cleared by software. When set to 1, this bit prevents disabling accidentally the FMC. The following fields cannot be modified when this bit is set to 1: PLL1ON, PLL2ON, PLL1DIVQEN, PLL2DIVREN, HSEON, HSION, CSION, FMCEN, FMCLPEN, FMCRST.
$00000070 constant RCC_RCC_CKPROTR_XSPI1SWP                         \ XSPI1 kernel clock switch position Set by hardware. This field can be used to verify the real position of XSPI2 kernel switch selector.
$00000700 constant RCC_RCC_CKPROTR_XSPI2SWP                         \ XSPI2 kernel clock switch position Set by hardware. This field can be used to verify the real position of XSPI2 kernel switch selector.
$00007000 constant RCC_RCC_CKPROTR_FMCSWP                           \ FMC kernel clock switch position Set by hardware. This field can be used to verify the real position of FMC kernel switch selector.


\
\ @brief RCC Reset status register
\ Address offset: 0x130
\ Reset value: 0x00E00000
\

$00010000 constant RCC_RCC_RSR_RMVF                                 \ remove reset flag Set and reset by software to reset the value of the reset flags.
$00020000 constant RCC_RCC_RSR_OBLRSTF                              \ Option byte loading reset flag <sup>(1)</sup> Reset by software by the RMVF bit. Set by hardware when a reset from the option byte loading occurs.
$00200000 constant RCC_RCC_RSR_BORRSTF                              \ BOR reset flag <sup>(1)</sup> Reset by software by writing the RMVF bit. Set by hardware when a BOR reset occurs (pwr_bor_rst).
$00400000 constant RCC_RCC_RSR_PINRSTF                              \ pin reset flag (NRST) <sup>(1)</sup> Reset by software by writing the RMVF bit. Set by hardware when a reset from pin occurs.
$00800000 constant RCC_RCC_RSR_PORRSTF                              \ POR/PDR reset flag <sup>(1)</sup> Reset by software by writing the RMVF bit. Set by hardware when a POR/PDR reset occurs.
$01000000 constant RCC_RCC_RSR_SFTRSTF                              \ system reset from CPU reset flag <sup>(1)</sup> Reset by software by writing the RMVF bit. Set by hardware when the system reset is due to CPU.The CPU can generate a system reset by writing SYSRESETREQ bit of AIRCR register of the core M7.
$04000000 constant RCC_RCC_RSR_IWDGRSTF                             \ independent watchdog reset flag <sup>(1)</sup> Reset by software by writing the RMVF bit. Set by hardware when an independent watchdog reset occurs.
$10000000 constant RCC_RCC_RSR_WWDGRSTF                             \ window watchdog reset flag <sup>(1)</sup> Reset by software by writing the RMVF bit. Set by hardware when a window watchdog reset occurs.
$40000000 constant RCC_RCC_RSR_LPWRRSTF                             \ reset due to illegal Stop or Standby flag Reset by software by writing the RMVF bit. Set by hardware when the CPU goes erroneously in Stop or Standby mode,


\
\ @brief RCC AHB5 clock enable register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB5ENR_HPDMA1EN                         \ HPDMA1 peripheral clock enable Set and reset by software.
$00000002 constant RCC_RCC_AHB5ENR_DMA2DEN                          \ DMA2D peripheral clock enable Set and reset by software.
$00000008 constant RCC_RCC_AHB5ENR_JPEGEN                           \ JPEG peripheral clock enable Set and reset by software.
$00000010 constant RCC_RCC_AHB5ENR_FMCEN                            \ FMC and MCE3 peripheral clocks enable Set and reset by software. The hardware prevents writing this bit if FMCCKP = 1. The peripheral clocks of the FMC are the kernel clock selected by FMCSEL, and the hclk5 bus interface clock.
$00000020 constant RCC_RCC_AHB5ENR_XSPI1EN                          \ XSPI1 and MCE1 peripheral clocks enable Set and reset by software. The hardware prevents writing this bit if XSPICKP = 1.
$00000100 constant RCC_RCC_AHB5ENR_SDMMC1EN                         \ SDMMC1 and DB_SDMMC1 peripheral clocks enable Set and reset by software.
$00001000 constant RCC_RCC_AHB5ENR_XSPI2EN                          \ XSPI2 and MCE2 peripheral clocks enable Set and reset by software. The hardware prevents writing this bit if XSPICKP = 1.
$00004000 constant RCC_RCC_AHB5ENR_IOMNGREN                         \ XSPIM peripheral clock enable Set and reset by software.
$00080000 constant RCC_RCC_AHB5ENR_GFXMMUEN                         \ GFXMMU peripheral clock enable Set and reset by software.
$00100000 constant RCC_RCC_AHB5ENR_GPUEN                            \ GPU peripheral clock enable Set and reset by software.


\
\ @brief RCC AHB1 clock enable register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000010 constant RCC_RCC_AHB1ENR_GPDMA1EN                         \ GPDMA1 clock enable Set and reset by software.
$00000020 constant RCC_RCC_AHB1ENR_ADC12EN                          \ ADC1 and 2 peripheral clocks enable Set and reset by software. The peripheral clocks of the ADC1 and 2 are the kernel clock selected by ADCSEL and provided to ADCx_CK input, and the hclk1 bus interface clock.
$00008000 constant RCC_RCC_AHB1ENR_ETH1MACEN                        \ ETH1 MAC peripheral clock enable Set and reset by software.
$00010000 constant RCC_RCC_AHB1ENR_ETH1TXEN                         \ ETH1 transmission clock enable Set and reset by software.
$00020000 constant RCC_RCC_AHB1ENR_ETH1RXEN                         \ ETH1 reception clock enable Set and reset by software.
$02000000 constant RCC_RCC_AHB1ENR_OTGHSEN                          \ OTGHS clocks enable Set and reset by software.
$04000000 constant RCC_RCC_AHB1ENR_USBPHYCEN                        \ USBPHYC clocks enable Set and reset by software.
$08000000 constant RCC_RCC_AHB1ENR_OTGFSEN                          \ OTGFS peripheral clocks enable Set and reset by software.
$80000000 constant RCC_RCC_AHB1ENR_ADFEN                            \ ADF clocks enable Set and reset by software.


\
\ @brief RCC AHB2 clock enable register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_AHB2ENR_PSSIEN                           \ PSSI peripheral clocks enable Set and reset by software.
$00000200 constant RCC_RCC_AHB2ENR_SDMMC2EN                         \ SDMMC2 and SDMMC2 delay clock enable Set and reset by software.
$00004000 constant RCC_RCC_AHB2ENR_CORDICEN                         \ CORDIC clock enable Set and reset by software.
$20000000 constant RCC_RCC_AHB2ENR_SRAM1EN                          \ SRAM1 clock enable Set and reset by software.
$40000000 constant RCC_RCC_AHB2ENR_SRAM2EN                          \ SRAM2 clock enable Set and reset by software.


\
\ @brief RCC AHB4 clock enable register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB4ENR_GPIOAEN                          \ GPIOA peripheral clock enable Set and reset by software.
$00000002 constant RCC_RCC_AHB4ENR_GPIOBEN                          \ GPIOB peripheral clock enable Set and reset by software.
$00000004 constant RCC_RCC_AHB4ENR_GPIOCEN                          \ GPIOC peripheral clock enable Set and reset by software.
$00000008 constant RCC_RCC_AHB4ENR_GPIODEN                          \ GPIOD peripheral clock enable Set and reset by software.
$00000010 constant RCC_RCC_AHB4ENR_GPIOEEN                          \ GPIOE peripheral clock enable Set and reset by software.
$00000020 constant RCC_RCC_AHB4ENR_GPIOFEN                          \ GPIOF peripheral clock enable Set and reset by software.
$00000040 constant RCC_RCC_AHB4ENR_GPIOGEN                          \ GPIOG peripheral clock enable Set and reset by software.
$00000080 constant RCC_RCC_AHB4ENR_GPIOHEN                          \ GPIOH peripheral clock enable Set and reset by software.
$00001000 constant RCC_RCC_AHB4ENR_GPIOMEN                          \ GPIOM peripheral clock enable Set and reset by software.
$00002000 constant RCC_RCC_AHB4ENR_GPIONEN                          \ GPION peripheral clock enable Set and reset by software.
$00004000 constant RCC_RCC_AHB4ENR_GPIOOEN                          \ GPIOO peripheral clock enable Set and reset by software.
$00008000 constant RCC_RCC_AHB4ENR_GPIOPEN                          \ GPIOP peripheral clock enable Set and reset by software.
$00080000 constant RCC_RCC_AHB4ENR_CRCEN                            \ CRC clock enable Set and reset by software.
$10000000 constant RCC_RCC_AHB4ENR_BKPRAMEN                         \ Backup RAM clock enable Set and reset by software.


\
\ @brief RCC APB5 clock enable register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB5ENR_LTDCEN                           \ LTDC peripheral clock enable Provides the pixel clock (ltdc_clk) to the LTDC block. Set and reset by software.
$00000004 constant RCC_RCC_APB5ENR_DCMIPPEN                         \ DCMIPP peripheral clock enable Set and reset by software.
$00000010 constant RCC_RCC_APB5ENR_GFXTIMEN                         \ GFXTIM peripheral clock enable Set and reset by software.


\
\ @brief RCC APB1 clock enable register 1
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1ENR1_TIM2EN                          \ TIM2 peripheral clock enable Set and reset by software.
$00000002 constant RCC_RCC_APB1ENR1_TIM3EN                          \ TIM3 peripheral clock enable Set and reset by software.
$00000004 constant RCC_RCC_APB1ENR1_TIM4EN                          \ TIM4 peripheral clock enable Set and reset by software.
$00000008 constant RCC_RCC_APB1ENR1_TIM5EN                          \ TIM5 peripheral clock enable Set and reset by software.
$00000010 constant RCC_RCC_APB1ENR1_TIM6EN                          \ TIM6 peripheral clock enable Set and reset by software.
$00000020 constant RCC_RCC_APB1ENR1_TIM7EN                          \ TIM7 peripheral clock enable Set and reset by software.
$00000040 constant RCC_RCC_APB1ENR1_TIM12EN                         \ TIM12 peripheral clock enable Set and reset by software.
$00000080 constant RCC_RCC_APB1ENR1_TIM13EN                         \ TIM13 peripheral clock enable Set and reset by software.
$00000100 constant RCC_RCC_APB1ENR1_TIM14EN                         \ TIM14 peripheral clock enable Set and reset by software.
$00000200 constant RCC_RCC_APB1ENR1_LPTIM1EN                        \ LPTIM1 peripheral clocks enable Set and reset by software. The peripheral clocks of the LPTIM1 are the kernel clock selected by LPTIM1SEL and provided to clk_lpt input, and the rcc_pclk1 bus interface clock.
$00000800 constant RCC_RCC_APB1ENR1_WWDGEN                          \ WWDG clock enable Set by software, and reset by hardware when a system reset occurs.
$00004000 constant RCC_RCC_APB1ENR1_SPI2EN                          \ SPI2 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI2 are the kernel clock selected by I2S123SRC and provided to com_clk input, and the rcc_pclk1 bus interface clock.
$00008000 constant RCC_RCC_APB1ENR1_SPI3EN                          \ SPI3 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI3 are the kernel clock selected by I2S123SRC and provided to com_clk input, and the rcc_pclk1 bus interface clock.
$00010000 constant RCC_RCC_APB1ENR1_SPDIFRXEN                       \ SPDIFRX peripheral clocks enable Set and reset by software. The peripheral clocks of the SPDIFRX are the kernel clock selected by SPDIFRXSEL and provided to SPDIFRX_CLK input, and the rcc_pclk1 bus interface clock.
$00020000 constant RCC_RCC_APB1ENR1_USART2EN                        \ USART2peripheral clocks enable Set and reset by software. The peripheral clocks of the USART2 are the kernel clock selected by USART234578SEL and provided to UCLK input, and the rcc_pclk1 bus interface clock.
$00040000 constant RCC_RCC_APB1ENR1_USART3EN                        \ USART3 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART3 are the kernel clock selected by USART234578SEL and provided to UCLK input, and the rcc_pclk1 bus interface clock.
$00080000 constant RCC_RCC_APB1ENR1_UART4EN                         \ UART4 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART4 are the kernel clock selected by USART234578SEL and provided to UCLK input, and the rcc_pclk1 bus interface clock.
$00100000 constant RCC_RCC_APB1ENR1_UART5EN                         \ UART5 peripheral clocks enable Set and reset by software.
$00200000 constant RCC_RCC_APB1ENR1_I2C1_I3C1EN                     \ I2C1/I3C1 peripheral clocks enable Set and reset by software.
$00400000 constant RCC_RCC_APB1ENR1_I2C2EN                          \ I2C2 peripheral clocks enable Set and reset by software.
$00800000 constant RCC_RCC_APB1ENR1_I2C3EN                          \ I2C3 peripheral clocks enable Set and reset by software.
$08000000 constant RCC_RCC_APB1ENR1_HDMICECEN                       \ HDMI-CEC peripheral clock enable Set and reset by software.
$40000000 constant RCC_RCC_APB1ENR1_UART7EN                         \ UART7 peripheral clocks enable Set and reset by software.
$80000000 constant RCC_RCC_APB1ENR1_UART8EN                         \ UART8 peripheral clocks enable Set and reset by software.


\
\ @brief RCC APB1 clock enable register 2
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB1ENR2_CRSEN                           \ clock recovery system peripheral clock enable Set and reset by software.
$00000020 constant RCC_RCC_APB1ENR2_MDIOSEN                         \ MDIOS peripheral clock enable Set and reset by software.
$00000100 constant RCC_RCC_APB1ENR2_FDCANEN                         \ FDCAN peripheral clock enable Set and reset by software.
$08000000 constant RCC_RCC_APB1ENR2_UCPDEN                          \ UCPD peripheral clock enable Set and reset by software.


\
\ @brief RCC APB2 clock enable register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB2ENR_TIM1EN                           \ TIM1 peripheral clock enable Set and reset by software.
$00000010 constant RCC_RCC_APB2ENR_USART1EN                         \ USART1 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART1 are the kernel clock selected by USART1SEL, and the pclk2 bus interface clock.
$00001000 constant RCC_RCC_APB2ENR_SPI1EN                           \ SPI2S1 Peripheral Clocks Enable Set and reset by software. The peripheral clocks of the SPI2S1 are: the kernel clock selected by SPI1SEL, and the pclk2 bus interface clock.
$00002000 constant RCC_RCC_APB2ENR_SPI4EN                           \ SPI4 Peripheral Clocks Enable Set and reset by software. The peripheral clocks of the SPI4 are: the kernel clock selected by SPI45SEL, and the pclk2 bus interface clock.
$00010000 constant RCC_RCC_APB2ENR_TIM15EN                          \ TIM15 peripheral clock enable Set and reset by software.
$00020000 constant RCC_RCC_APB2ENR_TIM16EN                          \ TIM16 peripheral clock enable Set and reset by software.
$00040000 constant RCC_RCC_APB2ENR_TIM17EN                          \ TIM17 peripheral clock enable Set and reset by software.
$00080000 constant RCC_RCC_APB2ENR_TIM9EN                           \ TIM9 peripheral clock enable Set and reset by software.
$00100000 constant RCC_RCC_APB2ENR_SPI5EN                           \ SPI5 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI5 are the kernel clock selected by SPI45SEL, and the pclk2 bus interface clock.
$00400000 constant RCC_RCC_APB2ENR_SAI1EN                           \ SAI1 peripheral clocks enable Set and reset by software. The peripheral clocks of the SAI1 are the kernel clock selected by SAI1SEL, and the pclk2 bus interface clock.
$00800000 constant RCC_RCC_APB2ENR_SAI2EN                           \ SAI2 peripheral clocks enable Set and reset by software. The peripheral clocks of the SAI2 are the kernel clock selected by SAI2SEL, and the pclk2 bus interface clock.


\
\ @brief RCC APB4 clock enable register
\ Address offset: 0x154
\ Reset value: 0x00010000
\

$00000002 constant RCC_RCC_APB4ENR_SBSEN                            \ SBS peripheral clock enable Set and reset by software.
$00000008 constant RCC_RCC_APB4ENR_LPUART1EN                        \ LPUART1 peripheral clocks enable Set and reset by software. The peripheral clocks of the LPUART1 are the kernel clock selected by LPUART1SEL and provided to UCLK input, and the pclk4 bus interface clock.
$00000020 constant RCC_RCC_APB4ENR_SPI6EN                           \ SPI/I2S6 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI/I2S6 are the kernel clock selected by SPI6SEL and provided to com_clk input, and the pclk4 bus interface clock.
$00000200 constant RCC_RCC_APB4ENR_LPTIM2EN                         \ LPTIM2 peripheral clocks enable Set and reset by software. The LPTIM2 kernel clock can be selected by LPTIM23SEL.
$00000400 constant RCC_RCC_APB4ENR_LPTIM3EN                         \ LPTIM3 peripheral clocks enable Set and reset by software. The LPTIM3 kernel clock can be selected by LPTIM23SEL.
$00000800 constant RCC_RCC_APB4ENR_LPTIM4EN                         \ LPTIM4 peripheral clocks enable Set and reset by software. The LPTIM4 kernel clock can be selected by LPTIM45SEL.
$00001000 constant RCC_RCC_APB4ENR_LPTIM5EN                         \ LPTIM5 peripheral clocks enable Set and reset by software. The LPTIM5 kernel clock can be selected by LPTIM45SEL.
$00008000 constant RCC_RCC_APB4ENR_VREFEN                           \ VREF peripheral clock enable Set and reset by software.
$00010000 constant RCC_RCC_APB4ENR_RTCAPBEN                         \ RTC APB clock enable Set and reset by software.
$04000000 constant RCC_RCC_APB4ENR_TMPSENSEN                        \ Temperature Sensor peripheral clock enable Set and reset by software.


\
\ @brief RCC AHB3 clock enable register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB3ENR_RNGEN                            \ RNG peripheral clocks enable Set and reset by software.
$00000002 constant RCC_RCC_AHB3ENR_HASHEN                           \ HASH peripheral clock enable Set and reset by software.


\
\ @brief RCC AHB5 low-power clock enable register
\ Address offset: 0x15C
\ Reset value: 0xF018513F
\

$00000001 constant RCC_RCC_AHB5LPENR_HPDMA1LPEN                     \ HPDMA1 low-power peripheral clock enable Set and reset by software.
$00000002 constant RCC_RCC_AHB5LPENR_DMA2DLPEN                      \ DMA2D low-power peripheral clock enable Set and reset by software.
$00000004 constant RCC_RCC_AHB5LPENR_FLITFLPEN                      \ FLITF low-power peripheral clock enable Set and reset by software.
$00000008 constant RCC_RCC_AHB5LPENR_JPEGLPEN                       \ JPEG clock enable during Sleep mode Set and reset by software.
$00000010 constant RCC_RCC_AHB5LPENR_FMCLPEN                        \ FMC and MCE3 peripheral clocks enable during Sleep mode Set and reset by software. The hardware prevents writing this bit if FMCCKP = 1. The peripheral clocks of the FMC are the kernel clock selected by FMCSEL, and the hclk5 bus interface clock.
$00000020 constant RCC_RCC_AHB5LPENR_XSPI1LPEN                      \ XSPI1 and MCE1 low-power peripheral clock enable Set and reset by software. The hardware prevents writing this bit if XSPICKP = 1.
$00000100 constant RCC_RCC_AHB5LPENR_SDMMC1LPEN                     \ SDMMC1 and SDMMC1 delay low-power peripheral clock enable Set and reset by software.
$00001000 constant RCC_RCC_AHB5LPENR_XSPI2LPEN                      \ XSPI2 and MCE2 low-power peripheral clock enable Set and reset by software. The hardware prevents writing this bit if XSPICKP = 1.
$00004000 constant RCC_RCC_AHB5LPENR_XSPIMLPEN                      \ XSPIM low-power peripheral clock enable Set and reset by software.
$00080000 constant RCC_RCC_AHB5LPENR_GFXMMULPEN                     \ GFXMMU low-power peripheral clock enable Set and reset by software.
$00100000 constant RCC_RCC_AHB5LPENR_GPULPEN                        \ GPU low-power peripheral clock enable Set and reset by software.
$10000000 constant RCC_RCC_AHB5LPENR_DTCM1LPEN                      \ DTCM1 low-power peripheral clock enable Set and reset by software.
$20000000 constant RCC_RCC_AHB5LPENR_DTCM2LPEN                      \ DTCM2 low-power peripheral clock enable Set and reset by software.
$40000000 constant RCC_RCC_AHB5LPENR_ITCMLPEN                       \ ITCM low-power peripheral clock enable Set and reset by software.
$80000000 constant RCC_RCC_AHB5LPENR_AXISRAMLPEN                    \ AXISRAM[4:1] low-power peripheral clock enable Set and reset by software.


\
\ @brief RCC AHB1 low-power clock enable register
\ Address offset: 0x160
\ Reset value: 0x8E038030
\

$00000010 constant RCC_RCC_AHB1LPENR_GPDMA1LPEN                     \ GPDMA1 clock enable in low-power mode Set and reset by software.
$00000020 constant RCC_RCC_AHB1LPENR_ADC12LPEN                      \ ADC1 and 2 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the ADC1 and 2 are the kernel clock selected by ADCSEL and provided to ADCx_CK input, and the rcc_hclk1 bus interface clock.
$00008000 constant RCC_RCC_AHB1LPENR_ETH1MACLPEN                    \ ETH1 MAC peripheral clock enable in low-power mode Set and reset by software.
$00010000 constant RCC_RCC_AHB1LPENR_ETH1TXLPEN                     \ ETH1 transmission peripheral clock enable in low-power mode Set and reset by software.
$00020000 constant RCC_RCC_AHB1LPENR_ETH1RXLPEN                     \ ETH1 reception peripheral clock enable in low-power mode Set and reset by software.
$01000000 constant RCC_RCC_AHB1LPENR_USBPDCTRL                      \ USBPHYC common block power-down control Set and reset by software.
$02000000 constant RCC_RCC_AHB1LPENR_OTGHSLPEN                      \ OTGHS peripheral clock enable in low-power mode Set and reset by software.
$04000000 constant RCC_RCC_AHB1LPENR_USBPHYCLPEN                    \ USBPHYC peripheral clock enable in low-power mode Set and reset by software.
$08000000 constant RCC_RCC_AHB1LPENR_OTGFSLPEN                      \ OTGFS clock enable in low-power mode Set and reset by software.
$80000000 constant RCC_RCC_AHB1LPENR_ADFLPEN                        \ ADF clock enable in low-power mode Set and reset by software.


\
\ @brief RCC AHB2 low-power clock enable register
\ Address offset: 0x164
\ Reset value: 0x60004202
\

$00000002 constant RCC_RCC_AHB2LPENR_PSSILPEN                       \ PSSI peripheral clock enable in low-power mode Set and reset by software.
$00000200 constant RCC_RCC_AHB2LPENR_SDMMC2LPEN                     \ SDMMC2 and SDMMC2 delay clock enable in low-power mode Set and reset by software.
$00004000 constant RCC_RCC_AHB2LPENR_CORDICLPEN                     \ CORDIC clock enable in low-power mode Set and reset by software.
$20000000 constant RCC_RCC_AHB2LPENR_SRAM1LPEN                      \ SRAM1 clock enable in low-power mode Set and reset by software.
$40000000 constant RCC_RCC_AHB2LPENR_SRAM2LPEN                      \ SRAM2 clock enable in low-power mode Set and reset by software.


\
\ @brief RCC AHB4 low-power clock enable register
\ Address offset: 0x168
\ Reset value: 0x1008F0FF
\

$00000001 constant RCC_RCC_AHB4LPENR_GPIOALPEN                      \ GPIOA peripheral clock enable in low-power mode Set and reset by software.
$00000002 constant RCC_RCC_AHB4LPENR_GPIOBLPEN                      \ GPIOB peripheral clock enable in low-power mode Set and reset by software.
$00000004 constant RCC_RCC_AHB4LPENR_GPIOCLPEN                      \ GPIOC peripheral clock enable in low-power mode Set and reset by software.
$00000008 constant RCC_RCC_AHB4LPENR_GPIODLPEN                      \ GPIOD peripheral clock enable in low-power mode Set and reset by software.
$00000010 constant RCC_RCC_AHB4LPENR_GPIOELPEN                      \ GPIOE peripheral clock enable in low-power mode Set and reset by software.
$00000020 constant RCC_RCC_AHB4LPENR_GPIOFLPEN                      \ GPIOF peripheral clock enable in low-power mode Set and reset by software.
$00000040 constant RCC_RCC_AHB4LPENR_GPIOGLPEN                      \ GPIOG peripheral clock enable in low-power mode Set and reset by software.
$00000080 constant RCC_RCC_AHB4LPENR_GPIOHLPEN                      \ GPIOH peripheral clock enable in low-power mode Set and reset by software.
$00001000 constant RCC_RCC_AHB4LPENR_GPIOMLPEN                      \ GPIOM peripheral clock enable in low-power mode Set and reset by software.
$00002000 constant RCC_RCC_AHB4LPENR_GPIONLPEN                      \ GPION peripheral clock enable in low-power mode Set and reset by software.
$00004000 constant RCC_RCC_AHB4LPENR_GPIOOLPEN                      \ GPIOO peripheral clock enable in low-power mode Set and reset by software.
$00008000 constant RCC_RCC_AHB4LPENR_GPIOPLPEN                      \ GPIOP peripheral clock enable in low-power mode Set and reset by software.
$00080000 constant RCC_RCC_AHB4LPENR_CRCLPEN                        \ CRC clock enable in low-power mode Set and reset by software.
$10000000 constant RCC_RCC_AHB4LPENR_BKPRAMLPEN                     \ Backup RAM clock enable in low-power mode Set and reset by software.


\
\ @brief RCC AHB3 low-power clock enable register
\ Address offset: 0x16C
\ Reset value: 0x00000057
\

$00000001 constant RCC_RCC_AHB3LPENR_RNGLPEN                        \ RNG peripheral clock enable in low-power mode Set and reset by software.
$00000002 constant RCC_RCC_AHB3LPENR_HASHLPEN                       \ HASH peripheral clock enable in low-power mode Set and reset by software.


\
\ @brief RCC APB1 low-power clock enable register 1
\ Address offset: 0x170
\ Reset value: 0xC8FFCBFF
\

$00000001 constant RCC_RCC_APB1LPENR1_TIM2LPEN                      \ TIM2 peripheral clock enable in low-power mode Set and reset by software.
$00000002 constant RCC_RCC_APB1LPENR1_TIM3LPEN                      \ TIM3 peripheral clock enable in low-power mode Set and reset by software.
$00000004 constant RCC_RCC_APB1LPENR1_TIM4LPEN                      \ TIM4 peripheral clock enable in low-power mode Set and reset by software.
$00000008 constant RCC_RCC_APB1LPENR1_TIM5LPEN                      \ TIM5 peripheral clock enable in low-power mode Set and reset by software.
$00000010 constant RCC_RCC_APB1LPENR1_TIM6LPEN                      \ TIM6 peripheral clock enable in low-power mode Set and reset by software.
$00000020 constant RCC_RCC_APB1LPENR1_TIM7LPEN                      \ TIM7 peripheral clock enable in low-power mode Set and reset by software.
$00000040 constant RCC_RCC_APB1LPENR1_TIM12LPEN                     \ TIM12 peripheral clock enable in low-power mode Set and reset by software.
$00000080 constant RCC_RCC_APB1LPENR1_TIM13LPEN                     \ TIM13 peripheral clock enable in low-power mode Set and reset by software.
$00000100 constant RCC_RCC_APB1LPENR1_TIM14LPEN                     \ TIM14 peripheral clock enable in low-power mode Set and reset by software.
$00000200 constant RCC_RCC_APB1LPENR1_LPTIM1LPEN                    \ LPTIM1 peripheral clocks enable in low-power mode Set and reset by software.
$00000800 constant RCC_RCC_APB1LPENR1_WWDGLPEN                      \ WWDG clock enable in low-power mode Set and reset by software.
$00004000 constant RCC_RCC_APB1LPENR1_SPI2LPEN                      \ SPI2 peripheral clocks enable in low-power mode Set and reset by software.
$00008000 constant RCC_RCC_APB1LPENR1_SPI3LPEN                      \ SPI3 peripheral clocks enable in low-power mode Set and reset by software.
$00010000 constant RCC_RCC_APB1LPENR1_SPDIFRXLPEN                   \ SPDIFRX peripheral clocks enable in low-power mode Set and reset by software.
$00020000 constant RCC_RCC_APB1LPENR1_USART2LPEN                    \ USART2 peripheral clocks enable in low-power mode Set and reset by software.
$00040000 constant RCC_RCC_APB1LPENR1_USART3LPEN                    \ USART3 peripheral clocks enable in low-power mode Set and reset by software.
$00080000 constant RCC_RCC_APB1LPENR1_UART4LPEN                     \ UART4 peripheral clocks enable in low-power mode Set and reset by software.
$00100000 constant RCC_RCC_APB1LPENR1_UART5LPEN                     \ UART5 peripheral clocks enable in low-power mode Set and reset by software.
$00200000 constant RCC_RCC_APB1LPENR1_I2C1_I3C1LPEN                 \ I2C1/I3C1 peripheral clocks enable in low-power mode Set and reset by software.
$00400000 constant RCC_RCC_APB1LPENR1_I2C2LPEN                      \ I2C2 peripheral clocks enable in low-power mode Set and reset by software.
$00800000 constant RCC_RCC_APB1LPENR1_I2C3LPEN                      \ I2C3 peripheral clocks enable in low-power mode Set and reset by software.
$08000000 constant RCC_RCC_APB1LPENR1_HDMICECLPEN                   \ HDMI-CEC peripheral clocks enable in low-power mode Set and reset by software.
$40000000 constant RCC_RCC_APB1LPENR1_UART7LPEN                     \ UART7 peripheral clocks enable in low-power mode Set and reset by software.
$80000000 constant RCC_RCC_APB1LPENR1_UART8LPEN                     \ UART8 peripheral clocks enable in low-power mode Set and reset by software.


\
\ @brief RCC APB1 low-power clock enable register 2
\ Address offset: 0x174
\ Reset value: 0x08000122
\

$00000002 constant RCC_RCC_APB1LPENR2_CRSLPEN                       \ clock recovery system peripheral clock enable in low-power mode Set and reset by software.
$00000020 constant RCC_RCC_APB1LPENR2_MDIOSLPEN                     \ MDIOS peripheral clock enable in low-power mode Set and reset by software.
$00000100 constant RCC_RCC_APB1LPENR2_FDCANLPEN                     \ FDCAN peripheral clock enable in low-power mode Set and reset by software.
$08000000 constant RCC_RCC_APB1LPENR2_UCPDLPEN                      \ UCPD peripheral clock enable in low-power mode Set and reset by software.


\
\ @brief RCC APB2 low-power clock enable register
\ Address offset: 0x178
\ Reset value: 0x00DF3011
\

$00000001 constant RCC_RCC_APB2LPENR_TIM1LPEN                       \ TIM1 peripheral clock enable in low-power mode Set and reset by software.
$00000010 constant RCC_RCC_APB2LPENR_USART1LPEN                     \ USART1 peripheral clock enable in low-power mode Set and reset by software. The peripheral clocks of the USART1 are the kernel clock selected by USART169SEL and provided to UCLK inputs, and the pclk2 bus interface clock.
$00001000 constant RCC_RCC_APB2LPENR_SPI1LPEN                       \ SPI2S1 peripheral clock enable in low-power mode Set and reset by software. The peripheral clocks of the SPI2S1 are: the kernel clock selected by I2S1SEL and provided to spi_ker_ck input, and the pclk2 bus interface clock.
$00002000 constant RCC_RCC_APB2LPENR_SPI4LPEN                       \ SPI4 peripheral clock enable in low-power mode Set and reset by software. The peripheral clocks of the SPI4 are: the kernel clock selected by SPI45SEL and provided to com_clk input, and the pclk2 bus interface clock.
$00010000 constant RCC_RCC_APB2LPENR_TIM15LPEN                      \ TIM15 peripheral clock enable in low-power mode Set and reset by software.
$00020000 constant RCC_RCC_APB2LPENR_TIM16LPEN                      \ TIM16 peripheral clock enable in low-power mode Set and reset by software.
$00040000 constant RCC_RCC_APB2LPENR_TIM17LPEN                      \ TIM17 peripheral clock enable in low-power mode Set and reset by software.
$00080000 constant RCC_RCC_APB2LPENR_TIM9LPEN                       \ TIM9 peripheral clock enable in low-power mode Set and reset by software.
$00100000 constant RCC_RCC_APB2LPENR_SPI5LPEN                       \ SPI5 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the SPI5 are the kernel clock selected by SPI45SEL and provided to com_clk input, and the pclk2 bus interface clock.
$00400000 constant RCC_RCC_APB2LPENR_SAI1LPEN                       \ SAI1 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the SAI1 are: the kernel clock selected by SAI1SEL and provided to SAI_CK_A and SAI_CK_B inputs, and the pclk2 bus interface clock.
$00800000 constant RCC_RCC_APB2LPENR_SAI2LPEN                       \ SAI2 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the SAI2 are: the kernel clock selected by SAI2SEL and provided to SAI_CK_A and SAI_CK_B inputs, and the pclk2 bus interface clock.


\
\ @brief RCC APB4 low-power clock enable register
\ Address offset: 0x17C
\ Reset value: 0x04019E2A
\

$00000002 constant RCC_RCC_APB4LPENR_SBSLPEN                        \ SBS peripheral clock enable in low-power mode Set and reset by software.
$00000008 constant RCC_RCC_APB4LPENR_LPUART1LPEN                    \ LPUART1 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the LPUART1 are the kernel clock selected by LPUART1SEL and provided to UCLK input, and the rcc_pclk4 bus interface clock.
$00000020 constant RCC_RCC_APB4LPENR_SPI6LPEN                       \ SPI/I2S6 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the SPI/I2S6 are the kernel clock selected by SPI6SEL and provided to com_ck input, and the rcc_pclk4 bus interface clock.
$00000200 constant RCC_RCC_APB4LPENR_LPTIM2LPEN                     \ LPTIM2 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the LPTIM2 are the kernel clock selected by LPTIM23SEL and provided to clk_lpt input, and the pclk4 bus interface clock.
$00000400 constant RCC_RCC_APB4LPENR_LPTIM3LPEN                     \ LPTIM3 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the LPTIM3 are the kernel clock selected by LPTIM23SEL and provided to clk_lpt input, and the pclk4 bus interface clock.
$00000800 constant RCC_RCC_APB4LPENR_LPTIM4LPEN                     \ LPTIM4 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the LPTIM4 are the kernel clock selected by LPTIM45SEL and provided to clk_lpt input, and the pclk4 bus interface clock.
$00001000 constant RCC_RCC_APB4LPENR_LPTIM5LPEN                     \ LPTIM5 peripheral clocks enable in low-power mode Set and reset by software. The peripheral clocks of the LPTIM5 are the kernel clock selected by LPTIM45SEL and provided to clk_lpt input, and the pclk4 bus interface clock.
$00008000 constant RCC_RCC_APB4LPENR_VREFLPEN                       \ VREF peripheral clock enable in low-power mode Set and reset by software.
$00010000 constant RCC_RCC_APB4LPENR_RTCAPBLPEN                     \ RTC APB clock enable in low-power mode Set and reset by software.
$04000000 constant RCC_RCC_APB4LPENR_TMPSENSLPEN                    \ temperature sensor peripheral clock enable in low-power mode Set and reset by software.


\
\ @brief RCC APB5 sleep clock register
\ Address offset: 0x180
\ Reset value: 0x00000016
\

$00000002 constant RCC_RCC_APB5LPENR_LTDCLPEN                       \ LTDC peripheral clock enable in low-power mode Set and reset by software.
$00000004 constant RCC_RCC_APB5LPENR_DCMIPPLPEN                     \ DCMIPP peripheral clock enable in low-power mode Set and reset by software.
$00000010 constant RCC_RCC_APB5LPENR_GFXTIMLPEN                     \ GFXTIM peripheral clock enable in low-power mode Set and reset by software.


\
\ @brief Reset and clock control
\
$58024400 constant RCC_RCC_CR     \ offset: 0x00 : RCC source control register
$58024404 constant RCC_RCC_HSICFGR  \ offset: 0x04 : RCC HSI calibration register
$58024408 constant RCC_RCC_CRRCR  \ offset: 0x08 : RCC clock recovery RC register
$5802440c constant RCC_RCC_CSICFGR  \ offset: 0x0C : RCC CSI calibration register
$58024410 constant RCC_RCC_CFGR   \ offset: 0x10 : RCC clock configuration register
$58024418 constant RCC_RCC_CDCFGR  \ offset: 0x18 : RCC CPU domain clock configuration register
$5802441c constant RCC_RCC_BMCFGR  \ offset: 0x1C : RCC AHB clock configuration register
$58024420 constant RCC_RCC_APBCFGR  \ offset: 0x20 : RCC APB clocks configuration register
$58024428 constant RCC_RCC_PLLCKSELR  \ offset: 0x28 : RCC PLLs clock source selection register
$5802442c constant RCC_RCC_PLLCFGR  \ offset: 0x2C : RCC PLLs configuration register
$58024430 constant RCC_RCC_PLL1DIVR1  \ offset: 0x30 : RCC PLL1 dividers configuration register 1
$58024434 constant RCC_RCC_PLL1FRACR  \ offset: 0x34 : RCC PLL1 fractional divider register
$58024438 constant RCC_RCC_PLL2DIVR1  \ offset: 0x38 : RCC PLL2 dividers configuration register 1
$5802443c constant RCC_RCC_PLL2FRACR  \ offset: 0x3C : RCC PLL2 fractional divider register
$58024440 constant RCC_RCC_PLL3DIVR1  \ offset: 0x40 : RCC PLL3 dividers configuration register 1
$58024444 constant RCC_RCC_PLL3FRACR  \ offset: 0x44 : RCC PLL3 fractional divider register
$5802444c constant RCC_RCC_AHBPERCKSELR  \ offset: 0x4C : RCC AHB peripheral kernel clock selection register
$58024450 constant RCC_RCC_APB1PERCKSELR  \ offset: 0x50 : RCC APB1 peripherals kernel clock selection register
$58024454 constant RCC_RCC_APB2PERCKSELR  \ offset: 0x54 : RCC APB2 peripherals kernel clock selection register
$58024458 constant RCC_RCC_APB45PERCKSELR  \ offset: 0x58 : RCC APB4,5 peripherals kernel clock selection register
$58024460 constant RCC_RCC_CIER   \ offset: 0x60 : RCC clock source interrupt enable register
$58024464 constant RCC_RCC_CIFR   \ offset: 0x64 : RCC clock source interrupt flag register
$58024468 constant RCC_RCC_CICR   \ offset: 0x68 : RCC clock source interrupt clear register
$58024470 constant RCC_RCC_BDCR   \ offset: 0x70 : RCC Backup domain control register
$58024474 constant RCC_RCC_CSR    \ offset: 0x74 : RCC clock control and status register
$5802447c constant RCC_RCC_AHB5RSTR  \ offset: 0x7C : RCC AHB5 peripheral reset register
$58024480 constant RCC_RCC_AHB1RSTR  \ offset: 0x80 : RCC AHB1 peripheral reset register
$58024484 constant RCC_RCC_AHB2RSTR  \ offset: 0x84 : RCC AHB2 peripheral reset register
$58024488 constant RCC_RCC_AHB4RSTR  \ offset: 0x88 : RCC AHB4 peripheral reset register
$5802448c constant RCC_RCC_APB5RSTR  \ offset: 0x8C : RCC APB5 peripheral reset register
$58024490 constant RCC_RCC_APB1RSTR1  \ offset: 0x90 : RCC APB1 peripheral reset register 1
$58024494 constant RCC_RCC_APB1RSTR2  \ offset: 0x94 : RCC APB1 peripheral reset register 2
$58024498 constant RCC_RCC_APB2RSTR  \ offset: 0x98 : RCC APB2 peripheral reset register
$5802449c constant RCC_RCC_APB4RSTR  \ offset: 0x9C : RCC APB4 peripheral reset register
$580244a4 constant RCC_RCC_AHB3RSTR  \ offset: 0xA4 : RCC AHB3 peripheral reset register
$580244b0 constant RCC_RCC_CKGDISR  \ offset: 0xB0 : RCC AXI clocks gating disable register
$580244c0 constant RCC_RCC_PLL1DIVR2  \ offset: 0xC0 : RCC PLL1 dividers configuration register 2
$580244c4 constant RCC_RCC_PLL2DIVR2  \ offset: 0xC4 : RCC PLL2 dividers configuration register 2
$580244c8 constant RCC_RCC_PLL3DIVR2  \ offset: 0xC8 : RCC PLL3 dividers configuration register 2
$580244cc constant RCC_RCC_PLL1SSCGR  \ offset: 0xCC : RCC PLL1 Spread Spectrum Clock Generator register
$580244d0 constant RCC_RCC_PLL2SSCGR  \ offset: 0xD0 : RCC PLL2 Spread Spectrum Clock Generator register
$580244d4 constant RCC_RCC_PLL3SSCGR  \ offset: 0xD4 : RCC PLL3 Spread Spectrum Clock Generator register
$58024500 constant RCC_RCC_CKPROTR  \ offset: 0x100 : RCC clock protection register
$58024530 constant RCC_RCC_RSR    \ offset: 0x130 : RCC Reset status register
$58024534 constant RCC_RCC_AHB5ENR  \ offset: 0x134 : RCC AHB5 clock enable register
$58024538 constant RCC_RCC_AHB1ENR  \ offset: 0x138 : RCC AHB1 clock enable register
$5802453c constant RCC_RCC_AHB2ENR  \ offset: 0x13C : RCC AHB2 clock enable register
$58024540 constant RCC_RCC_AHB4ENR  \ offset: 0x140 : RCC AHB4 clock enable register
$58024544 constant RCC_RCC_APB5ENR  \ offset: 0x144 : RCC APB5 clock enable register
$58024548 constant RCC_RCC_APB1ENR1  \ offset: 0x148 : RCC APB1 clock enable register 1
$5802454c constant RCC_RCC_APB1ENR2  \ offset: 0x14C : RCC APB1 clock enable register 2
$58024550 constant RCC_RCC_APB2ENR  \ offset: 0x150 : RCC APB2 clock enable register
$58024554 constant RCC_RCC_APB4ENR  \ offset: 0x154 : RCC APB4 clock enable register
$58024558 constant RCC_RCC_AHB3ENR  \ offset: 0x158 : RCC AHB3 clock enable register
$5802455c constant RCC_RCC_AHB5LPENR  \ offset: 0x15C : RCC AHB5 low-power clock enable register
$58024560 constant RCC_RCC_AHB1LPENR  \ offset: 0x160 : RCC AHB1 low-power clock enable register
$58024564 constant RCC_RCC_AHB2LPENR  \ offset: 0x164 : RCC AHB2 low-power clock enable register
$58024568 constant RCC_RCC_AHB4LPENR  \ offset: 0x168 : RCC AHB4 low-power clock enable register
$5802456c constant RCC_RCC_AHB3LPENR  \ offset: 0x16C : RCC AHB3 low-power clock enable register
$58024570 constant RCC_RCC_APB1LPENR1  \ offset: 0x170 : RCC APB1 low-power clock enable register 1
$58024574 constant RCC_RCC_APB1LPENR2  \ offset: 0x174 : RCC APB1 low-power clock enable register 2
$58024578 constant RCC_RCC_APB2LPENR  \ offset: 0x178 : RCC APB2 low-power clock enable register
$5802457c constant RCC_RCC_APB4LPENR  \ offset: 0x17C : RCC APB4 low-power clock enable register
$58024580 constant RCC_RCC_APB5LPENR  \ offset: 0x180 : RCC APB5 sleep clock register

