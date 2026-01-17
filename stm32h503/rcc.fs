\
\ @file rcc.fs
\ @brief Reset and clock controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RCC_DEF

  [ifdef] RCC_RCC_CR_DEF
    \
    \ @brief RCC clock control register
    \ Address offset: 0x00
    \ Reset value: 0x00000023
    \
    $00 constant RCC_HSION                      \ [0x00] HSI clock enable Set and cleared by software. Set by hardware to force the HSI to ON when the product leaves Stop mode, if STOPWUCK = 1 or STOPKERWUCK = 1. Set by hardware to force the HSI to ON when the product leaves Standby mode or in case of a failure of the HSE which is used as the system clock source. This bit cannot be cleared if the HSI is used directly (via SW mux) as system clock, or if the HSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
    $01 constant RCC_HSIRDY                     \ [0x01] HSI clock ready flag Set by hardware to indicate that the HSI oscillator is stable.
    $02 constant RCC_HSIKERON                   \ [0x02] HSI clock enable in Stop mode Set and reset by software to force the HSI to ON, even in Stop mode, in order to be quickly available as kernel clock for peripherals. This bit has no effect on the value of HSION.
    $03 constant RCC_HSIDIV                     \ [0x03 : 2] HSI clock divider Set and reset by software. These bits allow selecting a division ratio in order to configure the wanted HSI clock frequency. The HSIDIV cannot be changed if the HSI is selected as reference clock for at least one enabled PLL (PLLxON bit set to 1). In that case, the new HSIDIV value is ignored.
    $05 constant RCC_HSIDIVF                    \ [0x05] HSI divider flag Set and reset by hardware. As a write operation to HSIDIV has not an immediate effect on the frequency, this flag indicates the current status of the HSI divider. HSIDIVF goes immediately to 0 when HSIDIV value is changed, and is set back to 1 when the output frequency matches the value programmed into HSIDIV.
    $08 constant RCC_CSION                      \ [0x08] CSI clock enable Set and reset by software to enable/disable CSI clock for system and/or peripheral. Set by hardware to force the CSI to ON when the system leaves Stop mode, if STOPWUCK = 1 or STOPKERWUCK = 1. This bit cannot be cleared if the CSI is used directly (via SW mux) as system clock, or if the CSI is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
    $09 constant RCC_CSIRDY                     \ [0x09] CSI clock ready flag Set by hardware to indicate that the CSI oscillator is stable. This bit is activated only if the RC is enabled by CSION (it is not activated if the CSI is enabled by CSIKERON or by a peripheral request).
    $0a constant RCC_CSIKERON                   \ [0x0a] CSI clock enable in Stop mode Set and reset by software to force the CSI to ON, even in Stop mode, in order to be quickly available as kernel clock for some peripherals. This bit has no effect on the value of CSION.
    $0c constant RCC_HSI48ON                    \ [0x0c] HSI48 clock enable Set by software and cleared by software or by the hardware when the system enters to Stop or Standby mode.
    $0d constant RCC_HSI48RDY                   \ [0x0d] HSI48 clock ready flag Set by hardware to indicate that the HSI48 oscillator is stable.
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable Set and cleared by software. Cleared by hardware to stop the HSE when entering Stop or Standby mode. This bit cannot be cleared if the HSE is used directly (via SW mux) as system clock, or if the HSE is selected as reference clock for PLL1 with PLL1 enabled (PLL1ON bit set to 1).
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable.
    $12 constant RCC_HSEBYP                     \ [0x12] HSE clock bypass Set and cleared by software to bypass the oscillator with an external clock. The external clock must be enabled with the HSEON bit to be used by the device. The HSEBYP bit can be written only if the HSE oscillator is disabled.
    $13 constant RCC_HSECSSON                   \ [0x13] HSE clock security system enable Set by software to enable clock security system on HSE. This bit is 'set only' (disabled by a system reset or when the system enters in Standby mode). When HSECSSON is set, the clock detector is enabled by hardware when the HSE is ready and disabled by hardware if an oscillator failure is detected.
    $14 constant RCC_HSEEXT                     \ [0x14] external high speed clock type in Bypass mode Set and reset by software to select the external clock type (analog or digital). The external clock must be enabled with the HSEON bit to be used by the device. The HSEEXT bit can be written only if the HSE oscillator is disabled.
    $18 constant RCC_PLL1ON                     \ [0x18] PLL1 enable Set and cleared by software to enable PLL1. Cleared by hardware when entering Stop or Standby mode. Note that the hardware prevents writing this bit to 0, if the PLL1 output is used as the system clock.
    $19 constant RCC_PLL1RDY                    \ [0x19] PLL1 clock ready flag Set by hardware to indicate that the PLL1 is locked.
    $1a constant RCC_PLL2ON                     \ [0x1a] PLL2 enable Set and cleared by software to enable PLL2. Cleared by hardware when entering Stop or Standby mode.
    $1b constant RCC_PLL2RDY                    \ [0x1b] PLL2 clock ready flag Set by hardware to indicate that the PLL is locked.
  [then]


  [ifdef] RCC_RCC_HSICFGR_DEF
    \
    \ @brief RCC HSI calibration register
    \ Address offset: 0x10
    \ Reset value: 0x00400000
    \
    $00 constant RCC_HSICAL                     \ [0x00 : 12] HSI clock calibration Set by hardware by option byte loading during system reset nreset. Adjusted by software through trimming bits HSITRIM. This field represents the sum of engineering option byte calibration value and HSITRIM bits value.
    $10 constant RCC_HSITRIM                    \ [0x10 : 7] HSI clock trimming Set by software to adjust calibration. HSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_HSI_OPT) in order to form the calibration trimming value. HSICAL = HSITRIM + FLASH_HSI_OPT. After a change of HSITRIM it takes one system clock cycle before the new HSITRIM value is updated Note: The reset value of the field is 0x40.
  [then]


  [ifdef] RCC_RCC_CRRCR_DEF
    \
    \ @brief RCC clock recovery RC register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSI48CAL                   \ [0x00 : 10] Internal RC 48 MHz clock calibration Set by hardware by option-byte loading during system reset NRESET. Read-only.
  [then]


  [ifdef] RCC_RCC_CSICFGR_DEF
    \
    \ @brief RCC CSI calibration register
    \ Address offset: 0x18
    \ Reset value: 0x00200000
    \
    $00 constant RCC_CSICAL                     \ [0x00 : 8] CSI clock calibration Set by hardware by option byte loading during system reset NRESET. Adjusted by software through trimming bits CSITRIM. This field represents the sum of engineering option byte calibration value and CSITRIM bits value.
    $10 constant RCC_CSITRIM                    \ [0x10 : 6] CSI clock trimming Set by software to adjust calibration. CSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_CSI_OPT) in order to form the calibration trimming value. CSICAL = CSITRIM + FLASH_CSI_OPT. Note: The reset value of the field is 0x20.
  [then]


  [ifdef] RCC_RCC_CFGR1_DEF
    \
    \ @brief RCC clock configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW                         \ [0x00 : 3] system clock and trace clock switch Set and reset by software to select system clock and trace clock sources (sys_ck). Set by hardware in order to: - force the selection of the HSI or CSI (depending on STOPWUCK selection) when leaving a system Stop mode - force the selection of the HSI in case of failure of the HSE when used directly or indirectly as system clock others: reserved
    $03 constant RCC_SWS                        \ [0x03 : 3] system clock switch status Set and reset by hardware to indicate which clock source is used as system clock. 000: HSI used as system clock (hsi_ck) (default after reset). others: reserved
    $06 constant RCC_STOPWUCK                   \ [0x06] system clock selection after a wakeup from system Stop Set and reset by software to select the system wakeup clock from system Stop. The selected clock is also used as emergency clock for the clock security system (CSS) on HSE. 0: HSI selected as wakeup clock from system Stop (default after reset) STOPWUCK must not be modified when CSS is enabled (by HSECSSON bit) and the system clock is HSE (SWS = 10) or a switch on HSE is requested (SW =10).
    $07 constant RCC_STOPKERWUCK                \ [0x07] kernel clock selection after a wakeup from system Stop Set and reset by software to select the kernel wakeup clock from system Stop.
    $08 constant RCC_RTCPRE                     \ [0x08 : 6] HSE division factor for RTC clock Set and cleared by software to divide the HSE to generate a clock for RTC. Caution: The software must set these bits correctly to ensure that the clock supplied to the RTC is lower than 1 MHz. These bits must be configured if needed before selecting the RTC clock source. ...
    $0f constant RCC_TIMPRE                     \ [0x0f] timers clocks prescaler selection This bit is set and reset by software to control the clock frequency of all the timers connected to APB1 and APB2 domains.
    $12 constant RCC_MCO1PRE                    \ [0x12 : 4] MCO1 prescaler Set and cleared by software to configure the prescaler of the MCO1. Modification of this prescaler may generate glitches on MCO1. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. ...
    $16 constant RCC_MCO1SEL                    \ [0x16 : 3] Microcontroller clock output 1 Set and cleared by software. Clock source selection may generate glitches on MCO1. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved
    $19 constant RCC_MCO2PRE                    \ [0x19 : 4] MCO2 prescaler Set and cleared by software to configure the prescaler of the MCO2. Modification of this prescaler may generate glitches on MCO2. It is highly recommended to change this prescaler only after reset, before enabling the external oscillators and the PLLs. ...
    $1d constant RCC_MCO2SEL                    \ [0x1d : 3] microcontroller clock output 2 Set and cleared by software. Clock source selection may generate glitches on MCO2. It is highly recommended to configure these bits only after reset, before enabling the external oscillators and the PLLs. others: reserved
  [then]


  [ifdef] RCC_RCC_CFGR2_DEF
    \
    \ @brief RCC CPU domain clock configuration register 2
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPRE                       \ [0x00 : 4] AHB prescaler Set and reset by software to control the division factor of rcc_hclk. Changing this division ratio has an impact on the frequency of all bus matrix clocks 0xxx: rcc_hclk = sys_ck (default after reset)
    $04 constant RCC_PPRE1                      \ [0x04 : 3] APB low-speed prescaler (APB1) Set and reset by software to control the division factor of rcc_pclk1. The clock is divided by the new prescaler factor from 1 to 16 cycles of rcc_hclk after PPRE write. 0xx: rcc_pclk1 = rcc_hclk1 (default after reset)
    $08 constant RCC_PPRE2                      \ [0x08 : 3] APB high-speed prescaler (APB2) Set and reset by software to control APB high-speed clocks division factor. The clocks are divided with the new prescaler factor from 1 to 16 APB cycles after PPRE2 write. 0xx: rcc_pclk2 = rcc_hclk1
    $0c constant RCC_PPRE3                      \ [0x0c : 3] APB low-speed prescaler (APB3) Set and reset by software to control APB low-speed clocks division factor. The clocks are divided with the new prescaler factor from 1 to 16 APB cycles after PPRE3 write. 0xx: rcc_pclk3 = rcc_hclk1
    $10 constant RCC_AHB1DIS                    \ [0x10] AHB1 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB1 peripherals from RCC_AHB1ENR are used and when their clocks are disabled in RCC_AHB1ENR. When this bit is set, all the AHB1 peripherals clocks from RCC_AHB1ENR are off. enable control bits
    $11 constant RCC_AHB2DIS                    \ [0x11] AHB2 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB2 peripherals from RCC_AHB2ENR are used and when their clocks are disabled in RCC_AHB2ENR. When this bit is set, all the AHB2 peripherals clocks from RCC_AHB2ENR are off. enable control bits
    $13 constant RCC_AHB4DIS                    \ [0x13] AHB4 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB4 peripherals from RCC_AHB4ENR are used and when their clocks are disabled in RCC_AHB4ENR. When this bit is set, all the AHB4 peripherals clocks from RCC_AHB4ENR are off. enable control bits
    $14 constant RCC_APB1DIS                    \ [0x14] APB1 clock disable value This bit can be set in order to further reduce power consumption, when none of the APB1 peripherals (except IWDG) are used and when their clocks are disabled in RCC_APB1ENR. When this bit is set, all the APB1 peripherals clocks are off, except for IWDG. control bits
    $15 constant RCC_APB2DIS                    \ [0x15] APB2 clock disable value This bit can be set in order to further reduce power consumption, when none of the APB2 peripherals are used and when their clocks are disabled in RCC_APB2ENR. When this bit is set, all the APB2 peripherals clocks are off. control bits
    $16 constant RCC_APB3DIS                    \ [0x16] APB3 clock disable value.Set and cleared by software This bit can be set in order to further reduce power consumption, when none of the APB3 peripherals are used and when their clocks are disabled in RCC_APB3ENR. When this bit is set, all the APB3 peripherals clocks are off. control bits
  [then]


  [ifdef] RCC_RCC_PLL1CFGR_DEF
    \
    \ @brief RCC PLL clock source selection register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL1SRC                    \ [0x00 : 2] DIVMx and PLLs clock source selection Set and reset by software to select the PLL clock source. These bits can be written only when all PLLs are disabled. In order to save power, when no PLL is used, the value of PLL1SRC must be set to '00'. 00: no clock send to DIVMx divider and PLLs (default after reset).
    $02 constant RCC_PLL1RGE                    \ [0x02 : 2] PLL1 input frequency range Set and reset by software to select the proper reference frequency range used for PLL1. This bit must be written before enabling the PLL1.
    $04 constant RCC_PLL1FRACEN                 \ [0x04] PLL1 fractional latch enable Set and reset by software to latch the content of FRACN1 into the sigma-delta modulator. In order to latch the FRACN1 value into the sigma-delta modulator, PLL1FRACEN must be set to 0, then set to 1. The transition 0 to 1 transfers the content of FRACN1 into the modulator.
    $05 constant RCC_PLL1VCOSEL                 \ [0x05] PLL1 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL1. This bit must be written before enabling the PLL1.
    $08 constant RCC_PLL1M                      \ [0x08 : 6] prescaler for PLL1 Set and cleared by software to configure the prescaler of the PLL1. The hardware does not allow any modification of this prescaler when PLL1 is enabled (PLL1ON = 1 or PLL1RDY = 1). In order to save power when PLL1 is not used, the value of DIVM1 must be set to 0. ... ...
    $10 constant RCC_PLL1PEN                    \ [0x10] PLL1 DIVP divider output enable Set and reset by software to enable the pll1_p_ck output of the PLL1. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). In order to save power, when the pll1_p_ck output of the PLL1 is not used, the pll1_p_ck must be disabled.
    $11 constant RCC_PLL1QEN                    \ [0x11] PLL1 DIVQ divider output enable Set and reset by software to enable the pll1_q_ck output of the PLL1. In order to save power, when the pll1_q_ck output of the PLL1 is not used, the pll1_q_ck must be disabled. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).
    $12 constant RCC_PLL1REN                    \ [0x12] PLL1 DIVR divider output enable Set and reset by software to enable the pll1_r_ck output of the PLL1. To save power, DIVR1EN and DIVR1 bits must be set to 0 when the pll1_r_ck is not used. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).
  [then]


  [ifdef] RCC_RCC_PLL2CFGR_DEF
    \
    \ @brief RCC PLL clock source selection register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL2SRC                    \ [0x00 : 2] DIVMx and PLLs clock source selection Set and reset by software to select the PLL clock source. These bits can be written only when all PLLs are disabled. In order to save power, when no PLL is used, the value of PLL2SRC must be set to '00'.
    $02 constant RCC_PLL2RGE                    \ [0x02 : 2] PLL2 input frequency range Set and reset by software to select the proper reference frequency range used for PLL2. These bits must be written before enabling the PLL2.
    $04 constant RCC_PLL2FRACEN                 \ [0x04] PLL2 fractional latch enable Set and reset by software to enable the pll2_p_ck output of the PLL2. To save power, when the pll2_p_ck output of the PLL2 is not used, the pll2_p_ck must be disabled.
    $05 constant RCC_PLL2VCOSEL                 \ [0x05] PLL2 VCO selection Set and reset by software to select the proper VCO frequency range used for PLL2. This bit must be written before enabling the PLL2.
    $08 constant RCC_PLL2M                      \ [0x08 : 6] prescaler for PLL2 Set and cleared by software to configure the prescaler of the PLL2. The hardware does not allow any modification of this prescaler when PLL2 is enabled (PLL2ON = 1 or PLL2RDY = 1). In order to save power when PLL2 is not used, the value of DIVM2 must be set to 0. ... ...
    $10 constant RCC_PLL2PEN                    \ [0x10] PLL2 DIVP divider output enable Set and reset by software to enable the pll2_p_ck output of the PLL2. To save power, when the pll2_p_ck output of the PLL2 is not used, the pll2_p_ck must be disabled.
    $11 constant RCC_PLL2QEN                    \ [0x11] PLL2 DIVQ divider output enable Set and reset by software to enable the pll2_q_ck output of the PLL2. To save power, when the pll2_q_ck output of the PLL2 is not used, the pll2_q_ck must be disabled.
    $12 constant RCC_PLL2REN                    \ [0x12] PLL2 DIVR divider output enable Set and reset by software to enable the pll2_r_ck output of the PLL2. To save power, DIVR2EN and DIVR2 bits must be set to 0 when the pll2_r_ck is not used.
  [then]


  [ifdef] RCC_RCC_PLL1DIVR_DEF
    \
    \ @brief RCC PLL1 dividers register
    \ Address offset: 0x34
    \ Reset value: 0x01010280
    \
    $00 constant RCC_PLL1N                      \ [0x00 : 9] Multiplication factor for PLL1VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL1ON = 0 and PLL1RDY = 0). ... ... Others: reserved
    $09 constant RCC_PLL1P                      \ [0x09 : 7] PLL1 DIVP division factor Set and reset by software to control the frequency of the pll1_p_ck clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). Note that odd division factors are not allowed. ...
    $10 constant RCC_PLL1Q                      \ [0x10 : 7] PLL1 DIVQ division factor Set and reset by software to control the frequency of the pll1_q_ck clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
    $18 constant RCC_PLL1R                      \ [0x18 : 7] PLL1 DIVR division factor Set and reset by software to control the frequency of the pll1_r_ck clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
  [then]


  [ifdef] RCC_RCC_PLL1FRACR_DEF
    \
    \ @brief RCC PLL1 fractional divider register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $03 constant RCC_PLL1FRACN                  \ [0x03 : 13] fractional part of the multiplication factor for PLL1 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: * 128 to 560 MHz if PLL1VCOSEL = 0 * 150 to 420 MHz if PLL1VCOSEL = 1 VCO output frequency = Fref1_ck x (PLL1N + (PLL1FRACN / 213)), with * PLL1N between 8 and 420 * PLL1FRACN can be between 0 and 213- 1 * The input frequency Fref1_ck must be between 1 and 16 MHz. To change the PLL1FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: * Set the bit PLL1FRACEN to 0 * Write the new fractional value into PLL1FRACN * Set the bit PLL1FRACEN to 1
  [then]


  [ifdef] RCC_RCC_PLL2DIVR_DEF
    \
    \ @brief RCC PLL1 dividers register
    \ Address offset: 0x3C
    \ Reset value: 0x01010280
    \
    $00 constant RCC_PLL2N                      \ [0x00 : 9] Multiplication factor for PLL2VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled (PLL2ON = 0 and PLL2RDY = 0). ... ... Others: reserved
    $09 constant RCC_PLL2P                      \ [0x09 : 7] PLL2 DIVP division factor Set and reset by software to control the frequency of the pll2_p_ck clock. These bits can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...
    $10 constant RCC_PLL2Q                      \ [0x10 : 7] PLL2 DIVQ division factor Set and reset by software to control the frequency of the pll2_q_ck clock. These bits can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...
    $18 constant RCC_PLL2R                      \ [0x18 : 7] PLL2 DIVR division factor Set and reset by software to control the frequency of the pll2_r_ck clock. These bits can be written only when the PLL1 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...
  [then]


  [ifdef] RCC_RCC_PLL2FRACR_DEF
    \
    \ @brief RCC PLL2 fractional divider register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $03 constant RCC_PLL2FRACN                  \ [0x03 : 13] fractional part of the multiplication factor for PLL2 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. The software must set correctly these bits to insure that the VCO output frequency is between its valid frequency range, that is: * 128 to 560 MHz if PLL2VCOSEL = 0 * 150 to 420 MHz if PLL2VCOSEL = 1 VCO output frequency = Fref2_ck x (PLL2N + (PLL2FRACN / 213)), with * PLL2N between 8 and 420 * PLL2FRACN can be between 0 and 213- 1 * The input frequency Fref2_ck must be between 1 and 16 MHz. To change the PLL2FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: * Set the bit PLL2FRACEN to 0 * Write the new fractional value into PLL2FRACN * Set the bit PLL2FRACEN to 1
  [then]


  [ifdef] RCC_RCC_CIER_DEF
    \
    \ @brief RCC clock source interrupt enable register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the LSI oscillator stabilization.
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready interrupt enable Set and reset by software to enable/disable interrupt caused by the LSE oscillator stabilization.
    $02 constant RCC_CSIRDYIE                   \ [0x02] CSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the CSI oscillator stabilization.
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI ready interrupt enable Set and reset by software to enable/disable interrupt caused by the HSI oscillator stabilization.
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE ready interrupt enable Set and reset by software to enable/disable interrupt caused by the HSE oscillator stabilization.
    $05 constant RCC_HSI48RDYIE                 \ [0x05] HSI48 ready interrupt enable Set and reset by software to enable/disable interrupt caused by the HSI48 oscillator stabilization.
    $06 constant RCC_PLL1RDYIE                  \ [0x06] PLL1 ready interrupt enable Set and reset by software to enable/disable interrupt caused by PLL1 lock.
    $07 constant RCC_PLL2RDYIE                  \ [0x07] PLL2 ready interrupt enable Set and reset by software to enable/disable interrupt caused by PLL2 lock.
  [then]


  [ifdef] RCC_RCC_CIFR_DEF
    \
    \ @brief RCC clock source interrupt flag register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready interrupt flag Reset by software by writing LSIRDYC bit. Set by hardware when the LSI clock becomes stable and LSIRDYIE is set.
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag Reset by software by writing LSERDYC bit. Set by hardware when the LSE clock becomes stable and LSERDYIE is set.
    $02 constant RCC_CSIRDYF                    \ [0x02] CSI ready interrupt flag Reset by software by writing CSIRDYC bit. Set by hardware when the CSI clock becomes stable and CSIRDYIE is set.
    $03 constant RCC_HSIRDYF                    \ [0x03] HSI ready interrupt flag Reset by software by writing HSIRDYC bit. Set by hardware when the HSI clock becomes stable and HSIRDYIE is set.
    $04 constant RCC_HSERDYF                    \ [0x04] HSE ready interrupt flag Reset by software by writing HSERDYC bit. Set by hardware when the HSE clock becomes stable and HSERDYIE is set.
    $05 constant RCC_HSI48RDYF                  \ [0x05] HSI48 ready interrupt flag Reset by software by writing HSI48RDYC bit. Set by hardware when the HSI48 clock becomes stable and HSI48RDYIE is set.
    $06 constant RCC_PLL1RDYF                   \ [0x06] PLL1 ready interrupt flag Reset by software by writing PLL1RDYC bit. Set by hardware when the PLL1 locks and PLL1RDYIE is set.
    $07 constant RCC_PLL2RDYF                   \ [0x07] PLL2 ready interrupt flag Reset by software by writing PLL2RDYC bit. Set by hardware when the PLL2 locks and PLL2RDYIE is set.
    $0a constant RCC_HSECSSF                    \ [0x0a] HSE clock security system interrupt flag Reset by software by writing HSECSSC bit. Set by hardware in case of HSE clock failure.
  [then]


  [ifdef] RCC_RCC_CICR_DEF
    \
    \ @brief RCC clock source interrupt clear register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYC                    \ [0x00] LSI ready interrupt clear Set by software to clear LSIRDYF. Reset by hardware when clear done.
    $01 constant RCC_LSERDYC                    \ [0x01] LSE ready interrupt clear Set by software to clear LSERDYF. Reset by hardware when clear done.
    $02 constant RCC_CSIRDYC                    \ [0x02] HSI ready interrupt clear Set by software to clear CSIRDYF. Reset by hardware when clear done.
    $03 constant RCC_HSIRDYC                    \ [0x03] HSI ready interrupt clear Set by software to clear HSIRDYF. Reset by hardware when clear done.
    $04 constant RCC_HSERDYC                    \ [0x04] HSE ready interrupt clear Set by software to clear HSERDYF. Reset by hardware when clear done.
    $05 constant RCC_HSI48RDYC                  \ [0x05] HSI48 ready interrupt clear Set by software to clear HSI48RDYF. Reset by hardware when clear done.
    $06 constant RCC_PLL1RDYC                   \ [0x06] PLL1 ready interrupt clear Set by software to clear PLL1RDYF. Reset by hardware when clear done.
    $07 constant RCC_PLL2RDYC                   \ [0x07] PLL2 ready interrupt clear Set by software to clear PLL2RDYF. Reset by hardware when clear done.
    $0a constant RCC_HSECSSC                    \ [0x0a] HSE clock security system interrupt clear Set by software to clear HSECSSF. Reset by hardware when clear done.
  [then]


  [ifdef] RCC_RCC_AHB1RSTR_DEF
    \
    \ @brief RCC AHB1 reset register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPDMA1RST                  \ [0x00] GPDMA1 block reset Set and reset by software.
    $01 constant RCC_GPDMA2RST                  \ [0x01] GPDMA2 block reset Set and reset by software.
    $0c constant RCC_CRCRST                     \ [0x0c] CRC block reset Set and reset by software.
    $11 constant RCC_RAMCFGRST                  \ [0x11] RAMCFG block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB2RSTR_DEF
    \
    \ @brief RCC AHB2 peripheral reset register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] GPIOA block reset Set and reset by software.
    $01 constant RCC_GPIOBRST                   \ [0x01] GPIOB block reset Set and reset by software.
    $02 constant RCC_GPIOCRST                   \ [0x02] GPIOC block reset Set and reset by software.
    $03 constant RCC_GPIODRST                   \ [0x03] GPIOD block reset Set and reset by software.
    $07 constant RCC_GPIOHRST                   \ [0x07] GPIOH block reset Set and reset by software.
    $0a constant RCC_ADC1RST                    \ [0x0a] ADC1 block reset Set and reset by software.
    $0b constant RCC_DAC12RST                   \ [0x0b] DAC block reset Set and reset by software.
    $11 constant RCC_HASHRST                    \ [0x11] HASH block reset Set and reset by software.
    $12 constant RCC_RNGRST                     \ [0x12] RNG block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1LRSTR_DEF
    \
    \ @brief RCC APB1 peripheral low reset register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 block reset Set and reset by software.
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 block reset Set and reset by software.
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6 block reset Set and reset by software.
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7 block reset Set and reset by software.
    $0d constant RCC_OPAMPRST                   \ [0x0d] OPAMP block reset Set and reset by software.
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 block reset Set and reset by software.
    $0f constant RCC_SPI3RST                    \ [0x0f] SPI3 block reset Set and reset by software.
    $10 constant RCC_COMPRST                    \ [0x10] COMP block reset Set and reset by software.
    $11 constant RCC_USART2RST                  \ [0x11] USART2 block reset Set and reset by software.
    $12 constant RCC_USART3RST                  \ [0x12] USART3 block reset Set and reset by software.
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 block reset Set and reset by software.
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 block reset Set and reset by software.
    $17 constant RCC_I3C1RST                    \ [0x17] I3C1 block reset Set and reset by software.
    $18 constant RCC_CRSRST                     \ [0x18] CRS block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1HRSTR_DEF
    \
    \ @brief RCC APB1 peripheral high reset register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $03 constant RCC_DTSRST                     \ [0x03] DTS block reset Set and reset by software.
    $05 constant RCC_LPTIM2RST                  \ [0x05] LPTIM2 block reset Set and reset by software.
    $09 constant RCC_FDCAN1RST                  \ [0x09] FDCAN1 block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB2RSTR_DEF
    \
    \ @brief RCC APB2 peripheral reset register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $0b constant RCC_TIM1RST                    \ [0x0b] TIM1 block reset Set and reset by software.
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 block reset Set and reset by software.
    $0e constant RCC_USART1RST                  \ [0x0e] USART1 block reset Set and reset by software.
    $18 constant RCC_USBFSRST                   \ [0x18] USBFS block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB3RSTR_DEF
    \
    \ @brief RCC APB3 peripheral reset register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SBSRST                     \ [0x01] SBS block reset Set and reset by software.
    $06 constant RCC_LPUART1RST                 \ [0x06] LPUART1 block reset Set and reset by software.
    $09 constant RCC_I3C2RST                    \ [0x09] I3C2RST block reset Set and reset by software.
    $0b constant RCC_LPTIM1RST                  \ [0x0b] LPTIM1 block reset Set and reset by software.
    $14 constant RCC_VREFRST                    \ [0x14] VREF block reset Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB1ENR_DEF
    \
    \ @brief RCC AHB1 peripherals clock register
    \ Address offset: 0x88
    \ Reset value: 0x90000100
    \
    $00 constant RCC_GPDMA1EN                   \ [0x00] GPDMA1 clock enable Set and reset by software.
    $01 constant RCC_GPDMA2EN                   \ [0x01] GPDMA2 clock enable Set and reset by software.
    $08 constant RCC_FLITFEN                    \ [0x08] Flash interface clock enable Set and reset by software.
    $0c constant RCC_CRCEN                      \ [0x0c] CRC clock enable Set and reset by software.
    $11 constant RCC_RAMCFGEN                   \ [0x11] RAMCFG clock enable Set and reset by software.
    $1c constant RCC_BKPRAMEN                   \ [0x1c] BKPRAM clock enable Set and reset by software
    $1f constant RCC_SRAM1EN                    \ [0x1f] SRAM1 clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB2ENR_DEF
    \
    \ @brief RCC AHB2 peripheral clock register
    \ Address offset: 0x8C
    \ Reset value: 0x40000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] GPIOA clock enable Set and reset by software.
    $01 constant RCC_GPIOBEN                    \ [0x01] GPIOB clock enable Set and reset by software.
    $02 constant RCC_GPIOCEN                    \ [0x02] GPIOC clock enable Set and reset by software.
    $03 constant RCC_GPIODEN                    \ [0x03] GPIOD clock enable Set and reset by software.
    $07 constant RCC_GPIOHEN                    \ [0x07] GPIOH clock enable Set and reset by software.
    $0a constant RCC_ADC1EN                     \ [0x0a] ADC1 peripherals clock enabled Set and reset by software.
    $0b constant RCC_DAC12EN                    \ [0x0b] DAC clock enable Set and reset by software.
    $11 constant RCC_HASHEN                     \ [0x11] HASH clock enable Set and reset by software.
    $12 constant RCC_RNGEN                      \ [0x12] RNG clock enable Set and reset by software.
    $1e constant RCC_SRAM2EN                    \ [0x1e] SRAM2 clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1LENR_DEF
    \
    \ @brief RCC APB1 peripheral clock register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2 clock enable Set and reset by software.
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 clock enable Set and reset by software.
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6 clock enable Set and reset by software.
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7 clock enable Set and reset by software.
    $0b constant RCC_WWDGEN                     \ [0x0b] WWDG clock enable Set and reset by software.
    $0d constant RCC_OPAMPEN                    \ [0x0d] OPAMP clock enable Set and reset by software.
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 clock enable Set and reset by software.
    $0f constant RCC_SPI3EN                     \ [0x0f] SPI3 clock enable Set and reset by software.
    $10 constant RCC_COMPEN                     \ [0x10] COMP clock enable Set and reset by software.
    $11 constant RCC_USART2EN                   \ [0x11] USART2 clock enable Set and reset by software.
    $12 constant RCC_USART3EN                   \ [0x12] USART3 clock enable Set and reset by software.
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 clock enable Set and reset by software.
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 clock enable Set and reset by software.
    $17 constant RCC_I3C1EN                     \ [0x17] I3C1 clock enable Set and reset by software.
    $18 constant RCC_CRSEN                      \ [0x18] CRS clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1HENR_DEF
    \
    \ @brief RCC APB1 peripheral clock register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $03 constant RCC_DTSEN                      \ [0x03] DTS clock enable Set and reset by software.
    $05 constant RCC_LPTIM2EN                   \ [0x05] LPTIM2 clock enable Set and reset by software.
    $09 constant RCC_FDCAN1EN                   \ [0x09] FDCAN1 peripheral clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB2ENR_DEF
    \
    \ @brief RCC APB2 peripheral clock register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $0b constant RCC_TIM1EN                     \ [0x0b] TIM1 clock enable Set and reset by software.
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 clock enable Set and reset by software.
    $0e constant RCC_USART1EN                   \ [0x0e] USART1 clock enable Set and reset by software.
    $18 constant RCC_USBFSEN                    \ [0x18] USBFS clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB3ENR_DEF
    \
    \ @brief RCC APB3 peripheral clock register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SBSEN                      \ [0x01] SBS clock enable Set and reset by software.
    $06 constant RCC_LPUART1EN                  \ [0x06] LPUART1 clock enable Set and reset by software.
    $09 constant RCC_I3C2EN                     \ [0x09] I3C2EN clock enable Set and reset by software.
    $0b constant RCC_LPTIM1EN                   \ [0x0b] LPTIM1 clock enable Set and reset by software.
    $14 constant RCC_VREFEN                     \ [0x14] VREF clock enable Set and reset by software.
    $15 constant RCC_RTCAPBEN                   \ [0x15] RTC APB interface clock enable Set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB1LPENR_DEF
    \
    \ @brief RCC AHB1 sleep clock register
    \ Address offset: 0xB0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant RCC_GPDMA1LPEN                 \ [0x00] GPDMA1 clock enable during sleep mode Set and reset by software.
    $01 constant RCC_GPDMA2LPEN                 \ [0x01] GPDMA2 clock enable during sleep mode Set and reset by software.
    $08 constant RCC_FLITFLPEN                  \ [0x08] Flash interface (FLITF) clock enable during sleep mode Set and reset by software.
    $0c constant RCC_CRCLPEN                    \ [0x0c] CRC clock enable during sleep mode Set and reset by software.
    $11 constant RCC_RAMCFGLPEN                 \ [0x11] RAMCFG clock enable during sleep mode Set and reset by software.
    $1c constant RCC_BKPRAMLPEN                 \ [0x1c] BKPRAM clock enable during sleep mode Set and reset by software
    $1d constant RCC_ICACHELPEN                 \ [0x1d] ICACHE clock enable during sleep mode Set and reset by software
    $1f constant RCC_SRAM1LPEN                  \ [0x1f] SRAM1 clock enable during sleep mode Set and reset by software
  [then]


  [ifdef] RCC_RCC_AHB2LPENR_DEF
    \
    \ @brief RCC AHB2 sleep clock register
    \ Address offset: 0xB4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIOA clock enable during sleep mode Set and reset by software.
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIOB clock enable during sleep mode Set and reset by software.
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIOC clock enable during sleep mode Set and reset by software.
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIOD clock enable during sleep mode Set and reset by software.
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIOH clock enable during sleep mode Set and reset by software.
    $0a constant RCC_ADC1LPEN                   \ [0x0a] ADC1 peripherals clock enable during sleep mode Set and reset by software.
    $0b constant RCC_DAC12LPEN                  \ [0x0b] DAC clock enable during sleep mode Set and reset by software.
    $11 constant RCC_HASHLPEN                   \ [0x11] HASH clock enable during sleep mode Set and reset by software.
    $12 constant RCC_RNGLPEN                    \ [0x12] RNG clock enable during sleep mode Set and reset by software.
    $1e constant RCC_SRAM2LPEN                  \ [0x1e] SRAM2 clock enable during sleep mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1LLPENR_DEF
    \
    \ @brief RCC APB1 sleep clock register
    \ Address offset: 0xC4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2 clock enable during sleep mode Set and reset by software.
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3 clock enable during sleep mode Set and reset by software.
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6 clock enable during sleep mode Set and reset by software.
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7 clock enable during sleep mode Set and reset by software.
    $0b constant RCC_WWDGLPEN                   \ [0x0b] WWDG clock enable during sleep mode Set and reset by software.
    $0d constant RCC_OPAMPLPEN                  \ [0x0d] OPAMP clock enable during sleep mode Set and reset by software.
    $0e constant RCC_SPI2LPEN                   \ [0x0e] SPI2 clock enable during sleep mode Set and reset by software.
    $0f constant RCC_SPI3LPEN                   \ [0x0f] SPI3 clock enable during sleep mode Set and reset by software.
    $10 constant RCC_COMPLPEN                   \ [0x10] COMP clock enable during sleep mode Set and reset by software.
    $11 constant RCC_USART2LPEN                 \ [0x11] USART2 clock enable during sleep mode Set and reset by software.
    $12 constant RCC_USART3LPEN                 \ [0x12] USART3 clock enable during sleep mode Set and reset by software.
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C1 clock enable during sleep mode Set and reset by software.
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2 clock enable during sleep mode Set and reset by software.
    $17 constant RCC_I3C1LPEN                   \ [0x17] I3C1 clock enable during sleep mode Set and reset by software.
    $18 constant RCC_CRSLPEN                    \ [0x18] CRS clock enable during sleep mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1HLPENR_DEF
    \
    \ @brief RCC APB1 sleep clock register
    \ Address offset: 0xC8
    \ Reset value: 0xFFFFFFFF
    \
    $03 constant RCC_DTSLPEN                    \ [0x03] DTS clock enable during sleep mode Set and reset by software.
    $05 constant RCC_LPTIM2LPEN                 \ [0x05] LPTIM2 clock enable during sleep mode Set and reset by software.
    $09 constant RCC_FDCAN1LPEN                 \ [0x09] FDCAN1 peripheral clock enable during sleep mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB2LPENR_DEF
    \
    \ @brief RCC APB2 sleep clock register
    \ Address offset: 0xCC
    \ Reset value: 0xFFFFFFFF
    \
    $0b constant RCC_TIM1LPEN                   \ [0x0b] TIM1 clock enable during sleep mode Set and reset by software.
    $0c constant RCC_SPI1LPEN                   \ [0x0c] SPI1 clock enable during sleep mode Set and reset by software.
    $0e constant RCC_USART1LPEN                 \ [0x0e] USART1 clock enable during sleep mode Set and reset by software.
    $18 constant RCC_USBFSLPEN                  \ [0x18] USBFS clock enable during sleep mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB3LPENR_DEF
    \
    \ @brief RCC APB3 sleep clock register
    \ Address offset: 0xD0
    \ Reset value: 0xFFFFFFFF
    \
    $01 constant RCC_SBSLPEN                    \ [0x01] SBS clock enable during sleep mode Set and reset by software.
    $06 constant RCC_LPUART1LPEN                \ [0x06] LPUART1 clock enable during sleep mode Set and reset by software.
    $09 constant RCC_I3C2LPEN                   \ [0x09] I3C2 clock enable during sleep mode Set and reset by software.
    $0b constant RCC_LPTIM1LPEN                 \ [0x0b] LPTIM1 clock enable during sleep mode Set and reset by software.
    $14 constant RCC_VREFLPEN                   \ [0x14] VREF clock enable during sleep mode Set and reset by software.
    $15 constant RCC_RTCAPBLPEN                 \ [0x15] RTC APB interface clock enable during sleep mode Set and reset by software.
  [then]


  [ifdef] RCC_RCC_CCIPR1_DEF
    \
    \ @brief RCC kernel clock configuration register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL                  \ [0x00 : 3] USART1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $03 constant RCC_USART2SEL                  \ [0x03 : 3] USART2 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $06 constant RCC_USART3SEL                  \ [0x06 : 3] USART3 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $1f constant RCC_TIMICSEL                   \ [0x1f] TIM2, TIM3 and LPTIM2 input capture source selection Set and reset by software.
  [then]


  [ifdef] RCC_RCC_CCIPR2_DEF
    \
    \ @brief RCC kernel clock configuration register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $08 constant RCC_LPTIM1SEL                  \ [0x08 : 3] LPTIM1 kernel clock source selection others: reserved, the kernel clock is disabled
    $0c constant RCC_LPTIM2SEL                  \ [0x0c : 3] LPTIM2 kernel clock source selection others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_CCIPR3_DEF
    \
    \ @brief RCC kernel clock configuration register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI1SEL                    \ [0x00 : 3] SPI1 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $03 constant RCC_SPI2SEL                    \ [0x03 : 3] SPI2 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $06 constant RCC_SPI3SEL                    \ [0x06 : 3] SPI3 kernel clock source selection Set and reset by software. others: reserved, the kernel clock is disabled
    $18 constant RCC_LPUART1SEL                 \ [0x18 : 3] LPUART1 kernel clock source selection others: reserved, the kernel clock is disabled
  [then]


  [ifdef] RCC_RCC_CCIPR4_DEF
    \
    \ @brief RCC kernel clock configuration register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $02 constant RCC_SYSTICKSEL                 \ [0x02 : 2] SYSTICK clock source selection Note: rcc_hclk frequency must be four times higher than lsi_ker_ck/lse_ck (period (LSI/LSE) greater than or equal 4 * period (HCLK).
    $04 constant RCC_USBFSSEL                   \ [0x04 : 2] USBFS kernel clock source selection
    $10 constant RCC_I2C1SEL                    \ [0x10 : 2] I2C1 kernel clock source selection
    $12 constant RCC_I2C2SEL                    \ [0x12 : 2] I2C2 kernel clock source selection
    $18 constant RCC_I3C1SEL                    \ [0x18 : 2] I3C1 kernel clock source selection
    $1a constant RCC_I3C2SEL                    \ [0x1a : 2] I3C2 kernel clock source selection
  [then]


  [ifdef] RCC_RCC_CCIPR5_DEF
    \
    \ @brief RCC kernel clock configuration register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ADCDACSEL                  \ [0x00 : 3] ADC and DAC kernel clock source selection others: reserved, the kernel clock is disabled
    $03 constant RCC_DAC1SEL                    \ [0x03] DAC1 sample and hold clock source selection
    $04 constant RCC_RNGSEL                     \ [0x04 : 2] RNG kernel clock source selection
    $08 constant RCC_FDCAN1SEL                  \ [0x08 : 2] FDCAN1 kernel clock source selection
    $1e constant RCC_CKPERSEL                   \ [0x1e : 2] per_ck clock source selection
  [then]


  [ifdef] RCC_RCC_BDCR_DEF
    \
    \ @brief RCC Backup domain control register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enabled Set and reset by software.
    $01 constant RCC_LSERDY                     \ [0x01] LSE oscillator ready Set and reset by hardware to indicate when the LSE is stable. This bit needs 6 cycles of lse_ck clock to fall down after LSEON has been set to 0.
    $02 constant RCC_LSEBYP                     \ [0x02] LSE oscillator bypass Set and reset by software to bypass oscillator in debug mode. This bit must not be written when the LSE is enabled (by LSEON) or ready (LSERDY = 1)
    $03 constant RCC_LSEDRV                     \ [0x03 : 2] LSE oscillator driving capability Set by software to select the driving capability of the LSE oscillator. These bit can be written only if LSE oscillator is disabled (LSEON = 0 and LSERDY = 0).
    $05 constant RCC_LSECSSON                   \ [0x05] LSE clock security system enable Set by software to enable the clock security system on 32 kHz oscillator. LSECSSON must be enabled after LSE is enabled (LSEON enabled) and ready (LSERDY set by hardware) and after RTCSEL is selected. Once enabled, this bit cannot be disabled, except after a LSE failure detection (LSECSSD = 1). In that case the software must disable LSECSSON.
    $06 constant RCC_LSECSSD                    \ [0x06] LSE clock security system failure detection Set by hardware to indicate when a failure has been detected by the clock security system on the external 32 kHz oscillator.
    $07 constant RCC_LSEEXT                     \ [0x07] low-speed external clock type in bypass mode Set and reset by software to select the external clock type (analog or digital). The external clock must be enabled with the LSEON bit, to be used by the device. The LSEEXT bit can be written only if the LSE oscillator is disabled.
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC clock source selection Set by software to select the clock source for the RTC. These bits can be written only one time (except in case of failure detection on LSE). These bits must be written before LSECSSON is enabled. The VSWRST bit can be used to reset them, then it can be written one time again. If HSE is selected as RTC clock, this clock is lost when the system is in Stop mode or in case of a pin reset (NRST).
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable Set and reset by software.
    $10 constant RCC_VSWRST                     \ [0x10] VSwitch domain software reset Set and reset by software.
    $18 constant RCC_LSCOEN                     \ [0x18] Low-speed clock output (LSCO) enable Set and cleared by software.
    $19 constant RCC_LSCOSEL                    \ [0x19] Low-speed clock output selection Set and cleared by software.
    $1a constant RCC_LSION                      \ [0x1a] LSI oscillator enable Set and cleared by software.
    $1b constant RCC_LSIRDY                     \ [0x1b] LSI oscillator ready Set and cleared by hardware to indicate when the LSI oscillator is stable. After the LSION bit is cleared, LSIRDY goes low after three internal low-speed oscillator clock cycles. This bit is set when the LSI is used by IWDG or RTC, even if LSION = 0.
  [then]


  [ifdef] RCC_RCC_RSR_DEF
    \
    \ @brief RCC reset status register
    \ Address offset: 0xF4
    \ Reset value: 0x0C000000
    \
    $17 constant RCC_RMVF                       \ [0x17] remove reset flag Set and reset by software to reset the value of the reset flags.
    $1a constant RCC_PINRSTF                    \ [0x1a] pin reset flag (NRST) Reset by software by writing the RMVF bit. Set by hardware when a reset from pin occurs.
    $1b constant RCC_BORRSTF                    \ [0x1b] BOR reset flag Reset by software by writing the RMVF bit. Set by hardware when a BOR reset occurs (pwr_bor_rst).
    $1c constant RCC_SFTRSTF                    \ [0x1c] system reset from CPU reset flag Reset by software by writing the RMVF bit. Set by hardware when the system reset is due to CPU.The CPU can generate a system reset by writing SYSRESETREQ bit of AIRCR register of the core M33.
    $1d constant RCC_IWDGRSTF                   \ [0x1d] independent watchdog reset flag Reset by software by writing the RMVF bit. Set by hardware when an independent watchdog reset occurs.
    $1e constant RCC_WWDGRSTF                   \ [0x1e] window watchdog reset flag Reset by software by writing the RMVF bit. Set by hardware when a window watchdog reset occurs.
    $1f constant RCC_LPWRRSTF                   \ [0x1f] Low-power reset flag Set by hardware when a reset occurs due to Stop or Standby mode entry, whereas the corresponding nRST_STOP, nRST_STBY option bit is cleared. Cleared by writing to the RMVF bit.
  [then]

  \
  \ @brief Reset and clock controller
  \
  $00 constant RCC_RCC_CR               \ RCC clock control register
  $10 constant RCC_RCC_HSICFGR          \ RCC HSI calibration register
  $14 constant RCC_RCC_CRRCR            \ RCC clock recovery RC register
  $18 constant RCC_RCC_CSICFGR          \ RCC CSI calibration register
  $1C constant RCC_RCC_CFGR1            \ RCC clock configuration register
  $20 constant RCC_RCC_CFGR2            \ RCC CPU domain clock configuration register 2
  $28 constant RCC_RCC_PLL1CFGR         \ RCC PLL clock source selection register
  $2C constant RCC_RCC_PLL2CFGR         \ RCC PLL clock source selection register
  $34 constant RCC_RCC_PLL1DIVR         \ RCC PLL1 dividers register
  $38 constant RCC_RCC_PLL1FRACR        \ RCC PLL1 fractional divider register
  $3C constant RCC_RCC_PLL2DIVR         \ RCC PLL1 dividers register
  $40 constant RCC_RCC_PLL2FRACR        \ RCC PLL2 fractional divider register
  $50 constant RCC_RCC_CIER             \ RCC clock source interrupt enable register
  $54 constant RCC_RCC_CIFR             \ RCC clock source interrupt flag register
  $58 constant RCC_RCC_CICR             \ RCC clock source interrupt clear register
  $60 constant RCC_RCC_AHB1RSTR         \ RCC AHB1 reset register
  $64 constant RCC_RCC_AHB2RSTR         \ RCC AHB2 peripheral reset register
  $74 constant RCC_RCC_APB1LRSTR        \ RCC APB1 peripheral low reset register
  $78 constant RCC_RCC_APB1HRSTR        \ RCC APB1 peripheral high reset register
  $7C constant RCC_RCC_APB2RSTR         \ RCC APB2 peripheral reset register
  $80 constant RCC_RCC_APB3RSTR         \ RCC APB3 peripheral reset register
  $88 constant RCC_RCC_AHB1ENR          \ RCC AHB1 peripherals clock register
  $8C constant RCC_RCC_AHB2ENR          \ RCC AHB2 peripheral clock register
  $9C constant RCC_RCC_APB1LENR         \ RCC APB1 peripheral clock register
  $A0 constant RCC_RCC_APB1HENR         \ RCC APB1 peripheral clock register
  $A4 constant RCC_RCC_APB2ENR          \ RCC APB2 peripheral clock register
  $A8 constant RCC_RCC_APB3ENR          \ RCC APB3 peripheral clock register
  $B0 constant RCC_RCC_AHB1LPENR        \ RCC AHB1 sleep clock register
  $B4 constant RCC_RCC_AHB2LPENR        \ RCC AHB2 sleep clock register
  $C4 constant RCC_RCC_APB1LLPENR       \ RCC APB1 sleep clock register
  $C8 constant RCC_RCC_APB1HLPENR       \ RCC APB1 sleep clock register
  $CC constant RCC_RCC_APB2LPENR        \ RCC APB2 sleep clock register
  $D0 constant RCC_RCC_APB3LPENR        \ RCC APB3 sleep clock register
  $D8 constant RCC_RCC_CCIPR1           \ RCC kernel clock configuration register
  $DC constant RCC_RCC_CCIPR2           \ RCC kernel clock configuration register
  $E0 constant RCC_RCC_CCIPR3           \ RCC kernel clock configuration register
  $E4 constant RCC_RCC_CCIPR4           \ RCC kernel clock configuration register
  $E8 constant RCC_RCC_CCIPR5           \ RCC kernel clock configuration register
  $F0 constant RCC_RCC_BDCR             \ RCC Backup domain control register
  $F4 constant RCC_RCC_RSR              \ RCC reset status register

: RCC_DEF ; [then]
