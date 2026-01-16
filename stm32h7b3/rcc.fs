\
\ @file rcc.fs
\ @brief Reset and clock control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief HSI clock enable Set and cleared by software. Set by hardware to force the HSI to ON when the product leaves Stop mode, if STOPWUCK = 0 or STOPKERWUCK = 0. Set by hardware to force the HSI to ON when the product leaves Standby mode or in case of a failure of the HSE which is used as the system clock source. This bit cannot be cleared if the HSI is used directly (via SW mux) as system clock, or if the HSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
\ Address offset: 0x00
\ Reset value: 0x00000025
\

$00000001 constant RCC_RCC_CR_HSION                                 \ HSI clock enable Set and cleared by software. Set by hardware to force the HSI to ON when the product leaves Stop mode, if STOPWUCK = 0 or STOPKERWUCK = 0. Set by hardware to force the HSI to ON when the product leaves Standby mode or in case of a failure of the HSE which is used as the system clock source. This bit cannot be cleared if the HSI is used directly (via SW mux) as system clock, or if the HSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
$00000002 constant RCC_RCC_CR_HSIKERON                              \ HSI clock enable in Stop mode Set and reset by software to force the HSI to ON, even in Stop mode, in order to be quickly available as kernel clock for peripherals. This bit has no effect on the value of HSION.
$00000004 constant RCC_RCC_CR_HSIRDY                                \ HSI clock ready flag Set by hardware to indicate that the HSI oscillator is stable.
$00000018 constant RCC_RCC_CR_HSIDIV                                \ HSI clock divider Set and reset by software. These bits allow selecting a division ratio in order to configure the wanted HSI clock frequency. The HSIDIV cannot be changed if the HSI is selected as reference clock for at least one enabled PLL (PLLxON bit set to 1). In that case, the new HSIDIV value is ignored.
$00000020 constant RCC_RCC_CR_HSIDIVF                               \ HSI divider flag Set and reset by hardware. As a write operation to HSIDIV has not an immediate effect on the frequency, this flag indicates the current status of the HSI divider. HSIDIVF goes immediately to 0 when HSIDIV value is changed, and is set back to 1 when the output frequency matches the value programmed into HSIDIV. clock setting is completed)
$00000080 constant RCC_RCC_CR_CSION                                 \ CSI clock enable Set and reset by software to enable/disable CSI clock for system and/or peripheral. Set by hardware to force the CSI to ON when the system leaves Stop mode, if STOPWUCK = 1 or STOPKERWUCK = 1. This bit cannot be cleared if the CSI is used directly (via SW mux) as system clock, or if the CSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
$00000100 constant RCC_RCC_CR_CSIRDY                                \ CSI clock ready flag Set by hardware to indicate that the CSI oscillator is stable. This bit is activated only if the RC is enabled by CSION (it is not activated if the CSI is enabled by CSIKERON or by a peripheral request).
$00000200 constant RCC_RCC_CR_CSIKERON                              \ CSI clock enable in Stop mode Set and reset by software to force the CSI to ON, even in Stop mode, in order to be quickly available as kernel clock for some peripherals. This bit has no effect on the value of CSION.
$00001000 constant RCC_RCC_CR_HSI48ON                               \ HSI48 clock enable Set by software and cleared by software or by the hardware when the system enters to Stop or Standby mode.
$00002000 constant RCC_RCC_CR_HSI48RDY                              \ HSI48 clock ready flag Set by hardware to indicate that the HSI48 oscillator is stable.
$00004000 constant RCC_RCC_CR_CPUCKRDY                              \ CPU related clocks ready flag Set by hardware to indicate that the CPU related clocks (CPU, APB3, AXI bus matrix and related memories) are available.
$00008000 constant RCC_RCC_CR_CDCKRDY                               \ CPU domain clocks ready flag Set by hardware to indicate that the following CPU domain clocks are available: APB1, APB2, AHB bus matrix.
$00010000 constant RCC_RCC_CR_HSEON                                 \ HSE clock enable Set and cleared by software. Cleared by hardware to stop the HSE when entering Stop or Standby mode. This bit cannot be cleared if the HSE is used directly (via SW mux) as system clock, or if the HSE is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
$00020000 constant RCC_RCC_CR_HSERDY                                \ HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable.
$00040000 constant RCC_RCC_CR_HSEBYP                                \ HSE clock bypass Set and cleared by software to bypass the oscillator with an external clock. The external clock must be enabled with the HSEON bit to be used by the device. The HSEBYP bit can be written only if the HSE oscillator is disabled.
$00080000 constant RCC_RCC_CR_HSECSSON                              \ HSE clock security system enable Set by software to enable clock security system on HSE. This bit is âset onlyâ (disabled by a system reset or when the system enters in Standby mode). When HSECSSON is set, the clock detector is enabled by hardware when the HSE is ready and disabled by hardware if an oscillator failure is detected.
$00100000 constant RCC_RCC_CR_HSEEXT                                \ external high speed clock type in Bypass mode Set and reset by software to select the external clock type (analog or digital). The external clock must be enabled with the HSEON bit to be used by the device. The HSEEXT bit can be written only if the HSE oscillator is disabled.
$01000000 constant RCC_RCC_CR_PLL1ON                                \ PLL1 enable Set and cleared by software to enable PLL1. Cleared by hardware when entering Stop or Standby mode. Note that the hardware prevents writing this bit to 0, if the PLL1 output is used as the system clock.
$02000000 constant RCC_RCC_CR_PLL1RDY                               \ PLL1 clock ready flag Set by hardware to indicate that the PLL1 is locked.
$04000000 constant RCC_RCC_CR_PLL2ON                                \ PLL2 enable Set and cleared by software to enable PLL2. Cleared by hardware when entering Stop or Standby mode.
$08000000 constant RCC_RCC_CR_PLL2RDY                               \ PLL2 clock ready flag Set by hardware to indicate that the PLL2 is locked.
$10000000 constant RCC_RCC_CR_PLL3ON                                \ PLL3 enable Set and cleared by software to enable PLL3. Cleared by hardware when entering Stop or Standby mode.
$20000000 constant RCC_RCC_CR_PLL3RDY                               \ PLL3 clock ready flag Set by hardware to indicate that the PLL3 is locked.


\
\ @brief RCC HSI calibration register
\ Address offset: 0x04
\ Reset value: 0x40000000
\

$00000fff constant RCC_RCC_HSICFGR_HSICAL                           \ HSI clock calibration Set by hardware by option byte loading during system reset nreset. Adjusted by software through trimming bits HSITRIM. This field represents the sum of engineering option byte calibration value and HSITRIM bits value.
$7f000000 constant RCC_RCC_HSICFGR_HSITRIM                          \ HSI clock trimming Set by software to adjust calibration. HSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_HSI_opt) in order to form the calibration trimming value. HSICALÂ =Â HSITRIMÂ +Â FLASH_HSI_opt. Note: The reset value of the field is 0x40.


\
\ @brief RCC clock recovery RC register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000003ff constant RCC_RCC_CRRCR_HSI48CAL                           \ Internal RC 48 MHz clock calibration Set by hardware by option byte loading during system reset nreset. Read-only.


\
\ @brief RCC CSI calibration register
\ Address offset: 0x0C
\ Reset value: 0x20000000
\

$000000ff constant RCC_RCC_CSICFGR_CSICAL                           \ CSI clock calibration Set by hardware by option byte loading during system reset nreset. Adjusted by software through trimming bits CSITRIM. This field represents the sum of engineering option byte calibration value and CSITRIM bits value.
$3f000000 constant RCC_RCC_CSICFGR_CSITRIM                          \ CSI clock trimming Set by software to adjust calibration. CSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_CSI_opt) in order to form the calibration trimming value. CSICALÂ =Â CSITRIMÂ +Â FLASH_CSI_opt. Note: The reset value of the field is 0x20.


\
\ @brief system clock and trace clock switch Set and reset by software to select system clock and trace clock sources (sys_ck and traceclk). Set by hardware in order to: force the selection of the HSI or CSI (depending on STOPWUCK selection) when leaving a system Stop mode force the selection of the HSI in case of failure of the HSE when used directly or indirectly as system clock others: reserved
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_CFGR_SW                                  \ system clock and trace clock switch Set and reset by software to select system clock and trace clock sources (sys_ck and traceclk). Set by hardware in order to: force the selection of the HSI or CSI (depending on STOPWUCK selection) when leaving a system Stop mode force the selection of the HSI in case of failure of the HSE when used directly or indirectly as system clock others: reserved
$00000038 constant RCC_RCC_CFGR_SWS                                 \ system clock switch status Set and reset by hardware to indicate which clock source is used as system clock. others: reserved
$00000040 constant RCC_RCC_CFGR_STOPWUCK                            \ system clock selection after a wake up from system Stop Set and reset by software to select the system wakeup clock from system Stop. The selected clock is also used as emergency clock for the clock security system (CSS) on HSE. See for details. STOPWUCK must not be modified when CSS is enabled (by HSECSSON bit) and the system clock is HSE (SWSÂ =Â 10) or a switch on HSE is requested (SWÂ =10).
$00000080 constant RCC_RCC_CFGR_STOPKERWUCK                         \ kernel clock selection after a wake up from system Stop Set and reset by software to select the kernel wakeup clock from system Stop. See for details.
$00003f00 constant RCC_RCC_CFGR_RTCPRE                              \ HSE division factor for RTC clock Set and cleared by software to divide the HSE to generate a clock for RTC. Caution: The software must set these bits correctly to ensure that the clock supplied to the RTC is lower than 1Â MHz. These bits must be configured if needed before selecting the RTC clock source. ...
$00008000 constant RCC_RCC_CFGR_TIMPRE                              \ timers clocks prescaler selection This bit is set and reset by software to control the clock frequency of all the timers connected to APB1 and APB2 domains. Refer to for more details.
$003c0000 constant RCC_RCC_CFGR_MCO1PRE                             \ MCO1 prescaler Set and cleared by software to configure the prescaler of the MCO1. Modification of this prescaler may generate glitches on MCO1. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. ...
$01c00000 constant RCC_RCC_CFGR_MCO1SEL                             \ Microcontroller clock output 1 Set and cleared by software. Clock source selection may generate glitches on MCO1. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved
$1e000000 constant RCC_RCC_CFGR_MCO2PRE                             \ MCO2 prescaler Set and cleared by software to configure the prescaler of the MCO2. Modification of this prescaler may generate glitches on MCO2. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. ...
$e0000000 constant RCC_RCC_CFGR_MCO2SEL                             \ microcontroller clock output 2 Set and cleared by software. Clock source selection may generate glitches on MCO2. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved


\
\ @brief CPU domain AHB prescaler Set and reset by software to control the division factor of rcc_hclk3 and rcc_aclk. Changing this division ratio has an impact on the frequency of all bus matrix clocks. 0xxx: rcc_hclk3 = sys_cdcpre_ck (default after reset) Note: The clocks are divided by the new prescaler factor from1 to 16 periods of the slowest APB clock among rcc_pclk[4:1] after HPRE update. Note: Note also that rcc_hclk3 = rcc_aclk.
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000000f constant RCC_RCC_CDCFGR1_HPRE                             \ CPU domain AHB prescaler Set and reset by software to control the division factor of rcc_hclk3 and rcc_aclk. Changing this division ratio has an impact on the frequency of all bus matrix clocks. 0xxx: rcc_hclk3 = sys_cdcpre_ck (default after reset) Note: The clocks are divided by the new prescaler factor from1 to 16 periods of the slowest APB clock among rcc_pclk[4:1] after HPRE update. Note: Note also that rcc_hclk3 = rcc_aclk.
$00000070 constant RCC_RCC_CDCFGR1_CDPPRE                           \ CPU domain APB3 prescaler Set and reset by software to control the division factor of rcc_pclk3. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk3 after CDPPRE write. 0xx: rcc_pclk3 = rcc_hclk3 (default after reset)
$00000f00 constant RCC_RCC_CDCFGR1_CDCPRE                           \ CPU domain core prescaler Set and reset by software to control the CPU domain CPU clock division factor. Changing this division ratio has an impact on the frequency of the CPU clock and all bus matrix clocks. After changing this prescaler value, it takes up to 16 periods of the slowest APB clock before the new division ratio is taken into account. The application can check if the new division factor is taken into account by reading back this register. 0xxx: sys_ck not divided (default after reset)


\
\ @brief CPU domain APB1 prescaler Set and reset by software to control the CPU domain APB1 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk1 after CDPPRE1 write. 0xx: rcc_pclk1 = rcc_hclk1 (default after reset)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000070 constant RCC_RCC_CDCFGR2_CDPPRE1                          \ CPU domain APB1 prescaler Set and reset by software to control the CPU domain APB1 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk1 after CDPPRE1 write. 0xx: rcc_pclk1 = rcc_hclk1 (default after reset)
$00000700 constant RCC_RCC_CDCFGR2_CDPPRE2                          \ CPU domain APB2 prescaler Set and reset by software to control the CPU domain APB2 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk1 after CDPPRE2 write. 0xx: rcc_pclk2 = rcc_hclk1 (default after reset)


\
\ @brief SmartRun domain APB4 prescaler Set and reset by software to control the SmartRun domain APB4 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk4 after SRDPPRE write. 0xx: rcc_pclk4 = rcc_hclk4 (default after reset)
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000070 constant RCC_RCC_SRDCFGR_SRDPPRE                          \ SmartRun domain APB4 prescaler Set and reset by software to control the SmartRun domain APB4 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk4 after SRDPPRE write. 0xx: rcc_pclk4 = rcc_hclk4 (default after reset)


\
\ @brief DIVMx and PLLs clock source selection Set and reset by software to select the PLL clock source. These bits can be written only when all PLLs are disabled. In order to save power, when no PLL is used, the value of PLLSRC must be set to '11â.
\ Address offset: 0x28
\ Reset value: 0x02020200
\

$00000003 constant RCC_RCC_PLLCKSELR_PLLSRC                         \ DIVMx and PLLs clock source selection Set and reset by software to select the PLL clock source. These bits can be written only when all PLLs are disabled. In order to save power, when no PLL is used, the value of PLLSRC must be set to '11â.
$000003f0 constant RCC_RCC_PLLCKSELR_DIVM1                          \ prescaler for PLL1 Set and cleared by software to configure the prescaler of the PLL1. The hardware does not allow any modification of this prescaler when PLL1 is enabled (PLL1ONÂ =Â 1). In order to save power when PLL1 is not used, the value of DIVM1 must be set to 0. ... ...
$0003f000 constant RCC_RCC_PLLCKSELR_DIVM2                          \ prescaler for PLL2 Set and cleared by software to configure the prescaler of the PLL2. The hardware does not allow any modification of this prescaler when PLL2 is enabled (PLL2ONÂ =Â 1). In order to save power when PLL2 is not used, the value of DIVM2 must be set to 0. ... ...
$03f00000 constant RCC_RCC_PLLCKSELR_DIVM3                          \ prescaler for PLL3 Set and cleared by software to configure the prescaler of the PLL3. The hardware does not allow any modification of this prescaler when PLL3 is enabled (PLL3ONÂ =Â 1). In order to save power when PLL3 is not used, the value of DIVM3 must be set to 0. ... ...


\
\ @brief PLL1 fractional latch enable Set and reset by software to latch the content of FRACN1 into the sigma-delta modulator. In order to latch the FRACN1 value into the sigma-delta modulator, PLL1FRACEN must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN1 into the modulator. Refer to for additional information.
\ Address offset: 0x2C
\ Reset value: 0x01FF0000
\

$00000001 constant RCC_RCC_PLLCFGR_PLL1FRACEN                       \ PLL1 fractional latch enable Set and reset by software to latch the content of FRACN1 into the sigma-delta modulator. In order to latch the FRACN1 value into the sigma-delta modulator, PLL1FRACEN must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN1 into the modulator. Refer to for additional information.
$00000002 constant RCC_RCC_PLLCFGR_PLL1VCOSEL                       \ PLL1 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL1. These bits must be written before enabling the PLL1.
$0000000c constant RCC_RCC_PLLCFGR_PLL1RGE                          \ PLL1 input frequency range Set and reset by software to select the proper reference frequency range used for PLL1. This bit must be written before enabling the PLL1.
$00000010 constant RCC_RCC_PLLCFGR_PLL2FRACEN                       \ PLL2 fractional latch enable Set and reset by software to latch the content of FRACN2 into the sigma-delta modulator. In order to latch the FRACN2 value into the sigma-delta modulator, PLL2FRACEN must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN2 into the modulator. Refer to for additional information.
$00000020 constant RCC_RCC_PLLCFGR_PLL2VCOSEL                       \ PLL2 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL2. This bit must be written before enabling the PLL2.
$000000c0 constant RCC_RCC_PLLCFGR_PLL2RGE                          \ PLL2 input frequency range Set and reset by software to select the proper reference frequency range used for PLL2. These bits must be written before enabling the PLL2.
$00000100 constant RCC_RCC_PLLCFGR_PLL3FRACEN                       \ PLL3 fractional latch enable Set and reset by software to latch the content of FRACN3 into the sigma-delta modulator. In order to latch the FRACN3 value into the sigma-delta modulator, PLL3FRACEN must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN3 into the modulator. Refer to for additional information.
$00000200 constant RCC_RCC_PLLCFGR_PLL3VCOSEL                       \ PLL3 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL3. This bit must be written before enabling the PLL3.
$00000c00 constant RCC_RCC_PLLCFGR_PLL3RGE                          \ PLL3 input frequency range Set and reset by software to select the proper reference frequency range used for PLL3. These bits must be written before enabling the PLL3.
$00010000 constant RCC_RCC_PLLCFGR_DIVP1EN                          \ PLL1 DIVP divider output enable Set and reset by software to enable the pll1_p_ck output of the PLL1. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). In order to save power, when the pll1_p_ck output of the PLL1 is not used, the pll1_p_ck must be disabled.
$00020000 constant RCC_RCC_PLLCFGR_DIVQ1EN                          \ PLL1 DIVQ divider output enable Set and reset by software to enable the pll1_q_ck output of the PLL1. In order to save power, when the pll1_q_ck output of the PLL1 is not used, the pll1_q_ck must be disabled. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).
$00040000 constant RCC_RCC_PLLCFGR_DIVR1EN                          \ PLL1 DIVR divider output enable Set and reset by software to enable the pll1_r_ck output of the PLL1. To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).
$00080000 constant RCC_RCC_PLLCFGR_DIVP2EN                          \ PLL2 DIVP divider output enable Set and reset by software to enable the pll2_p_ck output of the PLL2. This bit can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used.
$00100000 constant RCC_RCC_PLLCFGR_DIVQ2EN                          \ PLL2 DIVQ divider output enable Set and reset by software to enable the pll2_q_ck output of the PLL2. To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used. This bit can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0).
$00200000 constant RCC_RCC_PLLCFGR_DIVR2EN                          \ PLL2 DIVR divider output enable Set and reset by software to enable the pll2_r_ck output of the PLL2. To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used. This bit can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0).
$00400000 constant RCC_RCC_PLLCFGR_DIVP3EN                          \ PLL3 DIVP divider output enable Set and reset by software to enable the pll3_p_ck output of the PLL3. This bit can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0). To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used.
$00800000 constant RCC_RCC_PLLCFGR_DIVQ3EN                          \ PLL3 DIVQ divider output enable Set and reset by software to enable the pll3_q_ck output of the PLL3. To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used. This bit can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0).
$01000000 constant RCC_RCC_PLLCFGR_DIVR3EN                          \ PLL3 DIVR divider output enable Set and reset by software to enable the pll3_r_ck output of the PLL3. To save power, DIVR3EN and DIVR3 bits must be set to 0 when the pll3_r_ck is not used. This bit can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0).


\
\ @brief multiplication factor for PLL1 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL1ON = PLL1RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL1VCOSEL = 0 150 to 420Â MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x DIVN1, when fractional value 0 has been loaded into FRACN1, with: DIVN1 between 8 and 420 The input frequency Fref1_ck must be between 1 and 16Â MHz.
\ Address offset: 0x30
\ Reset value: 0x01010280
\

$000001ff constant RCC_RCC_PLL1DIVR_DIVN1                           \ multiplication factor for PLL1 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL1ON = PLL1RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL1VCOSEL = 0 150 to 420Â MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x DIVN1, when fractional value 0 has been loaded into FRACN1, with: DIVN1 between 8 and 420 The input frequency Fref1_ck must be between 1 and 16Â MHz.
$0000fe00 constant RCC_RCC_PLL1DIVR_DIVP1                           \ PLL1 DIVP division factor Set and reset by software to control the frequency of the pll1_p_ck clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). Note that odd division factors are not allowed. ...
$007f0000 constant RCC_RCC_PLL1DIVR_DIVQ1                           \ PLL1 DIVQ division factor Set and reset by software to control the frequency of the pll1_q_ck clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
$7f000000 constant RCC_RCC_PLL1DIVR_DIVR1                           \ PLL1 DIVR division factor Set and reset by software to control the frequency of the pll1_r_ck clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...


\
\ @brief fractional part of the multiplication factor for PLL1 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL1VCOSEL = 0 150 to 420Â MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x (DIVN1 + (FRACN1 / 213)), with DIVN1 between 8 and 420 FRACN1 can be between 0 and 213- 1 The input frequency Fref1_ck must be between 1 and 16 MHz. To change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into FRACN1. Set the bit PLL1FRACEN to 1.
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL1FRACR_FRACN1                         \ fractional part of the multiplication factor for PLL1 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL1VCOSEL = 0 150 to 420Â MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x (DIVN1 + (FRACN1 / 213)), with DIVN1 between 8 and 420 FRACN1 can be between 0 and 213- 1 The input frequency Fref1_ck must be between 1 and 16 MHz. To change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into FRACN1. Set the bit PLL1FRACEN to 1.


\
\ @brief multiplication factor for PLL2 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL2ON = PLL2RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL2VCOSEL = 0 150 to 420Â MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x DIVN2, when fractional value 0 has been loaded into FRACN2, with DIVN2 between 8 and 420 The input frequency Fref2_ck must be between 1 and 16MHz.
\ Address offset: 0x38
\ Reset value: 0x01010280
\

$000001ff constant RCC_RCC_PLL2DIVR_DIVN2                           \ multiplication factor for PLL2 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL2ON = PLL2RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL2VCOSEL = 0 150 to 420Â MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x DIVN2, when fractional value 0 has been loaded into FRACN2, with DIVN2 between 8 and 420 The input frequency Fref2_ck must be between 1 and 16MHz.
$0000fe00 constant RCC_RCC_PLL2DIVR_DIVP2                           \ PLL2 DIVP division factor Set and reset by software to control the frequency of the pll2_p_ck clock. These bits can be written only when the PLL2 is disabled (PLL2ON = PLL2RDY = 0). ...
$007f0000 constant RCC_RCC_PLL2DIVR_DIVQ2                           \ PLL2 DIVQ division factor Set and reset by software to control the frequency of the pll2_q_ck clock. These bits can be written only when the PLL2 is disabled (PLL2ON = PLL2RDY = 0). ...
$7f000000 constant RCC_RCC_PLL2DIVR_DIVR2                           \ PLL2 DIVR division factor Set and reset by software to control the frequency of the pll2_r_ck clock. These bits can be written only when the PLL2 is disabled (PLL2ON = PLL2RDY = 0). ...


\
\ @brief fractional part of the multiplication factor for PLL2 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL2VCOSEL = 0 150 to 420Â MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x (DIVN2 + (FRACN2 / 213)), with DIVN2 between 8 and 420 FRACN2 can be between 0 and 213 - 1 The input frequency Fref2_ck must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL2FRACEN to 0. Write the new fractional value into FRACN2. Set the bit PLL2FRACEN to 1.
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL2FRACR_FRACN2                         \ fractional part of the multiplication factor for PLL2 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL2VCOSEL = 0 150 to 420Â MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x (DIVN2 + (FRACN2 / 213)), with DIVN2 between 8 and 420 FRACN2 can be between 0 and 213 - 1 The input frequency Fref2_ck must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL2FRACEN to 0. Write the new fractional value into FRACN2. Set the bit PLL2FRACEN to 1.


\
\ @brief Multiplication factor for PLL3 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL3ON = PLL3RDY = 0). ...........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL3VCOSEL = 0 150 to 420Â MHz if PLL3VCOSEL = 1 VCO output frequency = Fref3_ck x DIVN3, when fractional value 0 has been loaded into FRACN3, with: DIVN3 between 8 and 420 The input frequency Fref3_ck must be between 1 and 16MHz
\ Address offset: 0x40
\ Reset value: 0x01010280
\

$000001ff constant RCC_RCC_PLL3DIVR_DIVN3                           \ Multiplication factor for PLL3 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL3ON = PLL3RDY = 0). ...........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL3VCOSEL = 0 150 to 420Â MHz if PLL3VCOSEL = 1 VCO output frequency = Fref3_ck x DIVN3, when fractional value 0 has been loaded into FRACN3, with: DIVN3 between 8 and 420 The input frequency Fref3_ck must be between 1 and 16MHz
$0000fe00 constant RCC_RCC_PLL3DIVR_DIVP3                           \ PLL3 DIVP division factor Set and reset by software to control the frequency of the pll3_p_ck clock. These bits can be written only when the PLL3 is disabled (PLL3ON = PLL3RDY = 0). ...
$007f0000 constant RCC_RCC_PLL3DIVR_DIVQ3                           \ PLL3 DIVQ division factor Set and reset by software to control the frequency of the pll3_q_ck clock. These bits can be written only when the PLL3 is disabled (PLL3ON = PLL3RDY = 0). ...
$7f000000 constant RCC_RCC_PLL3DIVR_DIVR3                           \ PLL3 DIVR division factor Set and reset by software to control the frequency of the pll3_r_ck clock. These bits can be written only when the PLL3 is disabled (PLL3ON = PLL3RDY = 0). ...


\
\ @brief fractional part of the multiplication factor for PLL3 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL3 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL3VCOSEL = 0 150 to 420Â MHz if PLL3VCOSEL = 1 VCO output frequency = Fref3_ck x (DIVN3 + (FRACN3 / 213)), with DIVN3 between 8 and 420 FRACN3 can be between 0 and 213 - 1 The input frequency Fref3_ck must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into FRACN1. Set the bit PLL1FRACEN to 1.
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL3FRACR_FRACN3                         \ fractional part of the multiplication factor for PLL3 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL3 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL3VCOSEL = 0 150 to 420Â MHz if PLL3VCOSEL = 1 VCO output frequency = Fref3_ck x (DIVN3 + (FRACN3 / 213)), with DIVN3 between 8 and 420 FRACN3 can be between 0 and 213 - 1 The input frequency Fref3_ck must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into FRACN1. Set the bit PLL1FRACEN to 1.


\
\ @brief RCC CPU domain kernel clock configuration register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_CDCCIPR_FMCSEL                           \ FMC kernel clock source selection
$00000030 constant RCC_RCC_CDCCIPR_OCTOSPISEL                       \ OCTOSPI kernel clock source selection
$00010000 constant RCC_RCC_CDCCIPR_SDMMCSEL                         \ SDMMC kernel clock source selection
$30000000 constant RCC_RCC_CDCCIPR_CKPERSEL                         \ per_ck clock source selection


\
\ @brief RCC CPU domain kernel clock configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_CDCCIP1R_SAI1SEL                         \ SAI1 and DFSDM1 kernel Aclk clock source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it isnot be possible to switch to another clock. Refer to for additional information. Note: DFSDM1 clock source selection is done by DFSDM1SEL. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin.
$000001c0 constant RCC_RCC_CDCCIP1R_SAI2ASEL                        \ SAI2 kernel clock source A selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not be possible to switch to another clock. Refer to for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin. spdifrx_symb_ck is the symbol clock generated by the SPDIFRX (see ).
$00000e00 constant RCC_RCC_CDCCIP1R_SAI2BSEL                        \ SAI2 kernel clock B source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not be possible to switch to another clock. Refer to for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin. spdifrx_symb_ck is the symbol clock generated by the spdifrx (see ).
$00007000 constant RCC_RCC_CDCCIP1R_SPI123SEL                       \ SPI/I2S1,2 and 3 kernel clock source selection Set and reset by software. If the selected clock is the external clock and this clock is stopped, it is not be possible to switch to another clock. Refer to for additional information. others: reserved, the kernel clock is disabled Note: I2S_CKIN is an external clock taken from a pin.
$00070000 constant RCC_RCC_CDCCIP1R_SPI45SEL                        \ SPI4 and 5 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00300000 constant RCC_RCC_CDCCIP1R_SPDIFRXSEL                      \ SPDIFRX kernel clock source selection
$01000000 constant RCC_RCC_CDCCIP1R_DFSDM1SEL                       \ DFSDM1 kernel clock Clk source selection Set and reset by software. Note: the DFSDM1 Aclk clock source selection is done by SAI1SEL (see ).
$30000000 constant RCC_RCC_CDCCIP1R_FDCANSEL                        \ FDCAN kernel clock source selection Set and reset by software.
$80000000 constant RCC_RCC_CDCCIP1R_SWPMISEL                        \ SWPMI kernel clock source selection Set and reset by software.


\
\ @brief RCC CPU domain kernel clock configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_CDCCIP2R_USART234578SEL                  \ USART2/3, UART4,5, 7 and 8 (APB1) kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000038 constant RCC_RCC_CDCCIP2R_USART16910SEL                   \ USART1, 6, 9 and 10 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000300 constant RCC_RCC_CDCCIP2R_RNGSEL                          \ RNG kernel clock source selection Set and reset by software.
$00003000 constant RCC_RCC_CDCCIP2R_I2C123SEL                       \ I2C1,2,3 kernel clock source selection Set and reset by software.
$00300000 constant RCC_RCC_CDCCIP2R_USBSEL                          \ USBOTG 1 and 2 kernel clock source selection Set and reset by software.
$00c00000 constant RCC_RCC_CDCCIP2R_CECSEL                          \ HDMI-CEC kernel clock source selection Set and reset by software.
$70000000 constant RCC_RCC_CDCCIP2R_LPTIM1SEL                       \ LPTIM1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled


\
\ @brief RCC SmartRun domain kernel clock configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_SRDCCIPR_LPUART1SEL                      \ LPUART1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000300 constant RCC_RCC_SRDCCIPR_I2C4SEL                         \ I2C4 kernel clock source selection Set and reset by software.
$00001c00 constant RCC_RCC_SRDCCIPR_LPTIM2SEL                       \ LPTIM2 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$0000e000 constant RCC_RCC_SRDCCIPR_LPTIM3SEL                       \ LPTIM3 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00030000 constant RCC_RCC_SRDCCIPR_ADCSEL                          \ SAR ADC kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$08000000 constant RCC_RCC_SRDCCIPR_DFSDM2SEL                       \ DFSDM2 kernel Clk clock source selection Set and reset by software. Note: The DFSDM2 Aclk clock source selection is done by SPI6SEL (see and ).
$70000000 constant RCC_RCC_SRDCCIPR_SPI6SEL                         \ SPI6 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled


\
\ @brief LSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the LSI oscillator stabilization.
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
\ @brief LSI ready interrupt flag Reset by software by writing LSIRDYC bit. Set by hardware when the LSI clock becomes stable and LSIRDYIE is set.
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
\ @brief LSI ready interrupt clear Set by software to clear LSIRDYF. Reset by hardware when clear done.
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
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_BDCR_LSEON                               \ LSE oscillator enabled Set and reset by software.
$00000002 constant RCC_RCC_BDCR_LSERDY                              \ LSE oscillator ready Set and reset by hardware to indicate when the LSE is stable. This bit needs 6 cycles of lse_ck clock to fall down after LSEON has been set to 0.
$00000004 constant RCC_RCC_BDCR_LSEBYP                              \ LSE oscillator bypass Set and reset by software to bypass oscillator in debug mode. This bit must not be written when the LSE is enabled (by LSEON) or ready (LSERDY = 1)
$00000018 constant RCC_RCC_BDCR_LSEDRV                              \ LSE oscillator driving capability Set by software to select the driving capability of the LSE oscillator.
$00000020 constant RCC_RCC_BDCR_LSECSSON                            \ LSE clock security system enable Set by software to enable the clock security system on 32 kHz oscillator. LSECSSON must be enabled after LSE is enabled (LSEON enabled) and ready (LSERDY set by hardware) and after RTCSEL is selected. Once enabled, this bit cannot be disabled, except after a LSE failure detection (LSECSSD = 1). In that case the software must disable LSECSSON.
$00000040 constant RCC_RCC_BDCR_LSECSSD                             \ LSE clock security system failure detection Set by hardware to indicate when a failure has been detected by the clock security system on the external 32 kHz oscillator.
$00000080 constant RCC_RCC_BDCR_LSEEXT                              \ low-speed external clock type in Bypass mode Set and reset by software to select the external clock type (analog or digital). The external clock must be enabled with the LSEON bit, to be used by the device. The LSEEXT bit can be written only if the LSE oscillator is disabled.
$00000300 constant RCC_RCC_BDCR_RTCSEL                              \ RTC clock source selection Set by software to select the clock source for the RTC. These bits can be written only one time (except in case of failure detection on LSE). These bits must be written before LSECSSON is enabled. The VSWRST bit can be used to reset them, then it can be written one time again. If HSE is selected as RTC clock, this clock is lost when the system is in Stop mode or in case of a pin reset (NRST).
$00008000 constant RCC_RCC_BDCR_RTCEN                               \ RTC clock enable Set and reset by software.
$00010000 constant RCC_RCC_BDCR_VSWRST                              \ VSwitch domain software reset Set and reset by software.


\
\ @brief RCC clock control and status register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CSR_LSION                                \ LSI oscillator enable Set and reset by software.
$00000002 constant RCC_RCC_CSR_LSIRDY                               \ LSI oscillator ready Set and reset by hardware to indicate when the low-speed internal RC oscillator is stable. This bit needs 3 cycles of lsi_ck clock to fall down after LSION has been set to 0. This bit can be set even when LSION is not enabled if there is a request for LSI clock by the clock security system on LSE or by the low-speed watchdog or by the RTC.


\
\ @brief MDMA block reset Set and reset by software.
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB3RSTR_MDMARST                         \ MDMA block reset Set and reset by software.
$00000010 constant RCC_RCC_AHB3RSTR_DMA2DRST                        \ DMA2D block reset Set and reset by software.
$00000020 constant RCC_RCC_AHB3RSTR_JPGDECRST                       \ JPGDEC block reset Set and reset by software.
$00001000 constant RCC_RCC_AHB3RSTR_FMCRST                          \ FMC block reset Set and reset by software.
$00004000 constant RCC_RCC_AHB3RSTR_OCTOSPI1RST                     \ OCTOSPI1 and OCTOSPI1 delay blocks reset Set and reset by software.
$00010000 constant RCC_RCC_AHB3RSTR_SDMMC1RST                       \ SDMMC1 and SDMMC1 delay blocks reset Set and reset by software.
$00080000 constant RCC_RCC_AHB3RSTR_OCTOSPI2RST                     \ OCTOSPI2 and OCTOSPI2 delay block reset Set and reset by software
$00200000 constant RCC_RCC_AHB3RSTR_OCTOSPIMRST                     \ OCTOSPIM reset Set and reset by software
$00400000 constant RCC_RCC_AHB3RSTR_OTFD1RST                        \ OTFD1 reset Set and reset by software Take care that resetting the OTFD means loosing the decryption key loaded during secure boot.
$00800000 constant RCC_RCC_AHB3RSTR_OTFD2RST                        \ OTFD2 reset Set and reset by software Take care that resetting the OTFD means loosing the decryption key loaded during secure boot.
$01000000 constant RCC_RCC_AHB3RSTR_GFXMMURST                       \ GFXMMU reset Set and reset by software


\
\ @brief DMA1 and DMAMUX1 blocks reset Set and reset by software.
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB1RSTR_DMA1RST                         \ DMA1 and DMAMUX1 blocks reset Set and reset by software.
$00000002 constant RCC_RCC_AHB1RSTR_DMA2RST                         \ DMA2 and DMAMUX2 blocks reset Set and reset by software.
$00000020 constant RCC_RCC_AHB1RSTR_ADC12RST                        \ ADC1 and 2 blocks reset Set and reset by software.
$00000200 constant RCC_RCC_AHB1RSTR_CRCRST                          \ CRC block reset Set and reset by software.
$02000000 constant RCC_RCC_AHB1RSTR_USB1OTGRST                      \ USB1OTG block reset Set and reset by software.


\
\ @brief digital camera interface block reset (DCMI or PSSI depending which IP is active) Set and reset by software.
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB2RSTR_DCMI_PSSIRST                    \ digital camera interface block reset (DCMI or PSSI depending which IP is active) Set and reset by software.
$00000004 constant RCC_RCC_AHB2RSTR_HSEMRST                         \ HSEM block reset Set and reset by software.
$00000010 constant RCC_RCC_AHB2RSTR_CRYPTRST                        \ cryptography block reset Set and reset by software.
$00000020 constant RCC_RCC_AHB2RSTR_HASHRST                         \ hash block reset Set and reset by software.
$00000040 constant RCC_RCC_AHB2RSTR_RNGRST                          \ random number generator block reset Set and reset by software.
$00000200 constant RCC_RCC_AHB2RSTR_SDMMC2RST                       \ SDMMC2 and SDMMC2 delay blocks reset Set and reset by software.
$00000800 constant RCC_RCC_AHB2RSTR_BDMA1RST                        \ BDMA1 reset (DFSDM dedicated DMA) Set and reset by software.


\
\ @brief GPIOA block reset Set and reset by software.
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
$00000100 constant RCC_RCC_AHB4RSTR_GPIOIRST                        \ GPIOI block reset Set and reset by software.
$00000200 constant RCC_RCC_AHB4RSTR_GPIOJRST                        \ GPIOJ block reset Set and reset by software.
$00000400 constant RCC_RCC_AHB4RSTR_GPIOKRST                        \ GPIOK block reset Set and reset by software.
$00200000 constant RCC_RCC_AHB4RSTR_BDMA2RST                        \ SmartRun domain DMA and DMAMUX blocks reset Set and reset by software.


\
\ @brief LTDC block reset Set and reset by software.
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000008 constant RCC_RCC_APB3RSTR_LTDCRST                         \ LTDC block reset Set and reset by software.


\
\ @brief TIM2 block reset Set and reset by software.
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1LRSTR_TIM2RST                        \ TIM2 block reset Set and reset by software.
$00000002 constant RCC_RCC_APB1LRSTR_TIM3RST                        \ TIM3 block reset Set and reset by software.
$00000004 constant RCC_RCC_APB1LRSTR_TIM4RST                        \ TIM4 block reset Set and reset by software.
$00000008 constant RCC_RCC_APB1LRSTR_TIM5RST                        \ TIM5 block reset Set and reset by software.
$00000010 constant RCC_RCC_APB1LRSTR_TIM6RST                        \ TIM6 block reset Set and reset by software.
$00000020 constant RCC_RCC_APB1LRSTR_TIM7RST                        \ TIM7 block reset Set and reset by software.
$00000040 constant RCC_RCC_APB1LRSTR_TIM12RST                       \ TIM12 block reset Set and reset by software.
$00000080 constant RCC_RCC_APB1LRSTR_TIM13RST                       \ TIM13 block reset Set and reset by software.
$00000100 constant RCC_RCC_APB1LRSTR_TIM14RST                       \ TIM14 block reset Set and reset by software.
$00000200 constant RCC_RCC_APB1LRSTR_LPTIM1RST                      \ LPTIM1 block reset Set and reset by software.
$00004000 constant RCC_RCC_APB1LRSTR_SPI2RST                        \ SPI2 block reset Set and reset by software.
$00008000 constant RCC_RCC_APB1LRSTR_SPI3RST                        \ SPI3 block reset Set and reset by software.
$00010000 constant RCC_RCC_APB1LRSTR_SPDIFRXRST                     \ SPDIFRX block reset Set and reset by software.
$00020000 constant RCC_RCC_APB1LRSTR_USART2RST                      \ USART2 block reset Set and reset by software.
$00040000 constant RCC_RCC_APB1LRSTR_USART3RST                      \ USART3 block reset Set and reset by software.
$00080000 constant RCC_RCC_APB1LRSTR_UART4RST                       \ UART4 block reset Set and reset by software.
$00100000 constant RCC_RCC_APB1LRSTR_UART5RST                       \ UART5 block reset Set and reset by software.
$00200000 constant RCC_RCC_APB1LRSTR_I2C1RST                        \ I2C1 block reset Set and reset by software.
$00400000 constant RCC_RCC_APB1LRSTR_I2C2RST                        \ I2C2 block reset Set and reset by software.
$00800000 constant RCC_RCC_APB1LRSTR_I2C3RST                        \ I2C3 block reset Set and reset by software.
$08000000 constant RCC_RCC_APB1LRSTR_CECRST                         \ HDMI-CEC block reset Set and reset by software.
$20000000 constant RCC_RCC_APB1LRSTR_DAC1RST                        \ DAC1 (containing two converters) reset Set and reset by software.
$40000000 constant RCC_RCC_APB1LRSTR_UART7RST                       \ UART7 block reset Set and reset by software.
$80000000 constant RCC_RCC_APB1LRSTR_UART8RST                       \ UART8 block reset Set and reset by software.


\
\ @brief clock recovery system reset Set and reset by software.
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB1HRSTR_CRSRST                         \ clock recovery system reset Set and reset by software.
$00000004 constant RCC_RCC_APB1HRSTR_SWPMIRST                       \ SWPMI block reset Set and reset by software.
$00000010 constant RCC_RCC_APB1HRSTR_OPAMPRST                       \ OPAMP block reset Set and reset by software.
$00000020 constant RCC_RCC_APB1HRSTR_MDIOSRST                       \ MDIOS block reset Set and reset by software.
$00000100 constant RCC_RCC_APB1HRSTR_FDCANRST                       \ FDCAN block reset Set and reset by software.


\
\ @brief TIM1 block reset Set and reset by software.
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB2RSTR_TIM1RST                         \ TIM1 block reset Set and reset by software.
$00000002 constant RCC_RCC_APB2RSTR_TIM8RST                         \ TIM8 block reset Set and reset by software.
$00000010 constant RCC_RCC_APB2RSTR_USART1RST                       \ USART1 block reset Set and reset by software.
$00000020 constant RCC_RCC_APB2RSTR_USART6RST                       \ USART6 block reset Set and reset by software.
$00000040 constant RCC_RCC_APB2RSTR_UART9RST                        \ UART9 block reset Set and reset by software.
$00000080 constant RCC_RCC_APB2RSTR_USART10RST                      \ USART10 block reset Set and reset by software.
$00001000 constant RCC_RCC_APB2RSTR_SPI1RST                         \ SPI1 block reset Set and reset by software.
$00002000 constant RCC_RCC_APB2RSTR_SPI4RST                         \ SPI4 block reset Set and reset by software.
$00010000 constant RCC_RCC_APB2RSTR_TIM15RST                        \ TIM15 block reset Set and reset by software.
$00020000 constant RCC_RCC_APB2RSTR_TIM16RST                        \ TIM16 block reset Set and reset by software.
$00040000 constant RCC_RCC_APB2RSTR_TIM17RST                        \ TIM17 block reset Set and reset by software.
$00100000 constant RCC_RCC_APB2RSTR_SPI5RST                         \ SPI5 block reset Set and reset by software.
$00400000 constant RCC_RCC_APB2RSTR_SAI1RST                         \ SAI1 block reset Set and reset by software.
$00800000 constant RCC_RCC_APB2RSTR_SAI2RST                         \ SAI2 block reset Set and reset by software.
$40000000 constant RCC_RCC_APB2RSTR_DFSDM1RST                       \ DFSDM1 block reset Set and reset by software.


\
\ @brief SYSCFG block reset Set and reset by software.
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB4RSTR_SYSCFGRST                       \ SYSCFG block reset Set and reset by software.
$00000008 constant RCC_RCC_APB4RSTR_LPUART1RST                      \ LPUART1 block reset Set and reset by software.
$00000020 constant RCC_RCC_APB4RSTR_SPI6RST                         \ SPI6 block reset Set and reset by software.
$00000080 constant RCC_RCC_APB4RSTR_I2C4RST                         \ I2C4 block reset Set and reset by software.
$00000200 constant RCC_RCC_APB4RSTR_LPTIM2RST                       \ LPTIM2 block reset Set and reset by software.
$00000400 constant RCC_RCC_APB4RSTR_LPTIM3RST                       \ LPTIM3 block reset Set and reset by software.
$00002000 constant RCC_RCC_APB4RSTR_DAC2RST                         \ DAC2 (containing one converter) reset Set and reset by software.
$00004000 constant RCC_RCC_APB4RSTR_COMP12RST                       \ COMP1 and 2 blocks reset Set and reset by software.
$00008000 constant RCC_RCC_APB4RSTR_VREFRST                         \ VREF block reset Set and reset by software.
$04000000 constant RCC_RCC_APB4RSTR_DTSRST                          \ Digital temperature sensor block reset Set and reset by software.
$08000000 constant RCC_RCC_APB4RSTR_DFSDM2RST                       \ DFSDM2 block reset Set and reset by software.


\
\ @brief RCC SmartRun domain Autonomous mode register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_SRDAMR_BDMA2AMEN                         \ SmartRun domain DMA and DMAMUX Autonomous mode enable Set and reset by software. Refer to for additional information.
$00000002 constant RCC_RCC_SRDAMR_GPIOAMEN                          \ GPIO Autonomous mode enable Set and reset by software. Refer to for additional information.
$00000008 constant RCC_RCC_SRDAMR_LPUART1AMEN                       \ LPUART1 Autonomous mode enable Set and reset by software. Refer to for additional information.
$00000020 constant RCC_RCC_SRDAMR_SPI6AMEN                          \ SPI6 Autonomous mode enable Set and reset by software. Refer to for additional information.
$00000080 constant RCC_RCC_SRDAMR_I2C4AMEN                          \ I2C4 Autonomous mode enable Set and reset by software. Refer to for additional information.
$00000200 constant RCC_RCC_SRDAMR_LPTIM2AMEN                        \ LPTIM2 Autonomous mode enable Set and reset by software. Refer to for additional information
$00000400 constant RCC_RCC_SRDAMR_LPTIM3AMEN                        \ LPTIM3 Autonomous mode enable Set and reset by software. Refer to for additional information.
$00002000 constant RCC_RCC_SRDAMR_DAC2AMEN                          \ DAC2 (containing one converter) Autonomous mode enable Set and reset by software. Refer to for additional information.
$00004000 constant RCC_RCC_SRDAMR_COMP12AMEN                        \ COMP1 and 2 Autonomous mode enable Set and reset by software. Refer to for additional information.
$00008000 constant RCC_RCC_SRDAMR_VREFAMEN                          \ VREF Autonomous mode enable Set and reset by software. Refer to for additional information.
$00010000 constant RCC_RCC_SRDAMR_RTCAMEN                           \ RTC Autonomous mode enable Set and reset by software. Refer to for additional information.
$04000000 constant RCC_RCC_SRDAMR_DTSAMEN                           \ Digital temperature sensor Autonomous mode enable Set and reset by software. Refer to for additional information.
$08000000 constant RCC_RCC_SRDAMR_DFSDM2AMEN                        \ DFSDM2 Autonomous mode enable Set and reset by software. Refer to for additional information.
$10000000 constant RCC_RCC_SRDAMR_BKPRAMAMEN                        \ Backup RAM Autonomous mode enable Set and reset by software. Refer to for additional information.
$20000000 constant RCC_RCC_SRDAMR_SRDSRAMAMEN                       \ SmartRun domain SRAM Autonomous mode enable Set and reset by software. Refer to for additional information.


\
\ @brief RCC AXI clocks gating enable register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CKGAENR_AXICKG                           \ AXI interconnect matrix clock gating This bit is set and reset by software.
$00000002 constant RCC_RCC_CKGAENR_AHBCKG                           \ AXI master AHB clock gating This bit is set and reset by software.
$00000004 constant RCC_RCC_CKGAENR_CPUCKG                           \ AXI master CPU clock gating This bit is set and reset by software.
$00000008 constant RCC_RCC_CKGAENR_SDMMCCKG                         \ AXI master SDMMC clock gating This bit is set and reset by software.
$00000010 constant RCC_RCC_CKGAENR_MDMACKG                          \ AXI master MDMA clock gating This bit is set and reset by software.
$00000020 constant RCC_RCC_CKGAENR_DMA2DCKG                         \ AXI master DMA2D clock gating This bit is set and reset by software.
$00000040 constant RCC_RCC_CKGAENR_LTDCCKG                          \ AXI master LTDC clock gating This bit is set and reset by software.
$00000080 constant RCC_RCC_CKGAENR_GFXMMUMCKG                       \ AXI master GFXMMU clock gating This bit is set and reset by software.
$00000100 constant RCC_RCC_CKGAENR_AHB12CKG                         \ AXI slave AHB12 clock gating This bit is set and reset by software.
$00000200 constant RCC_RCC_CKGAENR_AHB34CKG                         \ AXI slave AHB34 clock gating This bit is set and reset by software.
$00000400 constant RCC_RCC_CKGAENR_FLIFTCKG                         \ AXI slave Flash interface (FLIFT) clock gating This bit is set and reset by software.
$00000800 constant RCC_RCC_CKGAENR_OCTOSPI2CKG                      \ AXI slave OCTOSPI2 clock gating This bit is set and reset by software.
$00001000 constant RCC_RCC_CKGAENR_FMCCKG                           \ AXI slave FMC clock gating This bit is set and reset by software.
$00002000 constant RCC_RCC_CKGAENR_OCTOSPI1CKG                      \ AXI slave OCTOSPI1 clock gating This bit is set and reset by software.
$00004000 constant RCC_RCC_CKGAENR_AXIRAM1CKG                       \ AXI slave SRAM1 clock gating This bit is set and reset by software.
$00008000 constant RCC_RCC_CKGAENR_AXIRAM2CKG                       \ AXI matrix slave SRAM2 clock gating This bit is set and reset by software.
$00010000 constant RCC_RCC_CKGAENR_AXIRAM3CKG                       \ AXI matrix slave SRAM3 clock gating This bit is set and reset by software.
$00020000 constant RCC_RCC_CKGAENR_GFXMMUSCKG                       \ AXI matrix slave GFXMMU clock gating This bit is set and reset by software.
$20000000 constant RCC_RCC_CKGAENR_ECCRAMCKG                        \ RAM error code correction (ECC) clock gating This bit is set and reset by software.
$40000000 constant RCC_RCC_CKGAENR_EXTICKG                          \ EXTI clock gating This bit is set and reset by software.
$80000000 constant RCC_RCC_CKGAENR_JTAGCKG                          \ JTAG automatic clock gating This bit is set and reset by software.


\
\ @brief RCC reset status register
\ Address offset: 0x130
\ Reset value: 0x00E80000
\

$00010000 constant RCC_RCC_RSR_RMVF                                 \ remove reset flag Set and reset by software to reset the value of the reset flags.
$00080000 constant RCC_RCC_RSR_CDRSTF                               \ CPU domain power-switch reset flag Reset by software by writing the RMVF bit. Set by hardware when a the CPU domain exits from DStop or after of power-on reset. Set also when the CPU domain exists DStop2 but only when a pad reset has occurred during DStop2 (PINRST bit also set by hardware)
$00200000 constant RCC_RCC_RSR_BORRSTF                              \ BOR reset flag Reset by software by writing the RMVF bit. Set by hardware when a BOR reset occurs (pwr_bor_rst).
$00400000 constant RCC_RCC_RSR_PINRSTF                              \ pin reset flag (NRST) Reset by software by writing the RMVF bit. Set by hardware when a reset from pin occurs.
$00800000 constant RCC_RCC_RSR_PORRSTF                              \ POR/PDR reset flag Reset by software by writing the RMVF bit. Set by hardware when a POR/PDR reset occurs.
$01000000 constant RCC_RCC_RSR_SFTRSTF                              \ system reset from CPU reset flag Reset by software by writing the RMVF bit. Set by hardware when the system reset is due to CPU.The CPU can generate a system reset by writing SYSRESETREQ bit of AIRCR register of the core M7.
$04000000 constant RCC_RCC_RSR_IWDGRSTF                             \ independent watchdog reset flag Reset by software by writing the RMVF bit. Set by hardware when an independent watchdog reset occurs.
$10000000 constant RCC_RCC_RSR_WWDGRSTF                             \ window watchdog reset flag Reset by software by writing the RMVF bit. Set by hardware when a window watchdog reset occurs.
$40000000 constant RCC_RCC_RSR_LPWRRSTF                             \ reset due to illegal CD DStop or CD DStop2 or CPU CStop flag Reset by software by writing the RMVF bit. Set by hardware when the CPU domain goes erroneously in DStop or DStop2, or when the CPU goes erroneously in CStop.


\
\ @brief MDMA peripheral clock enable Set and reset by software.
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB3ENR_MDMAEN                           \ MDMA peripheral clock enable Set and reset by software.
$00000010 constant RCC_RCC_AHB3ENR_DMA2DEN                          \ DMA2D peripheral clock enable Set and reset by software.
$00000020 constant RCC_RCC_AHB3ENR_JPGDECEN                         \ JPGDEC peripheral clock enable Set and reset by software.
$00001000 constant RCC_RCC_AHB3ENR_FMCEN                            \ FMC peripheral clocks enable Set and reset by software. The peripheral clocks of the FMC are the kernel clock selected by FMCSEL and provided to fmc_ker_ck input, and the rcc_hclk3 bus interface clock.
$00004000 constant RCC_RCC_AHB3ENR_OCTOSPI1EN                       \ OCTOSPI1 and OCTOSPI1 delay clock enable Set and reset by software.
$00010000 constant RCC_RCC_AHB3ENR_SDMMC1EN                         \ SDMMC1 and SDMMC1 delay clock enable Set and reset by software.
$00080000 constant RCC_RCC_AHB3ENR_OCTOSPI2EN                       \ OCTOSPI2 clock enable Set and reset by software.
$00200000 constant RCC_RCC_AHB3ENR_OCTOSPIMEN                       \ OCTOSPIM clock enable Set and reset by software.
$00400000 constant RCC_RCC_AHB3ENR_OTFD1EN                          \ OTFD1 clock enable Set and reset by software.
$00800000 constant RCC_RCC_AHB3ENR_OTFD2EN                          \ OTFD2 clock enable Set and reset by software.
$01000000 constant RCC_RCC_AHB3ENR_GFXMMUEN                         \ GFXMMU clock enable Set and reset by software.


\
\ @brief DMA1 clock enable Set and reset by software.
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB1ENR_DMA1EN                           \ DMA1 clock enable Set and reset by software.
$00000002 constant RCC_RCC_AHB1ENR_DMA2EN                           \ DMA2 clock enable Set and reset by software.
$00000020 constant RCC_RCC_AHB1ENR_ADC12EN                          \ ADC1 and 2 peripheral clocks enable Set and reset by software. The peripheral clocks of the ADC1 and 2 are the kernel clock selected by ADCSEL and provided to adc_ker_ck input, and the rcc_hclk1 bus interface clock.
$00000200 constant RCC_RCC_AHB1ENR_CRCEN                            \ CRC peripheral clock enable Set and reset by software.
$02000000 constant RCC_RCC_AHB1ENR_USB1OTGEN                        \ USB1OTG peripheral clocks enable Set and reset by software. The peripheral clocks of the USB1OTG are the kernel clock selected by USBSEL and the rcc_hclk1 bus interface clock.
$04000000 constant RCC_RCC_AHB1ENR_USB1ULPIEN                       \ USB_PHY1 clocks enable Set and reset by software.


\
\ @brief digital camera interface peripheral clock enable (DCMI or PSSI depending which IP is active) Set and reset by software.
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB2ENR_DCMI_PSSIEN                      \ digital camera interface peripheral clock enable (DCMI or PSSI depending which IP is active) Set and reset by software.
$00000004 constant RCC_RCC_AHB2ENR_HSEMEN                           \ HSEM peripheral clock enable Set and reset by software.
$00000010 constant RCC_RCC_AHB2ENR_CRYPTEN                          \ CRYPT peripheral clock enable Set and reset by software.
$00000020 constant RCC_RCC_AHB2ENR_HASHEN                           \ HASH peripheral clock enable Set and reset by software.
$00000040 constant RCC_RCC_AHB2ENR_RNGEN                            \ RNG peripheral clocks enable Set and reset by software. The peripheral clocks of the RNG are the kernel clock selected by RNGSEL and provided to rng_clk input, and the rcc_hclk2 bus interface clock.
$00000200 constant RCC_RCC_AHB2ENR_SDMMC2EN                         \ SDMMC2 and SDMMC2 delay clock enable Set and reset by software.
$00000800 constant RCC_RCC_AHB2ENR_BDMA1EN                          \ DMA clock enable (DFSDM dedicated DMA) Set and reset by software.
$20000000 constant RCC_RCC_AHB2ENR_AHBSRAM1EN                       \ AHBSRAM1 block enable Set and reset by software. When set, this bit indicates that the SRAM1 is allocated by the CPU. It causes the CPU domain to take into account also the CPU operation modes, keeping the CPU domain in DRun when the CPU is in CRun.
$40000000 constant RCC_RCC_AHB2ENR_AHBSRAM2EN                       \ AHBSRAM2 block enable Set and reset by software. When set, this bit indicates that the SRAM2 is allocated by the CPU. It causes the CPU domain to take into account also the CPU operation modes, keeping the CPU domain in DRun when the CPU is in CRun.


\
\ @brief GPIOA peripheral clock enable Set and reset by software.
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
$00000100 constant RCC_RCC_AHB4ENR_GPIOIEN                          \ GPIOI peripheral clock enable Set and reset by software.
$00000200 constant RCC_RCC_AHB4ENR_GPIOJEN                          \ GPIOJ peripheral clock enable Set and reset by software.
$00000400 constant RCC_RCC_AHB4ENR_GPIOKEN                          \ GPIOK peripheral clock enable Set and reset by software.
$00200000 constant RCC_RCC_AHB4ENR_BDMA2EN                          \ SmartRun domain DMA and DMAMUX clock enable Set and reset by software.
$10000000 constant RCC_RCC_AHB4ENR_BKPRAMEN                         \ Backup RAM clock enable Set and reset by software.
$20000000 constant RCC_RCC_AHB4ENR_SRDSRAMEN                        \ SmartRun domain SRAM clock enable Set and reset by software.


\
\ @brief LTDC clock enable Provides the clock (ltdc_pclk, ltdc_aclk, ltdc_ker_ck) to the LTDC block. Set and reset by software.
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000008 constant RCC_RCC_APB3ENR_LTDCEN                           \ LTDC clock enable Provides the clock (ltdc_pclk, ltdc_aclk, ltdc_ker_ck) to the LTDC block. Set and reset by software.
$00000040 constant RCC_RCC_APB3ENR_WWDGEN                           \ WWDG clock enable Set by software, and reset by hardware when a system reset occurs. Note that in order to work properly, before enabling the WWDG, the bit WW1RSC must be set to 1.


\
\ @brief TIM2 peripheral clock enable Set and reset by software.
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1LENR_TIM2EN                          \ TIM2 peripheral clock enable Set and reset by software.
$00000002 constant RCC_RCC_APB1LENR_TIM3EN                          \ TIM3 peripheral clock enable Set and reset by software.
$00000004 constant RCC_RCC_APB1LENR_TIM4EN                          \ TIM4 peripheral clock enable Set and reset by software.
$00000008 constant RCC_RCC_APB1LENR_TIM5EN                          \ TIM5 peripheral clock enable Set and reset by software.
$00000010 constant RCC_RCC_APB1LENR_TIM6EN                          \ TIM6 peripheral clock enable Set and reset by software.
$00000020 constant RCC_RCC_APB1LENR_TIM7EN                          \ TIM7 peripheral clock enable Set and reset by software.
$00000040 constant RCC_RCC_APB1LENR_TIM12EN                         \ TIM12 peripheral clock enable Set and reset by software.
$00000080 constant RCC_RCC_APB1LENR_TIM13EN                         \ TIM13 peripheral clock enable Set and reset by software.
$00000100 constant RCC_RCC_APB1LENR_TIM14EN                         \ TIM14 peripheral clock enable Set and reset by software.
$00000200 constant RCC_RCC_APB1LENR_LPTIM1EN                        \ LPTIM1 peripheral clocks enable Set and reset by software. The peripheral clocks of the LPTIM1 are the kernel clock selected by LPTIM1SEL and provided to lptim_ker_ck input, and the rcc_pclk1 bus interface clock.
$00004000 constant RCC_RCC_APB1LENR_SPI2EN                          \ SPI2 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI2 are the kernel clock selected by I2S123SRC and provided to spi_ker_ck input, and the rcc_pclk1 bus interface clock.
$00008000 constant RCC_RCC_APB1LENR_SPI3EN                          \ SPI3 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI3 are the kernel clock selected by I2S123SRC and provided to spi_ker_ck input, and the rcc_pclk1 bus interface clock.
$00010000 constant RCC_RCC_APB1LENR_SPDIFRXEN                       \ SPDIFRX peripheral clocks enable Set and reset by software. The peripheral clocks of the SPDIFRX are the kernel clock selected by SPDIFRXSEL and provided to spdifrx_ker_ck input, and the rcc_pclk1 bus interface clock.
$00020000 constant RCC_RCC_APB1LENR_USART2EN                        \ USART2peripheral clocks enable Set and reset by software. The peripheral clocks of the USART2 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
$00040000 constant RCC_RCC_APB1LENR_USART3EN                        \ USART3 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART3 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
$00080000 constant RCC_RCC_APB1LENR_UART4EN                         \ UART4 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART4 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
$00100000 constant RCC_RCC_APB1LENR_UART5EN                         \ UART5 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART5 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
$00200000 constant RCC_RCC_APB1LENR_I2C1EN                          \ I2C1 peripheral clocks enable Set and reset by software. The peripheral clocks of the I2C1 are the kernel clock selected by I2C123SEL and provided to i2C_ker_ck input, and the rcc_pclk1 bus interface clock.
$00400000 constant RCC_RCC_APB1LENR_I2C2EN                          \ I2C2 peripheral clocks enable Set and reset by software. The peripheral clocks of the I2C2 are the kernel clock selected by I2C123SEL and provided to i2C_ker_ck input, and the rcc_pclk1 bus interface clock.
$00800000 constant RCC_RCC_APB1LENR_I2C3EN                          \ I2C3 peripheral clocks enable Set and reset by software. The peripheral clocks of the I2C3 are the kernel clock selected by I2C123SEL and provided to i2C_ker_ck input, and the rcc_pclk1 bus interface clock.
$08000000 constant RCC_RCC_APB1LENR_CECEN                           \ HDMI-CEC peripheral clock enable Set and reset by software. The peripheral clocks of the HDMI-CEC are the kernel clock selected by CECSEL and provided to cec_ker_ck input, and the rcc_pclk1 bus interface clock.
$20000000 constant RCC_RCC_APB1LENR_DAC1EN                          \ DAC1 (containing two converters) peripheral clock enable Set and reset by software.
$40000000 constant RCC_RCC_APB1LENR_UART7EN                         \ UART7 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART7 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
$80000000 constant RCC_RCC_APB1LENR_UART8EN                         \ UART8 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART8 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.


\
\ @brief clock recovery system peripheral clock enable Set and reset by software.
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB1HENR_CRSEN                           \ clock recovery system peripheral clock enable Set and reset by software.
$00000004 constant RCC_RCC_APB1HENR_SWPMIEN                         \ SWPMI peripheral clocks enable Set and reset by software.
$00000010 constant RCC_RCC_APB1HENR_OPAMPEN                         \ OPAMP peripheral clock enable Set and reset by software.
$00000020 constant RCC_RCC_APB1HENR_MDIOSEN                         \ MDIOS peripheral clock enable Set and reset by software.
$00000100 constant RCC_RCC_APB1HENR_FDCANEN                         \ FDCAN peripheral clocks enable Set and reset by software. The peripheral clocks of the FDCAN are the kernel clock selected by FDCANSEL and provided to fdcan_ker_ck input, and the rcc_pclk1 bus interface clock.


\
\ @brief TIM1 peripheral clock enable Set and reset by software.
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB2ENR_TIM1EN                           \ TIM1 peripheral clock enable Set and reset by software.
$00000002 constant RCC_RCC_APB2ENR_TIM8EN                           \ TIM8 peripheral clock enable Set and reset by software.
$00000010 constant RCC_RCC_APB2ENR_USART1EN                         \ USART1 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART1 are the kernel clock selected by USART16910SEL and provided to UCKL input, and the rcc_pclk2 bus interface clock.
$00000020 constant RCC_RCC_APB2ENR_USART6EN                         \ USART6 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART6 are the kernel clock selected by USART16910SEL and provided to UCKL input, and the rcc_pclk2 bus interface clock.
$00000040 constant RCC_RCC_APB2ENR_UART9EN                          \ UART9 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART9 are the kernel clock selected by USART16910SEL and provided to UCKL input, and the rcc_pclk2 bus interface clock.
$00000080 constant RCC_RCC_APB2ENR_USART10EN                        \ USART10 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART10 are the kernel clock selected by USART16910SEL and provided to UCKL input, and the rcc_pclk2 bus interface clock.
$00001000 constant RCC_RCC_APB2ENR_SPI1EN                           \ SPI1 Peripheral Clocks Enable Set and reset by software. The peripheral clocks of the SPI1 are: the kernel clock selected by I2S123SRC and provided to spi_ker_ck input, and the rcc_pclk2 bus interface clock.
$00002000 constant RCC_RCC_APB2ENR_SPI4EN                           \ SPI4 Peripheral Clocks Enable Set and reset by software. The peripheral clocks of the SPI4 are: the kernel clock selected by SPI45SEL and provided to spi_ker_ck input, and the rcc_pclk2 bus interface clock.
$00010000 constant RCC_RCC_APB2ENR_TIM15EN                          \ TIM15 peripheral clock enable Set and reset by software.
$00020000 constant RCC_RCC_APB2ENR_TIM16EN                          \ TIM16 peripheral clock enable Set and reset by software.
$00040000 constant RCC_RCC_APB2ENR_TIM17EN                          \ TIM17 peripheral clock enable Set and reset by software.
$00100000 constant RCC_RCC_APB2ENR_SPI5EN                           \ SPI5 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI5 are the kernel clock selected by SPI45SEL and provided to spi_ker_ck input, and the rcc_pclk2 bus interface clock.
$00400000 constant RCC_RCC_APB2ENR_SAI1EN                           \ SAI1 peripheral clocks enable Set and reset by software. The peripheral clocks of the SAI1 are: the kernel clock selected by SAI1SEL and provided to sai_a_ker_ck and sai_b_ker_ck inputs, and the rcc_pclk2 bus interface clock.
$00800000 constant RCC_RCC_APB2ENR_SAI2EN                           \ SAI2 peripheral clocks enable Set and reset by software. The peripheral clocks of the SAI2 are the kernel clock selected by SAI2SEL and provided to sai_a_ker_ck and sai_b_ker_ck inputs, and the rcc_pclk2 bus interface clock.
$40000000 constant RCC_RCC_APB2ENR_DFSDM1EN                         \ DFSDM1 peripheral clocks enable Set and reset by software. DFSDM1 peripheral clocks are the kernel clocks selected by SAI1SEL and DFSDM1SEL and provided to Aclk and clk inputs respectively,


\
\ @brief SYSCFG peripheral clock enable Set and reset by software.
\ Address offset: 0x154
\ Reset value: 0x00010000
\

$00000002 constant RCC_RCC_APB4ENR_SYSCFGEN                         \ SYSCFG peripheral clock enable Set and reset by software.
$00000008 constant RCC_RCC_APB4ENR_LPUART1EN                        \ LPUART1 peripheral clocks enable Set and reset by software. The peripheral clocks of the LPUART1 are the kernel clock selected by LPUART1SEL and provided to lpuart_ker_ck input, and the rcc_pclk4 bus interface clock.
$00000020 constant RCC_RCC_APB4ENR_SPI6EN                           \ SPI6 peripheral clocks enable Set and reset by software. The peripheral clocks of the SPI6 are the kernel clock selected by SPI6SEL and provided to spi_ker_ck input, and the rcc_pclk4 bus interface clock.
$00000080 constant RCC_RCC_APB4ENR_I2C4EN                           \ I2C4 peripheral clocks enable Set and reset by software. The peripheral clocks of the I2C4 are the kernel clock selected by I2C4SEL and provided to i2C_ker_ck input, and the rcc_pclk4 bus interface clock.
$00000200 constant RCC_RCC_APB4ENR_LPTIM2EN                         \ LPTIM2 peripheral clocks enable Set and reset by software. The peripheral clocks of the LPTIM2 are the kernel clock selected by LPTIM2SEL and provided to lptim_ker_ck input, and the rcc_pclk4 bus interface clock.
$00000400 constant RCC_RCC_APB4ENR_LPTIM3EN                         \ LPTIM3 peripheral clocks enable Set and reset by software. The peripheral clocks of the LPTIM3 are the kernel clock selected by LPTIM345SEL and provided to lptim_ker_ck input, and the rcc_pclk4 bus interface clock.
$00002000 constant RCC_RCC_APB4ENR_DAC2EN                           \ DAC2 (containing one converter) peripheral clock enable Set and reset by software.
$00004000 constant RCC_RCC_APB4ENR_COMP12EN                         \ COMP1 and 2 peripheral clock enable Set and reset by software.
$00008000 constant RCC_RCC_APB4ENR_VREFEN                           \ VREF peripheral clock enable Set and reset by software.
$00010000 constant RCC_RCC_APB4ENR_RTCAPBEN                         \ RTC APB clock enable Set and reset by software.
$04000000 constant RCC_RCC_APB4ENR_DTSEN                            \ Digital temperature sensor peripheral clock enable Set and reset by software.
$08000000 constant RCC_RCC_APB4ENR_DFSDM2EN                         \ DFSDM2peripheral clock enable Set and reset by software.


\
\ @brief MDMA clock enable during CSleep mode Set and reset by software.
\ Address offset: 0x15C
\ Reset value: 0xFDE95131
\

$00000001 constant RCC_RCC_AHB3LPENR_MDMALPEN                       \ MDMA clock enable during CSleep mode Set and reset by software.
$00000010 constant RCC_RCC_AHB3LPENR_DMA2DLPEN                      \ DMA2D clock enable during CSleep mode Set and reset by software.
$00000020 constant RCC_RCC_AHB3LPENR_JPGDECLPEN                     \ JPGDEC clock enable during CSleep mode Set and reset by software.
$00000100 constant RCC_RCC_AHB3LPENR_FLITFLPEN                      \ FLITF clock enable during CSleep mode Set and reset by software.
$00001000 constant RCC_RCC_AHB3LPENR_FMCLPEN                        \ FMC peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the FMC are the kernel clock selected by FMCSEL and provided to fmc_ker_ck input, and the rcc_hclk3 bus interface clock.
$00004000 constant RCC_RCC_AHB3LPENR_OCTOSPI1LPEN                   \ OCTOSPI1 and OCTOSPI1 delay clock enable during CSleep mode Set and reset by software.
$00010000 constant RCC_RCC_AHB3LPENR_SDMMC1LPEN                     \ SDMMC1 and SDMMC1 delay clock enable during CSleep mode Set and reset by software.
$00080000 constant RCC_RCC_AHB3LPENR_OCTOSPI2LPEN                   \ OCTOSPI2 and OCTOSPI2 delay clock enable during CSleep mode Set and reset by software.
$00200000 constant RCC_RCC_AHB3LPENR_OCTOSPIMLPEN                   \ OCTOSPIM block clock enable during CSleep mode Set and reset by software.
$00400000 constant RCC_RCC_AHB3LPENR_OTFD1LPEN                      \ OTFD1 block clock enable during CSleep mode Set and reset by software.
$00800000 constant RCC_RCC_AHB3LPENR_OTFD2LPEN                      \ OTFD2 block clock enable during CSleep mode Set and reset by software.
$01000000 constant RCC_RCC_AHB3LPENR_GFXMMULPEN                     \ GFXMMU block clock enable during CSleep mode Set and reset by software.
$04000000 constant RCC_RCC_AHB3LPENR_AXISRAM2LPEN                   \ AXISRAM2 block clock enable during CSleep mode Set and reset by software.
$08000000 constant RCC_RCC_AHB3LPENR_AXISRAM3LPEN                   \ AXISRAM3 block clock enable during CSleep mode Set and reset by software.
$10000000 constant RCC_RCC_AHB3LPENR_DTCM1LPEN                      \ DTCM1 block clock enable during CSleep mode Set and reset by software.
$20000000 constant RCC_RCC_AHB3LPENR_DTCM2LPEN                      \ DTCM2 block clock enable during CSleep mode Set and reset by software.
$40000000 constant RCC_RCC_AHB3LPENR_ITCMLPEN                       \ ITCM block clock enable during CSleep mode Set and reset by software.
$80000000 constant RCC_RCC_AHB3LPENR_AXISRAM1LPEN                   \ AXISRAM1 block clock enable during CSleep mode Set and reset by software.


\
\ @brief DMA1 clock enable during CSleep mode Set and reset by software.
\ Address offset: 0x160
\ Reset value: 0x06000223
\

$00000001 constant RCC_RCC_AHB1LPENR_DMA1LPEN                       \ DMA1 clock enable during CSleep mode Set and reset by software.
$00000002 constant RCC_RCC_AHB1LPENR_DMA2LPEN                       \ DMA2 clock enable during CSleep mode Set and reset by software.
$00000020 constant RCC_RCC_AHB1LPENR_ADC12LPEN                      \ ADC1 and 2 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the ADC1 and 2 are the kernel clock selected by ADCSEL and provided to adc_ker_ck input, and the rcc_hclk1 bus interface clock.
$00000200 constant RCC_RCC_AHB1LPENR_CRCLPEN                        \ CRC peripheral clock enable during CSleep mode Set and reset by software.
$02000000 constant RCC_RCC_AHB1LPENR_USB1OTGLPEN                    \ USB1OTG peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the USB1OTG are the kernel clock selected by USBSEL and the rcc_hclk1 bus interface clock.
$04000000 constant RCC_RCC_AHB1LPENR_USB1ULPILPEN                   \ USB_PHY1 clock enable during CSleep mode Set and reset by software.


\
\ @brief digital camera interface peripheral clock enable during CSleep mode (DCMI or PSSI depending which IP is active) Set and reset by software.
\ Address offset: 0x164
\ Reset value: 0x60000A71
\

$00000001 constant RCC_RCC_AHB2LPENR_DCMI_PSSILPEN                  \ digital camera interface peripheral clock enable during CSleep mode (DCMI or PSSI depending which IP is active) Set and reset by software.
$00000010 constant RCC_RCC_AHB2LPENR_CRYPTLPEN                      \ CRYPT peripheral clock enable during CSleep mode Set and reset by software.
$00000020 constant RCC_RCC_AHB2LPENR_HASHLPEN                       \ HASH peripheral clock enable during CSleep mode Set and reset by software.
$00000040 constant RCC_RCC_AHB2LPENR_RNGLPEN                        \ RNG peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the RNG are the kernel clock selected by RNGSEL and provided to rng_clk input, and the rcc_hclk2 bus interface clock.
$00000200 constant RCC_RCC_AHB2LPENR_SDMMC2LPEN                     \ SDMMC2 and SDMMC2 delay clock enable during CSleep mode Set and reset by software.
$00000800 constant RCC_RCC_AHB2LPENR_DFSDMDMALPEN                   \ DFSDMDMA clock enable during CSleep mode Set and reset by software.
$20000000 constant RCC_RCC_AHB2LPENR_AHBSRAM1LPEN                   \ AHBSRAM1 clock enable during CSleep mode Set and reset by software.
$40000000 constant RCC_RCC_AHB2LPENR_AHBSRAM2LPEN                   \ AHBSRAM2 clock enable during CSleep mode Set and reset by software.


\
\ @brief GPIOA peripheral clock enable during CSleep mode Set and reset by software.
\ Address offset: 0x168
\ Reset value: 0x302007FF
\

$00000001 constant RCC_RCC_AHB4LPENR_GPIOALPEN                      \ GPIOA peripheral clock enable during CSleep mode Set and reset by software.
$00000002 constant RCC_RCC_AHB4LPENR_GPIOBLPEN                      \ GPIOB peripheral clock enable during CSleep mode Set and reset by software.
$00000004 constant RCC_RCC_AHB4LPENR_GPIOCLPEN                      \ GPIOC peripheral clock enable during CSleep mode Set and reset by software.
$00000008 constant RCC_RCC_AHB4LPENR_GPIODLPEN                      \ GPIOD peripheral clock enable during CSleep mode Set and reset by software.
$00000010 constant RCC_RCC_AHB4LPENR_GPIOELPEN                      \ GPIOE peripheral clock enable during CSleep mode Set and reset by software.
$00000020 constant RCC_RCC_AHB4LPENR_GPIOFLPEN                      \ GPIOF peripheral clock enable during CSleep mode Set and reset by software.
$00000040 constant RCC_RCC_AHB4LPENR_GPIOGLPEN                      \ GPIOG peripheral clock enable during CSleep mode Set and reset by software.
$00000080 constant RCC_RCC_AHB4LPENR_GPIOHLPEN                      \ GPIOH peripheral clock enable during CSleep mode Set and reset by software.
$00000100 constant RCC_RCC_AHB4LPENR_GPIOILPEN                      \ GPIOI peripheral clock enable during CSleep mode Set and reset by software.
$00000200 constant RCC_RCC_AHB4LPENR_GPIOJLPEN                      \ GPIOJ peripheral clock enable during CSleep mode Set and reset by software.
$00000400 constant RCC_RCC_AHB4LPENR_GPIOKLPEN                      \ GPIOK peripheral clock enable during CSleep mode Set and reset by software.
$00200000 constant RCC_RCC_AHB4LPENR_BDMA2LPEN                      \ SmartRun domain DMA and DMAMUX clock enable during CSleep mode Set and reset by software.
$10000000 constant RCC_RCC_AHB4LPENR_BKPRAMLPEN                     \ Backup RAM clock enable during CSleep mode Set and reset by software.
$20000000 constant RCC_RCC_AHB4LPENR_SRDSRAMLPEN                    \ SmartRun domain SRAM clock enable during CSleep mode Set and reset by software.


\
\ @brief LTDC peripheral clock enable during CSleep mode Set and reset by software. The LTDC peripheral clocks are the kernel clock provided to ltdc_ker_ck input and the rcc_pclk3 bus interface clock.
\ Address offset: 0x16C
\ Reset value: 0x00000048
\

$00000008 constant RCC_RCC_APB3LPENR_LTDCLPEN                       \ LTDC peripheral clock enable during CSleep mode Set and reset by software. The LTDC peripheral clocks are the kernel clock provided to ltdc_ker_ck input and the rcc_pclk3 bus interface clock.
$00000040 constant RCC_RCC_APB3LPENR_WWDGLPEN                       \ WWDG clock enable during CSleep mode Set and reset by software.


\
\ @brief TIM2 peripheral clock enable during CSleep mode Set and reset by software.
\ Address offset: 0x170
\ Reset value: 0xE8FFC3FF
\

$00000001 constant RCC_RCC_APB1LLPENR_TIM2LPEN                      \ TIM2 peripheral clock enable during CSleep mode Set and reset by software.
$00000002 constant RCC_RCC_APB1LLPENR_TIM3LPEN                      \ TIM3 peripheral clock enable during CSleep mode Set and reset by software.
$00000004 constant RCC_RCC_APB1LLPENR_TIM4LPEN                      \ TIM4 peripheral clock enable during CSleep mode Set and reset by software.
$00000008 constant RCC_RCC_APB1LLPENR_TIM5LPEN                      \ TIM5 peripheral clock enable during CSleep mode Set and reset by software.
$00000010 constant RCC_RCC_APB1LLPENR_TIM6LPEN                      \ TIM6 peripheral clock enable during CSleep mode Set and reset by software.
$00000020 constant RCC_RCC_APB1LLPENR_TIM7LPEN                      \ TIM7 peripheral clock enable during CSleep mode Set and reset by software.
$00000040 constant RCC_RCC_APB1LLPENR_TIM12LPEN                     \ TIM12 peripheral clock enable during CSleep mode Set and reset by software.
$00000080 constant RCC_RCC_APB1LLPENR_TIM13LPEN                     \ TIM13 peripheral clock enable during CSleep mode Set and reset by software.
$00000100 constant RCC_RCC_APB1LLPENR_TIM14LPEN                     \ TIM14 peripheral clock enable during CSleep mode Set and reset by software.
$00000200 constant RCC_RCC_APB1LLPENR_LPTIM1LPEN                    \ LPTIM1 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the LPTIM1 are the kernel clock selected by LPTIM1SEL and provided to lptim_ker_ck input, and the rcc_pclk1 bus interface clock.
$00004000 constant RCC_RCC_APB1LLPENR_SPI2LPEN                      \ SPI2 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SPI2 are the kernel clock selected by I2S123SRC and provided to spi_ker_ck input, and the rcc_pclk1 bus interface clock.
$00008000 constant RCC_RCC_APB1LLPENR_SPI3LPEN                      \ SPI3 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SPI3 are the kernel clock selected by I2S123SRC and provided to spi_ker_ck input, and the rcc_pclk1 bus interface clock.
$00010000 constant RCC_RCC_APB1LLPENR_SPDIFRXLPEN                   \ SPDIFRX peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SPDIFRX are: the kernel clock selected by SPDIFRXSEL and provided to spdifrx_ker_ck input, and the rcc_pclk1 bus interface clock.
$00020000 constant RCC_RCC_APB1LLPENR_USART2LPEN                    \ USART2 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the USART2 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
$00040000 constant RCC_RCC_APB1LLPENR_USART3LPEN                    \ USART3 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the USART3 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
$00080000 constant RCC_RCC_APB1LLPENR_UART4LPEN                     \ UART4 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the UART4 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
$00100000 constant RCC_RCC_APB1LLPENR_UART5LPEN                     \ UART5 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the UART5 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
$00200000 constant RCC_RCC_APB1LLPENR_I2C1LPEN                      \ I2C1 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the I2C1 are the kernel clock selected by I2C123SEL and provided to i2C_ker_ck input, and the rcc_pclk1 bus interface clock.
$00400000 constant RCC_RCC_APB1LLPENR_I2C2LPEN                      \ I2C2 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the I2C2 are the kernel clock selected by I2C123SEL and provided to i2C_ker_ck input, and the rcc_pclk1 bus interface clock.
$00800000 constant RCC_RCC_APB1LLPENR_I2C3LPEN                      \ I2C3 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the I2C3 are the kernel clock selected by I2C123SEL and provided to i2C_ker_ck input, and the rcc_pclk1 bus interface clock.
$08000000 constant RCC_RCC_APB1LLPENR_CECLPEN                       \ HDMI-CEC peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the HDMI-CEC are the kernel clock selected by CECSEL and provided to cec_ker_ck input, and the rcc_pclk1 bus interface clock.
$20000000 constant RCC_RCC_APB1LLPENR_DAC1LPEN                      \ DAC1 (containing two converters) peripheral clock enable during CSleep mode Set and reset by software.
$40000000 constant RCC_RCC_APB1LLPENR_UART7LPEN                     \ UART7 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the UART7 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.
$80000000 constant RCC_RCC_APB1LLPENR_UART8LPEN                     \ UART8 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the UART8 are the kernel clock selected by USART234578SEL and provided to usart_ker_ck input, and the rcc_pclk1 bus interface clock.


\
\ @brief clock recovery system peripheral clock enable during CSleep mode Set and reset by software.
\ Address offset: 0x174
\ Reset value: 0x00000136
\

$00000002 constant RCC_RCC_APB1HLPENR_CRSLPEN                       \ clock recovery system peripheral clock enable during CSleep mode Set and reset by software.
$00000004 constant RCC_RCC_APB1HLPENR_SWPMILPEN                     \ SWPMI peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SWPMI are the kernel clock selected by SWPMISEL and provided to swpmi_ker_ck input, and the rcc_pclk1 bus interface clock.
$00000010 constant RCC_RCC_APB1HLPENR_OPAMPLPEN                     \ OPAMP peripheral clock enable during CSleep mode Set and reset by software.
$00000020 constant RCC_RCC_APB1HLPENR_MDIOSLPEN                     \ MDIOS peripheral clock enable during CSleep mode Set and reset by software.
$00000100 constant RCC_RCC_APB1HLPENR_FDCANLPEN                     \ FDCAN peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the FDCAN are: the kernel clock selected by FDCANSEL and provided to fdcan_clk input, and the rcc_pclk1 bus interface clock.


\
\ @brief TIM1 peripheral clock enable during CSleep mode Set and reset by software.
\ Address offset: 0x178
\ Reset value: 0x40D730F3
\

$00000001 constant RCC_RCC_APB2LPENR_TIM1LPEN                       \ TIM1 peripheral clock enable during CSleep mode Set and reset by software.
$00000002 constant RCC_RCC_APB2LPENR_TIM8LPEN                       \ TIM8 peripheral clock enable during CSleep mode Set and reset by software.
$00000010 constant RCC_RCC_APB2LPENR_USART1LPEN                     \ USART1 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the USART1 are the kernel clock selected by USART16910SEL and provided to usart_ker_ck inputs, and the rcc_pclk2 bus interface clock.
$00000020 constant RCC_RCC_APB2LPENR_USART6LPEN                     \ USART6 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the USART6 are the kernel clock selected by USART16910SEL and provided to usart_ker_ck input, and the rcc_pclk2 bus interface clock.
$00000040 constant RCC_RCC_APB2LPENR_UART9LPEN                      \ UART9 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the UART9 are the kernel clock selected by USART16910SEL and provided to usart_ker_ck input, and the rcc_pclk2 bus interface clock.
$00000080 constant RCC_RCC_APB2LPENR_USART10LPEN                    \ USART10 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the USART10 are the kernel clock selected by USART16910SEL and provided to usart_ker_ck input, and the rcc_pclk2 bus interface clock.
$00001000 constant RCC_RCC_APB2LPENR_SPI1LPEN                       \ SPI1 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the SPI1 are: the kernel clock selected by I2S123SRC and provided to spi_ker_ck input, and the rcc_pclk2 bus interface clock.
$00002000 constant RCC_RCC_APB2LPENR_SPI4LPEN                       \ SPI4 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the SPI4 are: the kernel clock selected by SPI45SEL and provided to spi_ker_ck input, and the rcc_pclk2 bus interface clock.
$00010000 constant RCC_RCC_APB2LPENR_TIM15LPEN                      \ TIM15 peripheral clock enable during CSleep mode Set and reset by software.
$00020000 constant RCC_RCC_APB2LPENR_TIM16LPEN                      \ TIM16 peripheral clock enable during CSleep mode Set and reset by software.
$00040000 constant RCC_RCC_APB2LPENR_TIM17LPEN                      \ TIM17 peripheral clock enable during CSleep mode Set and reset by software.
$00100000 constant RCC_RCC_APB2LPENR_SPI5LPEN                       \ SPI5 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SPI5 are the kernel clock selected by SPI45SEL and provided to spi_ker_ck input, and the rcc_pclk2 bus interface clock.
$00400000 constant RCC_RCC_APB2LPENR_SAI1LPEN                       \ SAI1 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SAI1 are: the kernel clock selected by SAI1SEL and provided to sai_a_ker_ck and sai_b_ker_ck inputs, and the rcc_pclk2 bus interface clock.
$00800000 constant RCC_RCC_APB2LPENR_SAI2LPEN                       \ SAI2 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SAI2 are the kernel clock selected by SAI23EL and provided to sai_a_ker_ck and sai_b_ker_ck inputs, and the rcc_pclk2 bus interface clock.
$40000000 constant RCC_RCC_APB2LPENR_DFSDM1LPEN                     \ DFSDM1 peripheral clocks enable during CSleep mode Set and reset by software. DFSDM1 peripheral clocks are the kernel clocks selected by SAI1SEL and DFSDM1SEL and provided to Aclk and clk inputs respectively, and the rcc_pclk2 bus interface clock.


\
\ @brief SYSCFG peripheral clock enable during CSleep mode Set and reset by software.
\ Address offset: 0x17C
\ Reset value: 0x0C01E6AA
\

$00000002 constant RCC_RCC_APB4LPENR_SYSCFGLPEN                     \ SYSCFG peripheral clock enable during CSleep mode Set and reset by software.
$00000008 constant RCC_RCC_APB4LPENR_LPUART1LPEN                    \ LPUART1 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the LPUART1 are the kernel clock selected by LPUART1SEL and provided to lpuart_ker_ck input, and the rcc_pclk4 bus interface clock.
$00000020 constant RCC_RCC_APB4LPENR_SPI6LPEN                       \ SPI6 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the SPI6 are the kernel clock selected by SPI6SEL and provided to com_ck input, and the rcc_pclk4 bus interface clock.
$00000080 constant RCC_RCC_APB4LPENR_I2C4LPEN                       \ I2C4 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the I2C4 are the kernel clock selected by I2C4SEL and provided to i2C_ker_ck input, and the rcc_pclk4 bus interface clock.
$00000200 constant RCC_RCC_APB4LPENR_LPTIM2LPEN                     \ LPTIM2 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the LPTIM2 are the kernel clock selected by LPTIM2SEL and provided to lptim_ker_ck input, and the rcc_pclk4 bus interface clock.
$00000400 constant RCC_RCC_APB4LPENR_LPTIM3LPEN                     \ LPTIM3 peripheral clocks enable during CSleep mode Set and reset by software. The peripheral clocks of the LPTIM3 are the kernel clock selected by LPTIM345SEL and provided to lptim_ker_ck input, and the rcc_pclk4 bus interface clock.
$00002000 constant RCC_RCC_APB4LPENR_DAC2LPEN                       \ DAC2 (containing one converter) peripheral clock enable during CSleep mode Set and reset by software.
$00004000 constant RCC_RCC_APB4LPENR_COMP12LPEN                     \ COMP1 and 2 peripheral clock enable during CSleep mode Set and reset by software.
$00008000 constant RCC_RCC_APB4LPENR_VREFLPEN                       \ VREF peripheral clock enable during CSleep mode Set and reset by software.
$00010000 constant RCC_RCC_APB4LPENR_RTCAPBLPEN                     \ RTC APB clock enable during CSleep mode Set and reset by software.
$04000000 constant RCC_RCC_APB4LPENR_DTSLPEN                        \ temperature sensor peripheral clock enable during CSleep mode Set and reset by software.
$08000000 constant RCC_RCC_APB4LPENR_DFSDM2LPEN                     \ DFSDM2 peripheral clock enable during CSleep mode Set and reset by software.


\
\ @brief Reset and clock control
\
$58024400 constant RCC_RCC_CR     \ offset: 0x00 : HSI clock enable Set and cleared by software. Set by hardware to force the HSI to ON when the product leaves Stop mode, if STOPWUCK = 0 or STOPKERWUCK = 0. Set by hardware to force the HSI to ON when the product leaves Standby mode or in case of a failure of the HSE which is used as the system clock source. This bit cannot be cleared if the HSI is used directly (via SW mux) as system clock, or if the HSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
$58024404 constant RCC_RCC_HSICFGR  \ offset: 0x04 : RCC HSI calibration register
$58024408 constant RCC_RCC_CRRCR  \ offset: 0x08 : RCC clock recovery RC register
$5802440c constant RCC_RCC_CSICFGR  \ offset: 0x0C : RCC CSI calibration register
$58024410 constant RCC_RCC_CFGR   \ offset: 0x10 : system clock and trace clock switch Set and reset by software to select system clock and trace clock sources (sys_ck and traceclk). Set by hardware in order to: force the selection of the HSI or CSI (depending on STOPWUCK selection) when leaving a system Stop mode force the selection of the HSI in case of failure of the HSE when used directly or indirectly as system clock others: reserved
$58024418 constant RCC_RCC_CDCFGR1  \ offset: 0x18 : CPU domain AHB prescaler Set and reset by software to control the division factor of rcc_hclk3 and rcc_aclk. Changing this division ratio has an impact on the frequency of all bus matrix clocks. 0xxx: rcc_hclk3 = sys_cdcpre_ck (default after reset) Note: The clocks are divided by the new prescaler factor from1 to 16 periods of the slowest APB clock among rcc_pclk[4:1] after HPRE update. Note: Note also that rcc_hclk3 = rcc_aclk.
$5802441c constant RCC_RCC_CDCFGR2  \ offset: 0x1C : CPU domain APB1 prescaler Set and reset by software to control the CPU domain APB1 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk1 after CDPPRE1 write. 0xx: rcc_pclk1 = rcc_hclk1 (default after reset)
$58024420 constant RCC_RCC_SRDCFGR  \ offset: 0x20 : SmartRun domain APB4 prescaler Set and reset by software to control the SmartRun domain APB4 clock division factor. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk4 after SRDPPRE write. 0xx: rcc_pclk4 = rcc_hclk4 (default after reset)
$58024428 constant RCC_RCC_PLLCKSELR  \ offset: 0x28 : DIVMx and PLLs clock source selection Set and reset by software to select the PLL clock source. These bits can be written only when all PLLs are disabled. In order to save power, when no PLL is used, the value of PLLSRC must be set to '11â.
$5802442c constant RCC_RCC_PLLCFGR  \ offset: 0x2C : PLL1 fractional latch enable Set and reset by software to latch the content of FRACN1 into the sigma-delta modulator. In order to latch the FRACN1 value into the sigma-delta modulator, PLL1FRACEN must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN1 into the modulator. Refer to for additional information.
$58024430 constant RCC_RCC_PLL1DIVR  \ offset: 0x30 : multiplication factor for PLL1 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL1ON = PLL1RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL1VCOSEL = 0 150 to 420Â MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x DIVN1, when fractional value 0 has been loaded into FRACN1, with: DIVN1 between 8 and 420 The input frequency Fref1_ck must be between 1 and 16Â MHz.
$58024434 constant RCC_RCC_PLL1FRACR  \ offset: 0x34 : fractional part of the multiplication factor for PLL1 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL1VCOSEL = 0 150 to 420Â MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x (DIVN1 + (FRACN1 / 213)), with DIVN1 between 8 and 420 FRACN1 can be between 0 and 213- 1 The input frequency Fref1_ck must be between 1 and 16 MHz. To change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into FRACN1. Set the bit PLL1FRACEN to 1.
$58024438 constant RCC_RCC_PLL2DIVR  \ offset: 0x38 : multiplication factor for PLL2 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL2ON = PLL2RDY = 0). ..........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL2VCOSEL = 0 150 to 420Â MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x DIVN2, when fractional value 0 has been loaded into FRACN2, with DIVN2 between 8 and 420 The input frequency Fref2_ck must be between 1 and 16MHz.
$5802443c constant RCC_RCC_PLL2FRACR  \ offset: 0x3C : fractional part of the multiplication factor for PLL2 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL2VCOSEL = 0 150 to 420Â MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x (DIVN2 + (FRACN2 / 213)), with DIVN2 between 8 and 420 FRACN2 can be between 0 and 213 - 1 The input frequency Fref2_ck must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL2FRACEN to 0. Write the new fractional value into FRACN2. Set the bit PLL2FRACEN to 1.
$58024440 constant RCC_RCC_PLL3DIVR  \ offset: 0x40 : Multiplication factor for PLL3 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL3ON = PLL3RDY = 0). ...........: not used ... ... Others: wrong configurations The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL3VCOSEL = 0 150 to 420Â MHz if PLL3VCOSEL = 1 VCO output frequency = Fref3_ck x DIVN3, when fractional value 0 has been loaded into FRACN3, with: DIVN3 between 8 and 420 The input frequency Fref3_ck must be between 1 and 16MHz
$58024444 constant RCC_RCC_PLL3FRACR  \ offset: 0x44 : fractional part of the multiplication factor for PLL3 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL3 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: 128 to 560Â MHz if PLL3VCOSEL = 0 150 to 420Â MHz if PLL3VCOSEL = 1 VCO output frequency = Fref3_ck x (DIVN3 + (FRACN3 / 213)), with DIVN3 between 8 and 420 FRACN3 can be between 0 and 213 - 1 The input frequency Fref3_ck must be between 1 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into FRACN1. Set the bit PLL1FRACEN to 1.
$5802444c constant RCC_RCC_CDCCIPR  \ offset: 0x4C : RCC CPU domain kernel clock configuration register
$58024450 constant RCC_RCC_CDCCIP1R  \ offset: 0x50 : RCC CPU domain kernel clock configuration register
$58024454 constant RCC_RCC_CDCCIP2R  \ offset: 0x54 : RCC CPU domain kernel clock configuration register
$58024458 constant RCC_RCC_SRDCCIPR  \ offset: 0x58 : RCC SmartRun domain kernel clock configuration register
$58024460 constant RCC_RCC_CIER   \ offset: 0x60 : LSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the LSI oscillator stabilization.
$58024464 constant RCC_RCC_CIFR   \ offset: 0x64 : LSI ready interrupt flag Reset by software by writing LSIRDYC bit. Set by hardware when the LSI clock becomes stable and LSIRDYIE is set.
$58024468 constant RCC_RCC_CICR   \ offset: 0x68 : LSI ready interrupt clear Set by software to clear LSIRDYF. Reset by hardware when clear done.
$58024470 constant RCC_RCC_BDCR   \ offset: 0x70 : RCC Backup domain control register
$58024474 constant RCC_RCC_CSR    \ offset: 0x74 : RCC clock control and status register
$5802447c constant RCC_RCC_AHB3RSTR  \ offset: 0x7C : MDMA block reset Set and reset by software.
$58024480 constant RCC_RCC_AHB1RSTR  \ offset: 0x80 : DMA1 and DMAMUX1 blocks reset Set and reset by software.
$58024484 constant RCC_RCC_AHB2RSTR  \ offset: 0x84 : digital camera interface block reset (DCMI or PSSI depending which IP is active) Set and reset by software.
$58024488 constant RCC_RCC_AHB4RSTR  \ offset: 0x88 : GPIOA block reset Set and reset by software.
$5802448c constant RCC_RCC_APB3RSTR  \ offset: 0x8C : LTDC block reset Set and reset by software.
$58024490 constant RCC_RCC_APB1LRSTR  \ offset: 0x90 : TIM2 block reset Set and reset by software.
$58024494 constant RCC_RCC_APB1HRSTR  \ offset: 0x94 : clock recovery system reset Set and reset by software.
$58024498 constant RCC_RCC_APB2RSTR  \ offset: 0x98 : TIM1 block reset Set and reset by software.
$5802449c constant RCC_RCC_APB4RSTR  \ offset: 0x9C : SYSCFG block reset Set and reset by software.
$580244a8 constant RCC_RCC_SRDAMR  \ offset: 0xA8 : RCC SmartRun domain Autonomous mode register
$580244b0 constant RCC_RCC_CKGAENR  \ offset: 0xB0 : RCC AXI clocks gating enable register
$58024530 constant RCC_RCC_RSR    \ offset: 0x130 : RCC reset status register
$58024534 constant RCC_RCC_AHB3ENR  \ offset: 0x134 : MDMA peripheral clock enable Set and reset by software.
$58024538 constant RCC_RCC_AHB1ENR  \ offset: 0x138 : DMA1 clock enable Set and reset by software.
$5802453c constant RCC_RCC_AHB2ENR  \ offset: 0x13C : digital camera interface peripheral clock enable (DCMI or PSSI depending which IP is active) Set and reset by software.
$58024540 constant RCC_RCC_AHB4ENR  \ offset: 0x140 : GPIOA peripheral clock enable Set and reset by software.
$58024544 constant RCC_RCC_APB3ENR  \ offset: 0x144 : LTDC clock enable Provides the clock (ltdc_pclk, ltdc_aclk, ltdc_ker_ck) to the LTDC block. Set and reset by software.
$58024548 constant RCC_RCC_APB1LENR  \ offset: 0x148 : TIM2 peripheral clock enable Set and reset by software.
$5802454c constant RCC_RCC_APB1HENR  \ offset: 0x14C : clock recovery system peripheral clock enable Set and reset by software.
$58024550 constant RCC_RCC_APB2ENR  \ offset: 0x150 : TIM1 peripheral clock enable Set and reset by software.
$58024554 constant RCC_RCC_APB4ENR  \ offset: 0x154 : SYSCFG peripheral clock enable Set and reset by software.
$5802455c constant RCC_RCC_AHB3LPENR  \ offset: 0x15C : MDMA clock enable during CSleep mode Set and reset by software.
$58024560 constant RCC_RCC_AHB1LPENR  \ offset: 0x160 : DMA1 clock enable during CSleep mode Set and reset by software.
$58024564 constant RCC_RCC_AHB2LPENR  \ offset: 0x164 : digital camera interface peripheral clock enable during CSleep mode (DCMI or PSSI depending which IP is active) Set and reset by software.
$58024568 constant RCC_RCC_AHB4LPENR  \ offset: 0x168 : GPIOA peripheral clock enable during CSleep mode Set and reset by software.
$5802456c constant RCC_RCC_APB3LPENR  \ offset: 0x16C : LTDC peripheral clock enable during CSleep mode Set and reset by software. The LTDC peripheral clocks are the kernel clock provided to ltdc_ker_ck input and the rcc_pclk3 bus interface clock.
$58024570 constant RCC_RCC_APB1LLPENR  \ offset: 0x170 : TIM2 peripheral clock enable during CSleep mode Set and reset by software.
$58024574 constant RCC_RCC_APB1HLPENR  \ offset: 0x174 : clock recovery system peripheral clock enable during CSleep mode Set and reset by software.
$58024578 constant RCC_RCC_APB2LPENR  \ offset: 0x178 : TIM1 peripheral clock enable during CSleep mode Set and reset by software.
$5802457c constant RCC_RCC_APB4LPENR  \ offset: 0x17C : SYSCFG peripheral clock enable during CSleep mode Set and reset by software.

