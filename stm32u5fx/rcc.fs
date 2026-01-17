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
    \ Reset value: 0x00000035
    \
    $00 constant RCC_MSISON                     \ [0x00] MSIS clock enable This bit is set and cleared by software. It is cleared by hardware to stop the MSIS oscillator when entering Stop, Standby or Shutdown mode. This bit is set by hardware to force the�MSIS oscillator on when exiting Standby or Shutdown mode. It is set by hardware to force the MSIS oscillator ON when STOPWUCK = 0 when exiting Stop modes, or in case of a failure of the HSE oscillator. Set by hardware when used directly or indirectly as system clock.
    $01 constant RCC_MSIKERON                   \ [0x01] MSI enable for some peripheral kernels This bit is set and cleared by software to force MSI ON even in Stop modes. Keeping the MSI on in Stop mode allows the communication speed not to be reduced by the MSI startup time. This bit has no effect on MSISON and MSIKON values (see Section�11.4.24 for more details). This bit must be configured at 0 before entering Stop 3 mode.
    $02 constant RCC_MSISRDY                    \ [0x02] MSIS clock ready flag This bit is set by hardware to indicate that the MSIS oscillator is stable. It is set only when MSIS is enabled by software (by setting MSISON). Note: Once the MSISON bit is cleared, MSISRDY goes low after six MSIS clock cycles.
    $03 constant RCC_MSIPLLEN                   \ [0x03] MSI clock PLL-mode enable This bit is set and cleared by software to enable/disable the PLL part of the MSI clock source. MSIPLLEN must be enabled after LSE is enabled (LSEON enabled) and ready (LSERDY set by hardware). A hardware protection prevents from enabling MSIPLLEN if LSE is not ready. This bit is cleared by hardware when LSE is disabled (LSEON = 0) or when the CSS on LSE detects a LSE failure (see RCC_CSR).
    $04 constant RCC_MSIKON                     \ [0x04] MSIK clock enable This bit is set and cleared by software. It is cleared by hardware to stop the MSIK when entering Stop, Standby, or Shutdown mode. This bit is set by hardware to force the MSIK oscillator ON when exiting Standby or Shutdown mode. It is set by hardware to force the MSIK oscillator on when STOPWUCK = 0 or STOPKERWUCK�=�0 when exiting Stop modes, or in case of a failure of the HSE oscillator.
    $05 constant RCC_MSIKRDY                    \ [0x05] MSIK clock ready flag This bit is set by hardware to indicate that the MSIK is stable. It is set only when MSI kernel oscillator is enabled by software by setting MSIKON. Note: Once MSIKON bit is cleared, MSIKRDY goes low after six MSIK oscillator clock cycles.
    $06 constant RCC_MSIPLLSEL                  \ [0x06] MSI clock with PLL mode selection This bit is set and cleared by software to select which MSI output clock uses the PLL mode. It�can be written only when the MSI PLL mode is disabled (MSIPLLEN = 0). Note: If the MSI kernel clock output uses the same oscillator source than the MSI system clock output, then the PLL mode is applied to both clock outputs.
    $07 constant RCC_MSIPLLFAST                 \ [0x07] MSI PLL mode fast startup This bit is set and reset by software to enable/disable the fast PLL mode start-up of the MSI clock source. This bit is used only if PLL mode is selected (MSIPLLEN = 1). The fast start-up feature is not active the first time the PLL mode is selected. The�fast start-up is active when the MSI in PLL mode returns from switch off.
    $08 constant RCC_HSION                      \ [0x08] HSI16 clock enable This bit is set and cleared by software. It is cleared by hardware to stop the HSI16 oscillator when entering Stop, Standby, or Shutdown mode. This bit is set by hardware to force the�HSI16 oscillator on when STOPWUCK = 1 when leaving Stop modes, or in case of failure of the HSE crystal oscillator. This bit is set by hardware if the HSI16 is used directly or indirectly as system clock.
    $09 constant RCC_HSIKERON                   \ [0x09] HSI16 enable for some peripheral kernels This bit is set and cleared by software to force HSI16 ON even in Stop modes. Keeping HSI16 on in Stop mode allows the communication speed not to be reduced by the HSI16 startup time. This bit has no effect on HSION value. Refer to Section�11.4.24 for more details. This bit must be configured at 0 before entering Stop 3 mode.
    $0a constant RCC_HSIRDY                     \ [0x0a] HSI16 clock ready flag This bit is set by hardware to indicate that HSI16 oscillator is stable. It is set only when HSI16 is enabled by software (by setting HSION). Note: Once the HSION bit is cleared, HSIRDY goes low after six HSI16 clock cycles.
    $0c constant RCC_HSI48ON                    \ [0x0c] HSI48 clock enable This bit is set and cleared by software. It is cleared by hardware to stop the HSI48 when entering in Stop, Standby, or Shutdown modes.
    $0d constant RCC_HSI48RDY                   \ [0x0d] HSI48 clock ready flag This bit is set by hardware to indicate that HSI48 oscillator is stable. Itis set only when HSI48 is enabled by software (by setting HSI48ON).
    $0e constant RCC_SHSION                     \ [0x0e] SHSI clock enable This bit is set and cleared by software. It is cleared by hardware to stop the SHSI when entering in Stop, Standby, or Shutdown modes.
    $0f constant RCC_SHSIRDY                    \ [0x0f] SHSI clock ready flag This bit is set by hardware to indicate that the SHSI oscillator is stable. It is set only when SHSI is enabled by software (by setting SHSION). Note: Once the SHSION bit is cleared, SHSIRDY goes low after six SHSI clock cycles.
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable This bit is set and cleared by software. It is cleared by hardware to stop the HSE oscillator when entering Stop, Standby, or Shutdown mode. This bit cannot be reset if the HSE oscillator is used directly or indirectly as the system clock.
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag This bit is set by hardware to indicate that the HSE oscillator is stable. Note: Once the HSEON bit is cleared, HSERDY goes low after six HSE clock cycles.
    $12 constant RCC_HSEBYP                     \ [0x12] HSE crystal oscillator bypass This bit is set and cleared by software to bypass the oscillator with an external clock. The�external clock must be enabled with the HSEON bit set, to be used by the device. This�bit can be written only if the HSE oscillator is disabled.
    $13 constant RCC_CSSON                      \ [0x13] Clock security system enable This bit is set by software to enable the clock security system. When CSSON is set, the clock detector is enabled by hardware when the HSE oscillator is ready, and disabled by hardware if a HSE clock failure is detected. This bit is set only and is cleared by reset.
    $14 constant RCC_HSEEXT                     \ [0x14] HSE external clock bypass mode This bit is set and reset by software to select the external clock mode in bypass mode. External clock mode must be configured with HSEON bit to be used by the device. This bit can be written only if the HSE oscillator is disabled. This bit is active only if the HSE bypass mode is enabled.
    $18 constant RCC_PLL1ON                     \ [0x18] PLL1 enable This bit is set and cleared by software to enable the main PLL. It is cleared by hardware when entering Stop, Standby, or Shutdown mode. This bit cannot be reset if the PLL1 clock is used as the system clock.
    $19 constant RCC_PLL1RDY                    \ [0x19] PLL1 clock ready flag This bit is set by hardware to indicate that the PLL1 is locked.
    $1a constant RCC_PLL2ON                     \ [0x1a] PLL2 enable This bit is set and cleared by software to enable PLL2. It is cleared by hardware when entering Stop, Standby, or Shutdown mode.
    $1b constant RCC_PLL2RDY                    \ [0x1b] PLL2 clock ready flag This bit is set by hardware to indicate that the PLL2 is locked.
    $1c constant RCC_PLL3ON                     \ [0x1c] PLL3 enable This bit is set and cleared by software to enable PLL3. It is cleared by hardware when entering Stop, Standby, or Shutdown mode.
    $1d constant RCC_PLL3RDY                    \ [0x1d] PLL3 clock ready flag This bit is set by hardware to indicate that the PLL3 is locked.
  [then]


  [ifdef] RCC_RCC_ICSCR1_DEF
    \
    \ @brief RCC internal clock sources calibration register 1
    \ Address offset: 0x08
    \ Reset value: 0x44000000
    \
    $00 constant RCC_MSICAL3                    \ [0x00 : 5] MSIRC3 clock calibration for MSI ranges 12 to 15 These bits are initialized at startup with the factory-programmed MSIRC3 calibration trim value for ranges 12 to 15. When MSITRIM3 is written, MSICAL3 is updated with the sum of MSITRIM3[4:0] and the factory calibration trim value MSIRC2[4:0]. There is no hardware protection to limit a potential overflow due to the addition of MSITRIM bitfield and factory program bitfield for this calibration value. Control must be managed by software at user level.
    $05 constant RCC_MSICAL2                    \ [0x05 : 5] MSIRC2 clock calibration for MSI ranges 8 to 11 These bits are initialized at startup with the factory-programmed MSIRC2 calibration trim value for ranges 8 to 11. When MSITRIM2 is written, MSICAL2 is updated with the sum of MSITRIM2[4:0] and the factory calibration trim value MSIRC2[4:0]. There is no hardware protection to limit a potential overflow due to the addition of MSITRIM bitfield and factory program bitfield for this calibration value. Control must be managed by software at user level.
    $0a constant RCC_MSICAL1                    \ [0x0a : 5] MSIRC1 clock calibration for MSI ranges 4 to 7 These bits are initialized at startup with the factory-programmed MSIRC1 calibration trim value for ranges 4 to 7. When MSITRIM1 is written, MSICAL1 is updated with the sum of MSITRIM1[4:0] and the factory calibration trim value MSIRC1[4:0]. There is no hardware protection to limit a potential overflow due to the addition of MSITRIM bitfield and factory program bitfield for this calibration value. Control must be managed by software at user level.
    $0f constant RCC_MSICAL0                    \ [0x0f : 5] MSIRC0 clock calibration for MSI ranges 0 to 3 These bits are initialized at startup with the factory-programmed MSIRC0 calibration trim value for ranges 0 to 3. When MSITRIM0 is written, MSICAL0 is updated with the sum of MSITRIM0[4:0] and the factory-programmed calibration trim value MSIRC0[4:0]. There is no hardware protection to limit a potential overflow due to the addition of MSITRIM bitfield and factory program bitfield for this calibration value. Control must be managed by software at user level.
    $16 constant RCC_MSIBIAS                    \ [0x16] MSI bias mode selection This bit is set by software to select the MSI bias mode. By default, the MSI bias is in�continuous mode in order to maintain the output clocks accuracy. Setting this bit reduces the MSI consumption when the regulator is in range 4, or when the device is in Stop 1 or Stop�2 mode, but it�decreases the MSI accuracy
    $17 constant RCC_MSIRGSEL                   \ [0x17] MSI clock range selection This bit is set by software to select the MSIS and MSIK clocks range with MSISRANGE[3:0] and MSIKRANGE[3:0]. Write 0 has no effect. After exiting Standby or Shutdown mode, or after a reset, this bit is at 0 and the MSIS and MSIK ranges are provided by MSISSRANGE[3:0] and MSIKSRANGE[3:0] in RCC_CSR.
    $18 constant RCC_MSIKRANGE                  \ [0x18 : 4] MSIK clock ranges These bits are configured by software to choose the frequency range of MSIK oscillator when MSIRGSEL is set. 16 frequency ranges are available: Note: MSIKRANGE can be modified when MSIK is off (MSISON = 0) or when MSIK is ready (MSIKRDY�=�1). MSIKRANGE must NOT be modified when MSIK is on and NOT ready (MSIKON = 1 and MSIKRDY = 0) Note: MSIKRANGE is kept when the device wakes up from Stop mode, except when the�MSIK range is above 24 MHz. In this case MSIKRANGE is changed by hardware into�range 2 (24 MHz).
    $1c constant RCC_MSISRANGE                  \ [0x1c : 4] MSIS clock ranges These bits are configured by software to choose the frequency range of MSIS oscillator when MSIRGSEL is set. 16 frequency ranges are available: Note: MSISRANGE can be modified when MSIS is off (MSISON = 0) or when MSIS is ready (MSISRDY�=�1). MSISRANGE must NOT be modified when MSIS is on and NOT ready (MSISON�=�1 and MSISRDY�=�0) Note: MSISRANGE is kept when the device wakes up from Stop mode, except when the�MSIS range is above 24 MHz. In this case MSISRANGE is changed by hardware into range 2 (24 MHz).
  [then]


  [ifdef] RCC_RCC_ICSCR2_DEF
    \
    \ @brief RCC internal clock sources calibration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00084210
    \
    $00 constant RCC_MSITRIM3                   \ [0x00 : 5] MSI clock trimming for ranges 12 to 15 These bits provide an additional user-programmable trimming value that is added to the factory-programmed calibration trim value MSIRC3[4:0] bits. It can be programmed to adjust to voltage and temperature variations that influence the frequency of the MSI.
    $05 constant RCC_MSITRIM2                   \ [0x05 : 5] MSI clock trimming for ranges 8 to 11 These bits provide an additional user-programmable trimming value that is added to the factory-programmed calibration trim value MSIRC2[4:0] bits. It can be programmed to adjust to voltage and temperature variations that influence the frequency of the MSI.
    $0a constant RCC_MSITRIM1                   \ [0x0a : 5] MSI clock trimming for ranges 4 to 7 These bits provide an additional user-programmable trimming value that is added to the factory-programmed calibration trim value MSIRC1[4:0] bits. It can be programmed to adjust to voltage and temperature variations that influence the frequency of the MSI.
    $0f constant RCC_MSITRIM0                   \ [0x0f : 5] MSI clock trimming for ranges 0 to 3 These bits provide an additional user-programmable trimming value that is added to the factory-programmed calibration trim value MSIRC0[4:0] bits. It can be programmed to adjust to voltage and temperature variations that influence the frequency of the MSI.
  [then]


  [ifdef] RCC_RCC_ICSCR3_DEF
    \
    \ @brief RCC internal clock sources calibration register 3
    \ Address offset: 0x10
    \ Reset value: 0x00100000
    \
    $00 constant RCC_HSICAL                     \ [0x00 : 12] HSI clock calibration These bits are initialized at startup with the factory-programmed HSI calibration trim value. When HSITRIM is written, HSICAL is updated with the sum of HSITRIM and the factory trim value.
    $10 constant RCC_HSITRIM                    \ [0x10 : 5] HSI clock trimming These bits provide an additional user-programmable trimming value that is added to HSICAL[11:0] bits. It can be programmed to adjust to voltage and temperature variations that influence the frequency of the HSI.
  [then]


  [ifdef] RCC_RCC_CRRCR_DEF
    \
    \ @brief RCC clock recovery RC register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSI48CAL                   \ [0x00 : 9] HSI48 clock calibration These bits are initialized at startup with the factory-programmed HSI48 calibration trim value.
  [then]


  [ifdef] RCC_RCC_CFGR1_DEF
    \
    \ @brief RCC clock configuration register 1
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW                         \ [0x00 : 2] system clock switch This bitfield is set and cleared by software to select system clock source (SYSCLK). It is configured by hardware to force MSIS oscillator selection when exiting Standby or Shutdown mode. This bitfield is configured by hardware to force MSIS or HSI16 oscillator selection when exiting Stop mode or in case of HSE oscillator failure, depending on STOPWUCK.
    $02 constant RCC_SWS                        \ [0x02 : 2] system clock switch status This bitfield is set and cleared by hardware to indicate which clock source is used as system clock.
    $04 constant RCC_STOPWUCK                   \ [0x04] wake-up from Stop and CSS backup clock selection This bit is set and cleared by software to select the system clock used when exiting Stop mode. The selected clock is also used as emergency clock for the clock security system on�HSE. STOPWUCK must not be modified when the CSS is enabled by HSECSSON in�RCC_CR, and the system clock is HSE (SWS = 10) or a switch on HSE is�requested (SW�=�10).
    $05 constant RCC_STOPKERWUCK                \ [0x05] wake-up from Stop kernel clock automatic enable selection This bit is set and cleared by software to enable automatically another oscillator when exiting Stop mode. This oscillator can be used as independent kernel clock by peripherals.
    $18 constant RCC_MCOSEL                     \ [0x18 : 4] microcontroller clock output This bitfield is set and cleared by software. Others: reserved Note: This clock output may have some truncated cycles at startup or during MCO clock source switching.
    $1c constant RCC_MCOPRE                     \ [0x1c : 3] microcontroller clock output prescaler This bitfield is set and cleared by software. It is highly recommended to change this prescaler before MCO output is enabled. Others: not allowed
  [then]


  [ifdef] RCC_RCC_CFGR2_DEF
    \
    \ @brief RCC clock configuration register 2
    \ Address offset: 0x20
    \ Reset value: 0x00006000
    \
    $00 constant RCC_HPRE                       \ [0x00 : 4] AHB prescaler This bitfiled is set and cleared by software to control the division factor of the AHB clock (HCLK). Depending on the device voltage range, the software must set these bits correctly to ensure that the system frequency does not exceed the maximum allowed frequency (for more details, refer to Table�118). After a write operation to these bits and before decreasing the voltage range, this register must be read to be sure that the new value is taken into account. 0xxx: SYSCLK not divided
    $04 constant RCC_PPRE1                      \ [0x04 : 3] APB1 prescaler This bitfiled is set and cleared by software to control the division factor of APB1 clock (PCLK1). 0xx: PCLK1 not divided
    $08 constant RCC_PPRE2                      \ [0x08 : 3] APB2 prescaler This bitfiled is set and cleared by software to control the division factor of APB2 clock (PCLK2). 0xx: PCLK2 not divided
    $0c constant RCC_DPRE                       \ [0x0c : 3] DSI PHY prescaler This bitfiled is set and cleared by software to control the division factor of DSI PHY bus clock (DCLK). 0xx: DCLK not divided Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
    $10 constant RCC_AHB1DIS                    \ [0x10] AHB1 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB1 peripherals (except those listed hereafter) are used and when their clocks are disabled in RCC_AHB1ENR. When this bit is set, all the AHB1 peripherals clocks are off, except for FLASH, BKPSRAM, ICACHE, DCACHE1 and SRAM1.
    $11 constant RCC_AHB2DIS1                   \ [0x11] AHB2_1 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB2 peripherals from RCC_AHB2ENR1 (except SRAM2 and SRAM3) are used and when their clocks are disabled in RCC_AHB2ENR1. When this bit is set, all the AHB2 peripherals clocks from RCC_AHB2ENR1 are off, except for SRAM2 and SRAM3.
    $12 constant RCC_AHB2DIS2                   \ [0x12] AHB2_2 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB2 peripherals from RCC_AHB2ENR2 are used and when their clocks are disabled in RCC_AHB2ENR2. When this bit is set, all the AHB2 peripherals clocks from RCC_AHB2ENR2 are off.
    $13 constant RCC_APB1DIS                    \ [0x13] APB1 clock disable This bit can be set in order to further reduce power consumption, when none of the APB1 peripherals (except IWDG) are used and when their clocks are disabled in RCC_APB1ENR. When this bit is set, all the APB1 peripherals clocks are off, except for IWDG.
    $14 constant RCC_APB2DIS                    \ [0x14] APB2 clock disable This bit can be set in order to further reduce power consumption, when none of the APB2 peripherals are used and when their clocks are disabled in RCC_APB2ENR. When this bit is set, all APB2 peripherals clocks are off.
  [then]


  [ifdef] RCC_RCC_CFGR3_DEF
    \
    \ @brief RCC clock configuration register 3
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $04 constant RCC_PPRE3                      \ [0x04 : 3] APB3 prescaler This bitfield is set and cleared by software to control the division factor of the APB3 clock (PCLK3). 0xx: HCLK not divided
    $10 constant RCC_AHB3DIS                    \ [0x10] AHB3 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB3 peripherals (except SRAM4) are used and when their clocks are disabled in RCC_AHB3ENR. When this bit is set, all the AHB3 peripherals clocks are off, except for SRAM4.
    $11 constant RCC_APB3DIS                    \ [0x11] APB3 clock disable This bit can be set in order to further reduce power consumption, when none of the APB3 peripherals from RCC_APB3ENR are used and when their clocks are disabled in RCC_APB3ENR. When this bit is set, all the APB3 peripherals clocks are off.
  [then]


  [ifdef] RCC_RCC_PLL1CFGR_DEF
    \
    \ @brief RCC PLL1 configuration register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL1SRC                    \ [0x00 : 2] PLL1 entry clock source This bitfield is set and cleared by software to select PLL1 clock source. It can be written only when the PLL1 is disabled. In order to save power, when no PLL1 is used, this bitfield value must be zero.
    $02 constant RCC_PLL1RGE                    \ [0x02 : 2] PLL1 input frequency range This bit is set and reset by software to select the proper reference frequency range used for PLL1. It must be written before enabling the PLL1. 00-01-10: PLL1 input (ref1_ck) clock range frequency between 4 and 8 MHz
    $04 constant RCC_PLL1FRACEN                 \ [0x04] PLL1 fractional latch enable This bit is set and reset by software to latch the content of PLL1FRACN in the ΣΔ modulator. In order to latch the PLL1FRACN value into the ΣΔ modulator, PLL1FRACEN must be set to 0, then set to 1: the transition 0 to 1 transfers the content of PLL1FRACN into the modulator (see PLL initialization phase for details).
    $08 constant RCC_PLL1M                      \ [0x08 : 4] Prescaler for PLL1 This bitfield is set and cleared by software to configure the prescaler of the PLL1. The VCO1 input frequency is PLL1 input clock frequency/PLL1M. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
    $0c constant RCC_PLL1MBOOST                 \ [0x0c : 4] Prescaler for EPOD booster input clock This bitfield is set and cleared by software to configure the prescaler of the PLL1, used for the EPOD booster. The EPOD booster input frequency is PLL1�input�clock�frequency/PLL1MBOOST. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0) and EPODboost mode is disabled (see Section�10: Power control (PWR)). others: reserved
    $10 constant RCC_PLL1PEN                    \ [0x10] PLL1 DIVP divider output enable This bit is set and reset by software to enable the pll1_p_ck output of the PLL1. To save power, PLL1PEN and PLL1P bits must be set to 0 when pll1_p_ck is not used.
    $11 constant RCC_PLL1QEN                    \ [0x11] PLL1 DIVQ divider output enable This bit is set and reset by software to enable the pll1_q_ck output of the PLL1. To save power, PLL1QEN and PLL1Q bits must be set to 0 when pll1_q_ck is not used.
    $12 constant RCC_PLL1REN                    \ [0x12] PLL1 DIVR divider output enable This bit is set and reset by software to enable the pll1_r_ck output of the PLL1. To save power, PLL1RENPLL2REN and PLL1R bits must be set to 0 when pll1_r_ck is not used. This bit can be cleared only when the PLL1 is not used as SYSCLK.
  [then]


  [ifdef] RCC_RCC_PLL2CFGR_DEF
    \
    \ @brief RCC PLL2 configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL2SRC                    \ [0x00 : 2] PLL2 entry clock source This bitfield is set and cleared by software to select PLL2 clock source. It can be written only when the PLL2 is disabled. To save power, when no PLL2 is used, this bitfield value must be�zero.
    $02 constant RCC_PLL2RGE                    \ [0x02 : 2] PLL2 input frequency range This bitfield is set and reset by software to select the proper reference frequency range used for�PLL2. It must be written before enabling the PLL2. 00-01-10: PLL2 input (ref2_ck) clock range frequency between 4 and 8 MHz
    $04 constant RCC_PLL2FRACEN                 \ [0x04] PLL2 fractional latch enable This bit is set and reset by software to latch the content of PLL2FRACN in the ΣΔ modulator. In order to latch the PLL2FRACN value into the ΣΔ modulator, PLL2FRACEN must be set to 0, then set to 1: the transition 0 to 1 transfers the content of PLL2FRACN into the modulator (see PLL initialization phase for details).
    $08 constant RCC_PLL2M                      \ [0x08 : 4] Prescaler for PLL2 This bitfield is set and cleared by software to configure the prescaler of the PLL2. The VCO2 input frequency is PLL2 input clock frequency/PLL2M. This bit can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...
    $10 constant RCC_PLL2PEN                    \ [0x10] PLL2 DIVP divider output enable This bit is set and reset by software to enable the pll2_p_ck output of the PLL2. To save power, PLL2PEN and PLL2P bits must be set to 0 when pll2_p_ck is not used.
    $11 constant RCC_PLL2QEN                    \ [0x11] PLL2 DIVQ divider output enable This bit is set and reset by software to enable the pll2_q_ck output of the PLL2. To save power, PLL2QEN and PLL2Q bits must be set to 0 when pll2_q_ck is not used.
    $12 constant RCC_PLL2REN                    \ [0x12] PLL2 DIVR divider output enable This bit is set and reset by software to enable the pll2_r_ck output of the PLL2. To save power, PLL2REN and PLL2R bits must be set to 0 when pll2_r_ck is not used.
  [then]


  [ifdef] RCC_RCC_PLL3CFGR_DEF
    \
    \ @brief RCC PLL3 configuration register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL3SRC                    \ [0x00 : 2] PLL3 entry clock source This bitfield is set and cleared by software to select PLL3 clock source. It can be written only when the PLL3 is disabled. To save power, when no PLL3 is used, this bitfield value must be�zero.
    $02 constant RCC_PLL3RGE                    \ [0x02 : 2] PLL3 input frequency range This bit is set and reset by software to select the proper reference frequency range used for�PLL3. It must be written before enabling the PLL3. 00-01-10: PLL3 input (ref3_ck) clock range frequency between 4 and 8 MHz
    $04 constant RCC_PLL3FRACEN                 \ [0x04] PLL3 fractional latch enable This bit is set and reset by software to latch the content of PLL3FRACN in the ΣΔ modulator. In order to latch the PLL3FRACN value into the ΣΔ modulator, PLL3FRACEN must be set to 0, then set to 1: the transition 0 to 1 transfers the content of PLL3FRACN into the modulator (see PLL initialization phase for details).
    $08 constant RCC_PLL3M                      \ [0x08 : 4] Prescaler for PLL3 This bitfield is set and cleared by software to configure the prescaler of the PLL3. The VCO3 input frequency is PLL3 input clock frequency/PLL3M. This bitfield can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0). ...
    $10 constant RCC_PLL3PEN                    \ [0x10] PLL3 DIVP divider output enable This bit is set and reset by software to enable the pll3_p_ck output of the PLL3. To save power, PLL3PEN and PLL3P bits must be set to 0 when pll3_p_ck is not used.
    $11 constant RCC_PLL3QEN                    \ [0x11] PLL3 DIVQ divider output enable This bit is set and reset by software to enable the pll3_q_ck output of the PLL3. To save power, PLL3QEN and PLL3Q bits must be set to 0 when pll3_q_ck is not used.
    $12 constant RCC_PLL3REN                    \ [0x12] PLL3 DIVR divider output enable This bit is set and reset by software to enable the pll3_r_ck output of the PLL3. To save power, PLL3REN and PLL3R bits must be set to 0 when pll3_r_ck is not used.
  [then]


  [ifdef] RCC_RCC_PLL1DIVR_DEF
    \
    \ @brief RCC PLL1 dividers register
    \ Address offset: 0x34
    \ Reset value: 0x01010280
    \
    $00 constant RCC_PLL1N                      \ [0x00 : 9] Multiplication factor for PLL1 VCO This bitfield is set and reset by software to control the multiplication factor of the VCO. It can be written only when the PLL is disabled (PLL1ON = 0 and PLL1RDY = 0). ... ... Others: reserved VCO output frequency = F<sub>ref1_ck</sub> x PLL1N, when fractional value 0 has been loaded in PLL1FRACN, with: PLL1N between 4 and 512 input frequency F<sub>ref1_ck</sub> between 4 and 16�MHz
    $09 constant RCC_PLL1P                      \ [0x09 : 7] PLL1 DIVP division factor This bitfield is set and reset by software to control the frequency of the pll1_p_ck clock. It can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
    $10 constant RCC_PLL1Q                      \ [0x10 : 7] PLL1 DIVQ division factor This bitfield is set and reset by software to control the frequency of the pll1_q_ck clock. It can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
    $18 constant RCC_PLL1R                      \ [0x18 : 7] PLL1 DIVR division factor This bitfield is set and reset by software to control frequency of the pll1_r_ck clock. It can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). Only division by one and even division factors are allowed. ...
  [then]


  [ifdef] RCC_RCC_PLL1FRACR_DEF
    \
    \ @brief RCC PLL1 fractional divider register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $03 constant RCC_PLL1FRACN                  \ [0x03 : 13] Fractional part of the multiplication factor for PLL1 VCO This bitfield is set and reset by software to control the fractional part of the VCO multiplication factor. It can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. VCO output frequency = F<sub>ref1_ck</sub> x (PLL1N + (PLL1FRACN / 2<sup>13</sup>)), with: PLL1N must be between 4 and 512. PLL1FRACN can be between 0 and 2<sup>13</sup>- 1. The input frequency F<sub>ref1_ck</sub> must be between 4 and 16 MHz. To change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as�follows: Set PLL1FRACEN = 0. Write the new fractional value into PLL1FRACN. Set PLL1FRACEN = 1.
  [then]


  [ifdef] RCC_RCC_PLL2DIVR_DEF
    \
    \ @brief RCC PLL2 dividers configuration register
    \ Address offset: 0x3C
    \ Reset value: 0x01010280
    \
    $00 constant RCC_PLL2N                      \ [0x00 : 9] Multiplication factor for PLL2 VCO This bitfield is set and reset by software to control the multiplication factor of the VCO. It can be written only when the PLL is disabled (PLL2ON = 0 and PLL2RDY = 0). ... ... Others: reserved VCO output frequency = F<sub>ref2_ck</sub> x PLL2N, when fractional value 0 has been loaded in PLL2FRACN, with: PLL2N between 4 and 512 input frequency F<sub>ref2_ck</sub> between 1MHz and 16MHz
    $09 constant RCC_PLL2P                      \ [0x09 : 7] PLL2 DIVP division factor This bitfield is set and reset by software to control the frequency of the pll2_p_ck clock. It can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...
    $10 constant RCC_PLL2Q                      \ [0x10 : 7] PLL2 DIVQ division factor This bitfield is set and reset by software to control the frequency of the pll2_q_ck clock. It can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...
    $18 constant RCC_PLL2R                      \ [0x18 : 7] PLL2 DIVR division factor This bitfield is set and reset by software to control the frequency of the pll2_r_ck clock. It can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...
  [then]


  [ifdef] RCC_RCC_PLL2FRACR_DEF
    \
    \ @brief RCC PLL2 fractional divider register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $03 constant RCC_PLL2FRACN                  \ [0x03 : 13] Fractional part of the multiplication factor for PLL2 VCO This bitfield is set and reset by software to control the fractional part of the VCO multiplication factor. It can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. VCO output frequency = F<sub>ref2_ck</sub> x (PLL2N + (PLL2FRACN / 2<sup>13</sup>)), with PLL2N must be between 4 and 512. PLL2FRACN can be between 0 and 2<sup>13 </sup>- 1. The input frequency F<sub>ref2_ck</sub> must be between 4 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL2FRACEN to 0. Write the new fractional value into PLL2FRACN. Set the bit PLL2FRACEN to 1.
  [then]


  [ifdef] RCC_RCC_PLL3DIVR_DEF
    \
    \ @brief RCC PLL3 dividers configuration register
    \ Address offset: 0x44
    \ Reset value: 0x01010280
    \
    $00 constant RCC_PLL3N                      \ [0x00 : 9] Multiplication factor for PLL3 VCO This bitfield is set and reset by software to control the multiplication factor of the VCO. It can be written only when the PLL is disabled (PLL3ON = 0 and PLL3RDY = 0). ... ... Others: reserved VCO output frequency = F<sub>ref3_ck</sub> x PLL3N, when fractional value 0 has been loaded in PLL3FRACN, with: PLL3N between 4 and 512 input frequency F<sub>ref3_ck</sub> between 4 and 16MHz
    $09 constant RCC_PLL3P                      \ [0x09 : 7] PLL3 DIVP division factor This bitfield is set and reset by software to control the frequency of the pll3_p_ck clock. It can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0). ...
    $10 constant RCC_PLL3Q                      \ [0x10 : 7] PLL3 DIVQ division factor This bitfield is set and reset by software to control the frequency of the pll3_q_ck clock. It can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0). ...
    $18 constant RCC_PLL3R                      \ [0x18 : 7] PLL3 DIVR division factor This bitfield is set and reset by software to control the frequency of the pll3_r_ck clock. It can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0). ...
  [then]


  [ifdef] RCC_RCC_PLL3FRACR_DEF
    \
    \ @brief RCC PLL3 fractional divider register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $03 constant RCC_PLL3FRACN                  \ [0x03 : 13] Fractional part of the multiplication factor for PLL3 VCO This bitfield is set and reset by software to control the fractional part of the VCO multiplication factor. It can be written at any time, allowing dynamic fine-tuning of the PLL3 VCO. VCO output frequency = F<sub>ref3_ck</sub> x (PLL3N + (PLL3FRACN / 2<sup>13</sup>)), with: PLL3N must be between 4 and 512. PLL3FRACN can be between 0 and 2<sup>13 </sup>- 1. The input frequency F<sub>ref3_ck</sub> must be between 4 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL3FRACEN to 0. Write the new fractional value into PLL3FRACN. Set the bit PLL3FRACEN to 1.
  [then]


  [ifdef] RCC_RCC_CIER_DEF
    \
    \ @brief RCC clock interrupt enable register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the LSI oscillator stabilization.
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the LSE oscillator stabilization.
    $02 constant RCC_MSISRDYIE                  \ [0x02] MSIS ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the MSIS oscillator stabilization.
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI16 ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the HSI16 oscillator stabilization.
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the HSE oscillator stabilization.
    $05 constant RCC_HSI48RDYIE                 \ [0x05] HSI48 ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the HSI48 oscillator stabilization.
    $06 constant RCC_PLL1RDYIE                  \ [0x06] PLL ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by PLL1 lock.
    $07 constant RCC_PLL2RDYIE                  \ [0x07] PLL2 ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by PLL2 lock.
    $08 constant RCC_PLL3RDYIE                  \ [0x08] PLL3 ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by PLL3 lock.
    $0b constant RCC_MSIKRDYIE                  \ [0x0b] MSIK ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the MSIK oscillator stabilization.
    $0c constant RCC_SHSIRDYIE                  \ [0x0c] SHSI ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the SHSI oscillator stabilization.
  [then]


  [ifdef] RCC_RCC_CIFR_DEF
    \
    \ @brief RCC clock interrupt flag register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready interrupt flag This bit is set by hardware when the LSI clock becomes stable and LSIRDYIE is set. It is cleared by software by�setting the LSIRDYC bit.
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag This bit is set by hardware when the LSE clock becomes stable and LSERDYIE is set. It is cleared by software by setting the LSERDYC bit.
    $02 constant RCC_MSISRDYF                   \ [0x02] MSIS ready interrupt flag This bit is set by hardware when the MSIS clock becomes stable and MSISRDYIE is set. It�is cleared by software by setting the MSISRDYC bit.
    $03 constant RCC_HSIRDYF                    \ [0x03] HSI16 ready interrupt flag This bit is set by hardware when the HSI16 clock becomes stable and HSIRDYIE = 1 in�response to setting the HSION (see RCC_CR). When HSION = 0 but the HSI16 oscillator is enabled by the peripheral through a clock request, this bit is not set and no interrupt is generated. This bit is cleared by software by setting the HSIRDYC bit.
    $04 constant RCC_HSERDYF                    \ [0x04] HSE ready interrupt flag This bit is set by hardware when the HSE clock becomes stable and HSERDYIE is set. It is cleared by software by setting the HSERDYC bit.
    $05 constant RCC_HSI48RDYF                  \ [0x05] HSI48 ready interrupt flag This bit is set by hardware when the HSI48 clock becomes stable and HSI48RDYIE is set. it�is cleared by software by setting the HSI48RDYC bit.
    $06 constant RCC_PLL1RDYF                   \ [0x06] PLL1 ready interrupt flag This bit is set by hardware when the PLL1 locks and PLL1RDYIE is set. It is cleared by software by setting the PLL1RDYC bit.
    $07 constant RCC_PLL2RDYF                   \ [0x07] PLL2 ready interrupt flag This bit is set by hardware when the PLL2 locks and PLL2RDYIE is set. It is cleared by software by setting the PLL2RDYC bit.
    $08 constant RCC_PLL3RDYF                   \ [0x08] PLL3 ready interrupt flag This bit is set by hardware when the PLL3 locks and PLL3RDYIE is set. It is cleared by software by setting the PLL3RDYC bit.
    $0a constant RCC_CSSF                       \ [0x0a] Clock security system interrupt flag This bit is set by hardware when a failure is detected in the HSE oscillator. It is cleared by software by setting the CSSC bit.
    $0b constant RCC_MSIKRDYF                   \ [0x0b] MSIK ready interrupt flag This bit is set by hardware when the MSIK clock becomes stable and MSIKRDYIE is set. It is cleared by software by setting the MSIKRDYC bit.
    $0c constant RCC_SHSIRDYF                   \ [0x0c] SHSI ready interrupt flag This bit is set by hardware when the SHSI clock becomes stable and SHSIRDYIE is set. It is cleared by software by setting the SHSIRDYC bit.
  [then]


  [ifdef] RCC_RCC_CICR_DEF
    \
    \ @brief RCC clock interrupt clear register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYC                    \ [0x00] LSI ready interrupt clear Writing this bit to 1 clears the LSIRDYF flag. Writing 0 has no effect.
    $01 constant RCC_LSERDYC                    \ [0x01] LSE ready interrupt clear Writing this bit to 1 clears the LSERDYF flag. Writing 0 has no effect.
    $02 constant RCC_MSISRDYC                   \ [0x02] MSIS ready interrupt clear Writing this bit to 1 clears the MSISRDYF flag. Writing 0 has no effect.
    $03 constant RCC_HSIRDYC                    \ [0x03] HSI16 ready interrupt clear Writing this bit to 1 clears the HSIRDYF flag. Writing 0 has no effect.
    $04 constant RCC_HSERDYC                    \ [0x04] HSE ready interrupt clear Writing this bit to 1 clears the HSERDYF flag. Writing 0 has no effect.
    $05 constant RCC_HSI48RDYC                  \ [0x05] HSI48 ready interrupt clear Writing this bit to 1 clears the HSI48RDYF flag. Writing 0 has no effect.
    $06 constant RCC_PLL1RDYC                   \ [0x06] PLL1 ready interrupt clear Writing this bit to 1 clears the PLL1RDYF flag. Writing 0 has no effect.
    $07 constant RCC_PLL2RDYC                   \ [0x07] PLL2 ready interrupt clear Writing this bit to 1 clears the PLL2RDYF flag. Writing 0 has no effect.
    $08 constant RCC_PLL3RDYC                   \ [0x08] PLL3 ready interrupt clear Writing this bit to 1 clears the PLL3RDYF flag. Writing 0 has no effect.
    $0a constant RCC_CSSC                       \ [0x0a] Clock security system interrupt clear Writing this bit to 1 clears the CSSF flag. Writing 0 has no effect.
    $0b constant RCC_MSIKRDYC                   \ [0x0b] MSIK oscillator ready interrupt clear Writing this bit to 1 clears the MSIKRDYF flag. Writing 0 has no effect.
    $0c constant RCC_SHSIRDYC                   \ [0x0c] SHSI oscillator ready interrupt clear Writing this bit to 1 clears the SHSIRDYF flag. Writing 0 has no effect.
  [then]


  [ifdef] RCC_RCC_AHB1RSTR_DEF
    \
    \ @brief RCC AHB1 peripheral reset register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPDMA1RST                  \ [0x00] GPDMA1 reset This bit is set and cleared by software.
    $01 constant RCC_CORDICRST                  \ [0x01] CORDIC reset This bit is set and cleared by software.
    $02 constant RCC_FMACRST                    \ [0x02] FMAC reset This bit is set and cleared by software.
    $03 constant RCC_MDF1RST                    \ [0x03] MDF1 reset This bit is set and cleared by software.
    $0c constant RCC_CRCRST                     \ [0x0c] CRC reset This bit is set and cleared by software.
    $0f constant RCC_JPEGRST                    \ [0x0f] JPEG reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $10 constant RCC_TSCRST                     \ [0x10] TSC reset This bit is set and cleared by software.
    $11 constant RCC_RAMCFGRST                  \ [0x11] RAMCFG reset This bit is set and cleared by software.
    $12 constant RCC_DMA2DRST                   \ [0x12] DMA2D reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $13 constant RCC_GFXMMURST                  \ [0x13] GFXMMU reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $14 constant RCC_GPU2DRST                   \ [0x14] GPU2D reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_AHB2RSTR1_DEF
    \
    \ @brief RCC AHB2 peripheral reset register 1
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] I/O port A reset This bit is set and cleared by software.
    $01 constant RCC_GPIOBRST                   \ [0x01] I/O port B reset This bit is set and cleared by software.
    $02 constant RCC_GPIOCRST                   \ [0x02] I/O port C reset This bit is set and cleared by software.
    $03 constant RCC_GPIODRST                   \ [0x03] I/O port D reset This bit is set and cleared by software.
    $04 constant RCC_GPIOERST                   \ [0x04] I/O port E reset This bit is set and cleared by software.
    $05 constant RCC_GPIOFRST                   \ [0x05] I/O port F reset This bit is set and cleared by software. This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. Note: If not present, consider this bit as reserved and keep it at reset value.
    $06 constant RCC_GPIOGRST                   \ [0x06] I/O port G reset This bit is set and cleared by software.
    $07 constant RCC_GPIOHRST                   \ [0x07] I/O port H reset This bit is set and cleared by software.
    $08 constant RCC_GPIOIRST                   \ [0x08] I/O port I reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $09 constant RCC_GPIOJRST                   \ [0x09] I/O port J reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $0a constant RCC_ADC12RST                   \ [0x0a] ADC1 and ADC2 reset This bit is set and cleared by software. Note: This bit impacts ADC1 in STM32U535/545/575/585, and ADC1/ADC2 in�STM32U59x/5Ax/5Fx/5Gx.
    $0c constant RCC_DCMI_PSSIRST               \ [0x0c] DCMI and PSSI reset This bit is set and cleared by software.
    $0e constant RCC_OTGRST                     \ [0x0e] OTG_FS or OTG_HS reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $10 constant RCC_AESRST                     \ [0x10] AES hardware accelerator reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $11 constant RCC_HASHRST                    \ [0x11] HASH reset This bit is set and cleared by software.
    $12 constant RCC_RNGRST                     \ [0x12] RNG reset This bit is set and cleared by software.
    $13 constant RCC_PKARST                     \ [0x13] PKA reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $14 constant RCC_SAESRST                    \ [0x14] SAES hardware accelerator reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $15 constant RCC_OCTOSPIMRST                \ [0x15] OCTOSPIM reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $17 constant RCC_OTFDEC1RST                 \ [0x17] OTFDEC1 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $18 constant RCC_OTFDEC2RST                 \ [0x18] OTFDEC2 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1b constant RCC_SDMMC1RST                  \ [0x1b] SDMMC1 reset This bit is set and cleared by software.
    $1c constant RCC_SDMMC2RST                  \ [0x1c] SDMMC2 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_AHB2RSTR2_DEF
    \
    \ @brief RCC AHB2 peripheral reset register 2
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FSMCRST                    \ [0x00] Flexible memory controller reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $04 constant RCC_OCTOSPI1RST                \ [0x04] OCTOSPI1 reset This bit is set and cleared by software.
    $08 constant RCC_OCTOSPI2RST                \ [0x08] OCTOSPI2 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $0c constant RCC_HSPI1RST                   \ [0x0c] HSPI1 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_AHB3RSTR_DEF
    \
    \ @brief RCC AHB3 peripheral reset register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPGPIO1RST                 \ [0x00] LPGPIO1 reset This bit is set and cleared by software.
    $05 constant RCC_ADC4RST                    \ [0x05] ADC4 reset This bit is set and cleared by software.
    $06 constant RCC_DAC1RST                    \ [0x06] DAC1 reset This bit is set and cleared by software.
    $09 constant RCC_LPDMA1RST                  \ [0x09] LPDMA1 reset This bit is set and cleared by software.
    $0a constant RCC_ADF1RST                    \ [0x0a] ADF1 reset This bit is set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APB1RSTR1_DEF
    \
    \ @brief RCC APB1 peripheral reset register 1
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 reset This bit is set and cleared by software.
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 reset This bit is set and cleared by software.
    $02 constant RCC_TIM4RST                    \ [0x02] TIM4 reset This bit is set and cleared by software.
    $03 constant RCC_TIM5RST                    \ [0x03] TIM5 reset This bit is set and cleared by software.
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6 reset This bit is set and cleared by software.
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7 reset This bit is set and cleared by software.
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 reset This bit is set and cleared by software.
    $11 constant RCC_USART2RST                  \ [0x11] USART2 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series.Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $12 constant RCC_USART3RST                  \ [0x12] USART3 reset This bit is set and cleared by software.
    $13 constant RCC_UART4RST                   \ [0x13] UART4 reset This bit is set and cleared by software.
    $14 constant RCC_UART5RST                   \ [0x14] UART5 reset This bit is set and cleared by software.
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset This bit is set and cleared by software.
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 reset This bit is set and cleared by software.
    $18 constant RCC_CRSRST                     \ [0x18] CRS reset This bit is set and cleared by software.
    $19 constant RCC_USART6RST                  \ [0x19] USART6 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_APB1RSTR2_DEF
    \
    \ @brief RCC APB1 peripheral reset register 2
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $01 constant RCC_I2C4RST                    \ [0x01] I2C4 reset This bit is set and cleared by software
    $05 constant RCC_LPTIM2RST                  \ [0x05] LPTIM2 reset This bit is set and cleared by software.
    $06 constant RCC_I2C5RST                    \ [0x06] I2C5 reset This bit is set and cleared by software Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $07 constant RCC_I2C6RST                    \ [0x07] I2C6 reset This bit is set and cleared by software Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $09 constant RCC_FDCAN1RST                  \ [0x09] FDCAN1 reset This bit is set and cleared by software.
    $17 constant RCC_UCPD1RST                   \ [0x17] UCPD1 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_APB2RSTR_DEF
    \
    \ @brief RCC APB2 peripheral reset register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $0b constant RCC_TIM1RST                    \ [0x0b] TIM1 reset This bit is set and cleared by software.
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 reset This bit is set and cleared by software.
    $0d constant RCC_TIM8RST                    \ [0x0d] TIM8 reset This bit is set and cleared by software.
    $0e constant RCC_USART1RST                  \ [0x0e] USART1 reset This bit is set and cleared by software.
    $10 constant RCC_TIM15RST                   \ [0x10] TIM15 reset This bit is set and cleared by software.
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 reset This bit is set and cleared by software.
    $12 constant RCC_TIM17RST                   \ [0x12] TIM17 reset This bit is set and cleared by software.
    $15 constant RCC_SAI1RST                    \ [0x15] SAI1 reset This bit is set and cleared by software.
    $16 constant RCC_SAI2RST                    \ [0x16] SAI2 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $18 constant RCC_USBRST                     \ [0x18] USB reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $19 constant RCC_GFXTIMRST                  \ [0x19] GFXTIM reset This bit is set and cleared by software. Note: .This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1a constant RCC_LTDCRST                    \ [0x1a] LTDC reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1b constant RCC_DSIRST                     \ [0x1b] DSI reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_APB3RSTR_DEF
    \
    \ @brief RCC APB3 peripheral reset register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SYSCFGRST                  \ [0x01] SYSCFG reset This bit is set and cleared by software.
    $05 constant RCC_SPI3RST                    \ [0x05] SPI3 reset This bit is set and cleared by software.
    $06 constant RCC_LPUART1RST                 \ [0x06] LPUART1 reset This bit is set and cleared by software.
    $07 constant RCC_I2C3RST                    \ [0x07] I2C3 reset This bit is set and cleared by software.
    $0b constant RCC_LPTIM1RST                  \ [0x0b] LPTIM1 reset This bit is set and cleared by software.
    $0c constant RCC_LPTIM3RST                  \ [0x0c] LPTIM3 reset This bit is set and cleared by software.
    $0d constant RCC_LPTIM4RST                  \ [0x0d] LPTIM4 reset This bit is set and cleared by software.
    $0e constant RCC_OPAMPRST                   \ [0x0e] OPAMP reset This bit is set and cleared by software.
    $0f constant RCC_COMPRST                    \ [0x0f] COMP reset This bit is set and cleared by software.
    $14 constant RCC_VREFRST                    \ [0x14] VREFBUF reset This bit is set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHB1ENR_DEF
    \
    \ @brief RCC AHB1 peripheral clock enable register
    \ Address offset: 0x88
    \ Reset value: 0xD0200100
    \
    $00 constant RCC_GPDMA1EN                   \ [0x00] GPDMA1 clock enable This bit is set and cleared by software.
    $01 constant RCC_CORDICEN                   \ [0x01] CORDIC clock enable This bit is set and cleared by software.
    $02 constant RCC_FMACEN                     \ [0x02] FMAC clock enable This bit is set and reset by software.
    $03 constant RCC_MDF1EN                     \ [0x03] MDF1 clock enable This bit is set and reset by software.
    $08 constant RCC_FLASHEN                    \ [0x08] FLASH clock enable This bit is set and cleared by software. This bit can be disabled only when the flash memory is in power-down mode.
    $0c constant RCC_CRCEN                      \ [0x0c] CRC clock enable This bit is set and cleared by software.
    $0f constant RCC_JPEGEN                     \ [0x0f] JPEG clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $10 constant RCC_TSCEN                      \ [0x10] Touch sensing controller clock enable This bit is set and cleared by software.
    $11 constant RCC_RAMCFGEN                   \ [0x11] RAMCFG clock enable This bit is set and cleared by software.
    $12 constant RCC_DMA2DEN                    \ [0x12] DMA2D clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $13 constant RCC_GFXMMUEN                   \ [0x13] GFXMMU clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $14 constant RCC_GPU2DEN                    \ [0x14] GPU2D clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $15 constant RCC_DCACHE2EN                  \ [0x15] DCACHE2 clock enable This bit is set and reset by software. Note: DCACHE2 clock must be enabled to access memories, even if the DCACHE2 is bypassed. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $18 constant RCC_GTZC1EN                    \ [0x18] GTZC1 clock enable This bit is set and reset by software.
    $1c constant RCC_BKPSRAMEN                  \ [0x1c] BKPSRAM clock enable This bit is set and reset by software.
    $1e constant RCC_DCACHE1EN                  \ [0x1e] DCACHE1 clock enable This bit is set and reset by software. Note: DCACHE1 clock must be enabled when external memories are accessed through OCTOSPI1, OCTOSPI2, HSPI1 or FSMC, even if the DCACHE1 is bypassed.
    $1f constant RCC_SRAM1EN                    \ [0x1f] SRAM1 clock enable This bit is set and reset by software.
  [then]


  [ifdef] RCC_RCC_AHB2ENR1_DEF
    \
    \ @brief RCC AHB2 peripheral clock enable register 1
    \ Address offset: 0x8C
    \ Reset value: 0xC0000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] I/O port A clock enable This bit is set and cleared by software.
    $01 constant RCC_GPIOBEN                    \ [0x01] I/O port B clock enable This bit is set and cleared by software.
    $02 constant RCC_GPIOCEN                    \ [0x02] I/O port C clock enable This bit is set and cleared by software.
    $03 constant RCC_GPIODEN                    \ [0x03] I/O port D clock enable This bit is set and cleared by software.
    $04 constant RCC_GPIOEEN                    \ [0x04] I/O port E clock enable This bit is set and cleared by software.
    $05 constant RCC_GPIOFEN                    \ [0x05] I/O port F clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $06 constant RCC_GPIOGEN                    \ [0x06] I/O port G clock enable This bit is set and cleared by software.
    $07 constant RCC_GPIOHEN                    \ [0x07] I/O port H clock enable This bit is set and cleared by software.
    $08 constant RCC_GPIOIEN                    \ [0x08] I/O port I clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $09 constant RCC_GPIOJEN                    \ [0x09] I/O port J clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $0a constant RCC_ADC12EN                    \ [0x0a] ADC1 and ADC2 clock enable This bit is set and cleared by software. Note: This bit impacts ADC1 in STM32U535/545/575/585, and ADC1/ADC2 in�STM32U59x/5Ax/5Fx/5Gx.
    $0c constant RCC_DCMI_PSSIEN                \ [0x0c] DCMI and PSSI clock enable This bit is set and cleared by software.
    $0e constant RCC_OTGEN                      \ [0x0e] OTG_FS or OTG_HS clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $0f constant RCC_OTGHSPHYEN                 \ [0x0f] OTG_HS PHY clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $10 constant RCC_AESEN                      \ [0x10] AES clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $11 constant RCC_HASHEN                     \ [0x11] HASH clock enable This bit is set and cleared by software
    $12 constant RCC_RNGEN                      \ [0x12] RNG clock enable This bit is set and cleared by software.
    $13 constant RCC_PKAEN                      \ [0x13] PKA clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $14 constant RCC_SAESEN                     \ [0x14] SAES clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $15 constant RCC_OCTOSPIMEN                 \ [0x15] OCTOSPIM clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $17 constant RCC_OTFDEC1EN                  \ [0x17] OTFDEC1 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $18 constant RCC_OTFDEC2EN                  \ [0x18] OTFDEC2 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1b constant RCC_SDMMC1EN                   \ [0x1b] SDMMC1 clock enable This bit is set and cleared by software.
    $1c constant RCC_SDMMC2EN                   \ [0x1c] SDMMC2 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1e constant RCC_SRAM2EN                    \ [0x1e] SRAM2 clock enable This bit is set and reset by software.
    $1f constant RCC_SRAM3EN                    \ [0x1f] SRAM3 clock enable This bit is set and reset by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_AHB2ENR2_DEF
    \
    \ @brief RCC AHB2 peripheral clock enable register 2
    \ Address offset: 0x90
    \ Reset value: 0x80000000
    \
    $00 constant RCC_FSMCEN                     \ [0x00] FSMC clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $04 constant RCC_OCTOSPI1EN                 \ [0x04] OCTOSPI1 clock enable This bit is set and cleared by software.
    $08 constant RCC_OCTOSPI2EN                 \ [0x08] OCTOSPI2 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $0c constant RCC_HSPI1EN                    \ [0x0c] HSPI1 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1e constant RCC_SRAM6EN                    \ [0x1e] SRAM6 clock enable This bit is set and reset by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1f constant RCC_SRAM5EN                    \ [0x1f] SRAM5 clock enable This bit is set and reset by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_AHB3ENR_DEF
    \
    \ @brief RCC AHB3 peripheral clock enable register
    \ Address offset: 0x94
    \ Reset value: 0x80000000
    \
    $00 constant RCC_LPGPIO1EN                  \ [0x00] LPGPIO1 enable This bit is set and cleared by software.
    $02 constant RCC_PWREN                      \ [0x02] PWR clock enable This bit is set and cleared by software.
    $05 constant RCC_ADC4EN                     \ [0x05] ADC4 clock enable This bit is set and cleared by software.
    $06 constant RCC_DAC1EN                     \ [0x06] DAC1 clock enable This bit is set and cleared by software.
    $09 constant RCC_LPDMA1EN                   \ [0x09] LPDMA1 clock enable This bit is set and cleared by software.
    $0a constant RCC_ADF1EN                     \ [0x0a] ADF1 clock enable This bit is set and cleared by software.
    $0c constant RCC_GTZC2EN                    \ [0x0c] GTZC2 clock enable This bit is set and cleared by software.
    $1f constant RCC_SRAM4EN                    \ [0x1f] SRAM4 clock enable This bit is set and reset by software.
  [then]


  [ifdef] RCC_RCC_APB1ENR1_DEF
    \
    \ @brief RCC APB1 peripheral clock enable register 1
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2 clock enable This bit is set and cleared by software.
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 clock enable This bit is set and cleared by software.
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4 clock enable This bit is set and cleared by software.
    $03 constant RCC_TIM5EN                     \ [0x03] TIM5 clock enable This bit is set and cleared by software.
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6 clock enable This bit is set and cleared by software.
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7 clock enable This bit is set and cleared by software.
    $0b constant RCC_WWDGEN                     \ [0x0b] WWDG clock enable This bit is set by software to enable the window watchdog clock. It is reset by hardware system reset. This bit can also be set by hardware if the WWDG_SW option bit is reset.
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 clock enable This bit is set and cleared by software.
    $11 constant RCC_USART2EN                   \ [0x11] USART2 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $12 constant RCC_USART3EN                   \ [0x12] USART3 clock enable This bit is set and cleared by software.
    $13 constant RCC_UART4EN                    \ [0x13] UART4 clock enable This bit is set and cleared by software.
    $14 constant RCC_UART5EN                    \ [0x14] UART5 clock enable This bit is set and cleared by software.
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 clock enable This bit is set and cleared by software.
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 clock enable This bit is set and cleared by software.
    $18 constant RCC_CRSEN                      \ [0x18] CRS clock enable This bit is set and cleared by software.
    $19 constant RCC_USART6EN                   \ [0x19] USART6 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_APB1ENR2_DEF
    \
    \ @brief RCC APB1 peripheral clock enable register 2
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $01 constant RCC_I2C4EN                     \ [0x01] I2C4 clock enable This bit is set and cleared by software
    $05 constant RCC_LPTIM2EN                   \ [0x05] LPTIM2 clock enable This bit is set and cleared by software.
    $06 constant RCC_I2C5EN                     \ [0x06] I2C5 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $07 constant RCC_I2C6EN                     \ [0x07] I2C6 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $09 constant RCC_FDCAN1EN                   \ [0x09] FDCAN1 clock enable This bit is set and cleared by software.
    $17 constant RCC_UCPD1EN                    \ [0x17] UCPD1 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_APB2ENR_DEF
    \
    \ @brief RCC APB2 peripheral clock enable register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $0b constant RCC_TIM1EN                     \ [0x0b] TIM1 clock enable This bit is set and cleared by software.
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 clock enable This bit is set and cleared by software.
    $0d constant RCC_TIM8EN                     \ [0x0d] TIM8 clock enable This bit is set and cleared by software.
    $0e constant RCC_USART1EN                   \ [0x0e] USART1clock enable This bit is set and cleared by software.
    $10 constant RCC_TIM15EN                    \ [0x10] TIM15 clock enable This bit is set and cleared by software.
    $11 constant RCC_TIM16EN                    \ [0x11] TIM16 clock enable This bit is set and cleared by software.
    $12 constant RCC_TIM17EN                    \ [0x12] TIM17 clock enable This bit is set and cleared by software.
    $15 constant RCC_SAI1EN                     \ [0x15] SAI1 clock enable This bit is set and cleared by software.
    $16 constant RCC_SAI2EN                     \ [0x16] SAI2 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $18 constant RCC_USBEN                      \ [0x18] USB clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $19 constant RCC_GFXTIMEN                   \ [0x19] GFXTIM clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1a constant RCC_LTDCEN                     \ [0x1a] LTDC clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1b constant RCC_DSIEN                      \ [0x1b] DSI clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_APB3ENR_DEF
    \
    \ @brief RCC APB3 peripheral clock enable register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SYSCFGEN                   \ [0x01] SYSCFG clock enable This bit is set and cleared by software.
    $05 constant RCC_SPI3EN                     \ [0x05] SPI3 clock enable This bit is set and cleared by software.
    $06 constant RCC_LPUART1EN                  \ [0x06] LPUART1 clock enable This bit is set and cleared by software.
    $07 constant RCC_I2C3EN                     \ [0x07] I2C3 clock enable This bit is set and cleared by software.
    $0b constant RCC_LPTIM1EN                   \ [0x0b] LPTIM1 clock enable This bit is set and cleared by software.
    $0c constant RCC_LPTIM3EN                   \ [0x0c] LPTIM3 clock enable This bit is set and cleared by software.
    $0d constant RCC_LPTIM4EN                   \ [0x0d] LPTIM4 clock enable This bit is set and cleared by software.
    $0e constant RCC_OPAMPEN                    \ [0x0e] OPAMP clock enable This bit is set and cleared by software.
    $0f constant RCC_COMPEN                     \ [0x0f] COMP clock enable This bit is set and cleared by software.
    $14 constant RCC_VREFEN                     \ [0x14] VREFBUF clock enable This bit is set and cleared by software.
    $15 constant RCC_RTCAPBEN                   \ [0x15] RTC and TAMP APB clock enable This bit is set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHB1SMENR_DEF
    \
    \ @brief RCC AHB1 peripheral clock enable in Sleep and Stop modes register
    \ Address offset: 0xB0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant RCC_GPDMA1SMEN                 \ [0x00] GPDMA1 clocks enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $01 constant RCC_CORDICSMEN                 \ [0x01] CORDIC clocks enable during Sleep and Stop modes This bit is set and cleared by software during Sleep mode.
    $02 constant RCC_FMACSMEN                   \ [0x02] FMAC clocks enable during Sleep and Stop modes. This bit is set and cleared by software.
    $03 constant RCC_MDF1SMEN                   \ [0x03] MDF1 clocks enable during Sleep and Stop modes. This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $08 constant RCC_FLASHSMEN                  \ [0x08] FLASH clocks enable during Sleep and Stop modes This bit is set and cleared by software.
    $0c constant RCC_CRCSMEN                    \ [0x0c] CRC clocks enable during Sleep and Stop modes This bit is set and cleared by software.
    $0f constant RCC_JPEGSMEN                   \ [0x0f] JPEG clocks enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $10 constant RCC_TSCSMEN                    \ [0x10] TSC clocks enable during Sleep and Stop modes This bit is set and cleared by software.
    $11 constant RCC_RAMCFGSMEN                 \ [0x11] RAMCFG clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $12 constant RCC_DMA2DSMEN                  \ [0x12] DMA2D clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $13 constant RCC_GFXMMUSMEN                 \ [0x13] GFXMMU clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $14 constant RCC_GPU2DSMEN                  \ [0x14] GPU2D clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $15 constant RCC_DCACHE2SMEN                \ [0x15] DCACHE2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $18 constant RCC_GTZC1SMEN                  \ [0x18] GTZC1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $1c constant RCC_BKPSRAMSMEN                \ [0x1c] BKPSRAM clock enable during Sleep and Stop modes This bit is set and cleared by software
    $1d constant RCC_ICACHESMEN                 \ [0x1d] ICACHE clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $1e constant RCC_DCACHE1SMEN                \ [0x1e] DCACHE1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $1f constant RCC_SRAM1SMEN                  \ [0x1f] SRAM1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHB2SMENR1_DEF
    \
    \ @brief RCC AHB2 peripheral clock enable in Sleep and Stop modes register 1
    \ Address offset: 0xB4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant RCC_GPIOASMEN                  \ [0x00] I/O port A clocks enable during Sleep and Stop modes This bit is set and cleared by software.
    $01 constant RCC_GPIOBSMEN                  \ [0x01] I/O port B clocks enable during Sleep and Stop modes This bit is set and cleared by software.
    $02 constant RCC_GPIOCSMEN                  \ [0x02] I/O port C clocks enable during Sleep and Stop modes This bit is set and cleared by software.
    $03 constant RCC_GPIODSMEN                  \ [0x03] I/O port D clocks enable during Sleep and Stop modes This bit is set and cleared by software.
    $04 constant RCC_GPIOESMEN                  \ [0x04] I/O port E clocks enable during Sleep and Stop modes This bit is set and cleared by software.
    $05 constant RCC_GPIOFSMEN                  \ [0x05] I/O port F clocks enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $06 constant RCC_GPIOGSMEN                  \ [0x06] I/O port G clocks enable during Sleep and Stop modes This bit is set and cleared by software.
    $07 constant RCC_GPIOHSMEN                  \ [0x07] I/O port H clocks enable during Sleep and Stop modes This bit is set and cleared by software.
    $08 constant RCC_GPIOISMEN                  \ [0x08] I/O port I clocks enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $09 constant RCC_GPIOJSMEN                  \ [0x09] I/O port J clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $0a constant RCC_ADC12SMEN                  \ [0x0a] ADC1 and ADC2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit impacts ADC1 in STM32U535/545/575/585 and ADC1/ADC2 in�STM32U59x/5Ax/5Fx/5Gx.
    $0c constant RCC_DCMI_PSSISMEN              \ [0x0c] DCMI and PSSI clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $0e constant RCC_OTGSMEN                    \ [0x0e] OTG_FS and OTG_HS clocks enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $0f constant RCC_OTGHSPHYSMEN               \ [0x0f] OTG_HS PHY clock enable during Sleep and Stop modes This bit is set and cleared by software Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $10 constant RCC_AESSMEN                    \ [0x10] AES clock enable during Sleep and Stop modes This bit is set and cleared by software Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $11 constant RCC_HASHSMEN                   \ [0x11] HASH clock enable during Sleep and Stop modes This bit is set and cleared by software
    $12 constant RCC_RNGSMEN                    \ [0x12] RNG clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $13 constant RCC_PKASMEN                    \ [0x13] PKA clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $14 constant RCC_SAESSMEN                   \ [0x14] SAES accelerator clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $15 constant RCC_OCTOSPIMSMEN               \ [0x15] OCTOSPIM clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $17 constant RCC_OTFDEC1SMEN                \ [0x17] OTFDEC1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $18 constant RCC_OTFDEC2SMEN                \ [0x18] OTFDEC2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1b constant RCC_SDMMC1SMEN                 \ [0x1b] SDMMC1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $1c constant RCC_SDMMC2SMEN                 \ [0x1c] SDMMC2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1e constant RCC_SRAM2SMEN                  \ [0x1e] SRAM2 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $1f constant RCC_SRAM3SMEN                  \ [0x1f] SRAM3 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_AHB2SMENR2_DEF
    \
    \ @brief RCC AHB2 peripheral clock enable in Sleep and Stop modes register 2
    \ Address offset: 0xB8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant RCC_FSMCSMEN                   \ [0x00] FSMC clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $04 constant RCC_OCTOSPI1SMEN               \ [0x04] OCTOSPI1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $08 constant RCC_OCTOSPI2SMEN               \ [0x08] OCTOSPI2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $0c constant RCC_HSPI1SMEN                  \ [0x0c] HSPI1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1e constant RCC_SRAM6SMEN                  \ [0x1e] SRAM6 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1f constant RCC_SRAM5SMEN                  \ [0x1f] SRAM5 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_AHB3SMENR_DEF
    \
    \ @brief RCC AHB3 peripheral clock enable in Sleep and Stop modes register
    \ Address offset: 0xBC
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant RCC_LPGPIO1SMEN                \ [0x00] LPGPIO1 enable during Sleep and Stop modes This bit is set and cleared by software.
    $02 constant RCC_PWRSMEN                    \ [0x02] PWR clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $05 constant RCC_ADC4SMEN                   \ [0x05] ADC4 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $06 constant RCC_DAC1SMEN                   \ [0x06] DAC1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $09 constant RCC_LPDMA1SMEN                 \ [0x09] LPDMA1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $0a constant RCC_ADF1SMEN                   \ [0x0a] ADF1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $0c constant RCC_GTZC2SMEN                  \ [0x0c] GTZC2 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $1f constant RCC_SRAM4SMEN                  \ [0x1f] SRAM4 clock enable during Sleep and Stop modes This bit is set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APB1SMENR1_DEF
    \
    \ @brief RCC APB1 peripheral clock enable in Sleep and Stop modes register 1
    \ Address offset: 0xC4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant RCC_TIM2SMEN                   \ [0x00] TIM2 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $01 constant RCC_TIM3SMEN                   \ [0x01] TIM3 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $02 constant RCC_TIM4SMEN                   \ [0x02] TIM4 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $03 constant RCC_TIM5SMEN                   \ [0x03] TIM5 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $04 constant RCC_TIM6SMEN                   \ [0x04] TIM6 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $05 constant RCC_TIM7SMEN                   \ [0x05] TIM7 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $0b constant RCC_WWDGSMEN                   \ [0x0b] Window watchdog clock enable during Sleep and Stop modes This bit is set and cleared by software. It is forced to one by hardware when the hardware WWDG option is activated.
    $0e constant RCC_SPI2SMEN                   \ [0x0e] SPI2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $11 constant RCC_USART2SMEN                 \ [0x11] USART2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $12 constant RCC_USART3SMEN                 \ [0x12] USART3 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $13 constant RCC_UART4SMEN                  \ [0x13] UART4 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $14 constant RCC_UART5SMEN                  \ [0x14] UART5 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $15 constant RCC_I2C1SMEN                   \ [0x15] I2C1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $16 constant RCC_I2C2SMEN                   \ [0x16] I2C2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $18 constant RCC_CRSSMEN                    \ [0x18] CRS clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $19 constant RCC_USART6SMEN                 \ [0x19] USART6 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_APB1SMENR2_DEF
    \
    \ @brief RCC APB1 peripheral clocks enable in Sleep and Stop modes register 2
    \ Address offset: 0xC8
    \ Reset value: 0xFFFFFFFF
    \
    $01 constant RCC_I2C4SMEN                   \ [0x01] I2C4 clock enable during Sleep and Stop modes This bit is set and cleared by software Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $05 constant RCC_LPTIM2SMEN                 \ [0x05] LPTIM2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $06 constant RCC_I2C5SMEN                   \ [0x06] I2C5 clock enable during Sleep and Stop modes This bit is set and cleared by software Note: This bit must be set to allow the peripheral to wake up from Stop modes. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $07 constant RCC_I2C6SMEN                   \ [0x07] I2C6 clock enable during Sleep and Stop modes This bit is set and cleared by software Note: This bit must be set to allow the peripheral to wake up from Stop modes. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $09 constant RCC_FDCAN1SMEN                 \ [0x09] FDCAN1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $17 constant RCC_UCPD1SMEN                  \ [0x17] UCPD1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_APB2SMENR_DEF
    \
    \ @brief RCC APB2 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0xCC
    \ Reset value: 0xFFFFFFFF
    \
    $0b constant RCC_TIM1SMEN                   \ [0x0b] TIM1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $0c constant RCC_SPI1SMEN                   \ [0x0c] SPI1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $0d constant RCC_TIM8SMEN                   \ [0x0d] TIM8 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $0e constant RCC_USART1SMEN                 \ [0x0e] USART1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $10 constant RCC_TIM15SMEN                  \ [0x10] TIM15 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $11 constant RCC_TIM16SMEN                  \ [0x11] TIM16 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $12 constant RCC_TIM17SMEN                  \ [0x12] TIM17 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $15 constant RCC_SAI1SMEN                   \ [0x15] SAI1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $16 constant RCC_SAI2SMEN                   \ [0x16] SAI2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series.Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $18 constant RCC_USBSMEN                    \ [0x18] USB clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $19 constant RCC_GFXTIMSMEN                 \ [0x19] GFXTIM clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1a constant RCC_LTDCSMEN                   \ [0x1a] LTDC clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $1b constant RCC_DSISMEN                    \ [0x1b] DSI clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_APB3SMENR_DEF
    \
    \ @brief RCC APB3 peripheral clock enable in Sleep and Stop modes register
    \ Address offset: 0xD0
    \ Reset value: 0xFFFFFFFF
    \
    $01 constant RCC_SYSCFGSMEN                 \ [0x01] SYSCFG clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $05 constant RCC_SPI3SMEN                   \ [0x05] SPI3 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $06 constant RCC_LPUART1SMEN                \ [0x06] LPUART1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $07 constant RCC_I2C3SMEN                   \ [0x07] I2C3 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $0b constant RCC_LPTIM1SMEN                 \ [0x0b] LPTIM1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $0c constant RCC_LPTIM3SMEN                 \ [0x0c] LPTIM3 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $0d constant RCC_LPTIM4SMEN                 \ [0x0d] LPTIM4 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $0e constant RCC_OPAMPSMEN                  \ [0x0e] OPAMP clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $0f constant RCC_COMPSMEN                   \ [0x0f] COMP clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $14 constant RCC_VREFSMEN                   \ [0x14] VREFBUF clock enable during Sleep and Stop modes This bit is set and cleared by software.
    $15 constant RCC_RTCAPBSMEN                 \ [0x15] RTC and TAMP APB clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
  [then]


  [ifdef] RCC_RCC_SRDAMR_DEF
    \
    \ @brief RCC SmartRun domain peripheral autonomous mode register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $05 constant RCC_SPI3AMEN                   \ [0x05] SPI3 autonomous mode enable in Stop 0,1, 2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $06 constant RCC_LPUART1AMEN                \ [0x06] LPUART1 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $07 constant RCC_I2C3AMEN                   \ [0x07] I2C3 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $0b constant RCC_LPTIM1AMEN                 \ [0x0b] LPTIM1 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $0c constant RCC_LPTIM3AMEN                 \ [0x0c] LPTIM3 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $0d constant RCC_LPTIM4AMEN                 \ [0x0d] LPTIM4 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $0e constant RCC_OPAMPAMEN                  \ [0x0e] OPAMP autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software.
    $0f constant RCC_COMPAMEN                   \ [0x0f] COMP autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software.
    $14 constant RCC_VREFAMEN                   \ [0x14] VREFBUF autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software.
    $15 constant RCC_RTCAPBAMEN                 \ [0x15] RTC and TAMP autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $19 constant RCC_ADC4AMEN                   \ [0x19] ADC4 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $1a constant RCC_LPGPIO1AMEN                \ [0x1a] LPGPIO1 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software.
    $1b constant RCC_DAC1AMEN                   \ [0x1b] DAC1 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $1c constant RCC_LPDMA1AMEN                 \ [0x1c] LPDMA1 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $1d constant RCC_ADF1AMEN                   \ [0x1d] ADF1 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
    $1f constant RCC_SRAM4AMEN                  \ [0x1f] SRAM4 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software.
  [then]


  [ifdef] RCC_RCC_CCIPR1_DEF
    \
    \ @brief RCC peripherals independent clock configuration register 1
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL                  \ [0x00 : 2] USART1 kernel clock source selection These bits are used to select the USART1 kernel clock source. Note: The USART1 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16 or LSE.
    $02 constant RCC_USART2SEL                  \ [0x02 : 2] USART2 kernel clock source selection These bits are used to select the USART2 kernel clock source. The USART2 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16 or LSE. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
    $04 constant RCC_USART3SEL                  \ [0x04 : 2] USART3 kernel clock source selection These bits are used to select the USART3 kernel clock source. Note: The USART3 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16 or LSE.
    $06 constant RCC_UART4SEL                   \ [0x06 : 2] UART4 kernel clock source selection These bits are used to select the UART4 kernel clock source. Note: The UART4 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16 or LSE.
    $08 constant RCC_UART5SEL                   \ [0x08 : 2] UART5 kernel clock source selection These bits are used to select the UART5 kernel clock source. Note: The UART5 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16 or LSE.
    $0a constant RCC_I2C1SEL                    \ [0x0a : 2] I2C1 kernel clock source selection These bits are used to select the I2C1 kernel clock source. Note: The I2C1 is functional in Stop 0 and Stop 1 mode sonly when the kernel clock is HSI16�or MSIK.
    $0c constant RCC_I2C2SEL                    \ [0x0c : 2] I2C2 kernel clock source selection These bits are used to select the I2C2 kernel clock source. Note: The I2C2 is functional in Stop 0 and Stop 1 mode sonly when the kernel clock is HSI16�or MSIK.
    $0e constant RCC_I2C4SEL                    \ [0x0e : 2] I2C4 kernel clock source selection These bits are used to select the I2C4 kernel clock source. Note: The I2C4 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16�or MSIK.
    $10 constant RCC_SPI2SEL                    \ [0x10 : 2] SPI2 kernel clock source selection These bits are used to select the SPI2 kernel clock source. Note: The SPI2 is functional in Stop 0 and Stop 1 mode only when the kernel clock is HSI16 or MSIK.
    $12 constant RCC_LPTIM2SEL                  \ [0x12 : 2] Low-power timer 2 kernel clock source selection These bits are used to select the LPTIM2 kernel clock source. Note: The LPTIM2 is functional in Stop 0 and Stop 1 mode only when the kernel clock is LSI, LSE or HSI16 if HSIKERON = 1.
    $14 constant RCC_SPI1SEL                    \ [0x14 : 2] SPI1 kernel clock source selection These bits are used to select the SPI1 kernel clock source. Note: The SPI1 is functional in Stop 0 and Stop 1 mode only when the kernel clock is HSI16 or MSIK.
    $16 constant RCC_SYSTICKSEL                 \ [0x16 : 2] SysTick clock source selection These bits are used to select the SysTick clock source. Note: When LSE or LSI is selected, the AHB frequency must be at least four times higher than the LSI or LSE frequency. In addition, a jitter up to one HCLK cycle is introduced, due to the LSE or LSI sampling with HCLK in the SysTick circuitry.
    $18 constant RCC_FDCAN1SEL                  \ [0x18 : 2] FDCAN1 kernel clock source selection These bits are used to select the FDCAN1 kernel clock source.
    $1a constant RCC_ICLKSEL                    \ [0x1a : 2] Intermediate clock source selection These bits are used to select the clock source for the OTG_FS, the USB, and the SDMMC.
    $1d constant RCC_TIMICSEL                   \ [0x1d : 3] Clock sources for TIM16,TIM17, and LPTIM2 internal input capture When TIMICSEL2 is set, the TIM16, TIM17, and LPTIM2 internal input capture can be connected either to HSI/256, MSI/4, or MSI/1024. Depending on TIMICSEL[1:0] value, MSI is either MSIK or MSIS. When TIMICSEL2 is cleared, the HSI, MSIK, and MSIS clock sources cannot be selected as�TIM16, TIM17, or LPTIM2 internal input capture. 0xx: HSI, MSIK and MSIS dividers disabled Note: The clock division must be disabled (TIMICSEL configured to 0xx) before selecting or changing a clock sources division.
  [then]


  [ifdef] RCC_RCC_CCIPR2_DEF
    \
    \ @brief RCC peripherals independent clock configuration register 2
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDF1SEL                    \ [0x00 : 3] MDF1 kernel clock source selection These bits are used to select the MDF1 kernel clock source. others: reserved
    $05 constant RCC_SAI1SEL                    \ [0x05 : 3] SAI1 kernel clock source selection These bits are used to select the SAI1 kernel clock source. others: reserved Note: If the selected clock is the external clock and this clock is stopped, a switch to another clock is impossible.
    $08 constant RCC_SAI2SEL                    \ [0x08 : 3] SAI2 kernel clock source selection These bits are used to select the SAI2 kernel clock source. others: reserved If the selected clock is the external clock and this clock is stopped, a switch to another clock is impossible. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
    $0b constant RCC_SAESSEL                    \ [0x0b] SAES kernel clock source selection This bit is used to select the SAES kernel clock source. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $0c constant RCC_RNGSEL                     \ [0x0c : 2] RNG kernel clock source selection These bits are used to select the RNG kernel clock source.
    $0e constant RCC_SDMMCSEL                   \ [0x0e] SDMMC1 and SDMMC2 kernel clock source selection This bit is used to select the SDMMC kernel clock source. It is recommended to change it only after reset and before enabling the SDMMC.
    $0f constant RCC_DSISEL                     \ [0x0f] DSI kernel clock source selection This bit is used to select the DSI kernel clock source. This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. Note: If not present, consider this bit as reserved and keep it at reset value.
    $10 constant RCC_USART6SEL                  \ [0x10 : 2] USART6 kernel clock source selection These bits are used to select the USART6 kernel clock source. The USART6 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16 or LSE. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
    $12 constant RCC_LTDCSEL                    \ [0x12] LTDC kernel clock source selection This bit is used to select the LTDC kernel clock source. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
    $14 constant RCC_OCTOSPISEL                 \ [0x14 : 2] OCTOSPI1 and OCTOSPI2 kernel clock source selection These bits are used to select the OCTOSPI1 and OCTOSPI2 kernel clock source.
    $16 constant RCC_HSPI1SEL                   \ [0x16 : 2] HSPI1 kernel clock source selection These bits are used to select the HSPI1 kernel clock source. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
    $18 constant RCC_I2C5SEL                    \ [0x18 : 2] I2C5 kernel clock source selection These bits are used to select the I2C5 kernel clock source. The I2C5 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16�or MSIK. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
    $1a constant RCC_I2C6SEL                    \ [0x1a : 2] I2C6 kernel clock source selection These bits are used to select the I2C6 kernel clock source. The I2C6 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16�or MSIK. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
    $1e constant RCC_OTGHSSEL                   \ [0x1e : 2] OTG_HS PHY kernel clock source selection These bits are used to select the OTG_HS PHY kernel clock source. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
  [then]


  [ifdef] RCC_RCC_CCIPR3_DEF
    \
    \ @brief RCC peripherals independent clock configuration register 3
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPUART1SEL                 \ [0x00 : 3] LPUART1 kernel clock source selection These bits are used to select the LPUART1 kernel clock source. others: reserved Note: The LPUART1 is functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is HSI16, LSE, or MSIK.
    $03 constant RCC_SPI3SEL                    \ [0x03 : 2] SPI3 kernel clock source selection These bits are used to select the SPI3 kernel clock source. Note: The SPI3 is functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is HSI16 or MSIK.
    $06 constant RCC_I2C3SEL                    \ [0x06 : 2] I2C3 kernel clock source selection These bits are used to select the I2C3 kernel clock source. Note: The I2C3 is functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is HSI16 or MSIK.
    $08 constant RCC_LPTIM34SEL                 \ [0x08 : 2] LPTIM3 and LPTIM4 kernel clock source selection These bits are used to select the LPTIM3 and LPTIM4 kernel clock source. Note: The LPTIM3 and LPTIM4 are functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is LSI, LSE, HSI16 with HSIKERON = 1, or MSIK with MSIKERON�=�1.
    $0a constant RCC_LPTIM1SEL                  \ [0x0a : 2] LPTIM1 kernel clock source selection These bits are used to select the LPTIM1 kernel clock source. Note: The LPTIM1 is functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is LSI, LSE, HSI16 with HSIKERON = 1, or MSIK with MSIKERON = 1.
    $0c constant RCC_ADCDACSEL                  \ [0x0c : 3] ADC1, ADC2, ADC4 and DAC1 kernel clock source selection These bits are used to select the ADC1, ADC2, ADC4, and DAC1 kernel clock source. others: reserved Note: The ADC1, ADC2, ADC4, and DAC1 are functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is HSI16 or MSIK (only ADC4 and DAC1 are functional in�Stop 2 mode).
    $0f constant RCC_DAC1SEL                    \ [0x0f] DAC1 sample-and-hold clock source selection This bit is used to select the DAC1 sample-and-hold clock source.
    $10 constant RCC_ADF1SEL                    \ [0x10 : 3] ADF1 kernel clock source selection These bits are used to select the ADF1 kernel clock source. others: reserved Note: The ADF1 is functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is AUDIOCLK or MSIK.
  [then]


  [ifdef] RCC_RCC_BDCR_DEF
    \
    \ @brief RCC backup domain control register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enable This bit is set and cleared by software.
    $01 constant RCC_LSERDY                     \ [0x01] LSE oscillator ready This bit is set and cleared by hardware to indicate when the external 32�kHz oscillator is stable. After LSEON is cleared, this LSERDY bit goes low after six external low-speed oscillator clock cycles.
    $02 constant RCC_LSEBYP                     \ [0x02] LSE oscillator bypass This bit is set and cleared by software to bypass oscillator in debug mode. It can be written only when the external 32�kHz oscillator is disabled (LSEON = 0 and LSERDY = 0).
    $03 constant RCC_LSEDRV                     \ [0x03 : 2] LSE oscillator drive capability This bitfield is set by software to modulate the drive capability of the LSE oscillator. It can be written only when the external 32 kHz oscillator is disabled (LSEON = 0 and LSERDY = 0). Note: The oscillator is in ‘Xtal mode’ when it is not in bypass mode.
    $05 constant RCC_LSECSSON                   \ [0x05] CSS on LSE enable This bit is set by software to enable the CSS on LSE. It must be enabled after the LSE oscillator is enabled (LSEON bit enabled) and ready (LSERDY flag set by hardware), and after the RTCSEL bit is selected. Once enabled, this bit cannot be disabled, except after a LSE failure detection (LSECSSD�=�1). In that case, the software must disable this LSECSSON bit.
    $06 constant RCC_LSECSSD                    \ [0x06] CSS on LSE failure detection This bit is set by hardware to indicate when a failure is detected by the CCS on the external 32�kHz oscillator (LSE).
    $07 constant RCC_LSESYSEN                   \ [0x07] LSE system clock (LSESYS) enable This bit is set by software to enable always the LSE system clock generated by RCC, which can be used by any peripheral when its source clock is the LSE, or at system level if one of LSCOSEL, MCO, or MSI PLL mode is needed.
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC and TAMP clock source selection This bit is set by software to select the clock source for the RTC and TAMP. Once the RTC and TAMP clock source has been selected, it cannot be changed anymore unless the�backup domain is reset, or unless a failure is detected on LSE (LSECSSD is set). BDRST bit can be used to reset them.
    $0b constant RCC_LSESYSRDY                  \ [0x0b] LSE system clock (LSESYS) ready This bit is set and cleared by hardware to indicate when the LSE system clock is stable.When LSESYSEN is set, this LSESYSRDY flag is set after two LSE clock cycles. The LSE clock must be already enabled and stable (LSEON and LSERDY are set). When the LSEON bit is cleared, LSERDY goes low after six external low-speed oscillator clock cycles.
    $0c constant RCC_LSEGFON                    \ [0x0c] LSE clock glitch filter enable This bit is set and cleared by hardware to enable the LSE glitch filter. It can be written only when the LSE is disabled (LSEON = 0 and LSERDY = 0).
    $0f constant RCC_RTCEN                      \ [0x0f] RTC and TAMP clock enable This bit is set and cleared by software.
    $10 constant RCC_BDRST                      \ [0x10] Backup domain software reset This bit is set and cleared by software.
    $18 constant RCC_LSCOEN                     \ [0x18] Low-speed clock output (LSCO) enable This bit is set and cleared by software.
    $19 constant RCC_LSCOSEL                    \ [0x19] Low-speed clock output selection This bit is set and cleared by software.
    $1a constant RCC_LSION                      \ [0x1a] LSI oscillator enable This bit is set and cleared by software. The LSI oscillator is disabled 60��s maximum after the LSION bit is cleared.
    $1b constant RCC_LSIRDY                     \ [0x1b] LSI oscillator ready This bit is set and cleared by hardware to indicate when the LSI oscillator is stable. After�LSION is cleared, LSIRDY goes low after three internal low-speed oscillator clock cycles. This bit is set when the LSI is used by IWDG or RTC, even if LSION = 0.
    $1c constant RCC_LSIPREDIV                  \ [0x1c] Low-speed clock divider configuration This bit is set and cleared by software to enable the LSI division. It can be written only when the LSI is disabled (LSION = 0 and LSIRDY = 0). If the LSI was previously enabled, it is necessary to wait for at least 60 μs after clearing LSION bit (synchronization time for LSI to be really disabled), before writing LSIPREDIV. The LSIPREDIV cannot be changed if the LSI is used by the IWDG or by the RTC.
  [then]


  [ifdef] RCC_RCC_CSR_DEF
    \
    \ @brief RCC control/status register
    \ Address offset: 0xF4
    \ Reset value: 0x0C004400
    \
    $08 constant RCC_MSIKSRANGE                 \ [0x08 : 4] MSIK range after Standby mode This bit is set by software to chose the MSIK frequency at startup. It is used after exiting Standby mode until MSIRGSEL is set. After a NRST pin or a power-on reset or when exiting Shutdown mode, the range is always 4�MHz. MSIKSRANGE can be written only when MSIRGSEL = 1. others: reserved Note: Changing this bitfield does not change the current MSIK frequency.
    $0c constant RCC_MSISSRANGE                 \ [0x0c : 4] MSIS range after Standby mode This bitfield is set by software to chose the MSIS frequency at startup. It is used after exiting Standby mode until MSIRGSEL is set. After a NRST pin or a power-on reset or when exiting Shutdown mode, the range is always 4�MHz. MSISSRANGE can be written only when MSIRGSEL = 1. others: reserved Note: Changing this bitfield does not change the current MSIS frequency.
    $17 constant RCC_RMVF                       \ [0x17] Remove reset flag This bit is set by software to clear the reset flags.
    $19 constant RCC_OBLRSTF                    \ [0x19] Option-byte loader reset flag This bit is set by hardware when a reset from the option-byte loading occurs. It is cleared by�writing to the RMVF bit.
    $1a constant RCC_PINRSTF                    \ [0x1a] NRST pin reset flag This bit is set by hardware when a reset from the NRST pin occurs. It is cleared by writing to�the RMVF bit.
    $1b constant RCC_BORRSTF                    \ [0x1b] Brownout reset or an exit from Shutdown mode reset flag This bit is set by hardware when a brownout reset or an exit from Shutdown mode reset occurs. It is cleared by writing to the RMVF bit.
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag This bit is set by hardware when a software reset occurs. It is cleared by writing to RMVF.
    $1d constant RCC_IWDGRSTF                   \ [0x1d] Independent watchdog reset flag This bit is set by hardware when an independent watchdog reset domain occurs. It is cleared by writing to the RMVF bit.
    $1e constant RCC_WWDGRSTF                   \ [0x1e] Window watchdog reset flag This bit is set by hardware when a window watchdog reset occurs. It is cleared by writing to�the RMVF bit.
    $1f constant RCC_LPWRRSTF                   \ [0x1f] Low-power reset flag This bit is set by hardware when a reset occurs due to a Stop, Standby, or Shutdown mode entry, whereas the corresponding NRST_STOP, NRST_STBY, or NRST_SHDW option bit is cleared. This bit is cleared by writing to the RMVF bit.
  [then]


  [ifdef] RCC_RCC_SECCFGR_DEF
    \
    \ @brief RCC secure configuration register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSISEC                     \ [0x00] HSI clock configuration and status bit security This bit is set and reset by software.
    $01 constant RCC_HSESEC                     \ [0x01] HSE clock configuration bits, status bit and HSE_CSS security This bit is set and reset by software.
    $02 constant RCC_MSISEC                     \ [0x02] MSI clock configuration and status bit security This bit is set and reset by software.
    $03 constant RCC_LSISEC                     \ [0x03] LSI clock configuration and status bit security This bit is set and reset by software.
    $04 constant RCC_LSESEC                     \ [0x04] LSE clock configuration and status bit security This bit is set and reset by software.
    $05 constant RCC_SYSCLKSEC                  \ [0x05] SYSCLK clock selection, STOPWUCK bit, clock output on MCO configuration security This bit is set and reset by software.
    $06 constant RCC_PRESCSEC                   \ [0x06] AHBx/APBx prescaler configuration bits security This bit is set and reset by software.
    $07 constant RCC_PLL1SEC                    \ [0x07] PLL1 clock configuration and status bit security This bit is set and reset by software.
    $08 constant RCC_PLL2SEC                    \ [0x08] PLL2 clock configuration and status bit security Set and reset by software.
    $09 constant RCC_PLL3SEC                    \ [0x09] PLL3 clock configuration and status bit security This bit is set and reset by software.
    $0a constant RCC_ICLKSEC                    \ [0x0a] Intermediate clock source selection security This bit is set and reset by software.
    $0b constant RCC_HSI48SEC                   \ [0x0b] HSI48 clock configuration and status bit security This bit is set and reset by software.
    $0c constant RCC_RMVFSEC                    \ [0x0c] Remove reset flag security This bit is set and reset by software.
  [then]


  [ifdef] RCC_RCC_PRIVCFGR_DEF
    \
    \ @brief RCC privilege configuration register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPRIV                      \ [0x00] RCC secure function privilege configuration This bit is set and reset by software. It can be written only by a secure privileged access.
    $01 constant RCC_NSPRIV                     \ [0x01] RCC non-secure function privilege configuration This bit is set and reset by software. It can be written only by privileged access, secure or non-secure.
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_RCC_CR               \ RCC clock control register
  $08 constant RCC_RCC_ICSCR1           \ RCC internal clock sources calibration register 1
  $0C constant RCC_RCC_ICSCR2           \ RCC internal clock sources calibration register 2
  $10 constant RCC_RCC_ICSCR3           \ RCC internal clock sources calibration register 3
  $14 constant RCC_RCC_CRRCR            \ RCC clock recovery RC register
  $1C constant RCC_RCC_CFGR1            \ RCC clock configuration register 1
  $20 constant RCC_RCC_CFGR2            \ RCC clock configuration register 2
  $24 constant RCC_RCC_CFGR3            \ RCC clock configuration register 3
  $28 constant RCC_RCC_PLL1CFGR         \ RCC PLL1 configuration register
  $2C constant RCC_RCC_PLL2CFGR         \ RCC PLL2 configuration register
  $30 constant RCC_RCC_PLL3CFGR         \ RCC PLL3 configuration register
  $34 constant RCC_RCC_PLL1DIVR         \ RCC PLL1 dividers register
  $38 constant RCC_RCC_PLL1FRACR        \ RCC PLL1 fractional divider register
  $3C constant RCC_RCC_PLL2DIVR         \ RCC PLL2 dividers configuration register
  $40 constant RCC_RCC_PLL2FRACR        \ RCC PLL2 fractional divider register
  $44 constant RCC_RCC_PLL3DIVR         \ RCC PLL3 dividers configuration register
  $48 constant RCC_RCC_PLL3FRACR        \ RCC PLL3 fractional divider register
  $50 constant RCC_RCC_CIER             \ RCC clock interrupt enable register
  $54 constant RCC_RCC_CIFR             \ RCC clock interrupt flag register
  $58 constant RCC_RCC_CICR             \ RCC clock interrupt clear register
  $60 constant RCC_RCC_AHB1RSTR         \ RCC AHB1 peripheral reset register
  $64 constant RCC_RCC_AHB2RSTR1        \ RCC AHB2 peripheral reset register 1
  $68 constant RCC_RCC_AHB2RSTR2        \ RCC AHB2 peripheral reset register 2
  $6C constant RCC_RCC_AHB3RSTR         \ RCC AHB3 peripheral reset register
  $74 constant RCC_RCC_APB1RSTR1        \ RCC APB1 peripheral reset register 1
  $78 constant RCC_RCC_APB1RSTR2        \ RCC APB1 peripheral reset register 2
  $7C constant RCC_RCC_APB2RSTR         \ RCC APB2 peripheral reset register
  $80 constant RCC_RCC_APB3RSTR         \ RCC APB3 peripheral reset register
  $88 constant RCC_RCC_AHB1ENR          \ RCC AHB1 peripheral clock enable register
  $8C constant RCC_RCC_AHB2ENR1         \ RCC AHB2 peripheral clock enable register 1
  $90 constant RCC_RCC_AHB2ENR2         \ RCC AHB2 peripheral clock enable register 2
  $94 constant RCC_RCC_AHB3ENR          \ RCC AHB3 peripheral clock enable register
  $9C constant RCC_RCC_APB1ENR1         \ RCC APB1 peripheral clock enable register 1
  $A0 constant RCC_RCC_APB1ENR2         \ RCC APB1 peripheral clock enable register 2
  $A4 constant RCC_RCC_APB2ENR          \ RCC APB2 peripheral clock enable register
  $A8 constant RCC_RCC_APB3ENR          \ RCC APB3 peripheral clock enable register
  $B0 constant RCC_RCC_AHB1SMENR        \ RCC AHB1 peripheral clock enable in Sleep and Stop modes register
  $B4 constant RCC_RCC_AHB2SMENR1       \ RCC AHB2 peripheral clock enable in Sleep and Stop modes register 1
  $B8 constant RCC_RCC_AHB2SMENR2       \ RCC AHB2 peripheral clock enable in Sleep and Stop modes register 2
  $BC constant RCC_RCC_AHB3SMENR        \ RCC AHB3 peripheral clock enable in Sleep and Stop modes register
  $C4 constant RCC_RCC_APB1SMENR1       \ RCC APB1 peripheral clock enable in Sleep and Stop modes register 1
  $C8 constant RCC_RCC_APB1SMENR2       \ RCC APB1 peripheral clocks enable in Sleep and Stop modes register 2
  $CC constant RCC_RCC_APB2SMENR        \ RCC APB2 peripheral clocks enable in Sleep and Stop modes register
  $D0 constant RCC_RCC_APB3SMENR        \ RCC APB3 peripheral clock enable in Sleep and Stop modes register
  $D8 constant RCC_RCC_SRDAMR           \ RCC SmartRun domain peripheral autonomous mode register
  $E0 constant RCC_RCC_CCIPR1           \ RCC peripherals independent clock configuration register 1
  $E4 constant RCC_RCC_CCIPR2           \ RCC peripherals independent clock configuration register 2
  $E8 constant RCC_RCC_CCIPR3           \ RCC peripherals independent clock configuration register 3
  $F0 constant RCC_RCC_BDCR             \ RCC backup domain control register
  $F4 constant RCC_RCC_CSR              \ RCC control/status register
  $110 constant RCC_RCC_SECCFGR         \ RCC secure configuration register
  $114 constant RCC_RCC_PRIVCFGR        \ RCC privilege configuration register

: RCC_DEF ; [then]
