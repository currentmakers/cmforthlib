\
\ @file sec_rcc.fs
\ @brief Reset and clock controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RCC clock control register
\ Address offset: 0x00
\ Reset value: 0x00000023
\

$00000001 constant SEC_RCC_RCC_CR_HSION                             \ HSI clock enable Set and cleared by software. Set by hardware to force the HSI to ON when the product leaves Stop mode, if STOPWUCK = 1 or STOPKERWUCK = 1. Set by hardware to force the HSI to ON when the product leaves Standby mode or in case of a failure of the HSE which is used as the system clock source. This bit cannot be cleared if the HSI is used directly (via SW mux) as system clock, or if the HSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
$00000002 constant SEC_RCC_RCC_CR_HSIRDY                            \ HSI clock ready flag Set by hardware to indicate that the HSI oscillator is stable.
$00000004 constant SEC_RCC_RCC_CR_HSIKERON                          \ HSI clock enable in Stop mode Set and reset by software to force the HSI to ON, even in Stop mode, in order to be quickly available as kernel clock for peripherals. This bit has no effect on the value of HSION.
$00000018 constant SEC_RCC_RCC_CR_HSIDIV                            \ HSI clock divider Set and reset by software. These bits allow selecting a division ratio in order to configure the wanted HSI clock frequency. The HSIDIV cannot be changed if the HSI is selected as reference clock for at least one enabled PLL (PLLxON bit set to 1). In that case, the new HSIDIV value is ignored.
$00000020 constant SEC_RCC_RCC_CR_HSIDIVF                           \ HSI divider flag Set and reset by hardware. As a write operation to HSIDIV has not an immediate effect on the frequency, this flag indicates the current status of the HSI divider. HSIDIVF goes immediately to 0 when HSIDIV value is changed, and is set back to 1 when the output frequency matches the value programmed into HSIDIV.
$00000100 constant SEC_RCC_RCC_CR_CSION                             \ CSI clock enable Set and reset by software to enable/disable CSI clock for system and/or peripheral. Set by hardware to force the CSI to ON when the system leaves Stop mode, if STOPWUCK = 1 or STOPKERWUCK = 1. This bit cannot be cleared if the CSI is used directly (via SW mux) as system clock, or if the CSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
$00000200 constant SEC_RCC_RCC_CR_CSIRDY                            \ CSI clock ready flag Set by hardware to indicate that the CSI oscillator is stable. This bit is activated only if the RC is enabled by CSION (it is not activated if the CSI is enabled by CSIKERON or by a peripheral request).
$00000400 constant SEC_RCC_RCC_CR_CSIKERON                          \ CSI clock enable in Stop mode Set and reset by software to force the CSI to ON, even in Stop mode, in order to be quickly available as kernel clock for some peripherals. This bit has no effect on the value of CSION.
$00001000 constant SEC_RCC_RCC_CR_HSI48ON                           \ HSI48 clock enable Set by software and cleared by software or by the hardware when the system enters to Stop or Standby mode.
$00002000 constant SEC_RCC_RCC_CR_HSI48RDY                          \ HSI48 clock ready flag Set by hardware to indicate that the HSI48 oscillator is stable.
$00010000 constant SEC_RCC_RCC_CR_HSEON                             \ HSE clock enable Set and cleared by software. Cleared by hardware to stop the HSE when entering Stop or Standby mode. This bit cannot be cleared if the HSE is used directly (via SW mux) as system clock, or if the HSE is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
$00020000 constant SEC_RCC_RCC_CR_HSERDY                            \ HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable.
$00040000 constant SEC_RCC_RCC_CR_HSEBYP                            \ HSE clock bypass Set and cleared by software to bypass the oscillator with an external clock. The external clock must be enabled with the HSEON bit to be used by the device. The HSEBYP bit can be written only if the HSE oscillator is disabled.
$00080000 constant SEC_RCC_RCC_CR_HSECSSON                          \ HSE clock security system enable Set by software to enable clock security system on HSE. This bit is 'set only' (disabled by a system reset or when the system enters in Standby mode). When HSECSSON is set, the clock detector is enabled by hardware when the HSE is ready and disabled by hardware if an oscillator failure is detected.
$00100000 constant SEC_RCC_RCC_CR_HSEEXT                            \ external high speed clock type in Bypass mode Set and reset by software to select the external clock type (analog or digital). The external clock must be enabled with the HSEON bit to be used by the device. The HSEEXT bit can be written only if the HSE oscillator is disabled.
$01000000 constant SEC_RCC_RCC_CR_PLL1ON                            \ PLL1 enable Set and cleared by software to enable PLL1. Cleared by hardware when entering Stop or Standby mode. Note that the hardware prevents writing this bit to 0, if the PLL1 output is used as the system clock.
$02000000 constant SEC_RCC_RCC_CR_PLL1RDY                           \ PLL1 clock ready flag Set by hardware to indicate that the PLL1 is locked.
$04000000 constant SEC_RCC_RCC_CR_PLL2ON                            \ PLL2 enable Set and cleared by software to enable PLL2. Cleared by hardware when entering Stop or Standby mode.
$08000000 constant SEC_RCC_RCC_CR_PLL2RDY                           \ PLL2 clock ready flag Set by hardware to indicate that the PLL is locked.
$10000000 constant SEC_RCC_RCC_CR_PLL3ON                            \ PLL3 enable Set and cleared by software to enable PLL3. Cleared by hardware when entering Stop or Standby mode.
$20000000 constant SEC_RCC_RCC_CR_PLL3RDY                           \ PLL3 clock ready flag Set by hardware to indicate that the PLL3 is locked.


\
\ @brief RCC HSI calibration register
\ Address offset: 0x10
\ Reset value: 0x00400000
\

$00000fff constant SEC_RCC_RCC_HSICFGR_HSICAL                       \ HSI clock calibration Set by hardware by option byte loading during system reset nreset. Adjusted by software through trimming bits HSITRIM. This field represents the sum of engineering option byte calibration value and HSITRIM bits value.
$007f0000 constant SEC_RCC_RCC_HSICFGR_HSITRIM                      \ HSI clock trimming Set by software to adjust calibration. HSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_HSI_OPT) in order to form the calibration trimming value. HSICAL = HSITRIM + FLASH_HSI_OPT. After a change of HSITRIM it takes one system clock cycle before the new HSITRIM value is updated Note: The reset value of the field is 0x40.


\
\ @brief RCC clock recovery RC register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000003ff constant SEC_RCC_RCC_CRRCR_HSI48CAL                       \ Internal RC 48 MHz clock calibration Set by hardware by option-byte loading during system reset NRESET. Read-only.


\
\ @brief RCC CSI calibration register
\ Address offset: 0x18
\ Reset value: 0x00200000
\

$000000ff constant SEC_RCC_RCC_CSICFGR_CSICAL                       \ CSI clock calibration Set by hardware by option byte loading during system reset NRESET. Adjusted by software through trimming bits CSITRIM. This field represents the sum of engineering option byte calibration value and CSITRIM bits value.
$003f0000 constant SEC_RCC_RCC_CSICFGR_CSITRIM                      \ CSI clock trimming Set by software to adjust calibration. CSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_CSI_OPT) in order to form the calibration trimming value. CSICAL = CSITRIM + FLASH_CSI_OPT. Note: The reset value of the field is 0x20.


\
\ @brief RCC clock configuration register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000007 constant SEC_RCC_RCC_CFGR1_SW                             \ system clock and trace clock switch Set and reset by software to select system clock and trace clock sources (sys_ck). Set by hardware in order to: - force the selection of the HSI or CSI (depending on STOPWUCK selection) when leaving a system Stop mode - force the selection of the HSI in case of failure of the HSE when used directly or indirectly as system clock others: reserved
$00000038 constant SEC_RCC_RCC_CFGR1_SWS                            \ system clock switch status Set and reset by hardware to indicate which clock source is used as system clock. 000: HSI used as system clock (hsi_ck) (default after reset). others: reserved
$00000040 constant SEC_RCC_RCC_CFGR1_STOPWUCK                       \ system clock selection after a wakeup from system Stop Set and reset by software to select the system wakeup clock from system Stop. The selected clock is also used as emergency clock for the clock security system (CSS) on HSE. 0: HSI selected as wakeup clock from system Stop (default after reset) STOPWUCK must not be modified when CSS is enabled (by HSECSSON bit) and the system clock is HSE (SWS = 10) or a switch on HSE is requested (SW =10).
$00000080 constant SEC_RCC_RCC_CFGR1_STOPKERWUCK                    \ kernel clock selection after a wakeup from system Stop Set and reset by software to select the kernel wakeup clock from system Stop.
$00003f00 constant SEC_RCC_RCC_CFGR1_RTCPRE                         \ HSE division factor for RTC clock Set and cleared by software to divide the HSE to generate a clock for RTC. Caution: The software must set these bits correctly to ensure that the clock supplied to the RTC is lower than 1 MHz. These bits must be configured if needed before selecting the RTC clock source. ...
$00008000 constant SEC_RCC_RCC_CFGR1_TIMPRE                         \ timers clocks prescaler selection This bit is set and reset by software to control the clock frequency of all the timers connected to APB1 and APB2 domains.
$003c0000 constant SEC_RCC_RCC_CFGR1_MCO1PRE                        \ MCO1 prescaler Set and cleared by software to configure the prescaler of the MCO1. Modification of this prescaler may generate glitches on MCO1. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. ...
$01c00000 constant SEC_RCC_RCC_CFGR1_MCO1SEL                        \ Microcontroller clock output 1 Set and cleared by software. Clock source selection may generate glitches on MCO1. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved
$1e000000 constant SEC_RCC_RCC_CFGR1_MCO2PRE                        \ MCO2 prescaler Set and cleared by software to configure the prescaler of the MCO2. Modification of this prescaler may generate glitches on MCO2. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. ...
$e0000000 constant SEC_RCC_RCC_CFGR1_MCO2SEL                        \ microcontroller clock output 2 Set and cleared by software. Clock source selection may generate glitches on MCO2. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved


\
\ @brief RCC CPU domain clock configuration register 2
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant SEC_RCC_RCC_CFGR2_HPRE                           \ AHB prescaler Set and reset by software to control the division factor of rcc_hclk. Changing this division ratio has an impact on the frequency of all bus matrix clocks 0xxx: rcc_hclk = sys_ck (default after reset)
$00000070 constant SEC_RCC_RCC_CFGR2_PPRE1                          \ APB low-speed prescaler (APB1) Set and reset by software to control the division factor of rcc_pclk1. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk after PPRE write. 0xx: rcc_pclk1 = rcc_hclk1 (default after reset)
$00000700 constant SEC_RCC_RCC_CFGR2_PPRE2                          \ APB high-speed prescaler (APB2) Set and reset by software to control APB high-speed clocks division factor. The clocks are divided with the new prescaler factor from 1 to 16 APB cycles after PPRE2 write. 0xx: rcc_pclk2 = rcc_hclk1
$00007000 constant SEC_RCC_RCC_CFGR2_PPRE3                          \ APB low-speed prescaler (APB3) Set and reset by software to control APB low-speed clocks division factor. The clocks are divided with the new prescaler factor from 1 to 16 APB cycles after PPRE3 write. 0xx: rcc_pclk3 = rcc_hclk1
$00010000 constant SEC_RCC_RCC_CFGR2_AHB1DIS                        \ AHB1 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB1 peripherals from RCC_AHB1ENR are used and when their clocks are disabled in RCC_AHB1ENR. When this bit is set, all the AHB1 peripherals clocks from RCC_AHB1ENR are off. enable control bits
$00020000 constant SEC_RCC_RCC_CFGR2_AHB2DIS                        \ AHB2 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB2 peripherals from RCC_AHB2ENR are used and when their clocks are disabled in RCC_AHB2ENR. When this bit is set, all the AHB2 peripherals clocks from RCC_AHB2ENR are off. enable control bits
$00080000 constant SEC_RCC_RCC_CFGR2_AHB4DIS                        \ AHB4 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB4 peripherals from RCC_AHB4ENR are used and when their clocks are disabled in RCC_AHB4ENR. When this bit is set, all the AHB4 peripherals clocks from RCC_AHB4ENR are off. enable control bits
$00100000 constant SEC_RCC_RCC_CFGR2_APB1DIS                        \ APB1 clock disable value This bit can be set in order to further reduce power consumption, when none of the APB1 peripherals (except IWDG) are used and when their clocks are disabled in RCC_APB1ENR. When this bit is set, all the APB1 peripherals clocks are off, except for IWDG. control bits
$00200000 constant SEC_RCC_RCC_CFGR2_APB2DIS                        \ APB2 clock disable value This bit can be set in order to further reduce power consumption, when none of the APB2 peripherals are used and when their clocks are disabled in RCC_APB2ENR. When this bit is set, all the APB2 peripherals clocks are off. control bits
$00400000 constant SEC_RCC_RCC_CFGR2_APB3DIS                        \ APB3 clock disable value.Set and cleared by software This bit can be set in order to further reduce power consumption, when none of the APB3 peripherals are used and when their clocks are disabled in RCC_APB3ENR. When this bit is set, all the APB3 peripherals clocks are off. control bits


\
\ @brief RCC PLL clock source selection register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000003 constant SEC_RCC_RCC_PLL1CFGR_PLL1SRC                     \ DIVMx and PLLs clock source selection Set and reset by software to select the PLL clock source. These bits can be written only when all PLLs are disabled. In order to save power, when no PLL is used, the value of PLL1SRC must be set to '00'. 00: no clock send to DIVMx divider and PLLs (default after reset).
$0000000c constant SEC_RCC_RCC_PLL1CFGR_PLL1RGE                     \ PLL1 input frequency range Set and reset by software to select the proper reference frequency range used for PLL1. This bit must be written before enabling the PLL1.
$00000010 constant SEC_RCC_RCC_PLL1CFGR_PLL1FRACEN                  \ PLL1 fractional latch enable Set and reset by software to latch the content of FRACN1 into the sigma-delta modulator. In order to latch the FRACN1 value into the sigma-delta modulator, PLL1FRACEN must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN1 into the modulator.
$00000020 constant SEC_RCC_RCC_PLL1CFGR_PLL1VCOSEL                  \ PLL1 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL1. This bit must be written before enabling the PLL1.
$00003f00 constant SEC_RCC_RCC_PLL1CFGR_DIVM1                       \ prescaler for PLL1 Set and cleared by software to configure the prescaler of the PLL1. The hardware does not allow any modification of this prescaler when PLL1 is enabled (PLL1ON = 1 or PLL1RDY = 1). In order to save power when PLL1 is not used, the value of DIVM1 must be set to 0. ... ...
$00010000 constant SEC_RCC_RCC_PLL1CFGR_PLL1PEN                     \ PLL1 DIVP divider output enable Set and reset by software to enable the pll1_p_ck output of the PLL1. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). In order to save power, when the pll1_p_ck output of the PLL1 is not used, the pll1_p_ck must be disabled.
$00020000 constant SEC_RCC_RCC_PLL1CFGR_PLL1QEN                     \ PLL1 DIVQ divider output enable Set and reset by software to enable the pll1_q_ck output of the PLL1. In order to save power, when the pll1_q_ck output of the PLL1 is not used, the pll1_q_ck must be disabled. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).
$00040000 constant SEC_RCC_RCC_PLL1CFGR_PLL1REN                     \ PLL1 DIVR divider output enable Set and reset by software to enable the pll1_r_ck output of the PLL1. To save power, DIVR1EN and DIVR1 bits must be set to 0 when the pll1_r_ck is not used. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).


\
\ @brief RCC PLL clock source selection register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000003 constant SEC_RCC_RCC_PLL2CFGR_PLL2SRC                     \ DIVMx and PLLs clock source selection Set and reset by software to select the PLL clock source. These bits can be written only when all PLLs are disabled. In order to save power, when no PLL is used, the value of PLL2SRC must be set to '00'.
$0000000c constant SEC_RCC_RCC_PLL2CFGR_PLL2RGE                     \ PLL2 input frequency range Set and reset by software to select the proper reference frequency range used for PLL2. These bits must be written before enabling the PLL2.
$00000010 constant SEC_RCC_RCC_PLL2CFGR_PLL2FRACEN                  \ PLL2 fractional latch enable Set and reset by software to enable the pll2_p_ck output of the PLL2. To save power, when the pll2_p_ck output of the PLL2 is not used, the pll2_p_ck must be disabled.
$00000020 constant SEC_RCC_RCC_PLL2CFGR_PLL2VCOSEL                  \ PLL2 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL2. This bit must be written before enabling the PLL2.
$00003f00 constant SEC_RCC_RCC_PLL2CFGR_DIVM2                       \ prescaler for PLL2 Set and cleared by software to configure the prescaler of the PLL2. The hardware does not allow any modification of this prescaler when PLL2 is enabled (PLL2ON = 1 or PLL2RDY = 1). In order to save power when PLL2 is not used, the value of DIVM2 must be set to 0. ... ...
$00010000 constant SEC_RCC_RCC_PLL2CFGR_PLL2PEN                     \ PLL2 DIVP divider output enable Set and reset by software to enable the pll2_p_ck output of the PLL2. To save power, when the pll2_p_ck output of the PLL2 is not used, the pll2_p_ck must be disabled.
$00020000 constant SEC_RCC_RCC_PLL2CFGR_PLL2QEN                     \ PLL2 DIVQ divider output enable Set and reset by software to enable the pll2_q_ck output of the PLL2. To save power, when the pll2_q_ck output of the PLL2 is not used, the pll2_q_ck must be disabled.
$00040000 constant SEC_RCC_RCC_PLL2CFGR_PLL2REN                     \ PLL2 DIVR divider output enable Set and reset by software to enable the pll2_r_ck output of the PLL2. To save power, DIVR2EN and DIVR2 bits must be set to 0 when the pll2_r_ck is not used.


\
\ @brief RCC PLL clock source selection register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000003 constant SEC_RCC_RCC_PLL3CFGR_PLL3SRC                     \ DIVMx and PLLs clock source selection Set and reset by software to select the PLL clock source. These bits can be written only when all PLLs are disabled. In order to save power, when no PLL is used, the value of PLL3SRC must be set to '00'.
$0000000c constant SEC_RCC_RCC_PLL3CFGR_PLL3RGE                     \ PLL3 input frequency range Set and reset by software to select the proper reference frequency range used for PLL3. This bit must be written before enabling the PLL3.
$00000010 constant SEC_RCC_RCC_PLL3CFGR_PLL3FRACEN                  \ PLL3 fractional latch enable Set and reset by software to latch the content of FRACN3 into the sigma-delta modulator. In order to latch the FRACN3 value into the sigma-delta modulator, PLL3FRACEN must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN3 into the modulator.
$00000020 constant SEC_RCC_RCC_PLL3CFGR_PLL3VCOSEL                  \ PLL3 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL3. This bit must be written before enabling the PLL3.
$00003f00 constant SEC_RCC_RCC_PLL3CFGR_DIVM3                       \ prescaler for PLL3 Set and cleared by software to configure the prescaler of the PLL3. The hardware does not allow any modification of this prescaler when PLL3 is enabled (PLL3ON = 1 or PLL3RDY = 1). In order to save power when PLL3 is not used, the value of DIVM2 must be set to 0. ... ...
$00010000 constant SEC_RCC_RCC_PLL3CFGR_PLL3PEN                     \ PLL3 DIVP divider output enable Set and reset by software to enable the pll3_p_ck output of the PLL3. To save power, when the pll3_p_ck output of the PLL3 is not used, the pll3_p_ck must be disabled.
$00020000 constant SEC_RCC_RCC_PLL3CFGR_PLL3QEN                     \ PLL3 DIVQ divider output enable Set and reset by software to enable the pll3_q_ck output of the PLL3. To save power, when the pll3_q_ck output of the PLL3 is not used, the pll3_q_ck must be disabled.
$00040000 constant SEC_RCC_RCC_PLL3CFGR_PLL3REN                     \ PLL3 DIVR divider output enable Set and reset by software to enable the pll3_r_ck output of the PLL3. To save power, DIVR2EN and DIVR2 bits must be set to 0 when the pll3_r_ck is not used.


\
\ @brief RCC PLL1 dividers register
\ Address offset: 0x34
\ Reset value: 0x01010280
\

$000001ff constant SEC_RCC_RCC_PLL1DIVR_PLL1N                       \ Multiplication factor for PLL1VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL1ON = 0 and PLL1RDY = 0). ... ... Others: reserved
$0000fe00 constant SEC_RCC_RCC_PLL1DIVR_PLL1P                       \ PLL1 DIVP division factor Set and reset by software to control the frequency of the pll1_p_ck clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). Note that odd division factors are not allowed. ...
$007f0000 constant SEC_RCC_RCC_PLL1DIVR_PLL1Q                       \ PLL1 DIVQ division factor Set and reset by software to control the frequency of the pll1_q_ck clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
$7f000000 constant SEC_RCC_RCC_PLL1DIVR_PLL1R                       \ PLL1 DIVR division factor Set and reset by software to control the frequency of the pll1_r_ck clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...


\
\ @brief RCC PLL1 fractional divider register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000fff8 constant SEC_RCC_RCC_PLL1FRACR_PLL1FRACN                  \ fractional part of the multiplication factor for PLL1 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: * 128 to 560 MHz if PLL1VCOSEL = 0 * 150 to 420 MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x (PLL1N + (PLL1FRACN / 213)), with * PLL1N between 8 and 420 * PLL1FRACN can be between 0 and 213- 1 * The input frequency Fref1_ck must be between 1 and 16 MHz. To change the PLL1FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: * Set the bit PLL1FRACEN to 0 * Write the new fractional value into PLL1FRACN * Set the bit PLL1FRACEN to 1


\
\ @brief RCC PLL1 dividers register
\ Address offset: 0x3C
\ Reset value: 0x01010280
\

$000001ff constant SEC_RCC_RCC_PLL2DIVR_PLL2N                       \ Multiplication factor for PLL2VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL2ON = 0 and PLL2RDY = 0). ... ... Others: reserved
$0000fe00 constant SEC_RCC_RCC_PLL2DIVR_PLL2P                       \ PLL2 DIVP division factor Set and reset by software to control the frequency of the pll2_p_ck clock. These bits can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...
$007f0000 constant SEC_RCC_RCC_PLL2DIVR_PLL2Q                       \ PLL2 DIVQ division factor Set and reset by software to control the frequency of the pll2_q_ck clock. These bits can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...
$7f000000 constant SEC_RCC_RCC_PLL2DIVR_PLL2R                       \ PLL2 DIVR division factor Set and reset by software to control the frequency of the pll2_r_ck clock. These bits can be written only when the PLL1 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...


\
\ @brief RCC PLL2 fractional divider register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000fff8 constant SEC_RCC_RCC_PLL2FRACR_PLL2FRACN                  \ fractional part of the multiplication factor for PLL2 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: * 128 to 560 MHz if PLL2VCOSEL = 0 * 150 to 420 MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x (PLL2N + (PLL2FRACN / 213)), with * PLL2N between 8 and 420 * PLL2FRACN can be between 0 and 213- 1 * The input frequency Fref2_ck must be between 1 and 16 MHz. To change the PLL2FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: * Set the bit PLL2FRACEN to 0 * Write the new fractional value into PLL2FRACN * Set the bit PLL2FRACEN to 1


\
\ @brief RCC PLL3 dividers register
\ Address offset: 0x44
\ Reset value: 0x01010280
\

$000001ff constant SEC_RCC_RCC_PLL3DIVR_PLL3N                       \ Multiplication factor for PLL3VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL3ON = 0 and PLL3RDY = 0). ... ... Others: reserved
$0000fe00 constant SEC_RCC_RCC_PLL3DIVR_PLL3P                       \ PLL3 DIVP division factor Set and reset by software to control the frequency of the pll3_p_ck clock. These bits can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0). ...
$007f0000 constant SEC_RCC_RCC_PLL3DIVR_PLL3Q                       \ PLL3 DIVQ division factor Set and reset by software to control the frequency of the pll3_q_ck clock. These bits can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0). ...
$7f000000 constant SEC_RCC_RCC_PLL3DIVR_PLL3R                       \ PLL3 DIVR division factor Set and reset by software to control the frequency of the pll3_r_ck clock. These bits can be written only when the PLL1 is disabled (PLL3ON = 0 and PLL3RDY = 0). ...


\
\ @brief RCC PLL3 fractional divider register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000fff8 constant SEC_RCC_RCC_PLL3FRACR_PLL3FRACN                  \ fractional part of the multiplication factor for PLL3 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL3 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: * 128 to 560 MHz if PLL3VCOSEL = 0 * 150 to 420 MHz if PLL3VCOSEL = 1 VCO output frequency = Fref3_ck x (PLL3N + (PLL3FRACN / 213)), with * PLL3N between 8 and 420 * PLL3FRACN can be between 0 and 213- 1 * The input frequency Fref3_ck must be between 1 and 16 MHz. To change the PLL3FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: * Set the bit PLL3FRACEN to 0 * Write the new fractional value into PLL3FRACN * Set the bit PLL3FRACEN to 1.


\
\ @brief RCC clock source interrupt enable register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_RCC_CIER_LSIRDYIE                        \ LSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the LSI oscillator stabilization.
$00000002 constant SEC_RCC_RCC_CIER_LSERDYIE                        \ LSE ready interrupt enable Set and reset by software to enable/disable interrupt caused by the LSE oscillator stabilization.
$00000004 constant SEC_RCC_RCC_CIER_CSIRDYIE                        \ CSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the CSI oscillator stabilization.
$00000008 constant SEC_RCC_RCC_CIER_HSIRDYIE                        \ HSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the HSI oscillator stabilization.
$00000010 constant SEC_RCC_RCC_CIER_HSERDYIE                        \ HSE ready interrupt enable Set and reset by software to enable/disable interrupt caused by the HSE oscillator stabilization.
$00000020 constant SEC_RCC_RCC_CIER_HSI48RDYIE                      \ HSI48 ready interrupt enable Set and reset by software to enable/disable interrupt caused by the HSI48 oscillator stabilization.
$00000040 constant SEC_RCC_RCC_CIER_PLL1RDYIE                       \ PLL1 ready interrupt enable Set and reset by software to enable/disable interrupt caused by PLL1 lock.
$00000080 constant SEC_RCC_RCC_CIER_PLL2RDYIE                       \ PLL2 ready interrupt enable Set and reset by software to enable/disable interrupt caused by PLL2 lock.
$00000100 constant SEC_RCC_RCC_CIER_PLL3RDYIE                       \ PLL3 ready interrupt enable Set and reset by software to enable/disable interrupt caused by PLL3 lock.


\
\ @brief RCC clock source interrupt flag register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_RCC_CIFR_LSIRDYF                         \ LSI ready interrupt flag Reset by software by writing LSIRDYC bit. Set by hardware when the LSI clock becomes stable and LSIRDYIE is set.
$00000002 constant SEC_RCC_RCC_CIFR_LSERDYF                         \ LSE ready interrupt flag Reset by software by writing LSERDYC bit. Set by hardware when the LSE clock becomes stable and LSERDYIE is set.
$00000004 constant SEC_RCC_RCC_CIFR_CSIRDYF                         \ CSI ready interrupt flag Reset by software by writing CSIRDYC bit. Set by hardware when the CSI clock becomes stable and CSIRDYIE is set.
$00000008 constant SEC_RCC_RCC_CIFR_HSIRDYF                         \ HSI ready interrupt flag Reset by software by writing HSIRDYC bit. Set by hardware when the HSI clock becomes stable and HSIRDYIE is set.
$00000010 constant SEC_RCC_RCC_CIFR_HSERDYF                         \ HSE ready interrupt flag Reset by software by writing HSERDYC bit. Set by hardware when the HSE clock becomes stable and HSERDYIE is set.
$00000020 constant SEC_RCC_RCC_CIFR_HSI48RDYF                       \ HSI48 ready interrupt flag Reset by software by writing HSI48RDYC bit. Set by hardware when the HSI48 clock becomes stable and HSI48RDYIE is set.
$00000040 constant SEC_RCC_RCC_CIFR_PLL1RDYF                        \ PLL1 ready interrupt flag Reset by software by writing PLL1RDYC bit. Set by hardware when the PLL1 locks and PLL1RDYIE is set.
$00000080 constant SEC_RCC_RCC_CIFR_PLL2RDYF                        \ PLL2 ready interrupt flag Reset by software by writing PLL2RDYC bit. Set by hardware when the PLL2 locks and PLL2RDYIE is set.
$00000100 constant SEC_RCC_RCC_CIFR_PLL3RDYF                        \ PLL3 ready interrupt flag Reset by software by writing PLL3RDYC bit. Set by hardware when the PLL3 locks and PLL3RDYIE is set.
$00000400 constant SEC_RCC_RCC_CIFR_HSECSSF                         \ HSE clock security system interrupt flag Reset by software by writing HSECSSC bit. Set by hardware in case of HSE clock failure.


\
\ @brief RCC clock source interrupt clear register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_RCC_CICR_LSIRDYC                         \ LSI ready interrupt clear Set by software to clear LSIRDYF. Reset by hardware when clear done.
$00000002 constant SEC_RCC_RCC_CICR_LSERDYC                         \ LSE ready interrupt clear Set by software to clear LSERDYF. Reset by hardware when clear done.
$00000004 constant SEC_RCC_RCC_CICR_CSIRDYC                         \ HSI ready interrupt clear Set by software to clear CSIRDYF. Reset by hardware when clear done.
$00000008 constant SEC_RCC_RCC_CICR_HSIRDYC                         \ HSI ready interrupt clear Set by software to clear HSIRDYF. Reset by hardware when clear done.
$00000010 constant SEC_RCC_RCC_CICR_HSERDYC                         \ HSE ready interrupt clear Set by software to clear HSERDYF. Reset by hardware when clear done.
$00000020 constant SEC_RCC_RCC_CICR_HSI48RDYC                       \ HSI48 ready interrupt clear Set by software to clear HSI48RDYF. Reset by hardware when clear done.
$00000040 constant SEC_RCC_RCC_CICR_PLL1RDYC                        \ PLL1 ready interrupt clear Set by software to clear PLL1RDYF. Reset by hardware when clear done.
$00000080 constant SEC_RCC_RCC_CICR_PLL2RDYC                        \ PLL2 ready interrupt clear Set by software to clear PLL2RDYF. Reset by hardware when clear done.
$00000100 constant SEC_RCC_RCC_CICR_PLL3RDYC                        \ PLL3 ready interrupt clear Set by software to clear PLL3RDYF. Reset by hardware when clear done.
$00000400 constant SEC_RCC_RCC_CICR_HSECSSC                         \ HSE clock security system interrupt clear Set by software to clear HSECSSF. Reset by hardware when clear done.


\
\ @brief RCC AHB1 reset register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_RCC_AHB1RSTR_GPDMA1RST                   \ GPDMA1 block reset Set and reset by software.
$00000002 constant SEC_RCC_RCC_AHB1RSTR_GPDMA2RST                   \ GPDMA2 block reset Set and reset by software.
$00001000 constant SEC_RCC_RCC_AHB1RSTR_CRCRST                      \ CRC block reset Set and reset by software.
$00004000 constant SEC_RCC_RCC_AHB1RSTR_CORDICRST                   \ CORDIC block reset Set and reset by software.
$00008000 constant SEC_RCC_RCC_AHB1RSTR_FMACRST                     \ FMAC block reset Set and reset by software.
$00020000 constant SEC_RCC_RCC_AHB1RSTR_RAMCFGRST                   \ RAMCFG block reset Set and reset by software.
$00080000 constant SEC_RCC_RCC_AHB1RSTR_ETHRST                      \ ETHRST block reset Set and reset by software
$01000000 constant SEC_RCC_RCC_AHB1RSTR_TZSC1RST                    \ TZSC1 reset Set and reset by software


\
\ @brief RCC AHB2 peripheral reset register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_RCC_AHB2RSTR_GPIOARST                    \ GPIOA block reset Set and reset by software.
$00000002 constant SEC_RCC_RCC_AHB2RSTR_GPIOBRST                    \ GPIOB block reset Set and reset by software.
$00000004 constant SEC_RCC_RCC_AHB2RSTR_GPIOCRST                    \ GPIOC block reset Set and reset by software.
$00000008 constant SEC_RCC_RCC_AHB2RSTR_GPIODRST                    \ GPIOD block reset Set and reset by software.
$00000010 constant SEC_RCC_RCC_AHB2RSTR_GPIOERST                    \ GPIOE block reset Set and reset by software.
$00000020 constant SEC_RCC_RCC_AHB2RSTR_GPIOFRST                    \ GPIOF block reset Set and reset by software.
$00000040 constant SEC_RCC_RCC_AHB2RSTR_GPIOGRST                    \ GPIOG block reset Set and reset by software.
$00000080 constant SEC_RCC_RCC_AHB2RSTR_GPIOHRST                    \ GPIOH block reset Set and reset by software.
$00000100 constant SEC_RCC_RCC_AHB2RSTR_GPIOIRST                    \ GPIOI block reset Set and reset by software.
$00000400 constant SEC_RCC_RCC_AHB2RSTR_ADC12RST                    \ ADC1 and 2 blocks reset Set and reset by software.
$00000800 constant SEC_RCC_RCC_AHB2RSTR_DAC12RST                    \ DAC block reset Set and reset by software.
$00001000 constant SEC_RCC_RCC_AHB2RSTR_DCMI_PSSIRST                \ digital camera interface block reset (DCMI or PSSI depending which interface is active) Set and reset by software.
$00010000 constant SEC_RCC_RCC_AHB2RSTR_AESRST                      \ AES block reset Set and reset by software.
$00020000 constant SEC_RCC_RCC_AHB2RSTR_HASHRST                     \ HASH block reset Set and reset by software.
$00040000 constant SEC_RCC_RCC_AHB2RSTR_RNGRST                      \ RNG block reset Set and reset by software.
$00080000 constant SEC_RCC_RCC_AHB2RSTR_PKARST                      \ PKA block reset Set and reset by software.
$00100000 constant SEC_RCC_RCC_AHB2RSTR_SAESRST                     \ SAES block reset Set and reset by software.


\
\ @brief RCC AHB4 peripheral reset register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000080 constant SEC_RCC_RCC_AHB4RSTR_OTFDEC1RST                  \ OTFDEC1 block reset Set and reset by software.
$00000800 constant SEC_RCC_RCC_AHB4RSTR_SDMMC1RST                   \ SDMMC1 and SDMMC1 delay blocks reset Set and reset by software.
$00001000 constant SEC_RCC_RCC_AHB4RSTR_SDMMC2RST                   \ SDMMC2 and SDMMC2 delay blocks reset Set and reset by software.
$00010000 constant SEC_RCC_RCC_AHB4RSTR_FMCRST                      \ FMC block reset Set and reset by software.
$00100000 constant SEC_RCC_RCC_AHB4RSTR_OCTOSPI1RST                 \ OCTOSPI1 block reset Set and reset by software.


\
\ @brief RCC APB1 peripheral low reset register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_RCC_APB1LRSTR_TIM2RST                    \ TIM2 block reset Set and reset by software.
$00000002 constant SEC_RCC_RCC_APB1LRSTR_TIM3RST                    \ TIM3 block reset Set and reset by software.
$00000004 constant SEC_RCC_RCC_APB1LRSTR_TIM4RST                    \ TIM4 block reset Set and reset by software.
$00000008 constant SEC_RCC_RCC_APB1LRSTR_TIM5RST                    \ TIM5 block reset Set and reset by software.
$00000010 constant SEC_RCC_RCC_APB1LRSTR_TIM6RST                    \ TIM6 block reset Set and reset by software.
$00000020 constant SEC_RCC_RCC_APB1LRSTR_TIM7RST                    \ TIM7 block reset Set and reset by software.
$00000040 constant SEC_RCC_RCC_APB1LRSTR_TIM12RST                   \ TIM12 block reset Set and reset by software.
$00000080 constant SEC_RCC_RCC_APB1LRSTR_TIM13RST                   \ TIM13 block reset t Set and reset by software.
$00000100 constant SEC_RCC_RCC_APB1LRSTR_TIM14RST                   \ TIM14 block reset Set and reset by software.
$00004000 constant SEC_RCC_RCC_APB1LRSTR_SPI2RST                    \ SPI2 block reset Set and reset by software.
$00008000 constant SEC_RCC_RCC_APB1LRSTR_SPI3RST                    \ SPI3 block reset Set and reset by software.
$00020000 constant SEC_RCC_RCC_APB1LRSTR_USART2RST                  \ USART2 block reset Set and reset by software.
$00040000 constant SEC_RCC_RCC_APB1LRSTR_USART3RST                  \ USART3 block reset Set and reset by software.
$00080000 constant SEC_RCC_RCC_APB1LRSTR_UART4RST                   \ UART4 block reset Set and reset by software.
$00100000 constant SEC_RCC_RCC_APB1LRSTR_UART5RST                   \ UART5 block reset Set and reset by software.
$00200000 constant SEC_RCC_RCC_APB1LRSTR_I2C1RST                    \ I2C1 block reset Set and reset by software.
$00400000 constant SEC_RCC_RCC_APB1LRSTR_I2C2RST                    \ I2C2 block reset Set and reset by software.
$00800000 constant SEC_RCC_RCC_APB1LRSTR_I3C1RST                    \ I3C1 block reset Set and reset by software.
$01000000 constant SEC_RCC_RCC_APB1LRSTR_CRSRST                     \ CRS block reset Set and reset by software.
$02000000 constant SEC_RCC_RCC_APB1LRSTR_USART6RST                  \ USART6 block reset Set and reset by software.
$04000000 constant SEC_RCC_RCC_APB1LRSTR_USART10RST                 \ USART10 block reset Set and reset by software.
$08000000 constant SEC_RCC_RCC_APB1LRSTR_USART11RST                 \ USART11 block reset Set and reset by software.
$10000000 constant SEC_RCC_RCC_APB1LRSTR_CECRST                     \ HDMI-CEC block reset Set and reset by software.
$40000000 constant SEC_RCC_RCC_APB1LRSTR_UART7RST                   \ UART7 block reset Set and reset by software.
$80000000 constant SEC_RCC_RCC_APB1LRSTR_UART8RST                   \ UART8 block reset Set and reset by software.


\
\ @brief RCC APB1 peripheral high reset register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_RCC_APB1HRSTR_UART9RST                   \ UART9 block reset Set and reset by software.
$00000002 constant SEC_RCC_RCC_APB1HRSTR_UART12RST                  \ UART12 block reset Set and reset by software.
$00000008 constant SEC_RCC_RCC_APB1HRSTR_DTSRST                     \ DTS block reset Set and reset by software.
$00000020 constant SEC_RCC_RCC_APB1HRSTR_LPTIM2RST                  \ LPTIM2 block reset Set and reset by software.
$00000200 constant SEC_RCC_RCC_APB1HRSTR_FDCAN12RST                 \ FDCAN1 and FDCAN2 blocks reset Set and reset by software.
$00800000 constant SEC_RCC_RCC_APB1HRSTR_UCPDRST                    \ UCPD block reset Set and reset by software.


\
\ @brief RCC APB2 peripheral reset register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000800 constant SEC_RCC_RCC_APB2RSTR_TIM1RST                     \ TIM1 block reset Set and reset by software.
$00001000 constant SEC_RCC_RCC_APB2RSTR_SPI1RST                     \ SPI1 block reset Set and reset by software.
$00002000 constant SEC_RCC_RCC_APB2RSTR_TIM8RST                     \ TIM8 block reset Set and reset by software.
$00004000 constant SEC_RCC_RCC_APB2RSTR_USART1RST                   \ USART1 block reset Set and reset by software.
$00010000 constant SEC_RCC_RCC_APB2RSTR_TIM15RST                    \ TIM15 block reset Set and reset by software.
$00020000 constant SEC_RCC_RCC_APB2RSTR_TIM16RST                    \ TIM16 block reset Set and reset by software.
$00040000 constant SEC_RCC_RCC_APB2RSTR_TIM17RST                    \ TIM17 block reset Set and reset by software.
$00080000 constant SEC_RCC_RCC_APB2RSTR_SPI4RST                     \ SPI4 block reset Set and reset by software.
$00100000 constant SEC_RCC_RCC_APB2RSTR_SPI6RST                     \ SPI6 block reset Set and reset by software.
$00200000 constant SEC_RCC_RCC_APB2RSTR_SAI1RST                     \ SAI1 block reset Set and reset by software.
$00400000 constant SEC_RCC_RCC_APB2RSTR_SAI2RST                     \ SAI2 block reset Set and reset by software.
$01000000 constant SEC_RCC_RCC_APB2RSTR_USBFSRST                    \ USBFS block reset Set and reset by software.


\
\ @brief RCC APB4 peripheral reset register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000002 constant SEC_RCC_RCC_APB3RSTR_SBSRST                      \ SBS block reset Set and reset by software.
$00000020 constant SEC_RCC_RCC_APB3RSTR_SPI5RST                     \ SPI5 block reset Set and reset by software.
$00000040 constant SEC_RCC_RCC_APB3RSTR_LPUART1RST                  \ LPUART1 block reset Set and reset by software.
$00000080 constant SEC_RCC_RCC_APB3RSTR_I2C3RST                     \ I2C3 block reset Set and reset by software.
$00000100 constant SEC_RCC_RCC_APB3RSTR_I2C4RST                     \ I2C4 block reset Set and reset by software.
$00000800 constant SEC_RCC_RCC_APB3RSTR_LPTIM1RST                   \ LPTIM1 block reset Set and reset by software.
$00001000 constant SEC_RCC_RCC_APB3RSTR_LPTIM3RST                   \ LPTIM3 block reset Set and reset by software.
$00002000 constant SEC_RCC_RCC_APB3RSTR_LPTIM4RST                   \ LPTIM4 block reset Set and reset by software.
$00004000 constant SEC_RCC_RCC_APB3RSTR_LPTIM5RST                   \ LPTIM5 block reset Set and reset by software.
$00008000 constant SEC_RCC_RCC_APB3RSTR_LPTIM6RST                   \ LPTIM6 block reset Set and reset by software.
$00100000 constant SEC_RCC_RCC_APB3RSTR_VREFRST                     \ VREF block reset Set and reset by software.


\
\ @brief RCC AHB1 peripherals clock register
\ Address offset: 0x88
\ Reset value: 0xD0000100
\

$00000001 constant SEC_RCC_RCC_AHB1ENR_GPDMA1EN                     \ GPDMA1 clock enable Set and reset by software.
$00000002 constant SEC_RCC_RCC_AHB1ENR_GPDMA2EN                     \ GPDMA2 clock enable Set and reset by software.
$00000100 constant SEC_RCC_RCC_AHB1ENR_FLITFEN                      \ Flash interface clock enable Set and reset by software.
$00001000 constant SEC_RCC_RCC_AHB1ENR_CRCEN                        \ CRC clock enable Set and reset by software.
$00004000 constant SEC_RCC_RCC_AHB1ENR_CORDICEN                     \ CORDIC clock enable Set and reset by software.
$00008000 constant SEC_RCC_RCC_AHB1ENR_FMACEN                       \ FMAC clock enable Set and reset by software.
$00020000 constant SEC_RCC_RCC_AHB1ENR_RAMCFGEN                     \ RAMCFG clock enable Set and reset by software.
$00080000 constant SEC_RCC_RCC_AHB1ENR_ETHEN                        \ ETH clock enable Set and reset by software
$00100000 constant SEC_RCC_RCC_AHB1ENR_ETHTXEN                      \ ETHTX clock enable Set and reset by software
$00200000 constant SEC_RCC_RCC_AHB1ENR_ETHRXEN                      \ ETHRX clock enable Set and reset by software
$01000000 constant SEC_RCC_RCC_AHB1ENR_TZSC1EN                      \ TZSC1 clock enable Set and reset by software
$10000000 constant SEC_RCC_RCC_AHB1ENR_BKPRAMEN                     \ BKPRAM clock enable Set and reset by software
$40000000 constant SEC_RCC_RCC_AHB1ENR_DCACHEEN                     \ DCACHE clock enable Set and reset by software
$80000000 constant SEC_RCC_RCC_AHB1ENR_SRAM1EN                      \ SRAM1 clock enable Set and reset by software.


\
\ @brief RCC AHB2 peripheral clock register
\ Address offset: 0x8C
\ Reset value: 0xC0000000
\

$00000001 constant SEC_RCC_RCC_AHB2ENR_GPIOAEN                      \ GPIOA clock enable Set and reset by software.
$00000002 constant SEC_RCC_RCC_AHB2ENR_GPIOBEN                      \ GPIOB clock enable Set and reset by software.
$00000004 constant SEC_RCC_RCC_AHB2ENR_GPIOCEN                      \ GPIOC clock enable Set and reset by software.
$00000008 constant SEC_RCC_RCC_AHB2ENR_GPIODEN                      \ GPIOD clock enable Set and reset by software.
$00000010 constant SEC_RCC_RCC_AHB2ENR_GPIOEEN                      \ GPIOE clock enable Set and reset by software.
$00000020 constant SEC_RCC_RCC_AHB2ENR_GPIOFEN                      \ GPIOF clock enable Set and reset by software.
$00000040 constant SEC_RCC_RCC_AHB2ENR_GPIOGEN                      \ GPIOG clock enable Set and reset by software.
$00000080 constant SEC_RCC_RCC_AHB2ENR_GPIOHEN                      \ GPIOH clock enable Set and reset by software.
$00000100 constant SEC_RCC_RCC_AHB2ENR_GPIOIEN                      \ GPIOI clock enable Set and reset by software.
$00000400 constant SEC_RCC_RCC_AHB2ENR_ADC12EN                      \ ADC1 and 2 peripherals clock enabled Set and reset by software.
$00000800 constant SEC_RCC_RCC_AHB2ENR_DAC12EN                      \ DAC clock enable Set and reset by software.
$00001000 constant SEC_RCC_RCC_AHB2ENR_DCMI_PSSIEN                  \ digital camera interface clock enable (DCMI or PSSI depending which interface is active) Set and reset by software.
$00010000 constant SEC_RCC_RCC_AHB2ENR_AESEN                        \ AES clock enable Set and reset by software.
$00020000 constant SEC_RCC_RCC_AHB2ENR_HASHEN                       \ HASH clock enable Set and reset by software.
$00040000 constant SEC_RCC_RCC_AHB2ENR_RNGEN                        \ RNG clock enable Set and reset by software.
$00080000 constant SEC_RCC_RCC_AHB2ENR_PKAEN                        \ PKA clock enable Set and reset by software.
$00100000 constant SEC_RCC_RCC_AHB2ENR_SAESEN                       \ SAES clock enable Set and reset by software.
$40000000 constant SEC_RCC_RCC_AHB2ENR_SRAM3EN                      \ SRAM3 clock enable Set and reset by software.
$80000000 constant SEC_RCC_RCC_AHB2ENR_SRAM2EN                      \ SRAM2 clock enable Set and reset by software.


\
\ @brief RCC AHB4 peripheral clock register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000080 constant SEC_RCC_RCC_AHB4ENR_OTFDEC1EN                    \ OTFDEC1 clock enable Set and reset by software.
$00000800 constant SEC_RCC_RCC_AHB4ENR_SDMMC1EN                     \ SDMMC1 and SDMMC1 delay peripheral clock enable reset
$00001000 constant SEC_RCC_RCC_AHB4ENR_SDMMC2EN                     \ SDMMC2 and SDMMC2 delay peripheral clock enabled Set and reset by software.
$00010000 constant SEC_RCC_RCC_AHB4ENR_FMCEN                        \ FMC clock enable Set and reset by software.
$00100000 constant SEC_RCC_RCC_AHB4ENR_OCTOSPI1EN                   \ OCTOSPI1 clock enable Set and reset by software.


\
\ @brief RCC APB1 peripheral clock register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_RCC_APB1LENR_TIM2EN                      \ TIM2 clock enable Set and reset by software.
$00000002 constant SEC_RCC_RCC_APB1LENR_TIM3EN                      \ TIM3 clock enable Set and reset by software.
$00000004 constant SEC_RCC_RCC_APB1LENR_TIM4EN                      \ TIM4 clock enable Set and reset by software.
$00000008 constant SEC_RCC_RCC_APB1LENR_TIM5EN                      \ TIM5 clock enable Set and reset by software.
$00000010 constant SEC_RCC_RCC_APB1LENR_TIM6EN                      \ TIM6 clock enable Set and reset by software.
$00000020 constant SEC_RCC_RCC_APB1LENR_TIM7EN                      \ TIM7 clock enable Set and reset by software.
$00000040 constant SEC_RCC_RCC_APB1LENR_TIM12EN                     \ TIM12 clock enable Set and reset by software.
$00000080 constant SEC_RCC_RCC_APB1LENR_TIM13EN                     \ TIM13 clock enable Set and reset by software.
$00000100 constant SEC_RCC_RCC_APB1LENR_TIM14EN                     \ TIM14 clock enable Set and reset by software.
$00000800 constant SEC_RCC_RCC_APB1LENR_WWDGEN                      \ WWDG clock enable Set and reset by software.
$00004000 constant SEC_RCC_RCC_APB1LENR_SPI2EN                      \ SPI2 clock enable Set and reset by software.
$00008000 constant SEC_RCC_RCC_APB1LENR_SPI3EN                      \ SPI3 clock enable Set and reset by software.
$00020000 constant SEC_RCC_RCC_APB1LENR_USART2EN                    \ USART2 clock enable Set and reset by software.
$00040000 constant SEC_RCC_RCC_APB1LENR_USART3EN                    \ USART3 clock enable Set and reset by software.
$00080000 constant SEC_RCC_RCC_APB1LENR_UART4EN                     \ UART4 clock enable Set and reset by software.
$00100000 constant SEC_RCC_RCC_APB1LENR_UART5EN                     \ UART5 clock enable Set and reset by software.
$00200000 constant SEC_RCC_RCC_APB1LENR_I2C1EN                      \ I2C1 clock enable Set and reset by software.
$00400000 constant SEC_RCC_RCC_APB1LENR_I2C2EN                      \ I2C2 clock enable Set and reset by software.
$00800000 constant SEC_RCC_RCC_APB1LENR_I3C1EN                      \ I3C1 clock enable Set and reset by software.
$01000000 constant SEC_RCC_RCC_APB1LENR_CRSEN                       \ CRS clock enable Set and reset by software.
$02000000 constant SEC_RCC_RCC_APB1LENR_USART6EN                    \ USART6 clock enable Set and reset by software.
$04000000 constant SEC_RCC_RCC_APB1LENR_USART10EN                   \ USART10 clock enable Set and reset by software.
$08000000 constant SEC_RCC_RCC_APB1LENR_USART11EN                   \ USART11 clock enable
$10000000 constant SEC_RCC_RCC_APB1LENR_CECEN                       \ HDMI-CEC clock enable Set and reset by software.
$40000000 constant SEC_RCC_RCC_APB1LENR_UART7EN                     \ UART7 clock enable Set and reset by software.
$80000000 constant SEC_RCC_RCC_APB1LENR_UART8EN                     \ UART8 clock enable Set and reset by software.


\
\ @brief RCC APB1 peripheral clock register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_RCC_APB1HENR_UART9EN                     \ UART9 clock enable Set and reset by software.
$00000002 constant SEC_RCC_RCC_APB1HENR_UART12EN                    \ UART12 clock enable Set and reset by software.
$00000008 constant SEC_RCC_RCC_APB1HENR_DTSEN                       \ DTS clock enable Set and reset by software.
$00000020 constant SEC_RCC_RCC_APB1HENR_LPTIM2EN                    \ LPTIM2 clock enable Set and reset by software.
$00000200 constant SEC_RCC_RCC_APB1HENR_FDCAN12EN                   \ FDCAN1 and FDCAN2 peripheral clock enable Set and reset by software.
$00800000 constant SEC_RCC_RCC_APB1HENR_UCPDEN                      \ UCPD clock enable Set and reset by software.


\
\ @brief RCC APB2 peripheral clock register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000800 constant SEC_RCC_RCC_APB2ENR_TIM1EN                       \ TIM1 clock enable Set and reset by software.
$00001000 constant SEC_RCC_RCC_APB2ENR_SPI1EN                       \ SPI1 clock enable Set and reset by software.
$00002000 constant SEC_RCC_RCC_APB2ENR_TIM8EN                       \ TIM8 clock enable Set and reset by software.
$00004000 constant SEC_RCC_RCC_APB2ENR_USART1EN                     \ USART1 clock enable Set and reset by software.
$00010000 constant SEC_RCC_RCC_APB2ENR_TIM15EN                      \ TIM15 clock enable Set and reset by software.
$00020000 constant SEC_RCC_RCC_APB2ENR_TIM16EN                      \ TIM16 clock enable Set and reset by software.
$00040000 constant SEC_RCC_RCC_APB2ENR_TIM17EN                      \ TIM17 clock enable Set and reset by software.
$00080000 constant SEC_RCC_RCC_APB2ENR_SPI4EN                       \ SPI4 clock enable Set and reset by software.
$00100000 constant SEC_RCC_RCC_APB2ENR_SPI6EN                       \ SPI6 clock enable Set and reset by software.
$00200000 constant SEC_RCC_RCC_APB2ENR_SAI1EN                       \ SAI1 clock enable Set and reset by software.
$00400000 constant SEC_RCC_RCC_APB2ENR_SAI2EN                       \ SAI2 clock enable Set and cleared by software.
$01000000 constant SEC_RCC_RCC_APB2ENR_USBFSEN                      \ USBFS clock enable Set and reset by software.


\
\ @brief RCC APB4 peripheral clock register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000002 constant SEC_RCC_RCC_APB3ENR_SBSEN                        \ SBS clock enable Set and reset by software.
$00000020 constant SEC_RCC_RCC_APB3ENR_SPI5EN                       \ SPI5 clock enable Set and reset by software.
$00000040 constant SEC_RCC_RCC_APB3ENR_LPUART1EN                    \ LPUART1 clock enable Set and reset by software.
$00000080 constant SEC_RCC_RCC_APB3ENR_I2C3EN                       \ I2C3 clock enable Set and reset by software.
$00000100 constant SEC_RCC_RCC_APB3ENR_I2C4EN                       \ I2C4 clock enable Set and reset by software.
$00000800 constant SEC_RCC_RCC_APB3ENR_LPTIM1EN                     \ LPTIM1 clock enable Set and reset by software.
$00001000 constant SEC_RCC_RCC_APB3ENR_LPTIM3EN                     \ LPTIM3 clock enable Set and reset by software.
$00002000 constant SEC_RCC_RCC_APB3ENR_LPTIM4EN                     \ LPTIM4 clock enable Set and reset by software.
$00004000 constant SEC_RCC_RCC_APB3ENR_LPTIM5EN                     \ LPTIM5 clock enable Set and reset by software.
$00008000 constant SEC_RCC_RCC_APB3ENR_LPTIM6EN                     \ LPTIM6 clock enable Set and reset by software.
$00100000 constant SEC_RCC_RCC_APB3ENR_VREFEN                       \ VREF clock enable Set and reset by software.
$00200000 constant SEC_RCC_RCC_APB3ENR_RTCAPBEN                     \ RTC APB interface clock enable Set and reset by software.


\
\ @brief RCC AHB1 sleep clock register
\ Address offset: 0xB0
\ Reset value: 0xF13AD103
\

$00000001 constant SEC_RCC_RCC_AHB1LPENR_GPDMA1LPEN                 \ GPDMA1 clock enable during sleep mode Set and reset by software.
$00000002 constant SEC_RCC_RCC_AHB1LPENR_GPDMA2LPEN                 \ GPDMA2 clock enable during sleep mode Set and reset by software.
$00000100 constant SEC_RCC_RCC_AHB1LPENR_FLITFLPEN                  \ Flash interface (FLITF) clock enable during sleep mode Set and reset by software.
$00001000 constant SEC_RCC_RCC_AHB1LPENR_CRCLPEN                    \ CRC clock enable during sleep mode Set and reset by software.
$00004000 constant SEC_RCC_RCC_AHB1LPENR_CORDICLPEN                 \ CORDIC clock enable during sleep mode Set and reset by software.
$00008000 constant SEC_RCC_RCC_AHB1LPENR_FMACLPEN                   \ FMAC clock enable during sleep mode Set and reset by software.
$00020000 constant SEC_RCC_RCC_AHB1LPENR_RAMCFGLPEN                 \ RAMCFG clock enable during sleep mode Set and reset by software.
$00080000 constant SEC_RCC_RCC_AHB1LPENR_ETHLPEN                    \ ETH clock enable during Sleep mode Set and reset by software
$00100000 constant SEC_RCC_RCC_AHB1LPENR_ETHTXLPEN                  \ ETHTX clock enable during sleep mode Set and reset by software
$00200000 constant SEC_RCC_RCC_AHB1LPENR_ETHRXLPEN                  \ ETHRX clock enable during sleep mode Set and reset by software
$01000000 constant SEC_RCC_RCC_AHB1LPENR_TZSC1LPEN                  \ TZSC1 clock enable during sleep mode Set and reset by software
$10000000 constant SEC_RCC_RCC_AHB1LPENR_BKPRAMLPEN                 \ BKPRAM clock enable during sleep mode Set and reset by software
$20000000 constant SEC_RCC_RCC_AHB1LPENR_ICACHELPEN                 \ ICACHE clock enable during sleep mode Set and reset by software
$40000000 constant SEC_RCC_RCC_AHB1LPENR_DCACHELPEN                 \ DCACHE clock enable during sleep mode Set and reset by software
$80000000 constant SEC_RCC_RCC_AHB1LPENR_SRAM1LPEN                  \ SRAM1 clock enable during sleep mode Set and reset by software


\
\ @brief RCC AHB2 sleep clock register
\ Address offset: 0xB4
\ Reset value: 0xC01F1DFF
\

$00000001 constant SEC_RCC_RCC_AHB2LPENR_GPIOALPEN                  \ GPIOA clock enable during sleep mode Set and reset by software.
$00000002 constant SEC_RCC_RCC_AHB2LPENR_GPIOBLPEN                  \ GPIOB clock enable during sleep mode Set and reset by software.
$00000004 constant SEC_RCC_RCC_AHB2LPENR_GPIOCLPEN                  \ GPIOC clock enable during sleep mode Set and reset by software.
$00000008 constant SEC_RCC_RCC_AHB2LPENR_GPIODLPEN                  \ GPIOD clock enable during sleep mode Set and reset by software.
$00000010 constant SEC_RCC_RCC_AHB2LPENR_GPIOELPEN                  \ GPIOE clock enable during sleep mode Set and reset by software.
$00000020 constant SEC_RCC_RCC_AHB2LPENR_GPIOFLPEN                  \ GPIOF clock enable during sleep mode Set and reset by software.
$00000040 constant SEC_RCC_RCC_AHB2LPENR_GPIOGLPEN                  \ GPIOG clock enable during sleep mode Set and reset by software.
$00000080 constant SEC_RCC_RCC_AHB2LPENR_GPIOHLPEN                  \ GPIOH clock enable during sleep mode Set and reset by software.
$00000100 constant SEC_RCC_RCC_AHB2LPENR_GPIOILPEN                  \ GPIOI clock enable during sleep mode Set and reset by software.
$00000400 constant SEC_RCC_RCC_AHB2LPENR_ADC12LPEN                  \ ADC1 and 2 peripherals clock enable during sleep mode Set and reset by software.
$00000800 constant SEC_RCC_RCC_AHB2LPENR_DAC12LPEN                  \ DAC clock enable during sleep mode Set and reset by software.
$00001000 constant SEC_RCC_RCC_AHB2LPENR_DCMI_PSSILPEN              \ digital camera interface clock enable during sleep mode (DCMI or PSSI depending which interface is active) Set and reset by software.
$00010000 constant SEC_RCC_RCC_AHB2LPENR_AESLPEN                    \ AES clock enable during sleep mode Set and reset by software.
$00020000 constant SEC_RCC_RCC_AHB2LPENR_HASHLPEN                   \ HASH clock enable during sleep mode Set and reset by software.
$00040000 constant SEC_RCC_RCC_AHB2LPENR_RNGLPEN                    \ RNG clock enable during sleep mode Set and reset by software.
$00080000 constant SEC_RCC_RCC_AHB2LPENR_PKALPEN                    \ PKA clock enable during sleep mode Set and reset by software.
$00100000 constant SEC_RCC_RCC_AHB2LPENR_SAESLPEN                   \ SAES clock enable during sleep mode Set and reset by software.
$40000000 constant SEC_RCC_RCC_AHB2LPENR_SRAM2LPEN                  \ SRAM2 clock enable during sleep mode Set and reset by software.
$80000000 constant SEC_RCC_RCC_AHB2LPENR_SRAM3LPEN                  \ SRAM3 clock enable during sleep mode Set and reset by software.


\
\ @brief RCC AHB4 sleep clock register
\ Address offset: 0xBC
\ Reset value: 0x00111880
\

$00000080 constant SEC_RCC_RCC_AHB4LPENR_OTFDEC1LPEN                \ OTFDEC1 clock enable during sleep mode Set and reset by software.
$00000800 constant SEC_RCC_RCC_AHB4LPENR_SDMMC1LPEN                 \ SDMMC1 and SDMMC1 delay peripheral clock enable during sleep mode Set and reset by software
$00001000 constant SEC_RCC_RCC_AHB4LPENR_SDMMC2LPEN                 \ SDMMC2 and SDMMC2 delay peripheral clock enable during sleep mode Set and reset by software.
$00010000 constant SEC_RCC_RCC_AHB4LPENR_FMCLPEN                    \ FMC clock enable during sleep mode Set and reset by software.
$00100000 constant SEC_RCC_RCC_AHB4LPENR_OCTOSPI1LPEN               \ OCTOSPI1 clock enable during sleep mode Set and reset by software.


\
\ @brief RCC APB1 sleep clock register
\ Address offset: 0xC4
\ Reset value: 0xDFFEC9FF
\

$00000001 constant SEC_RCC_RCC_APB1LLPENR_TIM2LPEN                  \ TIM2 clock enable during sleep mode Set and reset by software.
$00000002 constant SEC_RCC_RCC_APB1LLPENR_TIM3LPEN                  \ TIM3 clock enable during sleep mode Set and reset by software.
$00000004 constant SEC_RCC_RCC_APB1LLPENR_TIM4LPEN                  \ TIM4 clock enable during sleep mode Set and reset by software.
$00000008 constant SEC_RCC_RCC_APB1LLPENR_TIM5LPEN                  \ TIM5 clock enable during sleep mode Set and reset by software.
$00000010 constant SEC_RCC_RCC_APB1LLPENR_TIM6LPEN                  \ TIM6 clock enable during sleep mode Set and reset by software.
$00000020 constant SEC_RCC_RCC_APB1LLPENR_TIM7LPEN                  \ TIM7 clock enable during sleep mode Set and reset by software.
$00000040 constant SEC_RCC_RCC_APB1LLPENR_TIM12LPEN                 \ TIM12 clock enable during sleep mode Set and reset by software.
$00000080 constant SEC_RCC_RCC_APB1LLPENR_TIM13LPEN                 \ TIM13 clock enable during sleep mode Set and reset by software.
$00000100 constant SEC_RCC_RCC_APB1LLPENR_TIM14LPEN                 \ TIM14 clock enable during sleep mode Set and reset by software.
$00000800 constant SEC_RCC_RCC_APB1LLPENR_WWDGLPEN                  \ WWDG clock enable during sleep mode Set and reset by software.
$00004000 constant SEC_RCC_RCC_APB1LLPENR_SPI2LPEN                  \ SPI2 clock enable during sleep mode Set and reset by software.
$00008000 constant SEC_RCC_RCC_APB1LLPENR_SPI3LPEN                  \ SPI3 clock enable during sleep mode Set and reset by software.
$00020000 constant SEC_RCC_RCC_APB1LLPENR_USART2LPEN                \ USART2 clock enable during sleep mode Set and reset by software.
$00040000 constant SEC_RCC_RCC_APB1LLPENR_USART3LPEN                \ USART3 clock enable during sleep mode Set and reset by software.
$00080000 constant SEC_RCC_RCC_APB1LLPENR_UART4LPEN                 \ UART4 clock enable during sleep mode Set and reset by software.
$00100000 constant SEC_RCC_RCC_APB1LLPENR_UART5LPEN                 \ UART5 clock enable during sleep mode Set and reset by software.
$00200000 constant SEC_RCC_RCC_APB1LLPENR_I2C1LPEN                  \ I2C1 clock enable during sleep mode Set and reset by software.
$00400000 constant SEC_RCC_RCC_APB1LLPENR_I2C2LPEN                  \ I2C2 clock enable during sleep mode Set and reset by software.
$00800000 constant SEC_RCC_RCC_APB1LLPENR_I3C1LPEN                  \ I3C1 clock enable during sleep mode Set and reset by software.
$01000000 constant SEC_RCC_RCC_APB1LLPENR_CRSLPEN                   \ CRS clock enable during sleep mode Set and reset by software.
$02000000 constant SEC_RCC_RCC_APB1LLPENR_USART6LPEN                \ USART6 clock enable during sleep mode Set and reset by software.
$04000000 constant SEC_RCC_RCC_APB1LLPENR_USART10LPEN               \ USART10 clock enable during sleep mode Set and reset by software.
$08000000 constant SEC_RCC_RCC_APB1LLPENR_USART11LPEN               \ USART11 clock enable during sleep mode Set and reset by software.
$10000000 constant SEC_RCC_RCC_APB1LLPENR_CECLPEN                   \ HDMI-CEC clock enable during sleep mode Set and reset by software.
$40000000 constant SEC_RCC_RCC_APB1LLPENR_UART7LPEN                 \ UART7 clock enable during sleep mode Set and reset by software.
$80000000 constant SEC_RCC_RCC_APB1LLPENR_UART8LPEN                 \ UART8 clock enable during sleep mode Set and reset by software.


\
\ @brief RCC APB1 sleep clock register
\ Address offset: 0xC8
\ Reset value: 0x4080022B
\

$00000001 constant SEC_RCC_RCC_APB1HLPENR_UART9LPEN                 \ UART9 clock enable during sleep mode Set and reset by software.
$00000002 constant SEC_RCC_RCC_APB1HLPENR_UART12LPEN                \ UART12 clock enable during sleep mode Set and reset by software.
$00000008 constant SEC_RCC_RCC_APB1HLPENR_DTSLPEN                   \ DTS clock enable during sleep mode Set and reset by software.
$00000020 constant SEC_RCC_RCC_APB1HLPENR_LPTIM2LPEN                \ LPTIM2 clock enable during sleep mode Set and reset by software.
$00000200 constant SEC_RCC_RCC_APB1HLPENR_FDCAN12LPEN               \ FDCAN1 and FDCAN2 peripheral clock enable during sleep mode Set and reset by software.
$00800000 constant SEC_RCC_RCC_APB1HLPENR_UCPDLPEN                  \ UCPD clock enable during sleep mode Set and reset by software.


\
\ @brief RCC APB2 sleep clock register
\ Address offset: 0xCC
\ Reset value: 0x017F7800
\

$00000800 constant SEC_RCC_RCC_APB2LPENR_TIM1LPEN                   \ TIM1 clock enable during sleep mode Set and reset by software.
$00001000 constant SEC_RCC_RCC_APB2LPENR_SPI1LPEN                   \ SPI1 clock enable during sleep mode Set and reset by software.
$00002000 constant SEC_RCC_RCC_APB2LPENR_TIM8LPEN                   \ TIM8 clock enable during sleep mode Set and reset by software.
$00004000 constant SEC_RCC_RCC_APB2LPENR_USART1LPEN                 \ USART1 clock enable during sleep mode Set and reset by software.
$00010000 constant SEC_RCC_RCC_APB2LPENR_TIM15LPEN                  \ TIM15 clock enable during sleep mode Set and reset by software.
$00020000 constant SEC_RCC_RCC_APB2LPENR_TIM16LPEN                  \ TIM16 clock enable during sleep mode Set and reset by software.
$00040000 constant SEC_RCC_RCC_APB2LPENR_TIM17LPEN                  \ TIM17 clock enable during sleep mode Set and reset by software.
$00080000 constant SEC_RCC_RCC_APB2LPENR_SPI4LPEN                   \ SPI4 clock enable during sleep mode Set and reset by software.
$00100000 constant SEC_RCC_RCC_APB2LPENR_SPI6LPEN                   \ SPI6 clock enable during sleep mode Set and reset by software.
$00200000 constant SEC_RCC_RCC_APB2LPENR_SAI1LPEN                   \ SAI1 clock enable during sleep mode Set and reset by software.
$00400000 constant SEC_RCC_RCC_APB2LPENR_SAI2LPEN                   \ SAI2 clock enable during sleep mode Set and reset by software.
$01000000 constant SEC_RCC_RCC_APB2LPENR_USBFSLPEN                  \ USBFS clock enable during sleep mode Set and reset by software.


\
\ @brief RCC APB4 sleep clock register
\ Address offset: 0xD0
\ Reset value: 0x0030F9E2
\

$00000002 constant SEC_RCC_RCC_APB3LPENR_SBSLPEN                    \ SBS clock enable during sleep mode Set and reset by software.
$00000020 constant SEC_RCC_RCC_APB3LPENR_SPI5LPEN                   \ SPI5 clock enable during Slsleepeep mode Set and reset by software.
$00000040 constant SEC_RCC_RCC_APB3LPENR_LPUART1LPEN                \ LPUART1 clock enable during sleep mode Set and reset by software.
$00000080 constant SEC_RCC_RCC_APB3LPENR_I2C3LPEN                   \ I2C3 clock enable during sleep mode Set and reset by software.
$00000100 constant SEC_RCC_RCC_APB3LPENR_I2C4LPEN                   \ I2C4 clock enable during sleep mode Set and reset by software.
$00000800 constant SEC_RCC_RCC_APB3LPENR_LPTIM1LPEN                 \ LPTIM1 clock enable during sleep mode Set and reset by software.
$00001000 constant SEC_RCC_RCC_APB3LPENR_LPTIM3LPEN                 \ LPTIM3 clock enable during sleep mode Set and reset by software.
$00002000 constant SEC_RCC_RCC_APB3LPENR_LPTIM4LPEN                 \ LPTIM4 clock enable during sleep mode Set and reset by software.
$00004000 constant SEC_RCC_RCC_APB3LPENR_LPTIM5LPEN                 \ LPTIM5 clock enable during sleep mode Set and reset by software.
$00008000 constant SEC_RCC_RCC_APB3LPENR_LPTIM6LPEN                 \ LPTIM6 clock enable during sleep mode Set and reset by software.
$00100000 constant SEC_RCC_RCC_APB3LPENR_VREFLPEN                   \ VREF clock enable during sleep mode Set and reset by software.
$00200000 constant SEC_RCC_RCC_APB3LPENR_RTCAPBLPEN                 \ RTC APB interface clock enable during sleep mode Set and reset by software.


\
\ @brief RCC kernel clock configuration register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000007 constant SEC_RCC_RCC_CCIPR1_USART1SEL                     \ USART1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000038 constant SEC_RCC_RCC_CCIPR1_USART2SEL                     \ USART2 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$000001c0 constant SEC_RCC_RCC_CCIPR1_USART3SEL                     \ USART3 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000e00 constant SEC_RCC_RCC_CCIPR1_UART4SEL                      \ UART4 kernel clock source selection others: reserved, the kernel clock is disabled
$00007000 constant SEC_RCC_RCC_CCIPR1_UART5SEL                      \ UART5 kernel clock source selection others: reserved, the kernel clock is disabled
$00038000 constant SEC_RCC_RCC_CCIPR1_USART6SEL                     \ USART6 kernel clock source selection others: reserved, the kernel clock is disabled
$001c0000 constant SEC_RCC_RCC_CCIPR1_UART7SEL                      \ UART7 kernel clock source selection others: reserved, the kernel clock is disabled
$00e00000 constant SEC_RCC_RCC_CCIPR1_UART8SEL                      \ UART8 kernel clock source selection others: reserved, the kernel clock is disabled
$07000000 constant SEC_RCC_RCC_CCIPR1_UART9SEL                      \ UART9 kernel clock source selection others: reserved, the kernel clock is disabled
$38000000 constant SEC_RCC_RCC_CCIPR1_USART10SEL                    \ USART10 kernel clock source selection others: reserved, the kernel clock is disabled
$80000000 constant SEC_RCC_RCC_CCIPR1_TIMICSEL                      \ TIM12, TIM15 and LPTIM2 input capture source selection Set and reset by software.


\
\ @brief RCC kernel clock configuration register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000007 constant SEC_RCC_RCC_CCIPR2_USART11SEL                    \ USART11 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000070 constant SEC_RCC_RCC_CCIPR2_USART12SEL                    \ USART12 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000700 constant SEC_RCC_RCC_CCIPR2_LPTIM1SEL                     \ LPTIM1 kernel clock source selection others: reserved, the kernel clock is disabled
$00007000 constant SEC_RCC_RCC_CCIPR2_LPTIM2SEL                     \ LPTIM2 kernel clock source selection others: reserved, the kernel clock is disabled
$00070000 constant SEC_RCC_RCC_CCIPR2_LPTIM3SEL                     \ LPTIM3 kernel clock source selection others: reserved, the kernel clock is disabled
$00700000 constant SEC_RCC_RCC_CCIPR2_LPTIM4SEL                     \ LPTIM4 kernel clock source selection others: reserved, the kernel clock is disabled
$07000000 constant SEC_RCC_RCC_CCIPR2_LPTIM5SEL                     \ LPTIM5 kernel clock source selection others: reserved, the kernel clock is disabled
$70000000 constant SEC_RCC_RCC_CCIPR2_LPTIM6SEL                     \ LPTIM6 kernel clock source selection others: reserved, the kernel clock is disabled


\
\ @brief RCC kernel clock configuration register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000007 constant SEC_RCC_RCC_CCIPR3_SPI1SEL                       \ SPI1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000038 constant SEC_RCC_RCC_CCIPR3_SPI2SEL                       \ SPI2 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$000001c0 constant SEC_RCC_RCC_CCIPR3_SPI3SEL                       \ SPI3 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
$00000e00 constant SEC_RCC_RCC_CCIPR3_SPI4SEL                       \ SPI4 kernel clock source selection others: reserved, the kernel clock is disabled
$00007000 constant SEC_RCC_RCC_CCIPR3_SPI5SEL                       \ SPI5 kernel clock source selection others: reserved, the kernel clock is disabled
$00038000 constant SEC_RCC_RCC_CCIPR3_SPI6SEL                       \ SPI6 kernel clock source selection others: reserved, the kernel clock is disabled
$07000000 constant SEC_RCC_RCC_CCIPR3_LPUART1SEL                    \ LPUART1 kernel clock source selection others: reserved, the kernel clock is disabled


\
\ @brief RCC kernel clock configuration register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000003 constant SEC_RCC_RCC_CCIPR4_OCTOSPI1SEL                   \ OCTOSPI1 kernel clock source selection Set and reset by software.
$0000000c constant SEC_RCC_RCC_CCIPR4_SYSTICKSEL                    \ SYSTICK clock source selection Note: rcc_hclk frequency must be four times higher than lsi_ker_ck/lse_ck (period (LSI/LSE) greater than or equal 4 * period (HCLK).
$00000030 constant SEC_RCC_RCC_CCIPR4_USBFSSEL                      \ USBFS kernel clock source selection
$00000040 constant SEC_RCC_RCC_CCIPR4_SDMMC1SEL                     \ SDMMC1 kernel clock source selection
$00000080 constant SEC_RCC_RCC_CCIPR4_SDMMC2SEL                     \ SDMMC2 kernel clock source selection
$00030000 constant SEC_RCC_RCC_CCIPR4_I2C1SEL                       \ I2C1 kernel clock source selection
$000c0000 constant SEC_RCC_RCC_CCIPR4_I2C2SEL                       \ I2C2 kernel clock source selection
$00300000 constant SEC_RCC_RCC_CCIPR4_I2C3SEL                       \ I2C3 kernel clock source selection
$00c00000 constant SEC_RCC_RCC_CCIPR4_I2C4SEL                       \ I2C4 kernel clock source selection
$03000000 constant SEC_RCC_RCC_CCIPR4_I3C1SEL                       \ I3C1 kernel clock source selection


\
\ @brief RCC kernel clock configuration register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000007 constant SEC_RCC_RCC_CCIPR5_ADCDACSEL                     \ ADC and DAC kernel clock source selection others: reserved, the kernel clock is disabled
$00000008 constant SEC_RCC_RCC_CCIPR5_DACSEL                        \ DAC hold clock
$00000030 constant SEC_RCC_RCC_CCIPR5_RNGSEL                        \ RNG kernel clock source selection
$000000c0 constant SEC_RCC_RCC_CCIPR5_CECSEL                        \ HSMI-CEC kernel clock source selection
$00000300 constant SEC_RCC_RCC_CCIPR5_FDCAN12SEL                    \ FDCAN1 and FDCAN2 kernel clock source selection
$00070000 constant SEC_RCC_RCC_CCIPR5_SAI1SEL                       \ SAI1 kernel clock source selection others: reserved, the kernel clock is disabled
$00380000 constant SEC_RCC_RCC_CCIPR5_SAI2SEL                       \ SAI2 kernel clock source selection others: reserved, the kernel clock is disabled
$c0000000 constant SEC_RCC_RCC_CCIPR5_CKPERSEL                      \ per_ck clock source selection


\
\ @brief RCC Backup domain control register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_RCC_BDCR_LSEON                           \ LSE oscillator enabled Set and reset by software.
$00000002 constant SEC_RCC_RCC_BDCR_LSERDY                          \ LSE oscillator ready Set and reset by hardware to indicate when the LSE is stable. This bit needs 6 cycles of lse_ck clock to fall down after LSEON has been set to 0.
$00000004 constant SEC_RCC_RCC_BDCR_LSEBYP                          \ LSE oscillator bypass Set and reset by software to bypass oscillator in debug mode. This bit must not be written when the LSE is enabled (by LSEON) or ready (LSERDY = 1)
$00000018 constant SEC_RCC_RCC_BDCR_LSEDRV                          \ LSE oscillator driving capability Set by software to select the driving capability of the LSE oscillator. These bit can be written only if LSE oscillator is disabled (LSEON = 0 and LSERDY = 0).
$00000020 constant SEC_RCC_RCC_BDCR_LSECSSON                        \ LSE clock security system enable Set by software to enable the clock security system on 32 kHz oscillator. LSECSSON must be enabled after LSE is enabled (LSEON enabled) and ready (LSERDY set by hardware) and after RTCSEL is selected. Once enabled, this bit cannot be disabled, except after a LSE failure detection (LSECSSD = 1). In that case the software must disable LSECSSON.
$00000040 constant SEC_RCC_RCC_BDCR_LSECSSD                         \ LSE clock security system failure detection Set by hardware to indicate when a failure has been detected by the clock security system on the external 32 kHz oscillator.
$00000080 constant SEC_RCC_RCC_BDCR_LSEEXT                          \ low-speed external clock type in bypass mode Set and reset by software to select the external clock type (analog or digital). The external clock must be enabled with the LSEON bit, to be used by the device. The LSEEXT bit can be written only if the LSE oscillator is disabled.
$00000300 constant SEC_RCC_RCC_BDCR_RTCSEL                          \ RTC clock source selection Set by software to select the clock source for the RTC. These bits can be written only one time (except in case of failure detection on LSE). These bits must be written before LSECSSON is enabled. The VSWRST bit can be used to reset them, then it can be written one time again. If HSE is selected as RTC clock, this clock is lost when the system is in Stop mode or in case of a pin reset (NRST).
$00008000 constant SEC_RCC_RCC_BDCR_RTCEN                           \ RTC clock enable Set and reset by software.
$00010000 constant SEC_RCC_RCC_BDCR_VSWRST                          \ VSwitch domain software reset Set and reset by software.
$01000000 constant SEC_RCC_RCC_BDCR_LSCOEN                          \ Low-speed clock output (LSCO) enable Set and cleared by software.
$02000000 constant SEC_RCC_RCC_BDCR_LSCOSEL                         \ Low-speed clock output selection Set and cleared by software.
$04000000 constant SEC_RCC_RCC_BDCR_LSION                           \ LSI oscillator enable Set and cleared by software.
$08000000 constant SEC_RCC_RCC_BDCR_LSIRDY                          \ LSI oscillator ready Set and cleared by hardware to indicate when the LSI oscillator is stable. After the LSION bit is cleared, LSIRDY goes low after three internal low-speed oscillator clock cycles. This bit is set when the LSI is used by IWDG or RTC, even if LSION = 0.


\
\ @brief RCC reset status register
\ Address offset: 0xF4
\ Reset value: 0x0C000000
\

$00800000 constant SEC_RCC_RCC_RSR_RMVF                             \ remove reset flag Set and reset by software to reset the value of the reset flags.
$04000000 constant SEC_RCC_RCC_RSR_PINRSTF                          \ pin reset flag (NRST) Reset by software by writing the RMVF bit. Set by hardware when a reset from pin occurs.
$08000000 constant SEC_RCC_RCC_RSR_BORRSTF                          \ BOR reset flag Reset by software by writing the RMVF bit. Set by hardware when a BOR reset occurs (pwr_bor_rst).
$10000000 constant SEC_RCC_RCC_RSR_SFTRSTF                          \ system reset from CPU reset flag Reset by software by writing the RMVF bit. Set by hardware when the system reset is due to CPU.The CPU can generate a system reset by writing SYSRESETREQ bit of AIRCR register of the core M33.
$20000000 constant SEC_RCC_RCC_RSR_IWDGRSTF                         \ independent watchdog reset flag Reset by software by writing the RMVF bit. Set by hardware when an independent watchdog reset occurs.
$40000000 constant SEC_RCC_RCC_RSR_WWDGRSTF                         \ window watchdog reset flag Reset by software by writing the RMVF bit. Set by hardware when a window watchdog reset occurs.
$80000000 constant SEC_RCC_RCC_RSR_LPWRRSTF                         \ Low-power reset flag Set by hardware when a reset occurs due to Stop or Standby mode entry, whereas the corresponding nRST_STOP, nRST_STBY option bit is cleared. Cleared by writing to the RMVF bit.


\
\ @brief RCC secure configuration register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_RCC_SECCFGR_HSISEC                       \ HSI clock configuration and status bits security Set and reset by software.
$00000002 constant SEC_RCC_RCC_SECCFGR_HSESEC                       \ HSE clock configuration bits, status bits and HSE_CSS security Set and reset by software.
$00000004 constant SEC_RCC_RCC_SECCFGR_CSISEC                       \ CSI clock configuration and status bits security Set and reset by software.
$00000008 constant SEC_RCC_RCC_SECCFGR_LSISEC                       \ LSI clock configuration and status bits security Set and reset by software.
$00000010 constant SEC_RCC_RCC_SECCFGR_LSESEC                       \ LSE clock configuration and status bits security Set and reset by software.
$00000020 constant SEC_RCC_RCC_SECCFGR_SYSCLKSEC                    \ SYSCLK clock selection, STOPWUCK bit, clock output on MCO configuration security Set and reset by software.
$00000040 constant SEC_RCC_RCC_SECCFGR_PRESCSEC                     \ AHBx/APBx prescaler configuration bits security Set and reset by software.
$00000080 constant SEC_RCC_RCC_SECCFGR_PLL1SEC                      \ PLL1 clock configuration and status bits security Set and reset by software.
$00000100 constant SEC_RCC_RCC_SECCFGR_PLL2SEC                      \ PLL2 clock configuration and status bits security Set and reset by software.
$00000200 constant SEC_RCC_RCC_SECCFGR_PLL3SEC                      \ PLL3 clock configuration and status bits security Set and reset by software.
$00000800 constant SEC_RCC_RCC_SECCFGR_HSI48SEC                     \ HSI48 clock configuration and status bits security Set and reset by software.
$00001000 constant SEC_RCC_RCC_SECCFGR_RMVFSEC                      \ Remove reset flag security Set and reset by software.
$00002000 constant SEC_RCC_RCC_SECCFGR_CKPERSELSEC                  \ per_ck selection security Set and reset by software.


\
\ @brief RCC privilege configuration register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_RCC_PRIVCFGR_SPRIV                       \ RCC secure functions privilege configuration Set and reset by software. This bit can be written only by a secure privileged access.
$00000002 constant SEC_RCC_RCC_PRIVCFGR_NSPRIV                      \ RCC non-secure functions privilege configuration Set and reset by software. This bit can be written only by privileged access, secure or non-secure.


\
\ @brief Reset and clock controller
\
$54020c00 constant SEC_RCC_RCC_CR  \ offset: 0x00 : RCC clock control register
$54020c10 constant SEC_RCC_RCC_HSICFGR  \ offset: 0x10 : RCC HSI calibration register
$54020c14 constant SEC_RCC_RCC_CRRCR  \ offset: 0x14 : RCC clock recovery RC register
$54020c18 constant SEC_RCC_RCC_CSICFGR  \ offset: 0x18 : RCC CSI calibration register
$54020c1c constant SEC_RCC_RCC_CFGR1  \ offset: 0x1C : RCC clock configuration register
$54020c20 constant SEC_RCC_RCC_CFGR2  \ offset: 0x20 : RCC CPU domain clock configuration register 2
$54020c28 constant SEC_RCC_RCC_PLL1CFGR  \ offset: 0x28 : RCC PLL clock source selection register
$54020c2c constant SEC_RCC_RCC_PLL2CFGR  \ offset: 0x2C : RCC PLL clock source selection register
$54020c30 constant SEC_RCC_RCC_PLL3CFGR  \ offset: 0x30 : RCC PLL clock source selection register
$54020c34 constant SEC_RCC_RCC_PLL1DIVR  \ offset: 0x34 : RCC PLL1 dividers register
$54020c38 constant SEC_RCC_RCC_PLL1FRACR  \ offset: 0x38 : RCC PLL1 fractional divider register
$54020c3c constant SEC_RCC_RCC_PLL2DIVR  \ offset: 0x3C : RCC PLL1 dividers register
$54020c40 constant SEC_RCC_RCC_PLL2FRACR  \ offset: 0x40 : RCC PLL2 fractional divider register
$54020c44 constant SEC_RCC_RCC_PLL3DIVR  \ offset: 0x44 : RCC PLL3 dividers register
$54020c48 constant SEC_RCC_RCC_PLL3FRACR  \ offset: 0x48 : RCC PLL3 fractional divider register
$54020c50 constant SEC_RCC_RCC_CIER  \ offset: 0x50 : RCC clock source interrupt enable register
$54020c54 constant SEC_RCC_RCC_CIFR  \ offset: 0x54 : RCC clock source interrupt flag register
$54020c58 constant SEC_RCC_RCC_CICR  \ offset: 0x58 : RCC clock source interrupt clear register
$54020c60 constant SEC_RCC_RCC_AHB1RSTR  \ offset: 0x60 : RCC AHB1 reset register
$54020c64 constant SEC_RCC_RCC_AHB2RSTR  \ offset: 0x64 : RCC AHB2 peripheral reset register
$54020c6c constant SEC_RCC_RCC_AHB4RSTR  \ offset: 0x6C : RCC AHB4 peripheral reset register
$54020c74 constant SEC_RCC_RCC_APB1LRSTR  \ offset: 0x74 : RCC APB1 peripheral low reset register
$54020c78 constant SEC_RCC_RCC_APB1HRSTR  \ offset: 0x78 : RCC APB1 peripheral high reset register
$54020c7c constant SEC_RCC_RCC_APB2RSTR  \ offset: 0x7C : RCC APB2 peripheral reset register
$54020c80 constant SEC_RCC_RCC_APB3RSTR  \ offset: 0x80 : RCC APB4 peripheral reset register
$54020c88 constant SEC_RCC_RCC_AHB1ENR  \ offset: 0x88 : RCC AHB1 peripherals clock register
$54020c8c constant SEC_RCC_RCC_AHB2ENR  \ offset: 0x8C : RCC AHB2 peripheral clock register
$54020c94 constant SEC_RCC_RCC_AHB4ENR  \ offset: 0x94 : RCC AHB4 peripheral clock register
$54020c9c constant SEC_RCC_RCC_APB1LENR  \ offset: 0x9C : RCC APB1 peripheral clock register
$54020ca0 constant SEC_RCC_RCC_APB1HENR  \ offset: 0xA0 : RCC APB1 peripheral clock register
$54020ca4 constant SEC_RCC_RCC_APB2ENR  \ offset: 0xA4 : RCC APB2 peripheral clock register
$54020ca8 constant SEC_RCC_RCC_APB3ENR  \ offset: 0xA8 : RCC APB4 peripheral clock register
$54020cb0 constant SEC_RCC_RCC_AHB1LPENR  \ offset: 0xB0 : RCC AHB1 sleep clock register
$54020cb4 constant SEC_RCC_RCC_AHB2LPENR  \ offset: 0xB4 : RCC AHB2 sleep clock register
$54020cbc constant SEC_RCC_RCC_AHB4LPENR  \ offset: 0xBC : RCC AHB4 sleep clock register
$54020cc4 constant SEC_RCC_RCC_APB1LLPENR  \ offset: 0xC4 : RCC APB1 sleep clock register
$54020cc8 constant SEC_RCC_RCC_APB1HLPENR  \ offset: 0xC8 : RCC APB1 sleep clock register
$54020ccc constant SEC_RCC_RCC_APB2LPENR  \ offset: 0xCC : RCC APB2 sleep clock register
$54020cd0 constant SEC_RCC_RCC_APB3LPENR  \ offset: 0xD0 : RCC APB4 sleep clock register
$54020cd8 constant SEC_RCC_RCC_CCIPR1  \ offset: 0xD8 : RCC kernel clock configuration register
$54020cdc constant SEC_RCC_RCC_CCIPR2  \ offset: 0xDC : RCC kernel clock configuration register
$54020ce0 constant SEC_RCC_RCC_CCIPR3  \ offset: 0xE0 : RCC kernel clock configuration register
$54020ce4 constant SEC_RCC_RCC_CCIPR4  \ offset: 0xE4 : RCC kernel clock configuration register
$54020ce8 constant SEC_RCC_RCC_CCIPR5  \ offset: 0xE8 : RCC kernel clock configuration register
$54020cf0 constant SEC_RCC_RCC_BDCR  \ offset: 0xF0 : RCC Backup domain control register
$54020cf4 constant SEC_RCC_RCC_RSR  \ offset: 0xF4 : RCC reset status register
$54020d10 constant SEC_RCC_RCC_SECCFGR  \ offset: 0x110 : RCC secure configuration register
$54020d14 constant SEC_RCC_RCC_PRIVCFGR  \ offset: 0x114 : RCC privilege configuration register

