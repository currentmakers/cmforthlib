\
\ @file rcc.fs
\ @brief Reset and clock control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RCC clock control register
\ Address offset: 0x00
\ Reset value: 0x00000500
\

$00000100 constant RCC_RCC_CR_HSION                                 \ HSI16 clock enable Set and cleared by software. Cleared by hardware when entering Stop and Standby modes. Set by hardware to force the HSI16 oscillator on when exiting Stop and Standby modes. Set by hardware to force the HSI16 oscillator on in case of clock security failure of the HSE32 crystal oscillator. This bit is set by hardware if the HSI16 is used directly or indirectly as system clock. Access to the bit can be secured by RCC HSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000200 constant RCC_RCC_CR_HSIKERON                              \ HSI16 enable for some peripheral kernels Set and cleared by software to force HSI16 oscillator on even in Stop modes. Keeping the HSI16 oscillator on in Stop modes allows the communication speed not to be reduced by the HSI16 oscillator startup time. This bit has no effect on register bit HSION value. Cleared by hardware when entering Standby modes. Refer to Peripherals clock gating and autonomous mode for more details. Access to the bit can be secured by RCC HSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000400 constant RCC_RCC_CR_HSIRDY                                \ HSI16 clock ready flag Set by hardware to indicate that HSI16 oscillator is stable. This bit is set only when HSI16 is enabled by software by setting HSION. Access to the bit can be secured by RCC HSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: Once the HSION bit is cleared, HSIRDY goes low after six HSI16 clock cycles.
$00010000 constant RCC_RCC_CR_HSEON                                 \ HSE32 clock enable Set and cleared by software. Cleared by hardware to stop the HSE32 clock for the CPU when entering Stop and Standby modes and on a HSECSS failure. When the HSE32 is used as 2.4 GHz RADIO kernel clock, enabled by RADIOEN and RADIOSMEN and the 2.4 GHz RADIO is active, HSEON is not be cleared when entering low power mode. In this case only Stop 0 mode is entered as low power mode. This bit cannot be reset if the HSE32 oscillator is used directly or indirectly as the system clock. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00020000 constant RCC_RCC_CR_HSERDY                                \ HSE32 clock ready flag Set by hardware to indicate that the HSE32 oscillator is stable. This bit is set both when HSE32 is enabled by software by setting HSEON and when requested as kernel clock by the 2.4 GHz RADIO. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00080000 constant RCC_RCC_CR_HSECSSON                              \ HSE32 clock security system enable Set by software to enable the HSE32 clock security system. When HSECSSON is set, the clock detector is enabled by hardware when the HSE32 oscillator is ready and disabled by hardware if a HSE32 clock failure is detected. This bit is set only and is cleared by reset. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00100000 constant RCC_RCC_CR_HSEPRE                                \ HSE32 clock for SYSCLK prescaler Set and cleared by software to control the division factor of the HSE32 clock for SYSCLK. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$01000000 constant RCC_RCC_CR_PLL1ON                                \ PLL1 enable Set and cleared by software to enable the main PLL. Cleared by hardware when entering Stop or Standby modes and when PLL1 on HSE32 is selected as sysclk, on a HSECSS failure. This bit cannot be reset if the PLL1 clock is used as the system clock. Access to the bit can be secured by RCC PLL1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$02000000 constant RCC_RCC_CR_PLL1RDY                               \ PLL1 clock ready flag Set by hardware to indicate that the PLL1 is locked. Access to the bit can be secured by RCC PLL1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC internal clock sources calibration register 3
\ Address offset: 0x10
\ Reset value: 0x00100000
\

$00000fff constant RCC_RCC_ICSCR3_HSICAL                            \ HSI16 clock calibration These bits are initialized at startup with the factory-programmed HSI16 calibration value. When HSITRIM[4:0] is written, HSICAL[11:0] is updated with the sum of HSITRIM[4:0] and the initial factory trim value.
$001f0000 constant RCC_RCC_ICSCR3_HSITRIM                           \ HSI16 clock trimming These bits provide an additional user-programmable trimming value that is added to the HSICAL[11:0] bits. It can be programmed to adjust to voltage and temperature variations that influence the frequency of the HSI16.


\
\ @brief RCC clock configuration register 1
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_CFGR1_SW                                 \ system clock switch Set and cleared by software to select system clock source (SYSCLK). Cleared by hardware when entering Stop and Standby modes When selecting HSE32 directly or indirectly as system clock and HSE32 oscillator clock security fails, cleared by hardware.
$0000000c constant RCC_RCC_CFGR1_SWS                                \ system clock switch status Set and cleared by hardware to indicate which clock source is used as system clock.
$0f000000 constant RCC_RCC_CFGR1_MCOSEL                             \ microcontroller clock output Set and cleared by software. others: reserved Note: This clock output may have some truncated cycles at startup or during MCO clock source switching.
$70000000 constant RCC_RCC_CFGR1_MCOPRE                             \ microcontroller clock output prescaler Set and cleared by software. It is highly recommended to change this prescaler before MCO output is enabled. others: not allowed


\
\ @brief RCC clock configuration register 2
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_CFGR2_HPRE                               \ AHB1, AHB2 and AHB4 prescaler Set and cleared by software to control the division factor of the AHB1, AHB2 and AHB4 clock (hclk1). The software must limit the incremental frequency step by setting these bits correctly to ensure that the hclk1 maximum incremental frequency step does not exceed the maximum allowed incremental frequency step (for more details, refer to Table99: SYSCLK and bus maximum frequency). After a write operation to these bits and before decreasing the voltage range, this register must be read to be sure that the new value is taken into account. 0xx: hclk1 = SYSCLK not divided
$00000070 constant RCC_RCC_CFGR2_PPRE1                              \ APB1 prescaler Set and cleared by software to control the division factor of the APB1 clock (pclk1). 0xx: pclk1 = hclk1 not divided
$00000700 constant RCC_RCC_CFGR2_PPRE2                              \ APB2 prescaler Set and cleared by software to control the division factor of the APB2 clock (pclk2). 0xx: pclk2 = hclk1 not divided


\
\ @brief RCC clock configuration register 3
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000070 constant RCC_RCC_CFGR3_PPRE7                              \ APB7 prescaler Set and cleared by software to control the division factor of the APB7 clock (pclk7). 0xx: hclk1 not divided


\
\ @brief RCC PLL1 configuration register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_PLL1CFGR_PLL1SRC                         \ PLL1 entry clock source Set and cleared by software to select PLL1 clock source. These bits can be written only when the PLL1 is disabled. Cleared by hardware when entering Stop or Standby modes. Note: In order to save power, when no PLL1 clock is used, the value of PLL1SRC must be 0.
$0000000c constant RCC_RCC_PLL1CFGR_PLL1RGE                         \ PLL1 input frequency range Set and reset by software to select the proper reference frequency range used for PLL1. This bit must be written before enabling the PLL1. 00-01-10: PLL1 input (ref1_ck) clock range frequency between 4 and 8 MHz
$00000010 constant RCC_RCC_PLL1CFGR_PLL1FRACEN                      \ PLL1 fractional latch enable Set and reset by software to latch the content of PLL1FRACN into the modulator. In order to latch the PLL1FRACN value into the modulator, PLL1FRACEN must be set to 0, then set to 1: the transition 0 to 1 transfers the content of PLL1FRACN into the modulator (see PLL1 initialization phase for details).
$00000700 constant RCC_RCC_PLL1CFGR_PLL1M                           \ Prescaler for PLL1 Set and cleared by software to configure the prescaler of the PLL1. The VCO1 input frequency is PLL1 input clock frequency/PLL1M. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
$00010000 constant RCC_RCC_PLL1CFGR_PLL1PEN                         \ PLL1 DIVP divider output enable Set and reset by software to enable the pll1pclk output of the PLL1. To save power, PLL1PEN and PLL1P bits must be set to 0 when the pll1pclk is not used. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).
$00020000 constant RCC_RCC_PLL1CFGR_PLL1QEN                         \ PLL1 DIVQ divider output enable Set and reset by software to enable the pll1qclk output of the PLL1. To save power, PLL1QEN and PLL1Q bits must be set to 0 when the pll1qclk is not used. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).
$00040000 constant RCC_RCC_PLL1CFGR_PLL1REN                         \ PLL1 DIVR divider output enable Set and cleared by software to enable the pll1rclk output of the PLL1. To save power, PLL1REN and PLL1R bits must be set to 0 when the pll1rclk is not used. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).
$00100000 constant RCC_RCC_PLL1CFGR_PLL1RCLKPRE                     \ pll1rclk clock for SYSCLK prescaler division enable Set and cleared by software to control the division of the pll1rclk clock for SYSCLK.
$00200000 constant RCC_RCC_PLL1CFGR_PLL1RCLKPRESTEP                 \ pll1rclk clock for SYSCLK prescaler division step selection Set and cleared by software to control the division step of the pll1rclk clock for SYSCLK.
$00400000 constant RCC_RCC_PLL1CFGR_PLL1RCLKPRERDY                  \ pll1rclkpre not divided ready. Set by hardware after PLL1RCLKPRE has been set from divided to not divide, to indicate that the pll1rclk not divided is available on sysclkpre.


\
\ @brief RCC PLL1 dividers register
\ Address offset: 0x34
\ Reset value: 0x01010280
\

$000001ff constant RCC_RCC_PLL1DIVR_PLL1N                           \ Multiplication factor for PLL1 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ... ... others: reserved VCO output frequency = Fsubref1_ck/sub x multiplication factor for PLL1 VCO, when fractional value 0 has been loaded into PLL1FRACN, with: Multiplication factor for PLL1 VCO between 4 and 512 input frequency Fsubref1_ck/sub between 4 and 16MHz
$0000fe00 constant RCC_RCC_PLL1DIVR_PLL1P                           \ PLL1 DIVP division factor Set and reset by software to control the frequency of the pll1pclk clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). Note that odd division factors are not allowed. ...
$007f0000 constant RCC_RCC_PLL1DIVR_PLL1Q                           \ PLL1 DIVQ division factor Set and reset by software to control the frequency of the PLl1QCLK clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
$7f000000 constant RCC_RCC_PLL1DIVR_PLL1R                           \ PLL1 DIVR division factor Set and reset by software to control the frequency of the pll1rclk clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...


\
\ @brief RCC PLL1 fractional divider register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL1FRACR_PLL1FRACN                      \ Fractional part of the multiplication factor for PLL1 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. VCO output frequency = Fsubref1_ck/sub x [multiplication factor for PLL1 VCO + (PLL1FRACN / 2sup13/sup)], with: Multiplication factor for PLL1 VCO must be between 4 and 512. PLL1FRACN can be between 0 and 2sup13/sup- 1. The input frequency Fsubref1_ck/sub must be between 4 and 16 MHz. To change the used fractional value on-the-fly even if the PLL1 is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into PLL1FRACN. Set the bit PLL1FRACEN to 1.


\
\ @brief RCC clock interrupt enable register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CIER_LSI1RDYIE                           \ LSI1 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSI1 oscillator stabilization. Access to the bit can be secured by RCC LSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000002 constant RCC_RCC_CIER_LSERDYIE                            \ LSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSE oscillator stabilization. Access to the bit can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000008 constant RCC_RCC_CIER_HSIRDYIE                            \ HSI16 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSI16 oscillator stabilization. Access to the bit can be secured by RCC HSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000010 constant RCC_RCC_CIER_HSERDYIE                            \ HSE32 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSE32 oscillator stabilization. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000040 constant RCC_RCC_CIER_PLL1RDYIE                           \ PLL1 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by PLL1 lock. Access to the bit can be secured by RCC PLL1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC clock interrupt flag register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CIFR_LSI1RDYF                            \ LSI1 ready interrupt flag Set by hardware when the LSI1 clock becomes stable and LSI1RDYIE is set. Cleared by software setting the LSI1RDYC bit. Access to the bit can be secured by RCC LSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000002 constant RCC_RCC_CIFR_LSERDYF                             \ LSE ready interrupt flag Set by hardware when the LSE clock becomes stable and LSERDYIE is set. Cleared by software setting the LSERDYC bit. Access to the bit can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000008 constant RCC_RCC_CIFR_HSIRDYF                             \ HSI16 ready interrupt flag Set by hardware when the HSI16 clock becomes stable and HSIRDYIE is set in a response to setting the HSION (see RCC_CR). When HSION is not set but the HSI16 oscillator is enabled by the peripheral through a clock request, this bit is not set and no interrupt is generated. Access to the bit can be secured by RCC HSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Cleared by software setting the HSIRDYC bit.
$00000010 constant RCC_RCC_CIFR_HSERDYF                             \ HSE32 ready interrupt flag Set by hardware when the HSE32 clock becomes stable and HSERDYIE is set. Cleared by software setting the HSERDYC bit. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000040 constant RCC_RCC_CIFR_PLL1RDYF                            \ PLL1 ready interrupt flag Set by hardware when the PLL1 locks and PLL1RDYIE is set. Cleared by software setting the PLL1RDYC bit. Access to the bit can be secured by RCC PLL1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000400 constant RCC_RCC_CIFR_HSECSSF                             \ HSE32 clock security system interrupt flag Set by hardware when a clock security failure is detected in the HSE32 oscillator. Cleared by software setting the HSECSSC bit. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC clock interrupt clear register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CICR_LSI1RDYC                            \ LSI1 ready interrupt clear Writing this bit to 1 clears the LSI1RDYF flag. Writing 0 has no effect. Access to the bit can be secured by RCC LSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000002 constant RCC_RCC_CICR_LSERDYC                             \ LSE ready interrupt clear Writing this bit to 1 clears the LSERDYF flag. Writing 0 has no effect. Access to the bit can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000008 constant RCC_RCC_CICR_HSIRDYC                             \ HSI16 ready interrupt clear Writing this bit to 1 clears the HSIRDYF flag. Writing 0 has no effect. Access to the bit can be secured by RCC HSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000010 constant RCC_RCC_CICR_HSERDYC                             \ HSE32 ready interrupt clear Writing this bit to 1 clears the HSERDYF flag. Writing 0 has no effect. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000040 constant RCC_RCC_CICR_PLL1RDYC                            \ PLL1 ready interrupt clear Writing this bit to 1 clears the PLL1RDYF flag. Writing 0 has no effect. Access to the bit can be secured by RCC PLL1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000400 constant RCC_RCC_CICR_HSECSSC                             \ High speed external clock security system interrupt clear Writing this bit to 1 clears the HSECSSF flag. Writing 0 has no effect. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC AHB1 peripheral reset register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB1RSTR_GPDMA1RST                       \ GPDMA1 reset Set and cleared by software. Access can be secured by GPDMA1 SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00001000 constant RCC_RCC_AHB1RSTR_CRCRST                          \ CRC reset Set and cleared by software. Access can be secured by GTZC_TZSC CRCSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00010000 constant RCC_RCC_AHB1RSTR_TSCRST                          \ TSC reset Set and cleared by software. Access can be secured by GTZC_TZSC TSCSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC AHB2 peripheral reset register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB2RSTR_GPIOARST                        \ IO port A reset Set and cleared by software. Access can be secured by GPIOA SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000002 constant RCC_RCC_AHB2RSTR_GPIOBRST                        \ IO port B reset Set and cleared by software. Access can be secured by GPIOB SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000004 constant RCC_RCC_AHB2RSTR_GPIOCRST                        \ IO port C reset Set and cleared by software. Access can be secured by GPIOC SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000080 constant RCC_RCC_AHB2RSTR_GPIOHRST                        \ IO port H reset Set and cleared by software. Access can be secured by GPIOH SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00010000 constant RCC_RCC_AHB2RSTR_AESRST                          \ AES hardware accelerator reset Set and cleared by software. Access can be secured by GTZC_TZSC AESSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00020000 constant RCC_RCC_AHB2RSTR_HASHRST                         \ Hash reset Set and cleared by software. Access can be secured by GTZC_TZSC HASHSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00040000 constant RCC_RCC_AHB2RSTR_RNGRST                          \ Random number generator reset Set and cleared by software. Access can be secured by GTZC_TZSC RNGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00080000 constant RCC_RCC_AHB2RSTR_SAESRST                         \ SAES hardware accelerator reset Set and cleared by software. Access can be secured by GTZC_TZSC SAESSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00100000 constant RCC_RCC_AHB2RSTR_HSEMRST                         \ HSEM hardware accelerator reset Set and cleared by software. Can only be accessed secure when one or more features in the HSEM is secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00200000 constant RCC_RCC_AHB2RSTR_PKARST                          \ PKA reset Set and cleared by software. Access can be secured by GTZC_TZSC PKASEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC AHB4 peripheral reset register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000020 constant RCC_RCC_AHB4RSTR_ADC4RST                         \ ADC4 reset Set and cleared by software. Access can be secred by GTZC_TZSC ADC4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC AHB5 peripheral reset register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB5RSTR_RADIORST                        \ 2.4 GHz RADIO reset Set and cleared by software. Access can be secured by GTZC_TZSC RADIOSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC APB1 peripheral reset register 1
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1RSTR1_TIM2RST                        \ TIM2 reset Set and cleared by software. Access can be secured by GTZC_TZSC TIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000002 constant RCC_RCC_APB1RSTR1_TIM3RST                        \ TIM3 reset Set and cleared by software. Access can be secured by GTZC_TZSC TIM3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00020000 constant RCC_RCC_APB1RSTR1_USART2RST                      \ USART2 reset Set and cleared by software. Access can be secured by GTZC_TZSC UART2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00200000 constant RCC_RCC_APB1RSTR1_I2C1RST                        \ I2C1 reset Set and cleared by software. Access can be secured by GTZC_TZSC I2C1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC APB1 peripheral reset register 2
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000020 constant RCC_RCC_APB1RSTR2_LPTIM2RST                      \ LPTIM2 reset Set and cleared by software. Access can be secured by GTZC_TZSC LPTIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC APB2 peripheral reset register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000800 constant RCC_RCC_APB2RSTR_TIM1RST                         \ TIM1 reset Set and cleared by software. Access can be secured by GTZC_TZSC TIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00001000 constant RCC_RCC_APB2RSTR_SPI1RST                         \ SPI1 reset Set and cleared by software. Access can be secured by GTZC_TZSC SPI1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00004000 constant RCC_RCC_APB2RSTR_USART1RST                       \ USART1 reset Set and cleared by software. Access can be secured by GTZC_TZSC USART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00020000 constant RCC_RCC_APB2RSTR_TIM16RST                        \ TIM16 reset Set and cleared by software. Access can be secured by GTZC_TZSC TIM16SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00040000 constant RCC_RCC_APB2RSTR_TIM17RST                        \ TIM17 reset Set and cleared by software. Access can be secured by GTZC_TZSC TIM17SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC APB7 peripheral reset register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB7RSTR_SYSCFGRST                       \ SYSCFG reset Set and cleared by software. Access can be secured by SYSCFG SYSCFGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000020 constant RCC_RCC_APB7RSTR_SPI3RST                         \ SPI3 reset Set and cleared by software. Access can be secured by GTZC_TZSC SPI3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000040 constant RCC_RCC_APB7RSTR_LPUART1RST                      \ LPUART1 reset Set and cleared by software. Access can be secured by GTZC_TZSC LPUART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000080 constant RCC_RCC_APB7RSTR_I2C3RST                         \ I2C3 reset Set and cleared by software. Access can be secured by GTZC_TZSC I2C3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000800 constant RCC_RCC_APB7RSTR_LPTIM1RST                       \ LPTIM1 reset Set and cleared by software. Access can be secured by GTZC_TZSC LPTIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC AHB1 peripheral clock enable register
\ Address offset: 0x88
\ Reset value: 0x80000100
\

$00000001 constant RCC_RCC_AHB1ENR_GPDMA1EN                         \ GPDMA1 bus clock enable Set and cleared by software. Access can be secured by GPDMA1 SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000100 constant RCC_RCC_AHB1ENR_FLASHEN                          \ FLASH bus clock enable Set and cleared by software. This bit can be disabled only when the Flash memory is in power down mode. Can only be accessed secured when the Flash security state is secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00001000 constant RCC_RCC_AHB1ENR_CRCEN                            \ CRC bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC CRCSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00010000 constant RCC_RCC_AHB1ENR_TSCEN                            \ Touch sensing controller bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC TSCSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00020000 constant RCC_RCC_AHB1ENR_RAMCFGEN                         \ RAMCFG bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC RAMCFGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$01000000 constant RCC_RCC_AHB1ENR_GTZC1EN                          \ GTZC1 bus clock enable Set and reset by software. Can only be accessed secure when device is secure (TZEN = 1). When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$80000000 constant RCC_RCC_AHB1ENR_SRAM1EN                          \ SRAM1 bus clock enable Set and reset by software. Access can be secured by GTZC_MPCBB1 SECx, INVSECSTATE. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC AHB2 peripheral clock enable register
\ Address offset: 0x8C
\ Reset value: 0x40000000
\

$00000001 constant RCC_RCC_AHB2ENR_GPIOAEN                          \ IO port A bus clock enable Set and cleared by software. Access can be secured by GPIOA SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000002 constant RCC_RCC_AHB2ENR_GPIOBEN                          \ IO port B bus clock enable Set and cleared by software. Access can be secured by GPIOB SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000004 constant RCC_RCC_AHB2ENR_GPIOCEN                          \ IO port C bus clock enable Set and cleared by software. Access can be secured by GPIOC SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000080 constant RCC_RCC_AHB2ENR_GPIOHEN                          \ IO port H bus clock enable Set and cleared by software. Access can be secured by GPIOH SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00010000 constant RCC_RCC_AHB2ENR_AESEN                            \ AES bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC AESSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00020000 constant RCC_RCC_AHB2ENR_HASHEN                           \ HASH bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC HASHSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00040000 constant RCC_RCC_AHB2ENR_RNGEN                            \ RNG bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC RNGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00080000 constant RCC_RCC_AHB2ENR_SAESEN                           \ SAES bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC SAESSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00100000 constant RCC_RCC_AHB2ENR_HSEMEN                           \ HSEM bus clock enable Set and cleared by software. Can only be accessed secure when one or more features in the HSEM is secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00200000 constant RCC_RCC_AHB2ENR_PKAEN                            \ PKA bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC PKASEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$40000000 constant RCC_RCC_AHB2ENR_SRAM2EN                          \ SRAM2 bus clock enable Set and cleared by software. Access can be secured by GTZC_MPCBB2 SECx, INVSECSTATE. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC AHB4 peripheral clock enable register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000004 constant RCC_RCC_AHB4ENR_PWREN                            \ PWR bus clock enable Set and cleared by software. Can only be accessed secure when one or more features in the PWR is/are secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000020 constant RCC_RCC_AHB4ENR_ADC4EN                           \ ADC4 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC ADC4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC AHB5 peripheral clock enable register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB5ENR_RADIOEN                          \ 2.4 GHz RADIO bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC RADIOSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Before accessing the 2.4 GHz RADIO sleep timers registers the RADIOCLKRDY bit must be checked. Note: When RADIOSMEN and STRADIOCLKON are both cleared, RADIOCLKRDY bit must be re-checked when exiting low-power modes (Sleep and Stop).


\
\ @brief RCC APB1 peripheral clock enable register 1
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1ENR1_TIM2EN                          \ TIM2 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC TIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000002 constant RCC_RCC_APB1ENR1_TIM3EN                          \ TIM3 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC TIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000800 constant RCC_RCC_APB1ENR1_WWDGEN                          \ WWDG bus clock enable Set by software to enable the window watchdog bus clock. Reset by hardware system reset. This bit can also be set by hardware if the WWDG_SW option bit is reset. Access can be secured by GTZC_TZSC WWDGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00020000 constant RCC_RCC_APB1ENR1_USART2EN                        \ USART2 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC USART2SEC When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV..
$00200000 constant RCC_RCC_APB1ENR1_I2C1EN                          \ I2C1 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC I2C1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC APB1 peripheral clock enable register 2
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000020 constant RCC_RCC_APB1ENR2_LPTIM2EN                        \ LPTIM2 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC LPTIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC APB2 peripheral clock enable register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000800 constant RCC_RCC_APB2ENR_TIM1EN                           \ TIM1 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC TIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00001000 constant RCC_RCC_APB2ENR_SPI1EN                           \ SPI1 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC SPI1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00004000 constant RCC_RCC_APB2ENR_USART1EN                         \ USART1bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC USART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00020000 constant RCC_RCC_APB2ENR_TIM16EN                          \ TIM16 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC TIM16SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00040000 constant RCC_RCC_APB2ENR_TIM17EN                          \ TIM17 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC TIM17SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC APB7 peripheral clock enable register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB7ENR_SYSCFGEN                         \ SYSCFG bus clock enable Set and cleared by software. Access can be secured by SYSCFG SYSCFGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000020 constant RCC_RCC_APB7ENR_SPI3EN                           \ SPI3 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC SPI3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000040 constant RCC_RCC_APB7ENR_LPUART1EN                        \ LPUART1 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC LPUART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000080 constant RCC_RCC_APB7ENR_I2C3EN                           \ I2C3 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC I2C3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000800 constant RCC_RCC_APB7ENR_LPTIM1EN                         \ LPTIM1 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC LPTIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00200000 constant RCC_RCC_APB7ENR_RTCAPBEN                         \ RTC and TAMP bus clock enable Set and cleared by software. Can only be accessed secure when one or more features in the RTC or TAMP is/are secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC AHB1 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0xB0
\ Reset value: 0xFFFFFFFF
\

$00000001 constant RCC_RCC_AHB1SMENR_GPDMA1SMEN                     \ GPDMA1 bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GPDMA1 SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000100 constant RCC_RCC_AHB1SMENR_FLASHSMEN                      \ FLASH bus clock enable during Sleep and Stop modes Set and cleared by software. Can only be accessed secured when the Flash security state is secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00001000 constant RCC_RCC_AHB1SMENR_CRCSMEN                        \ CRC bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC CRCSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00010000 constant RCC_RCC_AHB1SMENR_TSCSMEN                        \ TSC bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC TSCSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV..
$00020000 constant RCC_RCC_AHB1SMENR_RAMCFGSMEN                     \ RAMCFG bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC RAMCFGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$01000000 constant RCC_RCC_AHB1SMENR_GTZC1SMEN                      \ GTZC1 bus clock enable during Sleep and Stop modes Set and cleared by software. Can only be accessed secure when one device is secure (TZEN = 1). When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$20000000 constant RCC_RCC_AHB1SMENR_ICACHESMEN                     \ ICACHE bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC ICACHE_REGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV..
$80000000 constant RCC_RCC_AHB1SMENR_SRAM1SMEN                      \ SRAM1 bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_MPCBB1 SECx, INVSECSTATE. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC AHB2 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0xB4
\ Reset value: 0xFFFFFFFF
\

$00000001 constant RCC_RCC_AHB2SMENR_GPIOASMEN                      \ IO port A bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GPIOA SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000002 constant RCC_RCC_AHB2SMENR_GPIOBSMEN                      \ IO port B bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GPIOB SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000004 constant RCC_RCC_AHB2SMENR_GPIOCSMEN                      \ IO port C bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GPIOC SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000080 constant RCC_RCC_AHB2SMENR_GPIOHSMEN                      \ IO port H bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GPIOH SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00010000 constant RCC_RCC_AHB2SMENR_AESSMEN                        \ AES bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC AESSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00020000 constant RCC_RCC_AHB2SMENR_HASHSMEN                       \ HASH bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC HASHSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00040000 constant RCC_RCC_AHB2SMENR_RNGSMEN                        \ Random number generator (RNG) bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC RNGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00080000 constant RCC_RCC_AHB2SMENR_SAESSMEN                       \ SAES accelerator bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC SAESSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00200000 constant RCC_RCC_AHB2SMENR_PKASMEN                        \ PKA bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC PKASEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$40000000 constant RCC_RCC_AHB2SMENR_SRAM2SMEN                      \ SRAM2 bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_MPCBB2 SECx, INVSECSTATE. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC AHB4 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0xBC
\ Reset value: 0xFFFFFFFF
\

$00000004 constant RCC_RCC_AHB4SMENR_PWRSMEN                        \ PWR bus clock enable during Sleep and Stop modes Set and cleared by software. Can only be accessed secure when one or more features in the PWR is/are secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000020 constant RCC_RCC_AHB4SMENR_ADC4SMEN                       \ ADC4 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC ADC4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.


\
\ @brief RCC AHB5 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0xC0
\ Reset value: 0xFFFFFFFF
\

$00000001 constant RCC_RCC_AHB5SMENR_RADIOSMEN                      \ 2.4 GHz RADIO bus clock enable during Sleep and Stop modes when the 2.4 GHz RADIO is active. Set and cleared by software. Access can be secured by GTZC_TZSC RADIOSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC APB1 peripheral clocks enable in Sleep and Stop modes register 1
\ Address offset: 0xC4
\ Reset value: 0xFFFFFFFF
\

$00000001 constant RCC_RCC_APB1SMENR1_TIM2SMEN                      \ TIM2 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC TIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000002 constant RCC_RCC_APB1SMENR1_TIM3SMEN                      \ TIM3 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC TIM3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000800 constant RCC_RCC_APB1SMENR1_WWDGSMEN                      \ Window watchdog bus clock enable during Sleep and Stop modes Set and cleared by software. This bit is forced to 1 by hardware when the hardware WWDG option is activated. Access can be secured by GTZC_TZSC WWDGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00020000 constant RCC_RCC_APB1SMENR1_USART2SMEN                    \ USART2 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC USART2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00200000 constant RCC_RCC_APB1SMENR1_I2C1SMEN                      \ I2C1 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC I2C1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.


\
\ @brief RCC APB1 peripheral clocks enable in Sleep and Stop modes register 2
\ Address offset: 0xC8
\ Reset value: 0xFFFFFFFF
\

$00000020 constant RCC_RCC_APB1SMENR2_LPTIM2SMEN                    \ LPTIM2 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC LPTIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.


\
\ @brief RCC APB2 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0xCC
\ Reset value: 0xFFFFFFFF
\

$00000800 constant RCC_RCC_APB2SMENR_TIM1SMEN                       \ TIM1 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC TIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00001000 constant RCC_RCC_APB2SMENR_SPI1SMEN                       \ SPI1 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC SPI1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00004000 constant RCC_RCC_APB2SMENR_USART1SMEN                     \ USART1 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC USART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00020000 constant RCC_RCC_APB2SMENR_TIM16SMEN                      \ TIM16 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC TIM16SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00040000 constant RCC_RCC_APB2SMENR_TIM17SMEN                      \ TIM17 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC TIM17SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC APB7 peripheral clock enable in Sleep and Stop modes register
\ Address offset: 0xD0
\ Reset value: 0xFFFFFFFF
\

$00000002 constant RCC_RCC_APB7SMENR_SYSCFGSMEN                     \ SYSCFG bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by SYSCFG SYSCFGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000020 constant RCC_RCC_APB7SMENR_SPI3SMEN                       \ SPI3 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC SPI3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000040 constant RCC_RCC_APB7SMENR_LPUART1SMEN                    \ LPUART1 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC LPUART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000080 constant RCC_RCC_APB7SMENR_I2C3SMEN                       \ I2C3 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC I2C3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000800 constant RCC_RCC_APB7SMENR_LPTIM1SMEN                     \ LPTIM1 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC LPTIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00200000 constant RCC_RCC_APB7SMENR_RTCAPBSMEN                     \ RTC and TAMP APB clock enable during Sleep and Stop modes Set and cleared by software. Can only be accessed secure when one or more features in the RTC or TAMP is/are secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.


\
\ @brief RCC peripherals independent clock configuration register 1
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_CCIPR1_USART1SEL                         \ USART1 kernel clock source selection This bits are used to select the USART1 kernel clock source. Access can be secured by GTZC_TZSC USART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The USART1 is functional in Stop 0 and Stop 1 mode only when the kernel clock is HSI16 or LSE.
$0000000c constant RCC_RCC_CCIPR1_USART2SEL                         \ USART2 kernel clock source selection This bits are used to select the USART2 kernel clock source. Access can be secured by GTZC_TZSC USART2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The USART2 is functional in Stop 0 and Stop 1 mode only when the kernel clock is HSI16 or LSE.
$00000c00 constant RCC_RCC_CCIPR1_I2C1SEL                           \ I2C1 kernel clock source selection These bits are used to select the I2C1 kernel clock source. Access can be secured by GTZC_TZSC I2C1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The I2C1 is functional in Stop 0 and Stop 1 mode only when the kernel clock is HSI16.
$000c0000 constant RCC_RCC_CCIPR1_LPTIM2SEL                         \ Low-power timer 2 kernel clock source selection These bits are used to select the LPTIM2 kernel clock source. Access can be secured by GTZC_TZSC LPTIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The LPTIM2 is functional in Stop 0 and Stop 1 mode only when the kernel clock is LSI, LSE or HSI16 if HSIKERON = 1.
$00300000 constant RCC_RCC_CCIPR1_SPI1SEL                           \ SPI1 kernel clock source selection These bits are used to select the SPI1 kernel clock source. Access can be secured by GTZC_TZSC SPI1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The SPI1 is functional in Stop 0 and Stop 1 mode only when the kernel clock is HSI16.
$00c00000 constant RCC_RCC_CCIPR1_SYSTICKSEL                        \ SysTick clock source selection These bits are used to select the SysTick clock source. Access can be secured by RCC SYSCLKSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: When LSE or LSI is selected, the AHB frequency must be at least four times higher than the LSI or LSE frequency. In addition, a jitter up to one hclk1 cycle is introduced, due to the LSE or LSI sampling with hclk1 in the SysTick circuitry.
$80000000 constant RCC_RCC_CCIPR1_TIMICSEL                          \ Clocks sources for TIM16,TIM17 and LPTIM2 internal input capture When the TIMICSEL bit is set, the TIM16, TIM17 and LPTIM2 internal input capture can be connected to HSI16/256. When TIMICSEL is cleared, the HSI16, clock sources cannot be selected as TIM16, TIM17 or LPTIM2 internal input capture. Access can be secured by GTZC_TZSC TIM16SEC, TIM17SEC, or LPTIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The clock division must be disabled (TIMICSEL configured to 0) before selecting or changing a clock sources division.


\
\ @brief RCC peripherals independent clock configuration register 2
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00003000 constant RCC_RCC_CCIPR2_RNGSEL                            \ RNGSEL kernel clock source selection These bits allow to select the RNG kernel clock source. Access can be secured by GTZC_TZSC RNGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.


\
\ @brief RCC peripherals independent clock configuration register 3
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_CCIPR3_LPUART1SEL                        \ LPUART1 kernel clock source selection These bits are used to select the LPUART1 kernel clock source. Access can be secured by GTZC_TZSC LPUART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The LPUART1 is functional in Stop modes only when the kernel clock is HSI16 or LSE.
$00000018 constant RCC_RCC_CCIPR3_SPI3SEL                           \ SPI3 kernel clock source selection These bits are used to select the SPI3 kernel clock source. Access can be secured by GTZC_TZSC SPI3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The SPI3 is functional in Stop modes only when the kernel clock is HSI16.
$000000c0 constant RCC_RCC_CCIPR3_I2C3SEL                           \ I2C3 kernel clock source selection These bits are used to select the I2C3 kernel clock source. Access can be secured by GTZC_TZSC I2C3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The I2C3 is functional in Stop modes only when the kernel clock is HSI16
$00000c00 constant RCC_RCC_CCIPR3_LPTIM1SEL                         \ LPTIM1 kernel clock source selection These bits are used to select the LPTIM1 kernel clock source. Access can be secured by GTZC_TZSC LPTIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The LPTIM1 is functional in Stop modes only when the kernel clock is LSI, LSE, HSI16 with HSIKERON = 1.
$00007000 constant RCC_RCC_CCIPR3_ADCSEL                            \ ADC4 kernel clock source selection These bits are used to select the ADC4 kernel clock source. Access can be secured by GTZC_TZSC ADC4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. others: reserved Note: The ADC4 is functional in Stop modes only when the kernel clock is HSI16.


\
\ @brief RCC backup domain control register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_BDCR1_LSEON                              \ LSE oscillator enable Set and cleared by software. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000002 constant RCC_RCC_BDCR1_LSERDY                             \ LSE oscillator ready Set and cleared by hardware to indicate when the external 32kHz oscillator is stable. After the LSEON bit is cleared, LSERDY goes low after six external low-speed oscillator clock cycles. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000004 constant RCC_RCC_BDCR1_LSEBYP                             \ LSE oscillator bypass Set and cleared by software to bypass oscillator in debug mode. This bit can be written only when the external 32kHz oscillator is disabled (LSEON = 0 and LSERDY = 0). Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000018 constant RCC_RCC_BDCR1_LSEDRV                             \ LSE oscillator drive capability Set by software to modulate the drive capability of the LSE oscillator. LSEDRV must be programmed to a different value than 0 before enabling the LSE oscillator in 'Xtal' mode. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The oscillator is in 'Xtal mode' when it is not in bypass mode.
$00000020 constant RCC_RCC_BDCR1_LSECSSON                           \ Low speed external clock security enable Set by software to enable the LSECSS. LSECSSON must be enabled after the LSE oscillator is enabled (LSEON bit enabled) and ready (LSERDY flag set by hardware) and after the RTCSEL bit is selected. Once enabled, this bit cannot be disabled, except after a LSE failure detection (LSECSSD=1). In that case, the software must disable the LSECSSON bit. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000040 constant RCC_RCC_BDCR1_LSECSSD                            \ Low speed external clock security, LSE failure Detection Set by hardware to indicate when a failure is detected by the LSECCS on the external 32kHz oscillator. Reset when LSCSSON bit is cleared. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000080 constant RCC_RCC_BDCR1_LSESYSEN                           \ LSE system clock (LSESYS) enable Set by software to enable the LSE system clock generated by RCC. The lsesys clock is used for peripherals (USART, LPUART, LPTIM, RNG, 2.4 GHz RADIO) and functions (LSCO, MCO, TIM triggers, LPTIM trigger) excluding the RTC, TAMP and LSECSS. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000300 constant RCC_RCC_BDCR1_RTCSEL                             \ RTC and TAMP kernel clock source enable and selection Set by software to enable and select the clock source for the RTC. Can only be accessed secure when one or more features in the RTC or TAMP is/are secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00000800 constant RCC_RCC_BDCR1_LSESYSRDY                          \ LSE system clock (LSESYS) ready Set and cleared by hardware to indicate when the LSE system clock is stable.When the LSESYSEN bit is set, the LSESYSRDY flag is set after two LSE clock cycles. The LSE clock must be already enabled and stable (LSEON and LSERDY are set). When the LSEON bit is cleared, LSERDY goes low after six external low-speed oscillator clock cycles. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00001000 constant RCC_RCC_BDCR1_LSEGFON                            \ LSE clock glitch filter enable Set and cleared by hardware to enable the LSE glitch filter. This bit can be written only when the LSE is disabled (LSEON = 0 and LSERDY = 0). Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$00006000 constant RCC_RCC_BDCR1_LSETRIM                            \ LSE trimming These bits are initialized at startup and after OBL_LAUNCH with SBF cleared with the factory-programmed LSE calibration value. Set and cleared by software. These bits must be modified only once after a BOR reset or an OBL_LAUNCH and before enabling LSE with LSEON (when both LSEON = 0 and LSERDY= 0). Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: OBL_LAUNCH of this field occurs only when SBF is cleared and must then only be started by software when LSE oscillator is disabled, LSEON = 0 and LSERDY = 0.
$00010000 constant RCC_RCC_BDCR1_BDRST                              \ Backup domain software reset Set and cleared by software. Can only be accessed secure when one or more features in the RTC or TAMP is secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$000c0000 constant RCC_RCC_BDCR1_RADIOSTSEL                         \ 2.4 GHz RADIO sleep timer kernel clock enable and selection Set and cleared by software. Access can be secured by GTZC_TZSC RADIOSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$01000000 constant RCC_RCC_BDCR1_LSCOEN                             \ Low-speed clock output (LSCO) enable Set and cleared by software. Access can be secured by RCC LSISEC and/or RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$02000000 constant RCC_RCC_BDCR1_LSCOSEL                            \ Low-speed clock output selection Set and cleared by software. Access can be secured by RCC LSISEC and/or RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$04000000 constant RCC_RCC_BDCR1_LSI1ON                             \ LSI1 oscillator enable Set and cleared by software. Access can be secured by RCC LSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$08000000 constant RCC_RCC_BDCR1_LSI1RDY                            \ LSI1 oscillator ready Set and cleared by hardware to indicate when the LSI1 oscillator is stable. After the LSI1ON bit is cleared, LSI1RDY goes low after three internal low-speed oscillator clock cycles. This bit is set when the LSI1 is used by IWDG or RTC, even if LSI1ON = 0. Access can be secured by RCC LSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$10000000 constant RCC_RCC_BDCR1_LSI1PREDIV                         \ LSI1 Low-speed clock divider configuration Set and cleared by software to enable the LSI1 division. This bit can be written only when the LSI1 is disabled (LSI1ON = 0 and LSI1RDY = 0). The LSI1PREDIV cannot be changed if the LSI1 is used by the IWDG or by the RTC. Access can be secured by RCC LSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$20000000 constant RCC_RCC_BDCR1_LSI2ON                             \ LSI2 oscillator enable
$40000000 constant RCC_RCC_BDCR1_LSI2RDY                            \ LSI2 oscillator ready


\
\ @brief RCC control/status register
\ Address offset: 0xF4
\ Reset value: 0x0C000000
\

$00800000 constant RCC_RCC_CSR_RMVF                                 \ Remove reset flag Set by software to clear the reset flags. Access can be secured by RCC RMVFSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
$02000000 constant RCC_RCC_CSR_OBLRSTF                              \ Option byte loader reset flag Set by hardware when a reset from the option byte loading occurs. Cleared by writing to the RMVF bit.
$04000000 constant RCC_RCC_CSR_PINRSTF                              \ NRST pin reset flag Set by hardware when a reset from the NRST pin occurs. Cleared by writing to the RMVF bit.
$08000000 constant RCC_RCC_CSR_BORRSTF                              \ BOR flag Set by hardware when a BOR occurs. Cleared by writing to the RMVF bit.
$10000000 constant RCC_RCC_CSR_SFTRSTF                              \ Software reset flag Set by hardware when a software reset occurs. Cleared by writing to the RMVF bit.
$20000000 constant RCC_RCC_CSR_IWDGRSTF                             \ Independent watchdog reset flag Set by hardware when an independent watchdog reset domain occurs. Cleared by writing to the RMVF bit.
$40000000 constant RCC_RCC_CSR_WWDGRSTF                             \ Window watchdog reset flag Set by hardware when a window watchdog reset occurs. Cleared by writing to the RMVF bit.
$80000000 constant RCC_RCC_CSR_LPWRRSTF                             \ Low-power reset flag Set by hardware when a reset occurs due to illegal Stop and Standby modes entry. Cleared by writing to the RMVF bit.


\
\ @brief RCC secure configuration register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_SECCFGR_HSISEC                           \ HSI16 clock configuration and status bits security Set and reset by software.
$00000002 constant RCC_RCC_SECCFGR_HSESEC                           \ HSE32 clock configuration bits, status bits and HSECSS security Set and reset by software.
$00000008 constant RCC_RCC_SECCFGR_LSISEC                           \ LSI clock configuration and status bits security Set and reset by software.
$00000010 constant RCC_RCC_SECCFGR_LSESEC                           \ LSE clock configuration and status bits security Set and reset by software.
$00000020 constant RCC_RCC_SECCFGR_SYSCLKSEC                        \ SYSCLK selection, clock output on MCO configuration security Set and reset by software.
$00000040 constant RCC_RCC_SECCFGR_PRESCSEC                         \ AHBx/APBx prescaler configuration bits security Set and reset by software.
$00000080 constant RCC_RCC_SECCFGR_PLL1SEC                          \ PLL1 clock configuration and status bits security Set and reset by software.
$00001000 constant RCC_RCC_SECCFGR_RMVFSEC                          \ Remove reset flag security Set and reset by software.


\
\ @brief RCC privilege configuration register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_PRIVCFGR_SPRIV                           \ RCC secure functions privilege configuration Set and reset by software. This bit can be written only by a secure privileged access.
$00000002 constant RCC_RCC_PRIVCFGR_NSPRIV                          \ RCC non-secure functions privilege configuration Set and reset by software. This bit can be written only by privileged access, secure or non-secure.


\
\ @brief RCC clock configuration register 2
\ Address offset: 0x200
\ Reset value: 0x00000010
\

$00000007 constant RCC_RCC_CFGR4_HPRE5                              \ AHB5 prescaler when SWS select PLL1 Set and cleared by software to control the division factor of the AHB5 clock (hclk5). Must not be changed when SYSCLK source indicated by SWS is PLL1. When SYSCLK source indicated by SWS is not PLL1: HPRE5 is not taken into account. When SYSCLK source indicated by SWS is PLL1: HPRE5 is taken into account, from the moment the system clock switch occurs Depending on the device voltage range, the software must set these bits correctly to ensure that the AHB5 frequency does not exceed the maximum allowed frequency (for more details, refer to Table99: SYSCLK and bus maximum frequency). After a write operation to these bits and before decreasing the voltage range, this register must be read to be sure that the new value is taken into account. 0xx: hclk5 = SYSCLK not divided
$00000010 constant RCC_RCC_CFGR4_HDIV5                              \ AHB5 divider when SWS select HSI16 or HSE32 Set and reset by software. Set to 1 by hardware when entering Stop 1 mode. When SYSCLK source indicated by SWS is HSI16 or HSE32: HDIV5 is taken into account When SYSCLK source indicated by SWS is PLL1: HDIV5 is taken not taken into account Depending on the device voltage range, the software must set this bit correctly to ensure that the AHB5 frequency does not exceed the maximum allowed frequency (for more details, refer to Table99). After a write operation to this bit and before decreasing the voltage range, this register must be read to be sure that the new value is taken into account.


\
\ @brief RCC RADIO peripheral clock enable register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_RADIOENR_BBCLKEN                         \ 2.4 GHz RADIO baseband kernel clock (aclk) enable Set and cleared by software. Note: The HSE32 oscillator needs to be enabled by either HSEON or STRADIOCLKON.
$00010000 constant RCC_RCC_RADIOENR_STRADIOCLKON                    \ 2.4 GHz RADIO bus clock enable and HSE32 oscillator enable by 2.4 GHz RADIO sleep timer wakeup event Set by hardware on a 2.4 GHz RADIO sleep timer wakeup event. Cleared by software writing zero to this bit. Note: Before accessing the 2.4 GHz RADIO registers the RADIOCLKRDY bit must be checked.
$00020000 constant RCC_RCC_RADIOENR_RADIOCLKRDY                     \ 2.4 GHz RADIO bus clock ready. Set and cleared by hardware to indicate that the 2.4 GHz RADIO bus clock is ready and the 2.4 GHz RADIO registers can be accessed. Note: Once both RADIOEN and STRADIOCLKON are cleared, RADIOCLKRDY goes low after three hclk5 clock cycles.


\
\ @brief RCC external clock sources calibration register 1
\ Address offset: 0x210
\ Reset value: 0x00200000
\

$003f0000 constant RCC_RCC_ECSCR1_HSETRIM                           \ HSE32 clock trimming These bits provide user-programmable capacitor trimming value. It can be programmed to adjust the HSE32 oscillator frequency.


\
\ @brief Reset and clock control
\
$46020c00 constant RCC_RCC_CR     \ offset: 0x00 : RCC clock control register
$46020c10 constant RCC_RCC_ICSCR3  \ offset: 0x10 : RCC internal clock sources calibration register 3
$46020c1c constant RCC_RCC_CFGR1  \ offset: 0x1C : RCC clock configuration register 1
$46020c20 constant RCC_RCC_CFGR2  \ offset: 0x20 : RCC clock configuration register 2
$46020c24 constant RCC_RCC_CFGR3  \ offset: 0x24 : RCC clock configuration register 3
$46020c28 constant RCC_RCC_PLL1CFGR  \ offset: 0x28 : RCC PLL1 configuration register
$46020c34 constant RCC_RCC_PLL1DIVR  \ offset: 0x34 : RCC PLL1 dividers register
$46020c38 constant RCC_RCC_PLL1FRACR  \ offset: 0x38 : RCC PLL1 fractional divider register
$46020c50 constant RCC_RCC_CIER   \ offset: 0x50 : RCC clock interrupt enable register
$46020c54 constant RCC_RCC_CIFR   \ offset: 0x54 : RCC clock interrupt flag register
$46020c58 constant RCC_RCC_CICR   \ offset: 0x58 : RCC clock interrupt clear register
$46020c60 constant RCC_RCC_AHB1RSTR  \ offset: 0x60 : RCC AHB1 peripheral reset register
$46020c64 constant RCC_RCC_AHB2RSTR  \ offset: 0x64 : RCC AHB2 peripheral reset register
$46020c6c constant RCC_RCC_AHB4RSTR  \ offset: 0x6C : RCC AHB4 peripheral reset register
$46020c70 constant RCC_RCC_AHB5RSTR  \ offset: 0x70 : RCC AHB5 peripheral reset register
$46020c74 constant RCC_RCC_APB1RSTR1  \ offset: 0x74 : RCC APB1 peripheral reset register 1
$46020c78 constant RCC_RCC_APB1RSTR2  \ offset: 0x78 : RCC APB1 peripheral reset register 2
$46020c7c constant RCC_RCC_APB2RSTR  \ offset: 0x7C : RCC APB2 peripheral reset register
$46020c80 constant RCC_RCC_APB7RSTR  \ offset: 0x80 : RCC APB7 peripheral reset register
$46020c88 constant RCC_RCC_AHB1ENR  \ offset: 0x88 : RCC AHB1 peripheral clock enable register
$46020c8c constant RCC_RCC_AHB2ENR  \ offset: 0x8C : RCC AHB2 peripheral clock enable register
$46020c94 constant RCC_RCC_AHB4ENR  \ offset: 0x94 : RCC AHB4 peripheral clock enable register
$46020c98 constant RCC_RCC_AHB5ENR  \ offset: 0x98 : RCC AHB5 peripheral clock enable register
$46020c9c constant RCC_RCC_APB1ENR1  \ offset: 0x9C : RCC APB1 peripheral clock enable register 1
$46020ca0 constant RCC_RCC_APB1ENR2  \ offset: 0xA0 : RCC APB1 peripheral clock enable register 2
$46020ca4 constant RCC_RCC_APB2ENR  \ offset: 0xA4 : RCC APB2 peripheral clock enable register
$46020ca8 constant RCC_RCC_APB7ENR  \ offset: 0xA8 : RCC APB7 peripheral clock enable register
$46020cb0 constant RCC_RCC_AHB1SMENR  \ offset: 0xB0 : RCC AHB1 peripheral clocks enable in Sleep and Stop modes register
$46020cb4 constant RCC_RCC_AHB2SMENR  \ offset: 0xB4 : RCC AHB2 peripheral clocks enable in Sleep and Stop modes register
$46020cbc constant RCC_RCC_AHB4SMENR  \ offset: 0xBC : RCC AHB4 peripheral clocks enable in Sleep and Stop modes register
$46020cc0 constant RCC_RCC_AHB5SMENR  \ offset: 0xC0 : RCC AHB5 peripheral clocks enable in Sleep and Stop modes register
$46020cc4 constant RCC_RCC_APB1SMENR1  \ offset: 0xC4 : RCC APB1 peripheral clocks enable in Sleep and Stop modes register 1
$46020cc8 constant RCC_RCC_APB1SMENR2  \ offset: 0xC8 : RCC APB1 peripheral clocks enable in Sleep and Stop modes register 2
$46020ccc constant RCC_RCC_APB2SMENR  \ offset: 0xCC : RCC APB2 peripheral clocks enable in Sleep and Stop modes register
$46020cd0 constant RCC_RCC_APB7SMENR  \ offset: 0xD0 : RCC APB7 peripheral clock enable in Sleep and Stop modes register
$46020ce0 constant RCC_RCC_CCIPR1  \ offset: 0xE0 : RCC peripherals independent clock configuration register 1
$46020ce4 constant RCC_RCC_CCIPR2  \ offset: 0xE4 : RCC peripherals independent clock configuration register 2
$46020ce8 constant RCC_RCC_CCIPR3  \ offset: 0xE8 : RCC peripherals independent clock configuration register 3
$46020cf0 constant RCC_RCC_BDCR1  \ offset: 0xF0 : RCC backup domain control register
$46020cf4 constant RCC_RCC_CSR    \ offset: 0xF4 : RCC control/status register
$46020d10 constant RCC_RCC_SECCFGR  \ offset: 0x110 : RCC secure configuration register
$46020d14 constant RCC_RCC_PRIVCFGR  \ offset: 0x114 : RCC privilege configuration register
$46020e00 constant RCC_RCC_CFGR4  \ offset: 0x200 : RCC clock configuration register 2
$46020e08 constant RCC_RCC_RADIOENR  \ offset: 0x208 : RCC RADIO peripheral clock enable register
$46020e10 constant RCC_RCC_ECSCR1  \ offset: 0x210 : RCC external clock sources calibration register 1

