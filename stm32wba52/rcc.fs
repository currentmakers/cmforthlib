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
    \ @brief RCC clock control register
    \ Address offset: 0x00
    \ Reset value: 0x00000500
    \
    $08 constant RCC_HSION                      \ [0x08] HSI16 clock enable Set and cleared by software. Cleared by hardware when entering Stop and Standby modes. Set by hardware to force the HSI16 oscillator on when exiting Stop and Standby modes. Set by hardware to force the HSI16 oscillator on in case of clock security failure of the HSE32 crystal oscillator. This bit is set by hardware if the HSI16 is used directly or indirectly as system clock. Access to the bit can be secured by RCC HSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $09 constant RCC_HSIKERON                   \ [0x09] HSI16 enable for some peripheral kernels Set and cleared by software to force HSI16 oscillator on even in Stop modes. Keeping the HSI16 oscillator on in Stop modes allows the communication speed not to be reduced by the HSI16 oscillator startup time. This bit has no effect on register bit HSION value. Cleared by hardware when entering Standby modes. Refer to Peripherals clock gating and autonomous mode for more details. Access to the bit can be secured by RCC HSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0a constant RCC_HSIRDY                     \ [0x0a] HSI16 clock ready flag Set by hardware to indicate that HSI16 oscillator is stable. This bit is set only when HSI16 is enabled by software by setting HSION. Access to the bit can be secured by RCC HSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: Once the HSION bit is cleared, HSIRDY goes low after six HSI16 clock cycles.
    $10 constant RCC_HSEON                      \ [0x10] HSE32 clock enable Set and cleared by software. Cleared by hardware to stop the HSE32 clock for the CPU when entering Stop and Standby modes and on a HSECSS failure. When the HSE32 is used as 2.4 GHz RADIO kernel clock, enabled by RADIOEN and RADIOSMEN and the 2.4 GHz RADIO is active, HSEON is not be cleared when entering low power mode. In this case only Stop 0 mode is entered as low power mode. This bit cannot be reset if the HSE32 oscillator is used directly or indirectly as the system clock. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $11 constant RCC_HSERDY                     \ [0x11] HSE32 clock ready flag Set by hardware to indicate that the HSE32 oscillator is stable. This bit is set both when HSE32 is enabled by software by setting HSEON and when requested as kernel clock by the 2.4 GHz RADIO. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $13 constant RCC_HSECSSON                   \ [0x13] HSE32 clock security system enable Set by software to enable the HSE32 clock security system. When HSECSSON is set, the clock detector is enabled by hardware when the HSE32 oscillator is ready and disabled by hardware if a HSE32 clock failure is detected. This bit is set only and is cleared by reset. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $14 constant RCC_HSEPRE                     \ [0x14] HSE32 clock for SYSCLK prescaler Set and cleared by software to control the division factor of the HSE32 clock for SYSCLK. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $18 constant RCC_PLL1ON                     \ [0x18] PLL1 enable Set and cleared by software to enable the main PLL. Cleared by hardware when entering Stop or Standby modes and when PLL1 on HSE32 is selected as sysclk, on a HSECSS failure. This bit cannot be reset if the PLL1 clock is used as the system clock. Access to the bit can be secured by RCC PLL1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $19 constant RCC_PLL1RDY                    \ [0x19] PLL1 clock ready flag Set by hardware to indicate that the PLL1 is locked. Access to the bit can be secured by RCC PLL1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_ICSCR3_DEF
    \
    \ @brief RCC internal clock sources calibration register 3
    \ Address offset: 0x10
    \ Reset value: 0x00100000
    \
    $00 constant RCC_HSICAL                     \ [0x00 : 12] HSI16 clock calibration These bits are initialized at startup with the factory-programmed HSI16 calibration value. When HSITRIM[4:0] is written, HSICAL[11:0] is updated with the sum of HSITRIM[4:0] and the initial factory trim value.
    $10 constant RCC_HSITRIM                    \ [0x10 : 5] HSI16 clock trimming These bits provide an additional user-programmable trimming value that is added to the HSICAL[11:0] bits. It can be programmed to adjust to voltage and temperature variations that influence the frequency of the HSI16.
  [then]


  [ifdef] RCC_RCC_CFGR1_DEF
    \
    \ @brief RCC clock configuration register 1
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW                         \ [0x00 : 2] system clock switch Set and cleared by software to select system clock source (SYSCLK). Cleared by hardware when entering Stop and Standby modes When selecting HSE32 directly or indirectly as system clock and HSE32 oscillator clock security fails, cleared by hardware.
    $02 constant RCC_SWS                        \ [0x02 : 2] system clock switch status Set and cleared by hardware to indicate which clock source is used as system clock.
    $18 constant RCC_MCOSEL                     \ [0x18 : 4] microcontroller clock output Set and cleared by software. others: reserved Note: This clock output may have some truncated cycles at startup or during MCO clock source switching.
    $1c constant RCC_MCOPRE                     \ [0x1c : 3] microcontroller clock output prescaler Set and cleared by software. It is highly recommended to change this prescaler before MCO output is enabled. others: not allowed
  [then]


  [ifdef] RCC_RCC_CFGR2_DEF
    \
    \ @brief RCC clock configuration register 2
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPRE                       \ [0x00 : 3] AHB1, AHB2 and AHB4 prescaler Set and cleared by software to control the division factor of the AHB1, AHB2 and AHB4 clock (hclk1). The software must limit the incremental frequency step by setting these bits correctly to ensure that the hclk1 maximum incremental frequency step does not exceed the maximum allowed incremental frequency step (for more details, refer to Table99: SYSCLK and bus maximum frequency). After a write operation to these bits and before decreasing the voltage range, this register must be read to be sure that the new value is taken into account. 0xx: hclk1 = SYSCLK not divided
    $04 constant RCC_PPRE1                      \ [0x04 : 3] APB1 prescaler Set and cleared by software to control the division factor of the APB1 clock (pclk1). 0xx: pclk1 = hclk1 not divided
    $08 constant RCC_PPRE2                      \ [0x08 : 3] APB2 prescaler Set and cleared by software to control the division factor of the APB2 clock (pclk2). 0xx: pclk2 = hclk1 not divided
  [then]


  [ifdef] RCC_RCC_CFGR3_DEF
    \
    \ @brief RCC clock configuration register 3
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $04 constant RCC_PPRE7                      \ [0x04 : 3] APB7 prescaler Set and cleared by software to control the division factor of the APB7 clock (pclk7). 0xx: hclk1 not divided
  [then]


  [ifdef] RCC_RCC_PLL1CFGR_DEF
    \
    \ @brief RCC PLL1 configuration register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL1SRC                    \ [0x00 : 2] PLL1 entry clock source Set and cleared by software to select PLL1 clock source. These bits can be written only when the PLL1 is disabled. Cleared by hardware when entering Stop or Standby modes. Note: In order to save power, when no PLL1 clock is used, the value of PLL1SRC must be 0.
    $02 constant RCC_PLL1RGE                    \ [0x02 : 2] PLL1 input frequency range Set and reset by software to select the proper reference frequency range used for PLL1. This bit must be written before enabling the PLL1. 00-01-10: PLL1 input (ref1_ck) clock range frequency between 4 and 8 MHz
    $04 constant RCC_PLL1FRACEN                 \ [0x04] PLL1 fractional latch enable Set and reset by software to latch the content of PLL1FRACN into the modulator. In order to latch the PLL1FRACN value into the modulator, PLL1FRACEN must be set to 0, then set to 1: the transition 0 to 1 transfers the content of PLL1FRACN into the modulator (see PLL1 initialization phase for details).
    $08 constant RCC_PLL1M                      \ [0x08 : 3] Prescaler for PLL1 Set and cleared by software to configure the prescaler of the PLL1. The VCO1 input frequency is PLL1 input clock frequency/PLL1M. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
    $10 constant RCC_PLL1PEN                    \ [0x10] PLL1 DIVP divider output enable Set and reset by software to enable the pll1pclk output of the PLL1. To save power, PLL1PEN and PLL1P bits must be set to 0 when the pll1pclk is not used. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).
    $11 constant RCC_PLL1QEN                    \ [0x11] PLL1 DIVQ divider output enable Set and reset by software to enable the pll1qclk output of the PLL1. To save power, PLL1QEN and PLL1Q bits must be set to 0 when the pll1qclk is not used. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).
    $12 constant RCC_PLL1REN                    \ [0x12] PLL1 DIVR divider output enable Set and cleared by software to enable the pll1rclk output of the PLL1. To save power, PLL1REN and PLL1R bits must be set to 0 when the pll1rclk is not used. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0).
    $14 constant RCC_PLL1RCLKPRE                \ [0x14] pll1rclk clock for SYSCLK prescaler division enable Set and cleared by software to control the division of the pll1rclk clock for SYSCLK.
    $15 constant RCC_PLL1RCLKPRESTEP            \ [0x15] pll1rclk clock for SYSCLK prescaler division step selection Set and cleared by software to control the division step of the pll1rclk clock for SYSCLK.
    $16 constant RCC_PLL1RCLKPRERDY             \ [0x16] pll1rclkpre not divided ready. Set by hardware after PLL1RCLKPRE has been set from divided to not divide, to indicate that the pll1rclk not divided is available on sysclkpre.
  [then]


  [ifdef] RCC_RCC_PLL1DIVR_DEF
    \
    \ @brief RCC PLL1 dividers register
    \ Address offset: 0x34
    \ Reset value: 0x01010280
    \
    $00 constant RCC_PLL1N                      \ [0x00 : 9] Multiplication factor for PLL1 VCO Set and reset by software to control the multiplication factor of the VCO. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ... ... others: reserved VCO output frequency = Fsubref1_ck/sub x multiplication factor for PLL1 VCO, when fractional value 0 has been loaded into PLL1FRACN, with: Multiplication factor for PLL1 VCO between 4 and 512 input frequency Fsubref1_ck/sub between 4 and 16MHz
    $09 constant RCC_PLL1P                      \ [0x09 : 7] PLL1 DIVP division factor Set and reset by software to control the frequency of the pll1pclk clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). Note that odd division factors are not allowed. ...
    $10 constant RCC_PLL1Q                      \ [0x10 : 7] PLL1 DIVQ division factor Set and reset by software to control the frequency of the PLl1QCLK clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
    $18 constant RCC_PLL1R                      \ [0x18 : 7] PLL1 DIVR division factor Set and reset by software to control the frequency of the pll1rclk clock. These bits can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
  [then]


  [ifdef] RCC_RCC_PLL1FRACR_DEF
    \
    \ @brief RCC PLL1 fractional divider register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $03 constant RCC_PLL1FRACN                  \ [0x03 : 13] Fractional part of the multiplication factor for PLL1 VCO Set and reset by software to control the fractional part of the multiplication factor of the VCO. These bits can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. VCO output frequency = Fsubref1_ck/sub x [multiplication factor for PLL1 VCO + (PLL1FRACN / 2sup13/sup)], with: Multiplication factor for PLL1 VCO must be between 4 and 512. PLL1FRACN can be between 0 and 2sup13/sup- 1. The input frequency Fsubref1_ck/sub must be between 4 and 16 MHz. To change the used fractional value on-the-fly even if the PLL1 is enabled, the application must proceed as follows: Set the bit PLL1FRACEN to 0. Write the new fractional value into PLL1FRACN. Set the bit PLL1FRACEN to 1.
  [then]


  [ifdef] RCC_RCC_CIER_DEF
    \
    \ @brief RCC clock interrupt enable register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSI1RDYIE                  \ [0x00] LSI1 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSI1 oscillator stabilization. Access to the bit can be secured by RCC LSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSE oscillator stabilization. Access to the bit can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI16 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSI16 oscillator stabilization. Access to the bit can be secured by RCC HSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE32 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSE32 oscillator stabilization. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $06 constant RCC_PLL1RDYIE                  \ [0x06] PLL1 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by PLL1 lock. Access to the bit can be secured by RCC PLL1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_CIFR_DEF
    \
    \ @brief RCC clock interrupt flag register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSI1RDYF                   \ [0x00] LSI1 ready interrupt flag Set by hardware when the LSI1 clock becomes stable and LSI1RDYIE is set. Cleared by software setting the LSI1RDYC bit. Access to the bit can be secured by RCC LSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag Set by hardware when the LSE clock becomes stable and LSERDYIE is set. Cleared by software setting the LSERDYC bit. Access to the bit can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $03 constant RCC_HSIRDYF                    \ [0x03] HSI16 ready interrupt flag Set by hardware when the HSI16 clock becomes stable and HSIRDYIE is set in a response to setting the HSION (see RCC_CR). When HSION is not set but the HSI16 oscillator is enabled by the peripheral through a clock request, this bit is not set and no interrupt is generated. Access to the bit can be secured by RCC HSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Cleared by software setting the HSIRDYC bit.
    $04 constant RCC_HSERDYF                    \ [0x04] HSE32 ready interrupt flag Set by hardware when the HSE32 clock becomes stable and HSERDYIE is set. Cleared by software setting the HSERDYC bit. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $06 constant RCC_PLL1RDYF                   \ [0x06] PLL1 ready interrupt flag Set by hardware when the PLL1 locks and PLL1RDYIE is set. Cleared by software setting the PLL1RDYC bit. Access to the bit can be secured by RCC PLL1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0a constant RCC_HSECSSF                    \ [0x0a] HSE32 clock security system interrupt flag Set by hardware when a clock security failure is detected in the HSE32 oscillator. Cleared by software setting the HSECSSC bit. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_CICR_DEF
    \
    \ @brief RCC clock interrupt clear register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSI1RDYC                   \ [0x00] LSI1 ready interrupt clear Writing this bit to 1 clears the LSI1RDYF flag. Writing 0 has no effect. Access to the bit can be secured by RCC LSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $01 constant RCC_LSERDYC                    \ [0x01] LSE ready interrupt clear Writing this bit to 1 clears the LSERDYF flag. Writing 0 has no effect. Access to the bit can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $03 constant RCC_HSIRDYC                    \ [0x03] HSI16 ready interrupt clear Writing this bit to 1 clears the HSIRDYF flag. Writing 0 has no effect. Access to the bit can be secured by RCC HSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $04 constant RCC_HSERDYC                    \ [0x04] HSE32 ready interrupt clear Writing this bit to 1 clears the HSERDYF flag. Writing 0 has no effect. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $06 constant RCC_PLL1RDYC                   \ [0x06] PLL1 ready interrupt clear Writing this bit to 1 clears the PLL1RDYF flag. Writing 0 has no effect. Access to the bit can be secured by RCC PLL1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0a constant RCC_HSECSSC                    \ [0x0a] High speed external clock security system interrupt clear Writing this bit to 1 clears the HSECSSF flag. Writing 0 has no effect. Access to the bit can be secured by RCC HSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_AHB1RSTR_DEF
    \
    \ @brief RCC AHB1 peripheral reset register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPDMA1RST                  \ [0x00] GPDMA1 reset Set and cleared by software. Access can be secured by GPDMA1 SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0c constant RCC_CRCRST                     \ [0x0c] CRC reset Set and cleared by software. Access can be secured by GTZC_TZSC CRCSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $10 constant RCC_TSCRST                     \ [0x10] TSC reset Set and cleared by software. Access can be secured by GTZC_TZSC TSCSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_AHB2RSTR_DEF
    \
    \ @brief RCC AHB2 peripheral reset register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] IO port A reset Set and cleared by software. Access can be secured by GPIOA SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $01 constant RCC_GPIOBRST                   \ [0x01] IO port B reset Set and cleared by software. Access can be secured by GPIOB SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $02 constant RCC_GPIOCRST                   \ [0x02] IO port C reset Set and cleared by software. Access can be secured by GPIOC SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $07 constant RCC_GPIOHRST                   \ [0x07] IO port H reset Set and cleared by software. Access can be secured by GPIOH SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $10 constant RCC_AESRST                     \ [0x10] AES hardware accelerator reset Set and cleared by software. Access can be secured by GTZC_TZSC AESSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $11 constant RCC_HASHRST                    \ [0x11] Hash reset Set and cleared by software. Access can be secured by GTZC_TZSC HASHSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $12 constant RCC_RNGRST                     \ [0x12] Random number generator reset Set and cleared by software. Access can be secured by GTZC_TZSC RNGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $13 constant RCC_SAESRST                    \ [0x13] SAES hardware accelerator reset Set and cleared by software. Access can be secured by GTZC_TZSC SAESSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $14 constant RCC_HSEMRST                    \ [0x14] HSEM hardware accelerator reset Set and cleared by software. Can only be accessed secure when one or more features in the HSEM is secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $15 constant RCC_PKARST                     \ [0x15] PKA reset Set and cleared by software. Access can be secured by GTZC_TZSC PKASEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_AHB4RSTR_DEF
    \
    \ @brief RCC AHB4 peripheral reset register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $05 constant RCC_ADC4RST                    \ [0x05] ADC4 reset Set and cleared by software. Access can be secred by GTZC_TZSC ADC4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_AHB5RSTR_DEF
    \
    \ @brief RCC AHB5 peripheral reset register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RADIORST                   \ [0x00] 2.4 GHz RADIO reset Set and cleared by software. Access can be secured by GTZC_TZSC RADIOSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_APB1RSTR1_DEF
    \
    \ @brief RCC APB1 peripheral reset register 1
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 reset Set and cleared by software. Access can be secured by GTZC_TZSC TIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 reset Set and cleared by software. Access can be secured by GTZC_TZSC TIM3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $11 constant RCC_USART2RST                  \ [0x11] USART2 reset Set and cleared by software. Access can be secured by GTZC_TZSC UART2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset Set and cleared by software. Access can be secured by GTZC_TZSC I2C1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_APB1RSTR2_DEF
    \
    \ @brief RCC APB1 peripheral reset register 2
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $05 constant RCC_LPTIM2RST                  \ [0x05] LPTIM2 reset Set and cleared by software. Access can be secured by GTZC_TZSC LPTIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_APB2RSTR_DEF
    \
    \ @brief RCC APB2 peripheral reset register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $0b constant RCC_TIM1RST                    \ [0x0b] TIM1 reset Set and cleared by software. Access can be secured by GTZC_TZSC TIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 reset Set and cleared by software. Access can be secured by GTZC_TZSC SPI1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0e constant RCC_USART1RST                  \ [0x0e] USART1 reset Set and cleared by software. Access can be secured by GTZC_TZSC USART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 reset Set and cleared by software. Access can be secured by GTZC_TZSC TIM16SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $12 constant RCC_TIM17RST                   \ [0x12] TIM17 reset Set and cleared by software. Access can be secured by GTZC_TZSC TIM17SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_APB7RSTR_DEF
    \
    \ @brief RCC APB7 peripheral reset register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SYSCFGRST                  \ [0x01] SYSCFG reset Set and cleared by software. Access can be secured by SYSCFG SYSCFGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $05 constant RCC_SPI3RST                    \ [0x05] SPI3 reset Set and cleared by software. Access can be secured by GTZC_TZSC SPI3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $06 constant RCC_LPUART1RST                 \ [0x06] LPUART1 reset Set and cleared by software. Access can be secured by GTZC_TZSC LPUART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $07 constant RCC_I2C3RST                    \ [0x07] I2C3 reset Set and cleared by software. Access can be secured by GTZC_TZSC I2C3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0b constant RCC_LPTIM1RST                  \ [0x0b] LPTIM1 reset Set and cleared by software. Access can be secured by GTZC_TZSC LPTIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_AHB1ENR_DEF
    \
    \ @brief RCC AHB1 peripheral clock enable register
    \ Address offset: 0x88
    \ Reset value: 0x80000100
    \
    $00 constant RCC_GPDMA1EN                   \ [0x00] GPDMA1 bus clock enable Set and cleared by software. Access can be secured by GPDMA1 SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $08 constant RCC_FLASHEN                    \ [0x08] FLASH bus clock enable Set and cleared by software. This bit can be disabled only when the Flash memory is in power down mode. Can only be accessed secured when the Flash security state is secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0c constant RCC_CRCEN                      \ [0x0c] CRC bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC CRCSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $10 constant RCC_TSCEN                      \ [0x10] Touch sensing controller bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC TSCSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $11 constant RCC_RAMCFGEN                   \ [0x11] RAMCFG bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC RAMCFGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $18 constant RCC_GTZC1EN                    \ [0x18] GTZC1 bus clock enable Set and reset by software. Can only be accessed secure when device is secure (TZEN = 1). When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $1f constant RCC_SRAM1EN                    \ [0x1f] SRAM1 bus clock enable Set and reset by software. Access can be secured by GTZC_MPCBB1 SECx, INVSECSTATE. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_AHB2ENR_DEF
    \
    \ @brief RCC AHB2 peripheral clock enable register
    \ Address offset: 0x8C
    \ Reset value: 0x40000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] IO port A bus clock enable Set and cleared by software. Access can be secured by GPIOA SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $01 constant RCC_GPIOBEN                    \ [0x01] IO port B bus clock enable Set and cleared by software. Access can be secured by GPIOB SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $02 constant RCC_GPIOCEN                    \ [0x02] IO port C bus clock enable Set and cleared by software. Access can be secured by GPIOC SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $07 constant RCC_GPIOHEN                    \ [0x07] IO port H bus clock enable Set and cleared by software. Access can be secured by GPIOH SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $10 constant RCC_AESEN                      \ [0x10] AES bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC AESSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $11 constant RCC_HASHEN                     \ [0x11] HASH bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC HASHSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $12 constant RCC_RNGEN                      \ [0x12] RNG bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC RNGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $13 constant RCC_SAESEN                     \ [0x13] SAES bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC SAESSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $14 constant RCC_HSEMEN                     \ [0x14] HSEM bus clock enable Set and cleared by software. Can only be accessed secure when one or more features in the HSEM is secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $15 constant RCC_PKAEN                      \ [0x15] PKA bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC PKASEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $1e constant RCC_SRAM2EN                    \ [0x1e] SRAM2 bus clock enable Set and cleared by software. Access can be secured by GTZC_MPCBB2 SECx, INVSECSTATE. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_AHB4ENR_DEF
    \
    \ @brief RCC AHB4 peripheral clock enable register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $02 constant RCC_PWREN                      \ [0x02] PWR bus clock enable Set and cleared by software. Can only be accessed secure when one or more features in the PWR is/are secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $05 constant RCC_ADC4EN                     \ [0x05] ADC4 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC ADC4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_AHB5ENR_DEF
    \
    \ @brief RCC AHB5 peripheral clock enable register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RADIOEN                    \ [0x00] 2.4 GHz RADIO bus clock enable Set and cleared by software. Access can be secured by GTZC_TZSC RADIOSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Before accessing the 2.4 GHz RADIO sleep timers registers the RADIOCLKRDY bit must be checked. Note: When RADIOSMEN and STRADIOCLKON are both cleared, RADIOCLKRDY bit must be re-checked when exiting low-power modes (Sleep and Stop).
  [then]


  [ifdef] RCC_RCC_APB1ENR1_DEF
    \
    \ @brief RCC APB1 peripheral clock enable register 1
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC TIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC TIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0b constant RCC_WWDGEN                     \ [0x0b] WWDG bus clock enable Set by software to enable the window watchdog bus clock. Reset by hardware system reset. This bit can also be set by hardware if the WWDG_SW option bit is reset. Access can be secured by GTZC_TZSC WWDGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $11 constant RCC_USART2EN                   \ [0x11] USART2 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC USART2SEC When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV..
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC I2C1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_APB1ENR2_DEF
    \
    \ @brief RCC APB1 peripheral clock enable register 2
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $05 constant RCC_LPTIM2EN                   \ [0x05] LPTIM2 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC LPTIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_APB2ENR_DEF
    \
    \ @brief RCC APB2 peripheral clock enable register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $0b constant RCC_TIM1EN                     \ [0x0b] TIM1 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC TIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC SPI1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0e constant RCC_USART1EN                   \ [0x0e] USART1bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC USART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $11 constant RCC_TIM16EN                    \ [0x11] TIM16 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC TIM16SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $12 constant RCC_TIM17EN                    \ [0x12] TIM17 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC TIM17SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_APB7ENR_DEF
    \
    \ @brief RCC APB7 peripheral clock enable register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SYSCFGEN                   \ [0x01] SYSCFG bus clock enable Set and cleared by software. Access can be secured by SYSCFG SYSCFGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $05 constant RCC_SPI3EN                     \ [0x05] SPI3 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC SPI3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $06 constant RCC_LPUART1EN                  \ [0x06] LPUART1 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC LPUART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $07 constant RCC_I2C3EN                     \ [0x07] I2C3 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC I2C3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0b constant RCC_LPTIM1EN                   \ [0x0b] LPTIM1 bus and kernel clocks enable Set and cleared by software. Access can be secured by GTZC_TZSC LPTIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $15 constant RCC_RTCAPBEN                   \ [0x15] RTC and TAMP bus clock enable Set and cleared by software. Can only be accessed secure when one or more features in the RTC or TAMP is/are secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_AHB1SMENR_DEF
    \
    \ @brief RCC AHB1 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0xB0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant RCC_GPDMA1SMEN                 \ [0x00] GPDMA1 bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GPDMA1 SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $08 constant RCC_FLASHSMEN                  \ [0x08] FLASH bus clock enable during Sleep and Stop modes Set and cleared by software. Can only be accessed secured when the Flash security state is secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0c constant RCC_CRCSMEN                    \ [0x0c] CRC bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC CRCSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $10 constant RCC_TSCSMEN                    \ [0x10] TSC bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC TSCSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV..
    $11 constant RCC_RAMCFGSMEN                 \ [0x11] RAMCFG bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC RAMCFGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $18 constant RCC_GTZC1SMEN                  \ [0x18] GTZC1 bus clock enable during Sleep and Stop modes Set and cleared by software. Can only be accessed secure when one device is secure (TZEN = 1). When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $1d constant RCC_ICACHESMEN                 \ [0x1d] ICACHE bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC ICACHE_REGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV..
    $1f constant RCC_SRAM1SMEN                  \ [0x1f] SRAM1 bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_MPCBB1 SECx, INVSECSTATE. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_AHB2SMENR_DEF
    \
    \ @brief RCC AHB2 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0xB4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant RCC_GPIOASMEN                  \ [0x00] IO port A bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GPIOA SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $01 constant RCC_GPIOBSMEN                  \ [0x01] IO port B bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GPIOB SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $02 constant RCC_GPIOCSMEN                  \ [0x02] IO port C bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GPIOC SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $07 constant RCC_GPIOHSMEN                  \ [0x07] IO port H bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GPIOH SECx. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $10 constant RCC_AESSMEN                    \ [0x10] AES bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC AESSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $11 constant RCC_HASHSMEN                   \ [0x11] HASH bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC HASHSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $12 constant RCC_RNGSMEN                    \ [0x12] Random number generator (RNG) bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC RNGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $13 constant RCC_SAESSMEN                   \ [0x13] SAES accelerator bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC SAESSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $15 constant RCC_PKASMEN                    \ [0x15] PKA bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC PKASEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $1e constant RCC_SRAM2SMEN                  \ [0x1e] SRAM2 bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_MPCBB2 SECx, INVSECSTATE. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_AHB4SMENR_DEF
    \
    \ @brief RCC AHB4 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0xBC
    \ Reset value: 0xFFFFFFFF
    \
    $02 constant RCC_PWRSMEN                    \ [0x02] PWR bus clock enable during Sleep and Stop modes Set and cleared by software. Can only be accessed secure when one or more features in the PWR is/are secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $05 constant RCC_ADC4SMEN                   \ [0x05] ADC4 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC ADC4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
  [then]


  [ifdef] RCC_RCC_AHB5SMENR_DEF
    \
    \ @brief RCC AHB5 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0xC0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant RCC_RADIOSMEN                  \ [0x00] 2.4 GHz RADIO bus clock enable during Sleep and Stop modes when the 2.4 GHz RADIO is active. Set and cleared by software. Access can be secured by GTZC_TZSC RADIOSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_APB1SMENR1_DEF
    \
    \ @brief RCC APB1 peripheral clocks enable in Sleep and Stop modes register 1
    \ Address offset: 0xC4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant RCC_TIM2SMEN                   \ [0x00] TIM2 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC TIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $01 constant RCC_TIM3SMEN                   \ [0x01] TIM3 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC TIM3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0b constant RCC_WWDGSMEN                   \ [0x0b] Window watchdog bus clock enable during Sleep and Stop modes Set and cleared by software. This bit is forced to 1 by hardware when the hardware WWDG option is activated. Access can be secured by GTZC_TZSC WWDGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $11 constant RCC_USART2SMEN                 \ [0x11] USART2 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC USART2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $15 constant RCC_I2C1SMEN                   \ [0x15] I2C1 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC I2C1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
  [then]


  [ifdef] RCC_RCC_APB1SMENR2_DEF
    \
    \ @brief RCC APB1 peripheral clocks enable in Sleep and Stop modes register 2
    \ Address offset: 0xC8
    \ Reset value: 0xFFFFFFFF
    \
    $05 constant RCC_LPTIM2SMEN                 \ [0x05] LPTIM2 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC LPTIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
  [then]


  [ifdef] RCC_RCC_APB2SMENR_DEF
    \
    \ @brief RCC APB2 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0xCC
    \ Reset value: 0xFFFFFFFF
    \
    $0b constant RCC_TIM1SMEN                   \ [0x0b] TIM1 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC TIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0c constant RCC_SPI1SMEN                   \ [0x0c] SPI1 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC SPI1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $0e constant RCC_USART1SMEN                 \ [0x0e] USART1 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC USART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $11 constant RCC_TIM16SMEN                  \ [0x11] TIM16 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC TIM16SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $12 constant RCC_TIM17SMEN                  \ [0x12] TIM17 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC TIM17SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_APB7SMENR_DEF
    \
    \ @brief RCC APB7 peripheral clock enable in Sleep and Stop modes register
    \ Address offset: 0xD0
    \ Reset value: 0xFFFFFFFF
    \
    $01 constant RCC_SYSCFGSMEN                 \ [0x01] SYSCFG bus clock enable during Sleep and Stop modes Set and cleared by software. Access can be secured by SYSCFG SYSCFGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $05 constant RCC_SPI3SMEN                   \ [0x05] SPI3 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC SPI3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $06 constant RCC_LPUART1SMEN                \ [0x06] LPUART1 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC LPUART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $07 constant RCC_I2C3SMEN                   \ [0x07] I2C3 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC I2C3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $0b constant RCC_LPTIM1SMEN                 \ [0x0b] LPTIM1 bus and kernel clocks enable during Sleep and Stop modes Set and cleared by software. Access can be secured by GTZC_TZSC LPTIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $15 constant RCC_RTCAPBSMEN                 \ [0x15] RTC and TAMP APB clock enable during Sleep and Stop modes Set and cleared by software. Can only be accessed secure when one or more features in the RTC or TAMP is/are secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
  [then]


  [ifdef] RCC_RCC_CCIPR1_DEF
    \
    \ @brief RCC peripherals independent clock configuration register 1
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL                  \ [0x00 : 2] USART1 kernel clock source selection This bits are used to select the USART1 kernel clock source. Access can be secured by GTZC_TZSC USART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The USART1 is functional in Stop 0 and Stop 1 mode only when the kernel clock is HSI16 or LSE.
    $02 constant RCC_USART2SEL                  \ [0x02 : 2] USART2 kernel clock source selection This bits are used to select the USART2 kernel clock source. Access can be secured by GTZC_TZSC USART2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The USART2 is functional in Stop 0 and Stop 1 mode only when the kernel clock is HSI16 or LSE.
    $0a constant RCC_I2C1SEL                    \ [0x0a : 2] I2C1 kernel clock source selection These bits are used to select the I2C1 kernel clock source. Access can be secured by GTZC_TZSC I2C1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The I2C1 is functional in Stop 0 and Stop 1 mode only when the kernel clock is HSI16.
    $12 constant RCC_LPTIM2SEL                  \ [0x12 : 2] Low-power timer 2 kernel clock source selection These bits are used to select the LPTIM2 kernel clock source. Access can be secured by GTZC_TZSC LPTIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The LPTIM2 is functional in Stop 0 and Stop 1 mode only when the kernel clock is LSI, LSE or HSI16 if HSIKERON = 1.
    $14 constant RCC_SPI1SEL                    \ [0x14 : 2] SPI1 kernel clock source selection These bits are used to select the SPI1 kernel clock source. Access can be secured by GTZC_TZSC SPI1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The SPI1 is functional in Stop 0 and Stop 1 mode only when the kernel clock is HSI16.
    $16 constant RCC_SYSTICKSEL                 \ [0x16 : 2] SysTick clock source selection These bits are used to select the SysTick clock source. Access can be secured by RCC SYSCLKSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: When LSE or LSI is selected, the AHB frequency must be at least four times higher than the LSI or LSE frequency. In addition, a jitter up to one hclk1 cycle is introduced, due to the LSE or LSI sampling with hclk1 in the SysTick circuitry.
    $1f constant RCC_TIMICSEL                   \ [0x1f] Clocks sources for TIM16,TIM17 and LPTIM2 internal input capture When the TIMICSEL bit is set, the TIM16, TIM17 and LPTIM2 internal input capture can be connected to HSI16/256. When TIMICSEL is cleared, the HSI16, clock sources cannot be selected as TIM16, TIM17 or LPTIM2 internal input capture. Access can be secured by GTZC_TZSC TIM16SEC, TIM17SEC, or LPTIM2SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The clock division must be disabled (TIMICSEL configured to 0) before selecting or changing a clock sources division.
  [then]


  [ifdef] RCC_RCC_CCIPR2_DEF
    \
    \ @brief RCC peripherals independent clock configuration register 2
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $0c constant RCC_RNGSEL                     \ [0x0c : 2] RNGSEL kernel clock source selection These bits allow to select the RNG kernel clock source. Access can be secured by GTZC_TZSC RNGSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
  [then]


  [ifdef] RCC_RCC_CCIPR3_DEF
    \
    \ @brief RCC peripherals independent clock configuration register 3
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPUART1SEL                 \ [0x00 : 2] LPUART1 kernel clock source selection These bits are used to select the LPUART1 kernel clock source. Access can be secured by GTZC_TZSC LPUART1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The LPUART1 is functional in Stop modes only when the kernel clock is HSI16 or LSE.
    $03 constant RCC_SPI3SEL                    \ [0x03 : 2] SPI3 kernel clock source selection These bits are used to select the SPI3 kernel clock source. Access can be secured by GTZC_TZSC SPI3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The SPI3 is functional in Stop modes only when the kernel clock is HSI16.
    $06 constant RCC_I2C3SEL                    \ [0x06 : 2] I2C3 kernel clock source selection These bits are used to select the I2C3 kernel clock source. Access can be secured by GTZC_TZSC I2C3SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The I2C3 is functional in Stop modes only when the kernel clock is HSI16
    $0a constant RCC_LPTIM1SEL                  \ [0x0a : 2] LPTIM1 kernel clock source selection These bits are used to select the LPTIM1 kernel clock source. Access can be secured by GTZC_TZSC LPTIM1SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The LPTIM1 is functional in Stop modes only when the kernel clock is LSI, LSE, HSI16 with HSIKERON = 1.
    $0c constant RCC_ADCSEL                     \ [0x0c : 3] ADC4 kernel clock source selection These bits are used to select the ADC4 kernel clock source. Access can be secured by GTZC_TZSC ADC4SEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. others: reserved Note: The ADC4 is functional in Stop modes only when the kernel clock is HSI16.
  [then]


  [ifdef] RCC_RCC_BDCR1_DEF
    \
    \ @brief RCC backup domain control register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enable Set and cleared by software. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $01 constant RCC_LSERDY                     \ [0x01] LSE oscillator ready Set and cleared by hardware to indicate when the external 32kHz oscillator is stable. After the LSEON bit is cleared, LSERDY goes low after six external low-speed oscillator clock cycles. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $02 constant RCC_LSEBYP                     \ [0x02] LSE oscillator bypass Set and cleared by software to bypass oscillator in debug mode. This bit can be written only when the external 32kHz oscillator is disabled (LSEON = 0 and LSERDY = 0). Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $03 constant RCC_LSEDRV                     \ [0x03 : 2] LSE oscillator drive capability Set by software to modulate the drive capability of the LSE oscillator. LSEDRV must be programmed to a different value than 0 before enabling the LSE oscillator in 'Xtal' mode. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: The oscillator is in 'Xtal mode' when it is not in bypass mode.
    $05 constant RCC_LSECSSON                   \ [0x05] Low speed external clock security enable Set by software to enable the LSECSS. LSECSSON must be enabled after the LSE oscillator is enabled (LSEON bit enabled) and ready (LSERDY flag set by hardware) and after the RTCSEL bit is selected. Once enabled, this bit cannot be disabled, except after a LSE failure detection (LSECSSD=1). In that case, the software must disable the LSECSSON bit. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $06 constant RCC_LSECSSD                    \ [0x06] Low speed external clock security, LSE failure Detection Set by hardware to indicate when a failure is detected by the LSECCS on the external 32kHz oscillator. Reset when LSCSSON bit is cleared. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $07 constant RCC_LSESYSEN                   \ [0x07] LSE system clock (LSESYS) enable Set by software to enable the LSE system clock generated by RCC. The lsesys clock is used for peripherals (USART, LPUART, LPTIM, RNG, 2.4 GHz RADIO) and functions (LSCO, MCO, TIM triggers, LPTIM trigger) excluding the RTC, TAMP and LSECSS. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC and TAMP kernel clock source enable and selection Set by software to enable and select the clock source for the RTC. Can only be accessed secure when one or more features in the RTC or TAMP is/are secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0b constant RCC_LSESYSRDY                  \ [0x0b] LSE system clock (LSESYS) ready Set and cleared by hardware to indicate when the LSE system clock is stable.When the LSESYSEN bit is set, the LSESYSRDY flag is set after two LSE clock cycles. The LSE clock must be already enabled and stable (LSEON and LSERDY are set). When the LSEON bit is cleared, LSERDY goes low after six external low-speed oscillator clock cycles. Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0c constant RCC_LSEGFON                    \ [0x0c] LSE clock glitch filter enable Set and cleared by hardware to enable the LSE glitch filter. This bit can be written only when the LSE is disabled (LSEON = 0 and LSERDY = 0). Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $0d constant RCC_LSETRIM                    \ [0x0d : 2] LSE trimming These bits are initialized at startup and after OBL_LAUNCH with SBF cleared with the factory-programmed LSE calibration value. Set and cleared by software. These bits must be modified only once after a BOR reset or an OBL_LAUNCH and before enabling LSE with LSEON (when both LSEON = 0 and LSERDY= 0). Access can be secured by RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV. Note: OBL_LAUNCH of this field occurs only when SBF is cleared and must then only be started by software when LSE oscillator is disabled, LSEON = 0 and LSERDY = 0.
    $10 constant RCC_BDRST                      \ [0x10] Backup domain software reset Set and cleared by software. Can only be accessed secure when one or more features in the RTC or TAMP is secure. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $12 constant RCC_RADIOSTSEL                 \ [0x12 : 2] 2.4 GHz RADIO sleep timer kernel clock enable and selection Set and cleared by software. Access can be secured by GTZC_TZSC RADIOSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $18 constant RCC_LSCOEN                     \ [0x18] Low-speed clock output (LSCO) enable Set and cleared by software. Access can be secured by RCC LSISEC and/or RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $19 constant RCC_LSCOSEL                    \ [0x19] Low-speed clock output selection Set and cleared by software. Access can be secured by RCC LSISEC and/or RCC LSESEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $1a constant RCC_LSI1ON                     \ [0x1a] LSI1 oscillator enable Set and cleared by software. Access can be secured by RCC LSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $1b constant RCC_LSI1RDY                    \ [0x1b] LSI1 oscillator ready Set and cleared by hardware to indicate when the LSI1 oscillator is stable. After the LSI1ON bit is cleared, LSI1RDY goes low after three internal low-speed oscillator clock cycles. This bit is set when the LSI1 is used by IWDG or RTC, even if LSI1ON = 0. Access can be secured by RCC LSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $1c constant RCC_LSI1PREDIV                 \ [0x1c] LSI1 Low-speed clock divider configuration Set and cleared by software to enable the LSI1 division. This bit can be written only when the LSI1 is disabled (LSI1ON = 0 and LSI1RDY = 0). The LSI1PREDIV cannot be changed if the LSI1 is used by the IWDG or by the RTC. Access can be secured by RCC LSISEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $1d constant RCC_LSI2ON                     \ [0x1d] LSI2 oscillator enable
    $1e constant RCC_LSI2RDY                    \ [0x1e] LSI2 oscillator ready
  [then]


  [ifdef] RCC_RCC_CSR_DEF
    \
    \ @brief RCC control/status register
    \ Address offset: 0xF4
    \ Reset value: 0x0C000000
    \
    $17 constant RCC_RMVF                       \ [0x17] Remove reset flag Set by software to clear the reset flags. Access can be secured by RCC RMVFSEC. When secure, a non-secure read/write access is RAZ/WI. It does not generate an illegal access interrupt. This bit can be protected against unprivileged access when secure with RCC SPRIV or when non-secure with RCC NSPRIV.
    $19 constant RCC_OBLRSTF                    \ [0x19] Option byte loader reset flag Set by hardware when a reset from the option byte loading occurs. Cleared by writing to the RMVF bit.
    $1a constant RCC_PINRSTF                    \ [0x1a] NRST pin reset flag Set by hardware when a reset from the NRST pin occurs. Cleared by writing to the RMVF bit.
    $1b constant RCC_BORRSTF                    \ [0x1b] BOR flag Set by hardware when a BOR occurs. Cleared by writing to the RMVF bit.
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag Set by hardware when a software reset occurs. Cleared by writing to the RMVF bit.
    $1d constant RCC_IWDGRSTF                   \ [0x1d] Independent watchdog reset flag Set by hardware when an independent watchdog reset domain occurs. Cleared by writing to the RMVF bit.
    $1e constant RCC_WWDGRSTF                   \ [0x1e] Window watchdog reset flag Set by hardware when a window watchdog reset occurs. Cleared by writing to the RMVF bit.
    $1f constant RCC_LPWRRSTF                   \ [0x1f] Low-power reset flag Set by hardware when a reset occurs due to illegal Stop and Standby modes entry. Cleared by writing to the RMVF bit.
  [then]


  [ifdef] RCC_RCC_SECCFGR_DEF
    \
    \ @brief RCC secure configuration register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSISEC                     \ [0x00] HSI16 clock configuration and status bits security Set and reset by software.
    $01 constant RCC_HSESEC                     \ [0x01] HSE32 clock configuration bits, status bits and HSECSS security Set and reset by software.
    $03 constant RCC_LSISEC                     \ [0x03] LSI clock configuration and status bits security Set and reset by software.
    $04 constant RCC_LSESEC                     \ [0x04] LSE clock configuration and status bits security Set and reset by software.
    $05 constant RCC_SYSCLKSEC                  \ [0x05] SYSCLK selection, clock output on MCO configuration security Set and reset by software.
    $06 constant RCC_PRESCSEC                   \ [0x06] AHBx/APBx prescaler configuration bits security Set and reset by software.
    $07 constant RCC_PLL1SEC                    \ [0x07] PLL1 clock configuration and status bits security Set and reset by software.
    $0c constant RCC_RMVFSEC                    \ [0x0c] Remove reset flag security Set and reset by software.
  [then]


  [ifdef] RCC_RCC_PRIVCFGR_DEF
    \
    \ @brief RCC privilege configuration register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPRIV                      \ [0x00] RCC secure functions privilege configuration Set and reset by software. This bit can be written only by a secure privileged access.
    $01 constant RCC_NSPRIV                     \ [0x01] RCC non-secure functions privilege configuration Set and reset by software. This bit can be written only by privileged access, secure or non-secure.
  [then]


  [ifdef] RCC_RCC_CFGR4_DEF
    \
    \ @brief RCC clock configuration register 2
    \ Address offset: 0x200
    \ Reset value: 0x00000010
    \
    $00 constant RCC_HPRE5                      \ [0x00 : 3] AHB5 prescaler when SWS select PLL1 Set and cleared by software to control the division factor of the AHB5 clock (hclk5). Must not be changed when SYSCLK source indicated by SWS is PLL1. When SYSCLK source indicated by SWS is not PLL1: HPRE5 is not taken into account. When SYSCLK source indicated by SWS is PLL1: HPRE5 is taken into account, from the moment the system clock switch occurs Depending on the device voltage range, the software must set these bits correctly to ensure that the AHB5 frequency does not exceed the maximum allowed frequency (for more details, refer to Table99: SYSCLK and bus maximum frequency). After a write operation to these bits and before decreasing the voltage range, this register must be read to be sure that the new value is taken into account. 0xx: hclk5 = SYSCLK not divided
    $04 constant RCC_HDIV5                      \ [0x04] AHB5 divider when SWS select HSI16 or HSE32 Set and reset by software. Set to 1 by hardware when entering Stop 1 mode. When SYSCLK source indicated by SWS is HSI16 or HSE32: HDIV5 is taken into account When SYSCLK source indicated by SWS is PLL1: HDIV5 is taken not taken into account Depending on the device voltage range, the software must set this bit correctly to ensure that the AHB5 frequency does not exceed the maximum allowed frequency (for more details, refer to Table99). After a write operation to this bit and before decreasing the voltage range, this register must be read to be sure that the new value is taken into account.
  [then]


  [ifdef] RCC_RCC_RADIOENR_DEF
    \
    \ @brief RCC RADIO peripheral clock enable register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $01 constant RCC_BBCLKEN                    \ [0x01] 2.4 GHz RADIO baseband kernel clock (aclk) enable Set and cleared by software. Note: The HSE32 oscillator needs to be enabled by either HSEON or STRADIOCLKON.
    $10 constant RCC_STRADIOCLKON               \ [0x10] 2.4 GHz RADIO bus clock enable and HSE32 oscillator enable by 2.4 GHz RADIO sleep timer wakeup event Set by hardware on a 2.4 GHz RADIO sleep timer wakeup event. Cleared by software writing zero to this bit. Note: Before accessing the 2.4 GHz RADIO registers the RADIOCLKRDY bit must be checked.
    $11 constant RCC_RADIOCLKRDY                \ [0x11] 2.4 GHz RADIO bus clock ready. Set and cleared by hardware to indicate that the 2.4 GHz RADIO bus clock is ready and the 2.4 GHz RADIO registers can be accessed. Note: Once both RADIOEN and STRADIOCLKON are cleared, RADIOCLKRDY goes low after three hclk5 clock cycles.
  [then]


  [ifdef] RCC_RCC_ECSCR1_DEF
    \
    \ @brief RCC external clock sources calibration register 1
    \ Address offset: 0x210
    \ Reset value: 0x00200000
    \
    $10 constant RCC_HSETRIM                    \ [0x10 : 6] HSE32 clock trimming These bits provide user-programmable capacitor trimming value. It can be programmed to adjust the HSE32 oscillator frequency.
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_RCC_CR               \ RCC clock control register
  $10 constant RCC_RCC_ICSCR3           \ RCC internal clock sources calibration register 3
  $1C constant RCC_RCC_CFGR1            \ RCC clock configuration register 1
  $20 constant RCC_RCC_CFGR2            \ RCC clock configuration register 2
  $24 constant RCC_RCC_CFGR3            \ RCC clock configuration register 3
  $28 constant RCC_RCC_PLL1CFGR         \ RCC PLL1 configuration register
  $34 constant RCC_RCC_PLL1DIVR         \ RCC PLL1 dividers register
  $38 constant RCC_RCC_PLL1FRACR        \ RCC PLL1 fractional divider register
  $50 constant RCC_RCC_CIER             \ RCC clock interrupt enable register
  $54 constant RCC_RCC_CIFR             \ RCC clock interrupt flag register
  $58 constant RCC_RCC_CICR             \ RCC clock interrupt clear register
  $60 constant RCC_RCC_AHB1RSTR         \ RCC AHB1 peripheral reset register
  $64 constant RCC_RCC_AHB2RSTR         \ RCC AHB2 peripheral reset register
  $6C constant RCC_RCC_AHB4RSTR         \ RCC AHB4 peripheral reset register
  $70 constant RCC_RCC_AHB5RSTR         \ RCC AHB5 peripheral reset register
  $74 constant RCC_RCC_APB1RSTR1        \ RCC APB1 peripheral reset register 1
  $78 constant RCC_RCC_APB1RSTR2        \ RCC APB1 peripheral reset register 2
  $7C constant RCC_RCC_APB2RSTR         \ RCC APB2 peripheral reset register
  $80 constant RCC_RCC_APB7RSTR         \ RCC APB7 peripheral reset register
  $88 constant RCC_RCC_AHB1ENR          \ RCC AHB1 peripheral clock enable register
  $8C constant RCC_RCC_AHB2ENR          \ RCC AHB2 peripheral clock enable register
  $94 constant RCC_RCC_AHB4ENR          \ RCC AHB4 peripheral clock enable register
  $98 constant RCC_RCC_AHB5ENR          \ RCC AHB5 peripheral clock enable register
  $9C constant RCC_RCC_APB1ENR1         \ RCC APB1 peripheral clock enable register 1
  $A0 constant RCC_RCC_APB1ENR2         \ RCC APB1 peripheral clock enable register 2
  $A4 constant RCC_RCC_APB2ENR          \ RCC APB2 peripheral clock enable register
  $A8 constant RCC_RCC_APB7ENR          \ RCC APB7 peripheral clock enable register
  $B0 constant RCC_RCC_AHB1SMENR        \ RCC AHB1 peripheral clocks enable in Sleep and Stop modes register
  $B4 constant RCC_RCC_AHB2SMENR        \ RCC AHB2 peripheral clocks enable in Sleep and Stop modes register
  $BC constant RCC_RCC_AHB4SMENR        \ RCC AHB4 peripheral clocks enable in Sleep and Stop modes register
  $C0 constant RCC_RCC_AHB5SMENR        \ RCC AHB5 peripheral clocks enable in Sleep and Stop modes register
  $C4 constant RCC_RCC_APB1SMENR1       \ RCC APB1 peripheral clocks enable in Sleep and Stop modes register 1
  $C8 constant RCC_RCC_APB1SMENR2       \ RCC APB1 peripheral clocks enable in Sleep and Stop modes register 2
  $CC constant RCC_RCC_APB2SMENR        \ RCC APB2 peripheral clocks enable in Sleep and Stop modes register
  $D0 constant RCC_RCC_APB7SMENR        \ RCC APB7 peripheral clock enable in Sleep and Stop modes register
  $E0 constant RCC_RCC_CCIPR1           \ RCC peripherals independent clock configuration register 1
  $E4 constant RCC_RCC_CCIPR2           \ RCC peripherals independent clock configuration register 2
  $E8 constant RCC_RCC_CCIPR3           \ RCC peripherals independent clock configuration register 3
  $F0 constant RCC_RCC_BDCR1            \ RCC backup domain control register
  $F4 constant RCC_RCC_CSR              \ RCC control/status register
  $110 constant RCC_RCC_SECCFGR         \ RCC secure configuration register
  $114 constant RCC_RCC_PRIVCFGR        \ RCC privilege configuration register
  $200 constant RCC_RCC_CFGR4           \ RCC clock configuration register 2
  $208 constant RCC_RCC_RADIOENR        \ RCC RADIO peripheral clock enable register
  $210 constant RCC_RCC_ECSCR1          \ RCC external clock sources calibration register 1

: RCC_DEF ; [then]
