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
\ Reset value: 0x00000035
\

$00000001 constant RCC_RCC_CR_MSISON                                \ MSIS clock enable This bit is set and cleared by software. It is cleared by hardware to stop the MSIS oscillator when entering Stop, Standby or Shutdown mode. This bit is set by hardware to force the�MSIS oscillator on when exiting Standby or Shutdown mode. It is set by hardware to force the MSIS oscillator ON when STOPWUCK = 0 when exiting Stop modes, or in case of a failure of the HSE oscillator. Set by hardware when used directly or indirectly as system clock.
$00000002 constant RCC_RCC_CR_MSIKERON                              \ MSI enable for some peripheral kernels This bit is set and cleared by software to force MSI ON even in Stop modes. Keeping the MSI on in Stop mode allows the communication speed not to be reduced by the MSI startup time. This bit has no effect on MSISON and MSIKON values (see Section�11.4.24 for more details). This bit must be configured at 0 before entering Stop 3 mode.
$00000004 constant RCC_RCC_CR_MSISRDY                               \ MSIS clock ready flag This bit is set by hardware to indicate that the MSIS oscillator is stable. It is set only when MSIS is enabled by software (by setting MSISON). Note: Once the MSISON bit is cleared, MSISRDY goes low after six MSIS clock cycles.
$00000008 constant RCC_RCC_CR_MSIPLLEN                              \ MSI clock PLL-mode enable This bit is set and cleared by software to enable/disable the PLL part of the MSI clock source. MSIPLLEN must be enabled after LSE is enabled (LSEON enabled) and ready (LSERDY set by hardware). A hardware protection prevents from enabling MSIPLLEN if LSE is not ready. This bit is cleared by hardware when LSE is disabled (LSEON = 0) or when the CSS on LSE detects a LSE failure (see RCC_CSR).
$00000010 constant RCC_RCC_CR_MSIKON                                \ MSIK clock enable This bit is set and cleared by software. It is cleared by hardware to stop the MSIK when entering Stop, Standby, or Shutdown mode. This bit is set by hardware to force the MSIK oscillator ON when exiting Standby or Shutdown mode. It is set by hardware to force the MSIK oscillator on when STOPWUCK = 0 or STOPKERWUCK�=�0 when exiting Stop modes, or in case of a failure of the HSE oscillator.
$00000020 constant RCC_RCC_CR_MSIKRDY                               \ MSIK clock ready flag This bit is set by hardware to indicate that the MSIK is stable. It is set only when MSI kernel oscillator is enabled by software by setting MSIKON. Note: Once MSIKON bit is cleared, MSIKRDY goes low after six MSIK oscillator clock cycles.
$00000040 constant RCC_RCC_CR_MSIPLLSEL                             \ MSI clock with PLL mode selection This bit is set and cleared by software to select which MSI output clock uses the PLL mode. It�can be written only when the MSI PLL mode is disabled (MSIPLLEN = 0). Note: If the MSI kernel clock output uses the same oscillator source than the MSI system clock output, then the PLL mode is applied to both clock outputs.
$00000080 constant RCC_RCC_CR_MSIPLLFAST                            \ MSI PLL mode fast startup This bit is set and reset by software to enable/disable the fast PLL mode start-up of the MSI clock source. This bit is used only if PLL mode is selected (MSIPLLEN = 1). The fast start-up feature is not active the first time the PLL mode is selected. The�fast start-up is active when the MSI in PLL mode returns from switch off.
$00000100 constant RCC_RCC_CR_HSION                                 \ HSI16 clock enable This bit is set and cleared by software. It is cleared by hardware to stop the HSI16 oscillator when entering Stop, Standby, or Shutdown mode. This bit is set by hardware to force the�HSI16 oscillator on when STOPWUCK = 1 when leaving Stop modes, or in case of failure of the HSE crystal oscillator. This bit is set by hardware if the HSI16 is used directly or indirectly as system clock.
$00000200 constant RCC_RCC_CR_HSIKERON                              \ HSI16 enable for some peripheral kernels This bit is set and cleared by software to force HSI16 ON even in Stop modes. Keeping HSI16 on in Stop mode allows the communication speed not to be reduced by the HSI16 startup time. This bit has no effect on HSION value. Refer to Section�11.4.24 for more details. This bit must be configured at 0 before entering Stop 3 mode.
$00000400 constant RCC_RCC_CR_HSIRDY                                \ HSI16 clock ready flag This bit is set by hardware to indicate that HSI16 oscillator is stable. It is set only when HSI16 is enabled by software (by setting HSION). Note: Once the HSION bit is cleared, HSIRDY goes low after six HSI16 clock cycles.
$00001000 constant RCC_RCC_CR_HSI48ON                               \ HSI48 clock enable This bit is set and cleared by software. It is cleared by hardware to stop the HSI48 when entering in Stop, Standby, or Shutdown modes.
$00002000 constant RCC_RCC_CR_HSI48RDY                              \ HSI48 clock ready flag This bit is set by hardware to indicate that HSI48 oscillator is stable. Itis set only when HSI48 is enabled by software (by setting HSI48ON).
$00004000 constant RCC_RCC_CR_SHSION                                \ SHSI clock enable This bit is set and cleared by software. It is cleared by hardware to stop the SHSI when entering in Stop, Standby, or Shutdown modes.
$00008000 constant RCC_RCC_CR_SHSIRDY                               \ SHSI clock ready flag This bit is set by hardware to indicate that the SHSI oscillator is stable. It is set only when SHSI is enabled by software (by setting SHSION). Note: Once the SHSION bit is cleared, SHSIRDY goes low after six SHSI clock cycles.
$00010000 constant RCC_RCC_CR_HSEON                                 \ HSE clock enable This bit is set and cleared by software. It is cleared by hardware to stop the HSE oscillator when entering Stop, Standby, or Shutdown mode. This bit cannot be reset if the HSE oscillator is used directly or indirectly as the system clock.
$00020000 constant RCC_RCC_CR_HSERDY                                \ HSE clock ready flag This bit is set by hardware to indicate that the HSE oscillator is stable. Note: Once the HSEON bit is cleared, HSERDY goes low after six HSE clock cycles.
$00040000 constant RCC_RCC_CR_HSEBYP                                \ HSE crystal oscillator bypass This bit is set and cleared by software to bypass the oscillator with an external clock. The�external clock must be enabled with the HSEON bit set, to be used by the device. This�bit can be written only if the HSE oscillator is disabled.
$00080000 constant RCC_RCC_CR_CSSON                                 \ Clock security system enable This bit is set by software to enable the clock security system. When CSSON is set, the clock detector is enabled by hardware when the HSE oscillator is ready, and disabled by hardware if a HSE clock failure is detected. This bit is set only and is cleared by reset.
$00100000 constant RCC_RCC_CR_HSEEXT                                \ HSE external clock bypass mode This bit is set and reset by software to select the external clock mode in bypass mode. External clock mode must be configured with HSEON bit to be used by the device. This bit can be written only if the HSE oscillator is disabled. This bit is active only if the HSE bypass mode is enabled.
$01000000 constant RCC_RCC_CR_PLL1ON                                \ PLL1 enable This bit is set and cleared by software to enable the main PLL. It is cleared by hardware when entering Stop, Standby, or Shutdown mode. This bit cannot be reset if the PLL1 clock is used as the system clock.
$02000000 constant RCC_RCC_CR_PLL1RDY                               \ PLL1 clock ready flag This bit is set by hardware to indicate that the PLL1 is locked.
$04000000 constant RCC_RCC_CR_PLL2ON                                \ PLL2 enable This bit is set and cleared by software to enable PLL2. It is cleared by hardware when entering Stop, Standby, or Shutdown mode.
$08000000 constant RCC_RCC_CR_PLL2RDY                               \ PLL2 clock ready flag This bit is set by hardware to indicate that the PLL2 is locked.
$10000000 constant RCC_RCC_CR_PLL3ON                                \ PLL3 enable This bit is set and cleared by software to enable PLL3. It is cleared by hardware when entering Stop, Standby, or Shutdown mode.
$20000000 constant RCC_RCC_CR_PLL3RDY                               \ PLL3 clock ready flag This bit is set by hardware to indicate that the PLL3 is locked.


\
\ @brief RCC internal clock sources calibration register 1
\ Address offset: 0x08
\ Reset value: 0x44000000
\

$0000001f constant RCC_RCC_ICSCR1_MSICAL3                           \ MSIRC3 clock calibration for MSI ranges 12 to 15 These bits are initialized at startup with the factory-programmed MSIRC3 calibration trim value for ranges 12 to 15. When MSITRIM3 is written, MSICAL3 is updated with the sum of MSITRIM3[4:0] and the factory calibration trim value MSIRC2[4:0]. There is no hardware protection to limit a potential overflow due to the addition of MSITRIM bitfield and factory program bitfield for this calibration value. Control must be managed by software at user level.
$000003e0 constant RCC_RCC_ICSCR1_MSICAL2                           \ MSIRC2 clock calibration for MSI ranges 8 to 11 These bits are initialized at startup with the factory-programmed MSIRC2 calibration trim value for ranges 8 to 11. When MSITRIM2 is written, MSICAL2 is updated with the sum of MSITRIM2[4:0] and the factory calibration trim value MSIRC2[4:0]. There is no hardware protection to limit a potential overflow due to the addition of MSITRIM bitfield and factory program bitfield for this calibration value. Control must be managed by software at user level.
$00007c00 constant RCC_RCC_ICSCR1_MSICAL1                           \ MSIRC1 clock calibration for MSI ranges 4 to 7 These bits are initialized at startup with the factory-programmed MSIRC1 calibration trim value for ranges 4 to 7. When MSITRIM1 is written, MSICAL1 is updated with the sum of MSITRIM1[4:0] and the factory calibration trim value MSIRC1[4:0]. There is no hardware protection to limit a potential overflow due to the addition of MSITRIM bitfield and factory program bitfield for this calibration value. Control must be managed by software at user level.
$000f8000 constant RCC_RCC_ICSCR1_MSICAL0                           \ MSIRC0 clock calibration for MSI ranges 0 to 3 These bits are initialized at startup with the factory-programmed MSIRC0 calibration trim value for ranges 0 to 3. When MSITRIM0 is written, MSICAL0 is updated with the sum of MSITRIM0[4:0] and the factory-programmed calibration trim value MSIRC0[4:0]. There is no hardware protection to limit a potential overflow due to the addition of MSITRIM bitfield and factory program bitfield for this calibration value. Control must be managed by software at user level.
$00400000 constant RCC_RCC_ICSCR1_MSIBIAS                           \ MSI bias mode selection This bit is set by software to select the MSI bias mode. By default, the MSI bias is in�continuous mode in order to maintain the output clocks accuracy. Setting this bit reduces the MSI consumption when the regulator is in range 4, or when the device is in Stop 1 or Stop�2 mode, but it�decreases the MSI accuracy
$00800000 constant RCC_RCC_ICSCR1_MSIRGSEL                          \ MSI clock range selection This bit is set by software to select the MSIS and MSIK clocks range with MSISRANGE[3:0] and MSIKRANGE[3:0]. Write 0 has no effect. After exiting Standby or Shutdown mode, or after a reset, this bit is at 0 and the MSIS and MSIK ranges are provided by MSISSRANGE[3:0] and MSIKSRANGE[3:0] in RCC_CSR.
$0f000000 constant RCC_RCC_ICSCR1_MSIKRANGE                         \ MSIK clock ranges These bits are configured by software to choose the frequency range of MSIK oscillator when MSIRGSEL is set. 16 frequency ranges are available: Note: MSIKRANGE can be modified when MSIK is off (MSISON = 0) or when MSIK is ready (MSIKRDY�=�1). MSIKRANGE must NOT be modified when MSIK is on and NOT ready (MSIKON = 1 and MSIKRDY = 0) Note: MSIKRANGE is kept when the device wakes up from Stop mode, except when the�MSIK range is above 24 MHz. In this case MSIKRANGE is changed by hardware into�range 2 (24 MHz).
$f0000000 constant RCC_RCC_ICSCR1_MSISRANGE                         \ MSIS clock ranges These bits are configured by software to choose the frequency range of MSIS oscillator when MSIRGSEL is set. 16 frequency ranges are available: Note: MSISRANGE can be modified when MSIS is off (MSISON = 0) or when MSIS is ready (MSISRDY�=�1). MSISRANGE must NOT be modified when MSIS is on and NOT ready (MSISON�=�1 and MSISRDY�=�0) Note: MSISRANGE is kept when the device wakes up from Stop mode, except when the�MSIS range is above 24 MHz. In this case MSISRANGE is changed by hardware into range 2 (24 MHz).


\
\ @brief RCC internal clock sources calibration register 2
\ Address offset: 0x0C
\ Reset value: 0x00084210
\

$0000001f constant RCC_RCC_ICSCR2_MSITRIM3                          \ MSI clock trimming for ranges 12 to 15 These bits provide an additional user-programmable trimming value that is added to the factory-programmed calibration trim value MSIRC3[4:0] bits. It can be programmed to adjust to voltage and temperature variations that influence the frequency of the MSI.
$000003e0 constant RCC_RCC_ICSCR2_MSITRIM2                          \ MSI clock trimming for ranges 8 to 11 These bits provide an additional user-programmable trimming value that is added to the factory-programmed calibration trim value MSIRC2[4:0] bits. It can be programmed to adjust to voltage and temperature variations that influence the frequency of the MSI.
$00007c00 constant RCC_RCC_ICSCR2_MSITRIM1                          \ MSI clock trimming for ranges 4 to 7 These bits provide an additional user-programmable trimming value that is added to the factory-programmed calibration trim value MSIRC1[4:0] bits. It can be programmed to adjust to voltage and temperature variations that influence the frequency of the MSI.
$000f8000 constant RCC_RCC_ICSCR2_MSITRIM0                          \ MSI clock trimming for ranges 0 to 3 These bits provide an additional user-programmable trimming value that is added to the factory-programmed calibration trim value MSIRC0[4:0] bits. It can be programmed to adjust to voltage and temperature variations that influence the frequency of the MSI.


\
\ @brief RCC internal clock sources calibration register 3
\ Address offset: 0x10
\ Reset value: 0x00100000
\

$00000fff constant RCC_RCC_ICSCR3_HSICAL                            \ HSI clock calibration These bits are initialized at startup with the factory-programmed HSI calibration trim value. When HSITRIM is written, HSICAL is updated with the sum of HSITRIM and the factory trim value.
$001f0000 constant RCC_RCC_ICSCR3_HSITRIM                           \ HSI clock trimming These bits provide an additional user-programmable trimming value that is added to HSICAL[11:0] bits. It can be programmed to adjust to voltage and temperature variations that influence the frequency of the HSI.


\
\ @brief RCC clock recovery RC register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000001ff constant RCC_RCC_CRRCR_HSI48CAL                           \ HSI48 clock calibration These bits are initialized at startup with the factory-programmed HSI48 calibration trim value.


\
\ @brief RCC clock configuration register 1
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_CFGR1_SW                                 \ system clock switch This bitfield is set and cleared by software to select system clock source (SYSCLK). It is configured by hardware to force MSIS oscillator selection when exiting Standby or Shutdown mode. This bitfield is configured by hardware to force MSIS or HSI16 oscillator selection when exiting Stop mode or in case of HSE oscillator failure, depending on STOPWUCK.
$0000000c constant RCC_RCC_CFGR1_SWS                                \ system clock switch status This bitfield is set and cleared by hardware to indicate which clock source is used as system clock.
$00000010 constant RCC_RCC_CFGR1_STOPWUCK                           \ wake-up from Stop and CSS backup clock selection This bit is set and cleared by software to select the system clock used when exiting Stop mode. The selected clock is also used as emergency clock for the clock security system on�HSE. STOPWUCK must not be modified when the CSS is enabled by HSECSSON in�RCC_CR, and the system clock is HSE (SWS = 10) or a switch on HSE is�requested (SW�=�10).
$00000020 constant RCC_RCC_CFGR1_STOPKERWUCK                        \ wake-up from Stop kernel clock automatic enable selection This bit is set and cleared by software to enable automatically another oscillator when exiting Stop mode. This oscillator can be used as independent kernel clock by peripherals.
$0f000000 constant RCC_RCC_CFGR1_MCOSEL                             \ microcontroller clock output This bitfield is set and cleared by software. Others: reserved Note: This clock output may have some truncated cycles at startup or during MCO clock source switching.
$70000000 constant RCC_RCC_CFGR1_MCOPRE                             \ microcontroller clock output prescaler This bitfield is set and cleared by software. It is highly recommended to change this prescaler before MCO output is enabled. Others: not allowed


\
\ @brief RCC clock configuration register 2
\ Address offset: 0x20
\ Reset value: 0x00006000
\

$0000000f constant RCC_RCC_CFGR2_HPRE                               \ AHB prescaler This bitfiled is set and cleared by software to control the division factor of the AHB clock (HCLK). Depending on the device voltage range, the software must set these bits correctly to ensure that the system frequency does not exceed the maximum allowed frequency (for more details, refer to Table�118). After a write operation to these bits and before decreasing the voltage range, this register must be read to be sure that the new value is taken into account. 0xxx: SYSCLK not divided
$00000070 constant RCC_RCC_CFGR2_PPRE1                              \ APB1 prescaler This bitfiled is set and cleared by software to control the division factor of APB1 clock (PCLK1). 0xx: PCLK1 not divided
$00000700 constant RCC_RCC_CFGR2_PPRE2                              \ APB2 prescaler This bitfiled is set and cleared by software to control the division factor of APB2 clock (PCLK2). 0xx: PCLK2 not divided
$00007000 constant RCC_RCC_CFGR2_DPRE                               \ DSI PHY prescaler This bitfiled is set and cleared by software to control the division factor of DSI PHY bus clock (DCLK). 0xx: DCLK not divided Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
$00010000 constant RCC_RCC_CFGR2_AHB1DIS                            \ AHB1 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB1 peripherals (except those listed hereafter) are used and when their clocks are disabled in RCC_AHB1ENR. When this bit is set, all the AHB1 peripherals clocks are off, except for FLASH, BKPSRAM, ICACHE, DCACHE1 and SRAM1.
$00020000 constant RCC_RCC_CFGR2_AHB2DIS1                           \ AHB2_1 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB2 peripherals from RCC_AHB2ENR1 (except SRAM2 and SRAM3) are used and when their clocks are disabled in RCC_AHB2ENR1. When this bit is set, all the AHB2 peripherals clocks from RCC_AHB2ENR1 are off, except for SRAM2 and SRAM3.
$00040000 constant RCC_RCC_CFGR2_AHB2DIS2                           \ AHB2_2 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB2 peripherals from RCC_AHB2ENR2 are used and when their clocks are disabled in RCC_AHB2ENR2. When this bit is set, all the AHB2 peripherals clocks from RCC_AHB2ENR2 are off.
$00080000 constant RCC_RCC_CFGR2_APB1DIS                            \ APB1 clock disable This bit can be set in order to further reduce power consumption, when none of the APB1 peripherals (except IWDG) are used and when their clocks are disabled in RCC_APB1ENR. When this bit is set, all the APB1 peripherals clocks are off, except for IWDG.
$00100000 constant RCC_RCC_CFGR2_APB2DIS                            \ APB2 clock disable This bit can be set in order to further reduce power consumption, when none of the APB2 peripherals are used and when their clocks are disabled in RCC_APB2ENR. When this bit is set, all APB2 peripherals clocks are off.


\
\ @brief RCC clock configuration register 3
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000070 constant RCC_RCC_CFGR3_PPRE3                              \ APB3 prescaler This bitfield is set and cleared by software to control the division factor of the APB3 clock (PCLK3). 0xx: HCLK not divided
$00010000 constant RCC_RCC_CFGR3_AHB3DIS                            \ AHB3 clock disable This bit can be set in order to further reduce power consumption, when none of the AHB3 peripherals (except SRAM4) are used and when their clocks are disabled in RCC_AHB3ENR. When this bit is set, all the AHB3 peripherals clocks are off, except for SRAM4.
$00020000 constant RCC_RCC_CFGR3_APB3DIS                            \ APB3 clock disable This bit can be set in order to further reduce power consumption, when none of the APB3 peripherals from RCC_APB3ENR are used and when their clocks are disabled in RCC_APB3ENR. When this bit is set, all the APB3 peripherals clocks are off.


\
\ @brief RCC PLL1 configuration register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_PLL1CFGR_PLL1SRC                         \ PLL1 entry clock source This bitfield is set and cleared by software to select PLL1 clock source. It can be written only when the PLL1 is disabled. In order to save power, when no PLL1 is used, this bitfield value must be zero.
$0000000c constant RCC_RCC_PLL1CFGR_PLL1RGE                         \ PLL1 input frequency range This bit is set and reset by software to select the proper reference frequency range used for PLL1. It must be written before enabling the PLL1. 00-01-10: PLL1 input (ref1_ck) clock range frequency between 4 and 8 MHz
$00000010 constant RCC_RCC_PLL1CFGR_PLL1FRACEN                      \ PLL1 fractional latch enable This bit is set and reset by software to latch the content of PLL1FRACN in the ΣΔ modulator. In order to latch the PLL1FRACN value into the ΣΔ modulator, PLL1FRACEN must be set to 0, then set to 1: the transition 0 to 1 transfers the content of PLL1FRACN into the modulator (see PLL initialization phase for details).
$00000f00 constant RCC_RCC_PLL1CFGR_PLL1M                           \ Prescaler for PLL1 This bitfield is set and cleared by software to configure the prescaler of the PLL1. The VCO1 input frequency is PLL1 input clock frequency/PLL1M. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
$0000f000 constant RCC_RCC_PLL1CFGR_PLL1MBOOST                      \ Prescaler for EPOD booster input clock This bitfield is set and cleared by software to configure the prescaler of the PLL1, used for the EPOD booster. The EPOD booster input frequency is PLL1�input�clock�frequency/PLL1MBOOST. This bit can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0) and EPODboost mode is disabled (see Section�10: Power control (PWR)). others: reserved
$00010000 constant RCC_RCC_PLL1CFGR_PLL1PEN                         \ PLL1 DIVP divider output enable This bit is set and reset by software to enable the pll1_p_ck output of the PLL1. To save power, PLL1PEN and PLL1P bits must be set to 0 when pll1_p_ck is not used.
$00020000 constant RCC_RCC_PLL1CFGR_PLL1QEN                         \ PLL1 DIVQ divider output enable This bit is set and reset by software to enable the pll1_q_ck output of the PLL1. To save power, PLL1QEN and PLL1Q bits must be set to 0 when pll1_q_ck is not used.
$00040000 constant RCC_RCC_PLL1CFGR_PLL1REN                         \ PLL1 DIVR divider output enable This bit is set and reset by software to enable the pll1_r_ck output of the PLL1. To save power, PLL1RENPLL2REN and PLL1R bits must be set to 0 when pll1_r_ck is not used. This bit can be cleared only when the PLL1 is not used as SYSCLK.


\
\ @brief RCC PLL2 configuration register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_PLL2CFGR_PLL2SRC                         \ PLL2 entry clock source This bitfield is set and cleared by software to select PLL2 clock source. It can be written only when the PLL2 is disabled. To save power, when no PLL2 is used, this bitfield value must be�zero.
$0000000c constant RCC_RCC_PLL2CFGR_PLL2RGE                         \ PLL2 input frequency range This bitfield is set and reset by software to select the proper reference frequency range used for�PLL2. It must be written before enabling the PLL2. 00-01-10: PLL2 input (ref2_ck) clock range frequency between 4 and 8 MHz
$00000010 constant RCC_RCC_PLL2CFGR_PLL2FRACEN                      \ PLL2 fractional latch enable This bit is set and reset by software to latch the content of PLL2FRACN in the ΣΔ modulator. In order to latch the PLL2FRACN value into the ΣΔ modulator, PLL2FRACEN must be set to 0, then set to 1: the transition 0 to 1 transfers the content of PLL2FRACN into the modulator (see PLL initialization phase for details).
$00000f00 constant RCC_RCC_PLL2CFGR_PLL2M                           \ Prescaler for PLL2 This bitfield is set and cleared by software to configure the prescaler of the PLL2. The VCO2 input frequency is PLL2 input clock frequency/PLL2M. This bit can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...
$00010000 constant RCC_RCC_PLL2CFGR_PLL2PEN                         \ PLL2 DIVP divider output enable This bit is set and reset by software to enable the pll2_p_ck output of the PLL2. To save power, PLL2PEN and PLL2P bits must be set to 0 when pll2_p_ck is not used.
$00020000 constant RCC_RCC_PLL2CFGR_PLL2QEN                         \ PLL2 DIVQ divider output enable This bit is set and reset by software to enable the pll2_q_ck output of the PLL2. To save power, PLL2QEN and PLL2Q bits must be set to 0 when pll2_q_ck is not used.
$00040000 constant RCC_RCC_PLL2CFGR_PLL2REN                         \ PLL2 DIVR divider output enable This bit is set and reset by software to enable the pll2_r_ck output of the PLL2. To save power, PLL2REN and PLL2R bits must be set to 0 when pll2_r_ck is not used.


\
\ @brief RCC PLL3 configuration register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_PLL3CFGR_PLL3SRC                         \ PLL3 entry clock source This bitfield is set and cleared by software to select PLL3 clock source. It can be written only when the PLL3 is disabled. To save power, when no PLL3 is used, this bitfield value must be�zero.
$0000000c constant RCC_RCC_PLL3CFGR_PLL3RGE                         \ PLL3 input frequency range This bit is set and reset by software to select the proper reference frequency range used for�PLL3. It must be written before enabling the PLL3. 00-01-10: PLL3 input (ref3_ck) clock range frequency between 4 and 8 MHz
$00000010 constant RCC_RCC_PLL3CFGR_PLL3FRACEN                      \ PLL3 fractional latch enable This bit is set and reset by software to latch the content of PLL3FRACN in the ΣΔ modulator. In order to latch the PLL3FRACN value into the ΣΔ modulator, PLL3FRACEN must be set to 0, then set to 1: the transition 0 to 1 transfers the content of PLL3FRACN into the modulator (see PLL initialization phase for details).
$00000f00 constant RCC_RCC_PLL3CFGR_PLL3M                           \ Prescaler for PLL3 This bitfield is set and cleared by software to configure the prescaler of the PLL3. The VCO3 input frequency is PLL3 input clock frequency/PLL3M. This bitfield can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0). ...
$00010000 constant RCC_RCC_PLL3CFGR_PLL3PEN                         \ PLL3 DIVP divider output enable This bit is set and reset by software to enable the pll3_p_ck output of the PLL3. To save power, PLL3PEN and PLL3P bits must be set to 0 when pll3_p_ck is not used.
$00020000 constant RCC_RCC_PLL3CFGR_PLL3QEN                         \ PLL3 DIVQ divider output enable This bit is set and reset by software to enable the pll3_q_ck output of the PLL3. To save power, PLL3QEN and PLL3Q bits must be set to 0 when pll3_q_ck is not used.
$00040000 constant RCC_RCC_PLL3CFGR_PLL3REN                         \ PLL3 DIVR divider output enable This bit is set and reset by software to enable the pll3_r_ck output of the PLL3. To save power, PLL3REN and PLL3R bits must be set to 0 when pll3_r_ck is not used.


\
\ @brief RCC PLL1 dividers register
\ Address offset: 0x34
\ Reset value: 0x01010280
\

$000001ff constant RCC_RCC_PLL1DIVR_PLL1N                           \ Multiplication factor for PLL1 VCO This bitfield is set and reset by software to control the multiplication factor of the VCO. It can be written only when the PLL is disabled (PLL1ON = 0 and PLL1RDY = 0). ... ... Others: reserved VCO output frequency = F<sub>ref1_ck</sub> x PLL1N, when fractional value 0 has been loaded in PLL1FRACN, with: PLL1N between 4 and 512 input frequency F<sub>ref1_ck</sub> between 4 and 16�MHz
$0000fe00 constant RCC_RCC_PLL1DIVR_PLL1P                           \ PLL1 DIVP division factor This bitfield is set and reset by software to control the frequency of the pll1_p_ck clock. It can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
$007f0000 constant RCC_RCC_PLL1DIVR_PLL1Q                           \ PLL1 DIVQ division factor This bitfield is set and reset by software to control the frequency of the pll1_q_ck clock. It can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). ...
$7f000000 constant RCC_RCC_PLL1DIVR_PLL1R                           \ PLL1 DIVR division factor This bitfield is set and reset by software to control frequency of the pll1_r_ck clock. It can be written only when the PLL1 is disabled (PLL1ON = 0 and PLL1RDY = 0). Only division by one and even division factors are allowed. ...


\
\ @brief RCC PLL1 fractional divider register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL1FRACR_PLL1FRACN                      \ Fractional part of the multiplication factor for PLL1 VCO This bitfield is set and reset by software to control the fractional part of the VCO multiplication factor. It can be written at any time, allowing dynamic fine-tuning of the PLL1 VCO. VCO output frequency = F<sub>ref1_ck</sub> x (PLL1N + (PLL1FRACN / 2<sup>13</sup>)), with: PLL1N must be between 4 and 512. PLL1FRACN can be between 0 and 2<sup>13</sup>- 1. The input frequency F<sub>ref1_ck</sub> must be between 4 and 16 MHz. To change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as�follows: Set PLL1FRACEN = 0. Write the new fractional value into PLL1FRACN. Set PLL1FRACEN = 1.


\
\ @brief RCC PLL2 dividers configuration register
\ Address offset: 0x3C
\ Reset value: 0x01010280
\

$000001ff constant RCC_RCC_PLL2DIVR_PLL2N                           \ Multiplication factor for PLL2 VCO This bitfield is set and reset by software to control the multiplication factor of the VCO. It can be written only when the PLL is disabled (PLL2ON = 0 and PLL2RDY = 0). ... ... Others: reserved VCO output frequency = F<sub>ref2_ck</sub> x PLL2N, when fractional value 0 has been loaded in PLL2FRACN, with: PLL2N between 4 and 512 input frequency F<sub>ref2_ck</sub> between 1MHz and 16MHz
$0000fe00 constant RCC_RCC_PLL2DIVR_PLL2P                           \ PLL2 DIVP division factor This bitfield is set and reset by software to control the frequency of the pll2_p_ck clock. It can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...
$007f0000 constant RCC_RCC_PLL2DIVR_PLL2Q                           \ PLL2 DIVQ division factor This bitfield is set and reset by software to control the frequency of the pll2_q_ck clock. It can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...
$7f000000 constant RCC_RCC_PLL2DIVR_PLL2R                           \ PLL2 DIVR division factor This bitfield is set and reset by software to control the frequency of the pll2_r_ck clock. It can be written only when the PLL2 is disabled (PLL2ON = 0 and PLL2RDY = 0). ...


\
\ @brief RCC PLL2 fractional divider register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL2FRACR_PLL2FRACN                      \ Fractional part of the multiplication factor for PLL2 VCO This bitfield is set and reset by software to control the fractional part of the VCO multiplication factor. It can be written at any time, allowing dynamic fine-tuning of the PLL2 VCO. VCO output frequency = F<sub>ref2_ck</sub> x (PLL2N + (PLL2FRACN / 2<sup>13</sup>)), with PLL2N must be between 4 and 512. PLL2FRACN can be between 0 and 2<sup>13 </sup>- 1. The input frequency F<sub>ref2_ck</sub> must be between 4 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL2FRACEN to 0. Write the new fractional value into PLL2FRACN. Set the bit PLL2FRACEN to 1.


\
\ @brief RCC PLL3 dividers configuration register
\ Address offset: 0x44
\ Reset value: 0x01010280
\

$000001ff constant RCC_RCC_PLL3DIVR_PLL3N                           \ Multiplication factor for PLL3 VCO This bitfield is set and reset by software to control the multiplication factor of the VCO. It can be written only when the PLL is disabled (PLL3ON = 0 and PLL3RDY = 0). ... ... Others: reserved VCO output frequency = F<sub>ref3_ck</sub> x PLL3N, when fractional value 0 has been loaded in PLL3FRACN, with: PLL3N between 4 and 512 input frequency F<sub>ref3_ck</sub> between 4 and 16MHz
$0000fe00 constant RCC_RCC_PLL3DIVR_PLL3P                           \ PLL3 DIVP division factor This bitfield is set and reset by software to control the frequency of the pll3_p_ck clock. It can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0). ...
$007f0000 constant RCC_RCC_PLL3DIVR_PLL3Q                           \ PLL3 DIVQ division factor This bitfield is set and reset by software to control the frequency of the pll3_q_ck clock. It can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0). ...
$7f000000 constant RCC_RCC_PLL3DIVR_PLL3R                           \ PLL3 DIVR division factor This bitfield is set and reset by software to control the frequency of the pll3_r_ck clock. It can be written only when the PLL3 is disabled (PLL3ON = 0 and PLL3RDY = 0). ...


\
\ @brief RCC PLL3 fractional divider register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_RCC_PLL3FRACR_PLL3FRACN                      \ Fractional part of the multiplication factor for PLL3 VCO This bitfield is set and reset by software to control the fractional part of the VCO multiplication factor. It can be written at any time, allowing dynamic fine-tuning of the PLL3 VCO. VCO output frequency = F<sub>ref3_ck</sub> x (PLL3N + (PLL3FRACN / 2<sup>13</sup>)), with: PLL3N must be between 4 and 512. PLL3FRACN can be between 0 and 2<sup>13 </sup>- 1. The input frequency F<sub>ref3_ck</sub> must be between 4 and 16 MHz. In order to change the FRACN value on-the-fly even if the PLL is enabled, the application must proceed as follows: Set the bit PLL3FRACEN to 0. Write the new fractional value into PLL3FRACN. Set the bit PLL3FRACEN to 1.


\
\ @brief RCC clock interrupt enable register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CIER_LSIRDYIE                            \ LSI ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the LSI oscillator stabilization.
$00000002 constant RCC_RCC_CIER_LSERDYIE                            \ LSE ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the LSE oscillator stabilization.
$00000004 constant RCC_RCC_CIER_MSISRDYIE                           \ MSIS ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the MSIS oscillator stabilization.
$00000008 constant RCC_RCC_CIER_HSIRDYIE                            \ HSI16 ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the HSI16 oscillator stabilization.
$00000010 constant RCC_RCC_CIER_HSERDYIE                            \ HSE ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the HSE oscillator stabilization.
$00000020 constant RCC_RCC_CIER_HSI48RDYIE                          \ HSI48 ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the HSI48 oscillator stabilization.
$00000040 constant RCC_RCC_CIER_PLL1RDYIE                           \ PLL ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by PLL1 lock.
$00000080 constant RCC_RCC_CIER_PLL2RDYIE                           \ PLL2 ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by PLL2 lock.
$00000100 constant RCC_RCC_CIER_PLL3RDYIE                           \ PLL3 ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by PLL3 lock.
$00000800 constant RCC_RCC_CIER_MSIKRDYIE                           \ MSIK ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the MSIK oscillator stabilization.
$00001000 constant RCC_RCC_CIER_SHSIRDYIE                           \ SHSI ready interrupt enable This bit is set and cleared by software to enable/disable interrupt caused by the SHSI oscillator stabilization.


\
\ @brief RCC clock interrupt flag register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CIFR_LSIRDYF                             \ LSI ready interrupt flag This bit is set by hardware when the LSI clock becomes stable and LSIRDYIE is set. It is cleared by software by�setting the LSIRDYC bit.
$00000002 constant RCC_RCC_CIFR_LSERDYF                             \ LSE ready interrupt flag This bit is set by hardware when the LSE clock becomes stable and LSERDYIE is set. It is cleared by software by setting the LSERDYC bit.
$00000004 constant RCC_RCC_CIFR_MSISRDYF                            \ MSIS ready interrupt flag This bit is set by hardware when the MSIS clock becomes stable and MSISRDYIE is set. It�is cleared by software by setting the MSISRDYC bit.
$00000008 constant RCC_RCC_CIFR_HSIRDYF                             \ HSI16 ready interrupt flag This bit is set by hardware when the HSI16 clock becomes stable and HSIRDYIE = 1 in�response to setting the HSION (see RCC_CR). When HSION = 0 but the HSI16 oscillator is enabled by the peripheral through a clock request, this bit is not set and no interrupt is generated. This bit is cleared by software by setting the HSIRDYC bit.
$00000010 constant RCC_RCC_CIFR_HSERDYF                             \ HSE ready interrupt flag This bit is set by hardware when the HSE clock becomes stable and HSERDYIE is set. It is cleared by software by setting the HSERDYC bit.
$00000020 constant RCC_RCC_CIFR_HSI48RDYF                           \ HSI48 ready interrupt flag This bit is set by hardware when the HSI48 clock becomes stable and HSI48RDYIE is set. it�is cleared by software by setting the HSI48RDYC bit.
$00000040 constant RCC_RCC_CIFR_PLL1RDYF                            \ PLL1 ready interrupt flag This bit is set by hardware when the PLL1 locks and PLL1RDYIE is set. It is cleared by software by setting the PLL1RDYC bit.
$00000080 constant RCC_RCC_CIFR_PLL2RDYF                            \ PLL2 ready interrupt flag This bit is set by hardware when the PLL2 locks and PLL2RDYIE is set. It is cleared by software by setting the PLL2RDYC bit.
$00000100 constant RCC_RCC_CIFR_PLL3RDYF                            \ PLL3 ready interrupt flag This bit is set by hardware when the PLL3 locks and PLL3RDYIE is set. It is cleared by software by setting the PLL3RDYC bit.
$00000400 constant RCC_RCC_CIFR_CSSF                                \ Clock security system interrupt flag This bit is set by hardware when a failure is detected in the HSE oscillator. It is cleared by software by setting the CSSC bit.
$00000800 constant RCC_RCC_CIFR_MSIKRDYF                            \ MSIK ready interrupt flag This bit is set by hardware when the MSIK clock becomes stable and MSIKRDYIE is set. It is cleared by software by setting the MSIKRDYC bit.
$00001000 constant RCC_RCC_CIFR_SHSIRDYF                            \ SHSI ready interrupt flag This bit is set by hardware when the SHSI clock becomes stable and SHSIRDYIE is set. It is cleared by software by setting the SHSIRDYC bit.


\
\ @brief RCC clock interrupt clear register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CICR_LSIRDYC                             \ LSI ready interrupt clear Writing this bit to 1 clears the LSIRDYF flag. Writing 0 has no effect.
$00000002 constant RCC_RCC_CICR_LSERDYC                             \ LSE ready interrupt clear Writing this bit to 1 clears the LSERDYF flag. Writing 0 has no effect.
$00000004 constant RCC_RCC_CICR_MSISRDYC                            \ MSIS ready interrupt clear Writing this bit to 1 clears the MSISRDYF flag. Writing 0 has no effect.
$00000008 constant RCC_RCC_CICR_HSIRDYC                             \ HSI16 ready interrupt clear Writing this bit to 1 clears the HSIRDYF flag. Writing 0 has no effect.
$00000010 constant RCC_RCC_CICR_HSERDYC                             \ HSE ready interrupt clear Writing this bit to 1 clears the HSERDYF flag. Writing 0 has no effect.
$00000020 constant RCC_RCC_CICR_HSI48RDYC                           \ HSI48 ready interrupt clear Writing this bit to 1 clears the HSI48RDYF flag. Writing 0 has no effect.
$00000040 constant RCC_RCC_CICR_PLL1RDYC                            \ PLL1 ready interrupt clear Writing this bit to 1 clears the PLL1RDYF flag. Writing 0 has no effect.
$00000080 constant RCC_RCC_CICR_PLL2RDYC                            \ PLL2 ready interrupt clear Writing this bit to 1 clears the PLL2RDYF flag. Writing 0 has no effect.
$00000100 constant RCC_RCC_CICR_PLL3RDYC                            \ PLL3 ready interrupt clear Writing this bit to 1 clears the PLL3RDYF flag. Writing 0 has no effect.
$00000400 constant RCC_RCC_CICR_CSSC                                \ Clock security system interrupt clear Writing this bit to 1 clears the CSSF flag. Writing 0 has no effect.
$00000800 constant RCC_RCC_CICR_MSIKRDYC                            \ MSIK oscillator ready interrupt clear Writing this bit to 1 clears the MSIKRDYF flag. Writing 0 has no effect.
$00001000 constant RCC_RCC_CICR_SHSIRDYC                            \ SHSI oscillator ready interrupt clear Writing this bit to 1 clears the SHSIRDYF flag. Writing 0 has no effect.


\
\ @brief RCC AHB1 peripheral reset register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB1RSTR_GPDMA1RST                       \ GPDMA1 reset This bit is set and cleared by software.
$00000002 constant RCC_RCC_AHB1RSTR_CORDICRST                       \ CORDIC reset This bit is set and cleared by software.
$00000004 constant RCC_RCC_AHB1RSTR_FMACRST                         \ FMAC reset This bit is set and cleared by software.
$00000008 constant RCC_RCC_AHB1RSTR_MDF1RST                         \ MDF1 reset This bit is set and cleared by software.
$00001000 constant RCC_RCC_AHB1RSTR_CRCRST                          \ CRC reset This bit is set and cleared by software.
$00008000 constant RCC_RCC_AHB1RSTR_JPEGRST                         \ JPEG reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00010000 constant RCC_RCC_AHB1RSTR_TSCRST                          \ TSC reset This bit is set and cleared by software.
$00020000 constant RCC_RCC_AHB1RSTR_RAMCFGRST                       \ RAMCFG reset This bit is set and cleared by software.
$00040000 constant RCC_RCC_AHB1RSTR_DMA2DRST                        \ DMA2D reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00080000 constant RCC_RCC_AHB1RSTR_GFXMMURST                       \ GFXMMU reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00100000 constant RCC_RCC_AHB1RSTR_GPU2DRST                        \ GPU2D reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC AHB2 peripheral reset register 1
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB2RSTR1_GPIOARST                       \ I/O port A reset This bit is set and cleared by software.
$00000002 constant RCC_RCC_AHB2RSTR1_GPIOBRST                       \ I/O port B reset This bit is set and cleared by software.
$00000004 constant RCC_RCC_AHB2RSTR1_GPIOCRST                       \ I/O port C reset This bit is set and cleared by software.
$00000008 constant RCC_RCC_AHB2RSTR1_GPIODRST                       \ I/O port D reset This bit is set and cleared by software.
$00000010 constant RCC_RCC_AHB2RSTR1_GPIOERST                       \ I/O port E reset This bit is set and cleared by software.
$00000020 constant RCC_RCC_AHB2RSTR1_GPIOFRST                       \ I/O port F reset This bit is set and cleared by software. This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. Note: If not present, consider this bit as reserved and keep it at reset value.
$00000040 constant RCC_RCC_AHB2RSTR1_GPIOGRST                       \ I/O port G reset This bit is set and cleared by software.
$00000080 constant RCC_RCC_AHB2RSTR1_GPIOHRST                       \ I/O port H reset This bit is set and cleared by software.
$00000100 constant RCC_RCC_AHB2RSTR1_GPIOIRST                       \ I/O port I reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000200 constant RCC_RCC_AHB2RSTR1_GPIOJRST                       \ I/O port J reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000400 constant RCC_RCC_AHB2RSTR1_ADC12RST                       \ ADC1 and ADC2 reset This bit is set and cleared by software. Note: This bit impacts ADC1 in STM32U535/545/575/585, and ADC1/ADC2 in�STM32U59x/5Ax/5Fx/5Gx.
$00001000 constant RCC_RCC_AHB2RSTR1_DCMI_PSSIRST                   \ DCMI and PSSI reset This bit is set and cleared by software.
$00004000 constant RCC_RCC_AHB2RSTR1_OTGRST                         \ OTG_FS or OTG_HS reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00010000 constant RCC_RCC_AHB2RSTR1_AESRST                         \ AES hardware accelerator reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00020000 constant RCC_RCC_AHB2RSTR1_HASHRST                        \ HASH reset This bit is set and cleared by software.
$00040000 constant RCC_RCC_AHB2RSTR1_RNGRST                         \ RNG reset This bit is set and cleared by software.
$00080000 constant RCC_RCC_AHB2RSTR1_PKARST                         \ PKA reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00100000 constant RCC_RCC_AHB2RSTR1_SAESRST                        \ SAES hardware accelerator reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00200000 constant RCC_RCC_AHB2RSTR1_OCTOSPIMRST                    \ OCTOSPIM reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00800000 constant RCC_RCC_AHB2RSTR1_OTFDEC1RST                     \ OTFDEC1 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$01000000 constant RCC_RCC_AHB2RSTR1_OTFDEC2RST                     \ OTFDEC2 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$08000000 constant RCC_RCC_AHB2RSTR1_SDMMC1RST                      \ SDMMC1 reset This bit is set and cleared by software.
$10000000 constant RCC_RCC_AHB2RSTR1_SDMMC2RST                      \ SDMMC2 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC AHB2 peripheral reset register 2
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB2RSTR2_FSMCRST                        \ Flexible memory controller reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000010 constant RCC_RCC_AHB2RSTR2_OCTOSPI1RST                    \ OCTOSPI1 reset This bit is set and cleared by software.
$00000100 constant RCC_RCC_AHB2RSTR2_OCTOSPI2RST                    \ OCTOSPI2 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00001000 constant RCC_RCC_AHB2RSTR2_HSPI1RST                       \ HSPI1 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC AHB3 peripheral reset register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB3RSTR_LPGPIO1RST                      \ LPGPIO1 reset This bit is set and cleared by software.
$00000020 constant RCC_RCC_AHB3RSTR_ADC4RST                         \ ADC4 reset This bit is set and cleared by software.
$00000040 constant RCC_RCC_AHB3RSTR_DAC1RST                         \ DAC1 reset This bit is set and cleared by software.
$00000200 constant RCC_RCC_AHB3RSTR_LPDMA1RST                       \ LPDMA1 reset This bit is set and cleared by software.
$00000400 constant RCC_RCC_AHB3RSTR_ADF1RST                         \ ADF1 reset This bit is set and cleared by software.


\
\ @brief RCC APB1 peripheral reset register 1
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1RSTR1_TIM2RST                        \ TIM2 reset This bit is set and cleared by software.
$00000002 constant RCC_RCC_APB1RSTR1_TIM3RST                        \ TIM3 reset This bit is set and cleared by software.
$00000004 constant RCC_RCC_APB1RSTR1_TIM4RST                        \ TIM4 reset This bit is set and cleared by software.
$00000008 constant RCC_RCC_APB1RSTR1_TIM5RST                        \ TIM5 reset This bit is set and cleared by software.
$00000010 constant RCC_RCC_APB1RSTR1_TIM6RST                        \ TIM6 reset This bit is set and cleared by software.
$00000020 constant RCC_RCC_APB1RSTR1_TIM7RST                        \ TIM7 reset This bit is set and cleared by software.
$00004000 constant RCC_RCC_APB1RSTR1_SPI2RST                        \ SPI2 reset This bit is set and cleared by software.
$00020000 constant RCC_RCC_APB1RSTR1_USART2RST                      \ USART2 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series.Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00040000 constant RCC_RCC_APB1RSTR1_USART3RST                      \ USART3 reset This bit is set and cleared by software.
$00080000 constant RCC_RCC_APB1RSTR1_UART4RST                       \ UART4 reset This bit is set and cleared by software.
$00100000 constant RCC_RCC_APB1RSTR1_UART5RST                       \ UART5 reset This bit is set and cleared by software.
$00200000 constant RCC_RCC_APB1RSTR1_I2C1RST                        \ I2C1 reset This bit is set and cleared by software.
$00400000 constant RCC_RCC_APB1RSTR1_I2C2RST                        \ I2C2 reset This bit is set and cleared by software.
$01000000 constant RCC_RCC_APB1RSTR1_CRSRST                         \ CRS reset This bit is set and cleared by software.
$02000000 constant RCC_RCC_APB1RSTR1_USART6RST                      \ USART6 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC APB1 peripheral reset register 2
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB1RSTR2_I2C4RST                        \ I2C4 reset This bit is set and cleared by software
$00000020 constant RCC_RCC_APB1RSTR2_LPTIM2RST                      \ LPTIM2 reset This bit is set and cleared by software.
$00000040 constant RCC_RCC_APB1RSTR2_I2C5RST                        \ I2C5 reset This bit is set and cleared by software Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000080 constant RCC_RCC_APB1RSTR2_I2C6RST                        \ I2C6 reset This bit is set and cleared by software Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000200 constant RCC_RCC_APB1RSTR2_FDCAN1RST                      \ FDCAN1 reset This bit is set and cleared by software.
$00800000 constant RCC_RCC_APB1RSTR2_UCPD1RST                       \ UCPD1 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC APB2 peripheral reset register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000800 constant RCC_RCC_APB2RSTR_TIM1RST                         \ TIM1 reset This bit is set and cleared by software.
$00001000 constant RCC_RCC_APB2RSTR_SPI1RST                         \ SPI1 reset This bit is set and cleared by software.
$00002000 constant RCC_RCC_APB2RSTR_TIM8RST                         \ TIM8 reset This bit is set and cleared by software.
$00004000 constant RCC_RCC_APB2RSTR_USART1RST                       \ USART1 reset This bit is set and cleared by software.
$00010000 constant RCC_RCC_APB2RSTR_TIM15RST                        \ TIM15 reset This bit is set and cleared by software.
$00020000 constant RCC_RCC_APB2RSTR_TIM16RST                        \ TIM16 reset This bit is set and cleared by software.
$00040000 constant RCC_RCC_APB2RSTR_TIM17RST                        \ TIM17 reset This bit is set and cleared by software.
$00200000 constant RCC_RCC_APB2RSTR_SAI1RST                         \ SAI1 reset This bit is set and cleared by software.
$00400000 constant RCC_RCC_APB2RSTR_SAI2RST                         \ SAI2 reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$01000000 constant RCC_RCC_APB2RSTR_USBRST                          \ USB reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$02000000 constant RCC_RCC_APB2RSTR_GFXTIMRST                       \ GFXTIM reset This bit is set and cleared by software. Note: .This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$04000000 constant RCC_RCC_APB2RSTR_LTDCRST                         \ LTDC reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$08000000 constant RCC_RCC_APB2RSTR_DSIRST                          \ DSI reset This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC APB3 peripheral reset register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB3RSTR_SYSCFGRST                       \ SYSCFG reset This bit is set and cleared by software.
$00000020 constant RCC_RCC_APB3RSTR_SPI3RST                         \ SPI3 reset This bit is set and cleared by software.
$00000040 constant RCC_RCC_APB3RSTR_LPUART1RST                      \ LPUART1 reset This bit is set and cleared by software.
$00000080 constant RCC_RCC_APB3RSTR_I2C3RST                         \ I2C3 reset This bit is set and cleared by software.
$00000800 constant RCC_RCC_APB3RSTR_LPTIM1RST                       \ LPTIM1 reset This bit is set and cleared by software.
$00001000 constant RCC_RCC_APB3RSTR_LPTIM3RST                       \ LPTIM3 reset This bit is set and cleared by software.
$00002000 constant RCC_RCC_APB3RSTR_LPTIM4RST                       \ LPTIM4 reset This bit is set and cleared by software.
$00004000 constant RCC_RCC_APB3RSTR_OPAMPRST                        \ OPAMP reset This bit is set and cleared by software.
$00008000 constant RCC_RCC_APB3RSTR_COMPRST                         \ COMP reset This bit is set and cleared by software.
$00100000 constant RCC_RCC_APB3RSTR_VREFRST                         \ VREFBUF reset This bit is set and cleared by software.


\
\ @brief RCC AHB1 peripheral clock enable register
\ Address offset: 0x88
\ Reset value: 0xD0200100
\

$00000001 constant RCC_RCC_AHB1ENR_GPDMA1EN                         \ GPDMA1 clock enable This bit is set and cleared by software.
$00000002 constant RCC_RCC_AHB1ENR_CORDICEN                         \ CORDIC clock enable This bit is set and cleared by software.
$00000004 constant RCC_RCC_AHB1ENR_FMACEN                           \ FMAC clock enable This bit is set and reset by software.
$00000008 constant RCC_RCC_AHB1ENR_MDF1EN                           \ MDF1 clock enable This bit is set and reset by software.
$00000100 constant RCC_RCC_AHB1ENR_FLASHEN                          \ FLASH clock enable This bit is set and cleared by software. This bit can be disabled only when the flash memory is in power-down mode.
$00001000 constant RCC_RCC_AHB1ENR_CRCEN                            \ CRC clock enable This bit is set and cleared by software.
$00008000 constant RCC_RCC_AHB1ENR_JPEGEN                           \ JPEG clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00010000 constant RCC_RCC_AHB1ENR_TSCEN                            \ Touch sensing controller clock enable This bit is set and cleared by software.
$00020000 constant RCC_RCC_AHB1ENR_RAMCFGEN                         \ RAMCFG clock enable This bit is set and cleared by software.
$00040000 constant RCC_RCC_AHB1ENR_DMA2DEN                          \ DMA2D clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00080000 constant RCC_RCC_AHB1ENR_GFXMMUEN                         \ GFXMMU clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00100000 constant RCC_RCC_AHB1ENR_GPU2DEN                          \ GPU2D clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00200000 constant RCC_RCC_AHB1ENR_DCACHE2EN                        \ DCACHE2 clock enable This bit is set and reset by software. Note: DCACHE2 clock must be enabled to access memories, even if the DCACHE2 is bypassed. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$01000000 constant RCC_RCC_AHB1ENR_GTZC1EN                          \ GTZC1 clock enable This bit is set and reset by software.
$10000000 constant RCC_RCC_AHB1ENR_BKPSRAMEN                        \ BKPSRAM clock enable This bit is set and reset by software.
$40000000 constant RCC_RCC_AHB1ENR_DCACHE1EN                        \ DCACHE1 clock enable This bit is set and reset by software. Note: DCACHE1 clock must be enabled when external memories are accessed through OCTOSPI1, OCTOSPI2, HSPI1 or FSMC, even if the DCACHE1 is bypassed.
$80000000 constant RCC_RCC_AHB1ENR_SRAM1EN                          \ SRAM1 clock enable This bit is set and reset by software.


\
\ @brief RCC AHB2 peripheral clock enable register 1
\ Address offset: 0x8C
\ Reset value: 0xC0000000
\

$00000001 constant RCC_RCC_AHB2ENR1_GPIOAEN                         \ I/O port A clock enable This bit is set and cleared by software.
$00000002 constant RCC_RCC_AHB2ENR1_GPIOBEN                         \ I/O port B clock enable This bit is set and cleared by software.
$00000004 constant RCC_RCC_AHB2ENR1_GPIOCEN                         \ I/O port C clock enable This bit is set and cleared by software.
$00000008 constant RCC_RCC_AHB2ENR1_GPIODEN                         \ I/O port D clock enable This bit is set and cleared by software.
$00000010 constant RCC_RCC_AHB2ENR1_GPIOEEN                         \ I/O port E clock enable This bit is set and cleared by software.
$00000020 constant RCC_RCC_AHB2ENR1_GPIOFEN                         \ I/O port F clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000040 constant RCC_RCC_AHB2ENR1_GPIOGEN                         \ I/O port G clock enable This bit is set and cleared by software.
$00000080 constant RCC_RCC_AHB2ENR1_GPIOHEN                         \ I/O port H clock enable This bit is set and cleared by software.
$00000100 constant RCC_RCC_AHB2ENR1_GPIOIEN                         \ I/O port I clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000200 constant RCC_RCC_AHB2ENR1_GPIOJEN                         \ I/O port J clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000400 constant RCC_RCC_AHB2ENR1_ADC12EN                         \ ADC1 and ADC2 clock enable This bit is set and cleared by software. Note: This bit impacts ADC1 in STM32U535/545/575/585, and ADC1/ADC2 in�STM32U59x/5Ax/5Fx/5Gx.
$00001000 constant RCC_RCC_AHB2ENR1_DCMI_PSSIEN                     \ DCMI and PSSI clock enable This bit is set and cleared by software.
$00004000 constant RCC_RCC_AHB2ENR1_OTGEN                           \ OTG_FS or OTG_HS clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00008000 constant RCC_RCC_AHB2ENR1_OTGHSPHYEN                      \ OTG_HS PHY clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00010000 constant RCC_RCC_AHB2ENR1_AESEN                           \ AES clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00020000 constant RCC_RCC_AHB2ENR1_HASHEN                          \ HASH clock enable This bit is set and cleared by software
$00040000 constant RCC_RCC_AHB2ENR1_RNGEN                           \ RNG clock enable This bit is set and cleared by software.
$00080000 constant RCC_RCC_AHB2ENR1_PKAEN                           \ PKA clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00100000 constant RCC_RCC_AHB2ENR1_SAESEN                          \ SAES clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00200000 constant RCC_RCC_AHB2ENR1_OCTOSPIMEN                      \ OCTOSPIM clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00800000 constant RCC_RCC_AHB2ENR1_OTFDEC1EN                       \ OTFDEC1 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$01000000 constant RCC_RCC_AHB2ENR1_OTFDEC2EN                       \ OTFDEC2 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$08000000 constant RCC_RCC_AHB2ENR1_SDMMC1EN                        \ SDMMC1 clock enable This bit is set and cleared by software.
$10000000 constant RCC_RCC_AHB2ENR1_SDMMC2EN                        \ SDMMC2 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$40000000 constant RCC_RCC_AHB2ENR1_SRAM2EN                         \ SRAM2 clock enable This bit is set and reset by software.
$80000000 constant RCC_RCC_AHB2ENR1_SRAM3EN                         \ SRAM3 clock enable This bit is set and reset by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC AHB2 peripheral clock enable register 2
\ Address offset: 0x90
\ Reset value: 0x80000000
\

$00000001 constant RCC_RCC_AHB2ENR2_FSMCEN                          \ FSMC clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000010 constant RCC_RCC_AHB2ENR2_OCTOSPI1EN                      \ OCTOSPI1 clock enable This bit is set and cleared by software.
$00000100 constant RCC_RCC_AHB2ENR2_OCTOSPI2EN                      \ OCTOSPI2 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00001000 constant RCC_RCC_AHB2ENR2_HSPI1EN                         \ HSPI1 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$40000000 constant RCC_RCC_AHB2ENR2_SRAM6EN                         \ SRAM6 clock enable This bit is set and reset by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$80000000 constant RCC_RCC_AHB2ENR2_SRAM5EN                         \ SRAM5 clock enable This bit is set and reset by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC AHB3 peripheral clock enable register
\ Address offset: 0x94
\ Reset value: 0x80000000
\

$00000001 constant RCC_RCC_AHB3ENR_LPGPIO1EN                        \ LPGPIO1 enable This bit is set and cleared by software.
$00000004 constant RCC_RCC_AHB3ENR_PWREN                            \ PWR clock enable This bit is set and cleared by software.
$00000020 constant RCC_RCC_AHB3ENR_ADC4EN                           \ ADC4 clock enable This bit is set and cleared by software.
$00000040 constant RCC_RCC_AHB3ENR_DAC1EN                           \ DAC1 clock enable This bit is set and cleared by software.
$00000200 constant RCC_RCC_AHB3ENR_LPDMA1EN                         \ LPDMA1 clock enable This bit is set and cleared by software.
$00000400 constant RCC_RCC_AHB3ENR_ADF1EN                           \ ADF1 clock enable This bit is set and cleared by software.
$00001000 constant RCC_RCC_AHB3ENR_GTZC2EN                          \ GTZC2 clock enable This bit is set and cleared by software.
$80000000 constant RCC_RCC_AHB3ENR_SRAM4EN                          \ SRAM4 clock enable This bit is set and reset by software.


\
\ @brief RCC APB1 peripheral clock enable register 1
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1ENR1_TIM2EN                          \ TIM2 clock enable This bit is set and cleared by software.
$00000002 constant RCC_RCC_APB1ENR1_TIM3EN                          \ TIM3 clock enable This bit is set and cleared by software.
$00000004 constant RCC_RCC_APB1ENR1_TIM4EN                          \ TIM4 clock enable This bit is set and cleared by software.
$00000008 constant RCC_RCC_APB1ENR1_TIM5EN                          \ TIM5 clock enable This bit is set and cleared by software.
$00000010 constant RCC_RCC_APB1ENR1_TIM6EN                          \ TIM6 clock enable This bit is set and cleared by software.
$00000020 constant RCC_RCC_APB1ENR1_TIM7EN                          \ TIM7 clock enable This bit is set and cleared by software.
$00000800 constant RCC_RCC_APB1ENR1_WWDGEN                          \ WWDG clock enable This bit is set by software to enable the window watchdog clock. It is reset by hardware system reset. This bit can also be set by hardware if the WWDG_SW option bit is reset.
$00004000 constant RCC_RCC_APB1ENR1_SPI2EN                          \ SPI2 clock enable This bit is set and cleared by software.
$00020000 constant RCC_RCC_APB1ENR1_USART2EN                        \ USART2 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00040000 constant RCC_RCC_APB1ENR1_USART3EN                        \ USART3 clock enable This bit is set and cleared by software.
$00080000 constant RCC_RCC_APB1ENR1_UART4EN                         \ UART4 clock enable This bit is set and cleared by software.
$00100000 constant RCC_RCC_APB1ENR1_UART5EN                         \ UART5 clock enable This bit is set and cleared by software.
$00200000 constant RCC_RCC_APB1ENR1_I2C1EN                          \ I2C1 clock enable This bit is set and cleared by software.
$00400000 constant RCC_RCC_APB1ENR1_I2C2EN                          \ I2C2 clock enable This bit is set and cleared by software.
$01000000 constant RCC_RCC_APB1ENR1_CRSEN                           \ CRS clock enable This bit is set and cleared by software.
$02000000 constant RCC_RCC_APB1ENR1_USART6EN                        \ USART6 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC APB1 peripheral clock enable register 2
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB1ENR2_I2C4EN                          \ I2C4 clock enable This bit is set and cleared by software
$00000020 constant RCC_RCC_APB1ENR2_LPTIM2EN                        \ LPTIM2 clock enable This bit is set and cleared by software.
$00000040 constant RCC_RCC_APB1ENR2_I2C5EN                          \ I2C5 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000080 constant RCC_RCC_APB1ENR2_I2C6EN                          \ I2C6 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000200 constant RCC_RCC_APB1ENR2_FDCAN1EN                        \ FDCAN1 clock enable This bit is set and cleared by software.
$00800000 constant RCC_RCC_APB1ENR2_UCPD1EN                         \ UCPD1 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC APB2 peripheral clock enable register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000800 constant RCC_RCC_APB2ENR_TIM1EN                           \ TIM1 clock enable This bit is set and cleared by software.
$00001000 constant RCC_RCC_APB2ENR_SPI1EN                           \ SPI1 clock enable This bit is set and cleared by software.
$00002000 constant RCC_RCC_APB2ENR_TIM8EN                           \ TIM8 clock enable This bit is set and cleared by software.
$00004000 constant RCC_RCC_APB2ENR_USART1EN                         \ USART1clock enable This bit is set and cleared by software.
$00010000 constant RCC_RCC_APB2ENR_TIM15EN                          \ TIM15 clock enable This bit is set and cleared by software.
$00020000 constant RCC_RCC_APB2ENR_TIM16EN                          \ TIM16 clock enable This bit is set and cleared by software.
$00040000 constant RCC_RCC_APB2ENR_TIM17EN                          \ TIM17 clock enable This bit is set and cleared by software.
$00200000 constant RCC_RCC_APB2ENR_SAI1EN                           \ SAI1 clock enable This bit is set and cleared by software.
$00400000 constant RCC_RCC_APB2ENR_SAI2EN                           \ SAI2 clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$01000000 constant RCC_RCC_APB2ENR_USBEN                            \ USB clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$02000000 constant RCC_RCC_APB2ENR_GFXTIMEN                         \ GFXTIM clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$04000000 constant RCC_RCC_APB2ENR_LTDCEN                           \ LTDC clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$08000000 constant RCC_RCC_APB2ENR_DSIEN                            \ DSI clock enable This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC APB3 peripheral clock enable register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000002 constant RCC_RCC_APB3ENR_SYSCFGEN                         \ SYSCFG clock enable This bit is set and cleared by software.
$00000020 constant RCC_RCC_APB3ENR_SPI3EN                           \ SPI3 clock enable This bit is set and cleared by software.
$00000040 constant RCC_RCC_APB3ENR_LPUART1EN                        \ LPUART1 clock enable This bit is set and cleared by software.
$00000080 constant RCC_RCC_APB3ENR_I2C3EN                           \ I2C3 clock enable This bit is set and cleared by software.
$00000800 constant RCC_RCC_APB3ENR_LPTIM1EN                         \ LPTIM1 clock enable This bit is set and cleared by software.
$00001000 constant RCC_RCC_APB3ENR_LPTIM3EN                         \ LPTIM3 clock enable This bit is set and cleared by software.
$00002000 constant RCC_RCC_APB3ENR_LPTIM4EN                         \ LPTIM4 clock enable This bit is set and cleared by software.
$00004000 constant RCC_RCC_APB3ENR_OPAMPEN                          \ OPAMP clock enable This bit is set and cleared by software.
$00008000 constant RCC_RCC_APB3ENR_COMPEN                           \ COMP clock enable This bit is set and cleared by software.
$00100000 constant RCC_RCC_APB3ENR_VREFEN                           \ VREFBUF clock enable This bit is set and cleared by software.
$00200000 constant RCC_RCC_APB3ENR_RTCAPBEN                         \ RTC and TAMP APB clock enable This bit is set and cleared by software.


\
\ @brief RCC AHB1 peripheral clock enable in Sleep and Stop modes register
\ Address offset: 0xB0
\ Reset value: 0xFFFFFFFF
\

$00000001 constant RCC_RCC_AHB1SMENR_GPDMA1SMEN                     \ GPDMA1 clocks enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000002 constant RCC_RCC_AHB1SMENR_CORDICSMEN                     \ CORDIC clocks enable during Sleep and Stop modes This bit is set and cleared by software during Sleep mode.
$00000004 constant RCC_RCC_AHB1SMENR_FMACSMEN                       \ FMAC clocks enable during Sleep and Stop modes. This bit is set and cleared by software.
$00000008 constant RCC_RCC_AHB1SMENR_MDF1SMEN                       \ MDF1 clocks enable during Sleep and Stop modes. This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000100 constant RCC_RCC_AHB1SMENR_FLASHSMEN                      \ FLASH clocks enable during Sleep and Stop modes This bit is set and cleared by software.
$00001000 constant RCC_RCC_AHB1SMENR_CRCSMEN                        \ CRC clocks enable during Sleep and Stop modes This bit is set and cleared by software.
$00008000 constant RCC_RCC_AHB1SMENR_JPEGSMEN                       \ JPEG clocks enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00010000 constant RCC_RCC_AHB1SMENR_TSCSMEN                        \ TSC clocks enable during Sleep and Stop modes This bit is set and cleared by software.
$00020000 constant RCC_RCC_AHB1SMENR_RAMCFGSMEN                     \ RAMCFG clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00040000 constant RCC_RCC_AHB1SMENR_DMA2DSMEN                      \ DMA2D clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00080000 constant RCC_RCC_AHB1SMENR_GFXMMUSMEN                     \ GFXMMU clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00100000 constant RCC_RCC_AHB1SMENR_GPU2DSMEN                      \ GPU2D clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00200000 constant RCC_RCC_AHB1SMENR_DCACHE2SMEN                    \ DCACHE2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$01000000 constant RCC_RCC_AHB1SMENR_GTZC1SMEN                      \ GTZC1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$10000000 constant RCC_RCC_AHB1SMENR_BKPSRAMSMEN                    \ BKPSRAM clock enable during Sleep and Stop modes This bit is set and cleared by software
$20000000 constant RCC_RCC_AHB1SMENR_ICACHESMEN                     \ ICACHE clock enable during Sleep and Stop modes This bit is set and cleared by software.
$40000000 constant RCC_RCC_AHB1SMENR_DCACHE1SMEN                    \ DCACHE1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$80000000 constant RCC_RCC_AHB1SMENR_SRAM1SMEN                      \ SRAM1 clock enable during Sleep and Stop modes This bit is set and cleared by software.


\
\ @brief RCC AHB2 peripheral clock enable in Sleep and Stop modes register 1
\ Address offset: 0xB4
\ Reset value: 0xFFFFFFFF
\

$00000001 constant RCC_RCC_AHB2SMENR1_GPIOASMEN                     \ I/O port A clocks enable during Sleep and Stop modes This bit is set and cleared by software.
$00000002 constant RCC_RCC_AHB2SMENR1_GPIOBSMEN                     \ I/O port B clocks enable during Sleep and Stop modes This bit is set and cleared by software.
$00000004 constant RCC_RCC_AHB2SMENR1_GPIOCSMEN                     \ I/O port C clocks enable during Sleep and Stop modes This bit is set and cleared by software.
$00000008 constant RCC_RCC_AHB2SMENR1_GPIODSMEN                     \ I/O port D clocks enable during Sleep and Stop modes This bit is set and cleared by software.
$00000010 constant RCC_RCC_AHB2SMENR1_GPIOESMEN                     \ I/O port E clocks enable during Sleep and Stop modes This bit is set and cleared by software.
$00000020 constant RCC_RCC_AHB2SMENR1_GPIOFSMEN                     \ I/O port F clocks enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000040 constant RCC_RCC_AHB2SMENR1_GPIOGSMEN                     \ I/O port G clocks enable during Sleep and Stop modes This bit is set and cleared by software.
$00000080 constant RCC_RCC_AHB2SMENR1_GPIOHSMEN                     \ I/O port H clocks enable during Sleep and Stop modes This bit is set and cleared by software.
$00000100 constant RCC_RCC_AHB2SMENR1_GPIOISMEN                     \ I/O port I clocks enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000200 constant RCC_RCC_AHB2SMENR1_GPIOJSMEN                     \ I/O port J clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000400 constant RCC_RCC_AHB2SMENR1_ADC12SMEN                     \ ADC1 and ADC2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit impacts ADC1 in STM32U535/545/575/585 and ADC1/ADC2 in�STM32U59x/5Ax/5Fx/5Gx.
$00001000 constant RCC_RCC_AHB2SMENR1_DCMI_PSSISMEN                 \ DCMI and PSSI clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00004000 constant RCC_RCC_AHB2SMENR1_OTGSMEN                       \ OTG_FS and OTG_HS clocks enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00008000 constant RCC_RCC_AHB2SMENR1_OTGHSPHYSMEN                  \ OTG_HS PHY clock enable during Sleep and Stop modes This bit is set and cleared by software Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00010000 constant RCC_RCC_AHB2SMENR1_AESSMEN                       \ AES clock enable during Sleep and Stop modes This bit is set and cleared by software Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00020000 constant RCC_RCC_AHB2SMENR1_HASHSMEN                      \ HASH clock enable during Sleep and Stop modes This bit is set and cleared by software
$00040000 constant RCC_RCC_AHB2SMENR1_RNGSMEN                       \ RNG clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00080000 constant RCC_RCC_AHB2SMENR1_PKASMEN                       \ PKA clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00100000 constant RCC_RCC_AHB2SMENR1_SAESSMEN                      \ SAES accelerator clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00200000 constant RCC_RCC_AHB2SMENR1_OCTOSPIMSMEN                  \ OCTOSPIM clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00800000 constant RCC_RCC_AHB2SMENR1_OTFDEC1SMEN                   \ OTFDEC1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$01000000 constant RCC_RCC_AHB2SMENR1_OTFDEC2SMEN                   \ OTFDEC2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$08000000 constant RCC_RCC_AHB2SMENR1_SDMMC1SMEN                    \ SDMMC1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$10000000 constant RCC_RCC_AHB2SMENR1_SDMMC2SMEN                    \ SDMMC2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$40000000 constant RCC_RCC_AHB2SMENR1_SRAM2SMEN                     \ SRAM2 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$80000000 constant RCC_RCC_AHB2SMENR1_SRAM3SMEN                     \ SRAM3 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC AHB2 peripheral clock enable in Sleep and Stop modes register 2
\ Address offset: 0xB8
\ Reset value: 0xFFFFFFFF
\

$00000001 constant RCC_RCC_AHB2SMENR2_FSMCSMEN                      \ FSMC clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000010 constant RCC_RCC_AHB2SMENR2_OCTOSPI1SMEN                  \ OCTOSPI1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00000100 constant RCC_RCC_AHB2SMENR2_OCTOSPI2SMEN                  \ OCTOSPI2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00001000 constant RCC_RCC_AHB2SMENR2_HSPI1SMEN                     \ HSPI1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$40000000 constant RCC_RCC_AHB2SMENR2_SRAM6SMEN                     \ SRAM6 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$80000000 constant RCC_RCC_AHB2SMENR2_SRAM5SMEN                     \ SRAM5 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC AHB3 peripheral clock enable in Sleep and Stop modes register
\ Address offset: 0xBC
\ Reset value: 0xFFFFFFFF
\

$00000001 constant RCC_RCC_AHB3SMENR_LPGPIO1SMEN                    \ LPGPIO1 enable during Sleep and Stop modes This bit is set and cleared by software.
$00000004 constant RCC_RCC_AHB3SMENR_PWRSMEN                        \ PWR clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00000020 constant RCC_RCC_AHB3SMENR_ADC4SMEN                       \ ADC4 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000040 constant RCC_RCC_AHB3SMENR_DAC1SMEN                       \ DAC1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000200 constant RCC_RCC_AHB3SMENR_LPDMA1SMEN                     \ LPDMA1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000400 constant RCC_RCC_AHB3SMENR_ADF1SMEN                       \ ADF1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00001000 constant RCC_RCC_AHB3SMENR_GTZC2SMEN                      \ GTZC2 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$80000000 constant RCC_RCC_AHB3SMENR_SRAM4SMEN                      \ SRAM4 clock enable during Sleep and Stop modes This bit is set and cleared by software.


\
\ @brief RCC APB1 peripheral clock enable in Sleep and Stop modes register 1
\ Address offset: 0xC4
\ Reset value: 0xFFFFFFFF
\

$00000001 constant RCC_RCC_APB1SMENR1_TIM2SMEN                      \ TIM2 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00000002 constant RCC_RCC_APB1SMENR1_TIM3SMEN                      \ TIM3 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00000004 constant RCC_RCC_APB1SMENR1_TIM4SMEN                      \ TIM4 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00000008 constant RCC_RCC_APB1SMENR1_TIM5SMEN                      \ TIM5 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00000010 constant RCC_RCC_APB1SMENR1_TIM6SMEN                      \ TIM6 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00000020 constant RCC_RCC_APB1SMENR1_TIM7SMEN                      \ TIM7 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00000800 constant RCC_RCC_APB1SMENR1_WWDGSMEN                      \ Window watchdog clock enable during Sleep and Stop modes This bit is set and cleared by software. It is forced to one by hardware when the hardware WWDG option is activated.
$00004000 constant RCC_RCC_APB1SMENR1_SPI2SMEN                      \ SPI2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00020000 constant RCC_RCC_APB1SMENR1_USART2SMEN                    \ USART2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00040000 constant RCC_RCC_APB1SMENR1_USART3SMEN                    \ USART3 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00080000 constant RCC_RCC_APB1SMENR1_UART4SMEN                     \ UART4 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00100000 constant RCC_RCC_APB1SMENR1_UART5SMEN                     \ UART5 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00200000 constant RCC_RCC_APB1SMENR1_I2C1SMEN                      \ I2C1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00400000 constant RCC_RCC_APB1SMENR1_I2C2SMEN                      \ I2C2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$01000000 constant RCC_RCC_APB1SMENR1_CRSSMEN                       \ CRS clock enable during Sleep and Stop modes This bit is set and cleared by software.
$02000000 constant RCC_RCC_APB1SMENR1_USART6SMEN                    \ USART6 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC APB1 peripheral clocks enable in Sleep and Stop modes register 2
\ Address offset: 0xC8
\ Reset value: 0xFFFFFFFF
\

$00000002 constant RCC_RCC_APB1SMENR2_I2C4SMEN                      \ I2C4 clock enable during Sleep and Stop modes This bit is set and cleared by software Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000020 constant RCC_RCC_APB1SMENR2_LPTIM2SMEN                    \ LPTIM2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000040 constant RCC_RCC_APB1SMENR2_I2C5SMEN                      \ I2C5 clock enable during Sleep and Stop modes This bit is set and cleared by software Note: This bit must be set to allow the peripheral to wake up from Stop modes. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000080 constant RCC_RCC_APB1SMENR2_I2C6SMEN                      \ I2C6 clock enable during Sleep and Stop modes This bit is set and cleared by software Note: This bit must be set to allow the peripheral to wake up from Stop modes. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00000200 constant RCC_RCC_APB1SMENR2_FDCAN1SMEN                    \ FDCAN1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00800000 constant RCC_RCC_APB1SMENR2_UCPD1SMEN                     \ UCPD1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC APB2 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0xCC
\ Reset value: 0xFFFFFFFF
\

$00000800 constant RCC_RCC_APB2SMENR_TIM1SMEN                       \ TIM1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00001000 constant RCC_RCC_APB2SMENR_SPI1SMEN                       \ SPI1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00002000 constant RCC_RCC_APB2SMENR_TIM8SMEN                       \ TIM8 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00004000 constant RCC_RCC_APB2SMENR_USART1SMEN                     \ USART1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00010000 constant RCC_RCC_APB2SMENR_TIM15SMEN                      \ TIM15 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00020000 constant RCC_RCC_APB2SMENR_TIM16SMEN                      \ TIM16 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00040000 constant RCC_RCC_APB2SMENR_TIM17SMEN                      \ TIM17 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00200000 constant RCC_RCC_APB2SMENR_SAI1SMEN                       \ SAI1 clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00400000 constant RCC_RCC_APB2SMENR_SAI2SMEN                       \ SAI2 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series.Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$01000000 constant RCC_RCC_APB2SMENR_USBSMEN                        \ USB clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$02000000 constant RCC_RCC_APB2SMENR_GFXTIMSMEN                     \ GFXTIM clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$04000000 constant RCC_RCC_APB2SMENR_LTDCSMEN                       \ LTDC clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$08000000 constant RCC_RCC_APB2SMENR_DSISMEN                        \ DSI clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.


\
\ @brief RCC APB3 peripheral clock enable in Sleep and Stop modes register
\ Address offset: 0xD0
\ Reset value: 0xFFFFFFFF
\

$00000002 constant RCC_RCC_APB3SMENR_SYSCFGSMEN                     \ SYSCFG clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00000020 constant RCC_RCC_APB3SMENR_SPI3SMEN                       \ SPI3 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000040 constant RCC_RCC_APB3SMENR_LPUART1SMEN                    \ LPUART1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000080 constant RCC_RCC_APB3SMENR_I2C3SMEN                       \ I2C3 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000800 constant RCC_RCC_APB3SMENR_LPTIM1SMEN                     \ LPTIM1 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00001000 constant RCC_RCC_APB3SMENR_LPTIM3SMEN                     \ LPTIM3 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00002000 constant RCC_RCC_APB3SMENR_LPTIM4SMEN                     \ LPTIM4 clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00004000 constant RCC_RCC_APB3SMENR_OPAMPSMEN                      \ OPAMP clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00008000 constant RCC_RCC_APB3SMENR_COMPSMEN                       \ COMP clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00100000 constant RCC_RCC_APB3SMENR_VREFSMEN                       \ VREFBUF clock enable during Sleep and Stop modes This bit is set and cleared by software.
$00200000 constant RCC_RCC_APB3SMENR_RTCAPBSMEN                     \ RTC and TAMP APB clock enable during Sleep and Stop modes This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.


\
\ @brief RCC SmartRun domain peripheral autonomous mode register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000020 constant RCC_RCC_SRDAMR_SPI3AMEN                          \ SPI3 autonomous mode enable in Stop 0,1, 2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000040 constant RCC_RCC_SRDAMR_LPUART1AMEN                       \ LPUART1 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000080 constant RCC_RCC_SRDAMR_I2C3AMEN                          \ I2C3 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00000800 constant RCC_RCC_SRDAMR_LPTIM1AMEN                        \ LPTIM1 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00001000 constant RCC_RCC_SRDAMR_LPTIM3AMEN                        \ LPTIM3 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00002000 constant RCC_RCC_SRDAMR_LPTIM4AMEN                        \ LPTIM4 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$00004000 constant RCC_RCC_SRDAMR_OPAMPAMEN                         \ OPAMP autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software.
$00008000 constant RCC_RCC_SRDAMR_COMPAMEN                          \ COMP autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software.
$00100000 constant RCC_RCC_SRDAMR_VREFAMEN                          \ VREFBUF autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software.
$00200000 constant RCC_RCC_SRDAMR_RTCAPBAMEN                        \ RTC and TAMP autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$02000000 constant RCC_RCC_SRDAMR_ADC4AMEN                          \ ADC4 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$04000000 constant RCC_RCC_SRDAMR_LPGPIO1AMEN                       \ LPGPIO1 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software.
$08000000 constant RCC_RCC_SRDAMR_DAC1AMEN                          \ DAC1 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$10000000 constant RCC_RCC_SRDAMR_LPDMA1AMEN                        \ LPDMA1 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$20000000 constant RCC_RCC_SRDAMR_ADF1AMEN                          \ ADF1 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software. Note: This bit must be set to allow the peripheral to wake up from Stop modes.
$80000000 constant RCC_RCC_SRDAMR_SRAM4AMEN                         \ SRAM4 autonomous mode enable in Stop 0/1/2 mode This bit is set and cleared by software.


\
\ @brief RCC peripherals independent clock configuration register 1
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_CCIPR1_USART1SEL                         \ USART1 kernel clock source selection These bits are used to select the USART1 kernel clock source. Note: The USART1 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16 or LSE.
$0000000c constant RCC_RCC_CCIPR1_USART2SEL                         \ USART2 kernel clock source selection These bits are used to select the USART2 kernel clock source. The USART2 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16 or LSE. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
$00000030 constant RCC_RCC_CCIPR1_USART3SEL                         \ USART3 kernel clock source selection These bits are used to select the USART3 kernel clock source. Note: The USART3 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16 or LSE.
$000000c0 constant RCC_RCC_CCIPR1_UART4SEL                          \ UART4 kernel clock source selection These bits are used to select the UART4 kernel clock source. Note: The UART4 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16 or LSE.
$00000300 constant RCC_RCC_CCIPR1_UART5SEL                          \ UART5 kernel clock source selection These bits are used to select the UART5 kernel clock source. Note: The UART5 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16 or LSE.
$00000c00 constant RCC_RCC_CCIPR1_I2C1SEL                           \ I2C1 kernel clock source selection These bits are used to select the I2C1 kernel clock source. Note: The I2C1 is functional in Stop 0 and Stop 1 mode sonly when the kernel clock is HSI16�or MSIK.
$00003000 constant RCC_RCC_CCIPR1_I2C2SEL                           \ I2C2 kernel clock source selection These bits are used to select the I2C2 kernel clock source. Note: The I2C2 is functional in Stop 0 and Stop 1 mode sonly when the kernel clock is HSI16�or MSIK.
$0000c000 constant RCC_RCC_CCIPR1_I2C4SEL                           \ I2C4 kernel clock source selection These bits are used to select the I2C4 kernel clock source. Note: The I2C4 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16�or MSIK.
$00030000 constant RCC_RCC_CCIPR1_SPI2SEL                           \ SPI2 kernel clock source selection These bits are used to select the SPI2 kernel clock source. Note: The SPI2 is functional in Stop 0 and Stop 1 mode only when the kernel clock is HSI16 or MSIK.
$000c0000 constant RCC_RCC_CCIPR1_LPTIM2SEL                         \ Low-power timer 2 kernel clock source selection These bits are used to select the LPTIM2 kernel clock source. Note: The LPTIM2 is functional in Stop 0 and Stop 1 mode only when the kernel clock is LSI, LSE or HSI16 if HSIKERON = 1.
$00300000 constant RCC_RCC_CCIPR1_SPI1SEL                           \ SPI1 kernel clock source selection These bits are used to select the SPI1 kernel clock source. Note: The SPI1 is functional in Stop 0 and Stop 1 mode only when the kernel clock is HSI16 or MSIK.
$00c00000 constant RCC_RCC_CCIPR1_SYSTICKSEL                        \ SysTick clock source selection These bits are used to select the SysTick clock source. Note: When LSE or LSI is selected, the AHB frequency must be at least four times higher than the LSI or LSE frequency. In addition, a jitter up to one HCLK cycle is introduced, due to the LSE or LSI sampling with HCLK in the SysTick circuitry.
$03000000 constant RCC_RCC_CCIPR1_FDCAN1SEL                         \ FDCAN1 kernel clock source selection These bits are used to select the FDCAN1 kernel clock source.
$0c000000 constant RCC_RCC_CCIPR1_ICLKSEL                           \ Intermediate clock source selection These bits are used to select the clock source for the OTG_FS, the USB, and the SDMMC.
$e0000000 constant RCC_RCC_CCIPR1_TIMICSEL                          \ Clock sources for TIM16,TIM17, and LPTIM2 internal input capture When TIMICSEL2 is set, the TIM16, TIM17, and LPTIM2 internal input capture can be connected either to HSI/256, MSI/4, or MSI/1024. Depending on TIMICSEL[1:0] value, MSI is either MSIK or MSIS. When TIMICSEL2 is cleared, the HSI, MSIK, and MSIS clock sources cannot be selected as�TIM16, TIM17, or LPTIM2 internal input capture. 0xx: HSI, MSIK and MSIS dividers disabled Note: The clock division must be disabled (TIMICSEL configured to 0xx) before selecting or changing a clock sources division.


\
\ @brief RCC peripherals independent clock configuration register 2
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_CCIPR2_MDF1SEL                           \ MDF1 kernel clock source selection These bits are used to select the MDF1 kernel clock source. others: reserved
$000000e0 constant RCC_RCC_CCIPR2_SAI1SEL                           \ SAI1 kernel clock source selection These bits are used to select the SAI1 kernel clock source. others: reserved Note: If the selected clock is the external clock and this clock is stopped, a switch to another clock is impossible.
$00000700 constant RCC_RCC_CCIPR2_SAI2SEL                           \ SAI2 kernel clock source selection These bits are used to select the SAI2 kernel clock source. others: reserved If the selected clock is the external clock and this clock is stopped, a switch to another clock is impossible. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
$00000800 constant RCC_RCC_CCIPR2_SAESSEL                           \ SAES kernel clock source selection This bit is used to select the SAES kernel clock source. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00003000 constant RCC_RCC_CCIPR2_RNGSEL                            \ RNG kernel clock source selection These bits are used to select the RNG kernel clock source.
$00004000 constant RCC_RCC_CCIPR2_SDMMCSEL                          \ SDMMC1 and SDMMC2 kernel clock source selection This bit is used to select the SDMMC kernel clock source. It is recommended to change it only after reset and before enabling the SDMMC.
$00008000 constant RCC_RCC_CCIPR2_DSISEL                            \ DSI kernel clock source selection This bit is used to select the DSI kernel clock source. This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. Note: If not present, consider this bit as reserved and keep it at reset value.
$00030000 constant RCC_RCC_CCIPR2_USART6SEL                         \ USART6 kernel clock source selection These bits are used to select the USART6 kernel clock source. The USART6 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16 or LSE. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
$00040000 constant RCC_RCC_CCIPR2_LTDCSEL                           \ LTDC kernel clock source selection This bit is used to select the LTDC kernel clock source. Note: This bit is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bit as reserved and keep it at reset value.
$00300000 constant RCC_RCC_CCIPR2_OCTOSPISEL                        \ OCTOSPI1 and OCTOSPI2 kernel clock source selection These bits are used to select the OCTOSPI1 and OCTOSPI2 kernel clock source.
$00c00000 constant RCC_RCC_CCIPR2_HSPI1SEL                          \ HSPI1 kernel clock source selection These bits are used to select the HSPI1 kernel clock source. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
$03000000 constant RCC_RCC_CCIPR2_I2C5SEL                           \ I2C5 kernel clock source selection These bits are used to select the I2C5 kernel clock source. The I2C5 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16�or MSIK. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
$0c000000 constant RCC_RCC_CCIPR2_I2C6SEL                           \ I2C6 kernel clock source selection These bits are used to select the I2C6 kernel clock source. The I2C6 is functional in Stop 0 and Stop 1 modes only when the kernel clock is HSI16�or MSIK. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.
$c0000000 constant RCC_RCC_CCIPR2_OTGHSSEL                          \ OTG_HS PHY kernel clock source selection These bits are used to select the OTG_HS PHY kernel clock source. Note: This bitfield is only available on some devices in the STM32U5 Series. Refer to the device datasheet for availability of its associated peripheral. If not present, consider this bitfield as reserved and keep it at reset value.


\
\ @brief RCC peripherals independent clock configuration register 3
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_CCIPR3_LPUART1SEL                        \ LPUART1 kernel clock source selection These bits are used to select the LPUART1 kernel clock source. others: reserved Note: The LPUART1 is functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is HSI16, LSE, or MSIK.
$00000018 constant RCC_RCC_CCIPR3_SPI3SEL                           \ SPI3 kernel clock source selection These bits are used to select the SPI3 kernel clock source. Note: The SPI3 is functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is HSI16 or MSIK.
$000000c0 constant RCC_RCC_CCIPR3_I2C3SEL                           \ I2C3 kernel clock source selection These bits are used to select the I2C3 kernel clock source. Note: The I2C3 is functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is HSI16 or MSIK.
$00000300 constant RCC_RCC_CCIPR3_LPTIM34SEL                        \ LPTIM3 and LPTIM4 kernel clock source selection These bits are used to select the LPTIM3 and LPTIM4 kernel clock source. Note: The LPTIM3 and LPTIM4 are functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is LSI, LSE, HSI16 with HSIKERON = 1, or MSIK with MSIKERON�=�1.
$00000c00 constant RCC_RCC_CCIPR3_LPTIM1SEL                         \ LPTIM1 kernel clock source selection These bits are used to select the LPTIM1 kernel clock source. Note: The LPTIM1 is functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is LSI, LSE, HSI16 with HSIKERON = 1, or MSIK with MSIKERON = 1.
$00007000 constant RCC_RCC_CCIPR3_ADCDACSEL                         \ ADC1, ADC2, ADC4 and DAC1 kernel clock source selection These bits are used to select the ADC1, ADC2, ADC4, and DAC1 kernel clock source. others: reserved Note: The ADC1, ADC2, ADC4, and DAC1 are functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is HSI16 or MSIK (only ADC4 and DAC1 are functional in�Stop 2 mode).
$00008000 constant RCC_RCC_CCIPR3_DAC1SEL                           \ DAC1 sample-and-hold clock source selection This bit is used to select the DAC1 sample-and-hold clock source.
$00070000 constant RCC_RCC_CCIPR3_ADF1SEL                           \ ADF1 kernel clock source selection These bits are used to select the ADF1 kernel clock source. others: reserved Note: The ADF1 is functional in Stop 0, Stop 1, and Stop 2 modes only when the kernel clock is AUDIOCLK or MSIK.


\
\ @brief RCC backup domain control register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_BDCR_LSEON                               \ LSE oscillator enable This bit is set and cleared by software.
$00000002 constant RCC_RCC_BDCR_LSERDY                              \ LSE oscillator ready This bit is set and cleared by hardware to indicate when the external 32�kHz oscillator is stable. After LSEON is cleared, this LSERDY bit goes low after six external low-speed oscillator clock cycles.
$00000004 constant RCC_RCC_BDCR_LSEBYP                              \ LSE oscillator bypass This bit is set and cleared by software to bypass oscillator in debug mode. It can be written only when the external 32�kHz oscillator is disabled (LSEON = 0 and LSERDY = 0).
$00000018 constant RCC_RCC_BDCR_LSEDRV                              \ LSE oscillator drive capability This bitfield is set by software to modulate the drive capability of the LSE oscillator. It can be written only when the external 32 kHz oscillator is disabled (LSEON = 0 and LSERDY = 0). Note: The oscillator is in ‘Xtal mode’ when it is not in bypass mode.
$00000020 constant RCC_RCC_BDCR_LSECSSON                            \ CSS on LSE enable This bit is set by software to enable the CSS on LSE. It must be enabled after the LSE oscillator is enabled (LSEON bit enabled) and ready (LSERDY flag set by hardware), and after the RTCSEL bit is selected. Once enabled, this bit cannot be disabled, except after a LSE failure detection (LSECSSD�=�1). In that case, the software must disable this LSECSSON bit.
$00000040 constant RCC_RCC_BDCR_LSECSSD                             \ CSS on LSE failure detection This bit is set by hardware to indicate when a failure is detected by the CCS on the external 32�kHz oscillator (LSE).
$00000080 constant RCC_RCC_BDCR_LSESYSEN                            \ LSE system clock (LSESYS) enable This bit is set by software to enable always the LSE system clock generated by RCC, which can be used by any peripheral when its source clock is the LSE, or at system level if one of LSCOSEL, MCO, or MSI PLL mode is needed.
$00000300 constant RCC_RCC_BDCR_RTCSEL                              \ RTC and TAMP clock source selection This bit is set by software to select the clock source for the RTC and TAMP. Once the RTC and TAMP clock source has been selected, it cannot be changed anymore unless the�backup domain is reset, or unless a failure is detected on LSE (LSECSSD is set). BDRST bit can be used to reset them.
$00000800 constant RCC_RCC_BDCR_LSESYSRDY                           \ LSE system clock (LSESYS) ready This bit is set and cleared by hardware to indicate when the LSE system clock is stable.When LSESYSEN is set, this LSESYSRDY flag is set after two LSE clock cycles. The LSE clock must be already enabled and stable (LSEON and LSERDY are set). When the LSEON bit is cleared, LSERDY goes low after six external low-speed oscillator clock cycles.
$00001000 constant RCC_RCC_BDCR_LSEGFON                             \ LSE clock glitch filter enable This bit is set and cleared by hardware to enable the LSE glitch filter. It can be written only when the LSE is disabled (LSEON = 0 and LSERDY = 0).
$00008000 constant RCC_RCC_BDCR_RTCEN                               \ RTC and TAMP clock enable This bit is set and cleared by software.
$00010000 constant RCC_RCC_BDCR_BDRST                               \ Backup domain software reset This bit is set and cleared by software.
$01000000 constant RCC_RCC_BDCR_LSCOEN                              \ Low-speed clock output (LSCO) enable This bit is set and cleared by software.
$02000000 constant RCC_RCC_BDCR_LSCOSEL                             \ Low-speed clock output selection This bit is set and cleared by software.
$04000000 constant RCC_RCC_BDCR_LSION                               \ LSI oscillator enable This bit is set and cleared by software. The LSI oscillator is disabled 60��s maximum after the LSION bit is cleared.
$08000000 constant RCC_RCC_BDCR_LSIRDY                              \ LSI oscillator ready This bit is set and cleared by hardware to indicate when the LSI oscillator is stable. After�LSION is cleared, LSIRDY goes low after three internal low-speed oscillator clock cycles. This bit is set when the LSI is used by IWDG or RTC, even if LSION = 0.
$10000000 constant RCC_RCC_BDCR_LSIPREDIV                           \ Low-speed clock divider configuration This bit is set and cleared by software to enable the LSI division. It can be written only when the LSI is disabled (LSION = 0 and LSIRDY = 0). If the LSI was previously enabled, it is necessary to wait for at least 60 μs after clearing LSION bit (synchronization time for LSI to be really disabled), before writing LSIPREDIV. The LSIPREDIV cannot be changed if the LSI is used by the IWDG or by the RTC.


\
\ @brief RCC control/status register
\ Address offset: 0xF4
\ Reset value: 0x0C004400
\

$00000f00 constant RCC_RCC_CSR_MSIKSRANGE                           \ MSIK range after Standby mode This bit is set by software to chose the MSIK frequency at startup. It is used after exiting Standby mode until MSIRGSEL is set. After a NRST pin or a power-on reset or when exiting Shutdown mode, the range is always 4�MHz. MSIKSRANGE can be written only when MSIRGSEL = 1. others: reserved Note: Changing this bitfield does not change the current MSIK frequency.
$0000f000 constant RCC_RCC_CSR_MSISSRANGE                           \ MSIS range after Standby mode This bitfield is set by software to chose the MSIS frequency at startup. It is used after exiting Standby mode until MSIRGSEL is set. After a NRST pin or a power-on reset or when exiting Shutdown mode, the range is always 4�MHz. MSISSRANGE can be written only when MSIRGSEL = 1. others: reserved Note: Changing this bitfield does not change the current MSIS frequency.
$00800000 constant RCC_RCC_CSR_RMVF                                 \ Remove reset flag This bit is set by software to clear the reset flags.
$02000000 constant RCC_RCC_CSR_OBLRSTF                              \ Option-byte loader reset flag This bit is set by hardware when a reset from the option-byte loading occurs. It is cleared by�writing to the RMVF bit.
$04000000 constant RCC_RCC_CSR_PINRSTF                              \ NRST pin reset flag This bit is set by hardware when a reset from the NRST pin occurs. It is cleared by writing to�the RMVF bit.
$08000000 constant RCC_RCC_CSR_BORRSTF                              \ Brownout reset or an exit from Shutdown mode reset flag This bit is set by hardware when a brownout reset or an exit from Shutdown mode reset occurs. It is cleared by writing to the RMVF bit.
$10000000 constant RCC_RCC_CSR_SFTRSTF                              \ Software reset flag This bit is set by hardware when a software reset occurs. It is cleared by writing to RMVF.
$20000000 constant RCC_RCC_CSR_IWDGRSTF                             \ Independent watchdog reset flag This bit is set by hardware when an independent watchdog reset domain occurs. It is cleared by writing to the RMVF bit.
$40000000 constant RCC_RCC_CSR_WWDGRSTF                             \ Window watchdog reset flag This bit is set by hardware when a window watchdog reset occurs. It is cleared by writing to�the RMVF bit.
$80000000 constant RCC_RCC_CSR_LPWRRSTF                             \ Low-power reset flag This bit is set by hardware when a reset occurs due to a Stop, Standby, or Shutdown mode entry, whereas the corresponding NRST_STOP, NRST_STBY, or NRST_SHDW option bit is cleared. This bit is cleared by writing to the RMVF bit.


\
\ @brief RCC secure configuration register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_SECCFGR_HSISEC                           \ HSI clock configuration and status bit security This bit is set and reset by software.
$00000002 constant RCC_RCC_SECCFGR_HSESEC                           \ HSE clock configuration bits, status bit and HSE_CSS security This bit is set and reset by software.
$00000004 constant RCC_RCC_SECCFGR_MSISEC                           \ MSI clock configuration and status bit security This bit is set and reset by software.
$00000008 constant RCC_RCC_SECCFGR_LSISEC                           \ LSI clock configuration and status bit security This bit is set and reset by software.
$00000010 constant RCC_RCC_SECCFGR_LSESEC                           \ LSE clock configuration and status bit security This bit is set and reset by software.
$00000020 constant RCC_RCC_SECCFGR_SYSCLKSEC                        \ SYSCLK clock selection, STOPWUCK bit, clock output on MCO configuration security This bit is set and reset by software.
$00000040 constant RCC_RCC_SECCFGR_PRESCSEC                         \ AHBx/APBx prescaler configuration bits security This bit is set and reset by software.
$00000080 constant RCC_RCC_SECCFGR_PLL1SEC                          \ PLL1 clock configuration and status bit security This bit is set and reset by software.
$00000100 constant RCC_RCC_SECCFGR_PLL2SEC                          \ PLL2 clock configuration and status bit security Set and reset by software.
$00000200 constant RCC_RCC_SECCFGR_PLL3SEC                          \ PLL3 clock configuration and status bit security This bit is set and reset by software.
$00000400 constant RCC_RCC_SECCFGR_ICLKSEC                          \ Intermediate clock source selection security This bit is set and reset by software.
$00000800 constant RCC_RCC_SECCFGR_HSI48SEC                         \ HSI48 clock configuration and status bit security This bit is set and reset by software.
$00001000 constant RCC_RCC_SECCFGR_RMVFSEC                          \ Remove reset flag security This bit is set and reset by software.


\
\ @brief RCC privilege configuration register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_PRIVCFGR_SPRIV                           \ RCC secure function privilege configuration This bit is set and reset by software. It can be written only by a secure privileged access.
$00000002 constant RCC_RCC_PRIVCFGR_NSPRIV                          \ RCC non-secure function privilege configuration This bit is set and reset by software. It can be written only by privileged access, secure or non-secure.


\
\ @brief Reset and clock control
\
$46020c00 constant RCC_RCC_CR     \ offset: 0x00 : RCC clock control register
$46020c08 constant RCC_RCC_ICSCR1  \ offset: 0x08 : RCC internal clock sources calibration register 1
$46020c0c constant RCC_RCC_ICSCR2  \ offset: 0x0C : RCC internal clock sources calibration register 2
$46020c10 constant RCC_RCC_ICSCR3  \ offset: 0x10 : RCC internal clock sources calibration register 3
$46020c14 constant RCC_RCC_CRRCR  \ offset: 0x14 : RCC clock recovery RC register
$46020c1c constant RCC_RCC_CFGR1  \ offset: 0x1C : RCC clock configuration register 1
$46020c20 constant RCC_RCC_CFGR2  \ offset: 0x20 : RCC clock configuration register 2
$46020c24 constant RCC_RCC_CFGR3  \ offset: 0x24 : RCC clock configuration register 3
$46020c28 constant RCC_RCC_PLL1CFGR  \ offset: 0x28 : RCC PLL1 configuration register
$46020c2c constant RCC_RCC_PLL2CFGR  \ offset: 0x2C : RCC PLL2 configuration register
$46020c30 constant RCC_RCC_PLL3CFGR  \ offset: 0x30 : RCC PLL3 configuration register
$46020c34 constant RCC_RCC_PLL1DIVR  \ offset: 0x34 : RCC PLL1 dividers register
$46020c38 constant RCC_RCC_PLL1FRACR  \ offset: 0x38 : RCC PLL1 fractional divider register
$46020c3c constant RCC_RCC_PLL2DIVR  \ offset: 0x3C : RCC PLL2 dividers configuration register
$46020c40 constant RCC_RCC_PLL2FRACR  \ offset: 0x40 : RCC PLL2 fractional divider register
$46020c44 constant RCC_RCC_PLL3DIVR  \ offset: 0x44 : RCC PLL3 dividers configuration register
$46020c48 constant RCC_RCC_PLL3FRACR  \ offset: 0x48 : RCC PLL3 fractional divider register
$46020c50 constant RCC_RCC_CIER   \ offset: 0x50 : RCC clock interrupt enable register
$46020c54 constant RCC_RCC_CIFR   \ offset: 0x54 : RCC clock interrupt flag register
$46020c58 constant RCC_RCC_CICR   \ offset: 0x58 : RCC clock interrupt clear register
$46020c60 constant RCC_RCC_AHB1RSTR  \ offset: 0x60 : RCC AHB1 peripheral reset register
$46020c64 constant RCC_RCC_AHB2RSTR1  \ offset: 0x64 : RCC AHB2 peripheral reset register 1
$46020c68 constant RCC_RCC_AHB2RSTR2  \ offset: 0x68 : RCC AHB2 peripheral reset register 2
$46020c6c constant RCC_RCC_AHB3RSTR  \ offset: 0x6C : RCC AHB3 peripheral reset register
$46020c74 constant RCC_RCC_APB1RSTR1  \ offset: 0x74 : RCC APB1 peripheral reset register 1
$46020c78 constant RCC_RCC_APB1RSTR2  \ offset: 0x78 : RCC APB1 peripheral reset register 2
$46020c7c constant RCC_RCC_APB2RSTR  \ offset: 0x7C : RCC APB2 peripheral reset register
$46020c80 constant RCC_RCC_APB3RSTR  \ offset: 0x80 : RCC APB3 peripheral reset register
$46020c88 constant RCC_RCC_AHB1ENR  \ offset: 0x88 : RCC AHB1 peripheral clock enable register
$46020c8c constant RCC_RCC_AHB2ENR1  \ offset: 0x8C : RCC AHB2 peripheral clock enable register 1
$46020c90 constant RCC_RCC_AHB2ENR2  \ offset: 0x90 : RCC AHB2 peripheral clock enable register 2
$46020c94 constant RCC_RCC_AHB3ENR  \ offset: 0x94 : RCC AHB3 peripheral clock enable register
$46020c9c constant RCC_RCC_APB1ENR1  \ offset: 0x9C : RCC APB1 peripheral clock enable register 1
$46020ca0 constant RCC_RCC_APB1ENR2  \ offset: 0xA0 : RCC APB1 peripheral clock enable register 2
$46020ca4 constant RCC_RCC_APB2ENR  \ offset: 0xA4 : RCC APB2 peripheral clock enable register
$46020ca8 constant RCC_RCC_APB3ENR  \ offset: 0xA8 : RCC APB3 peripheral clock enable register
$46020cb0 constant RCC_RCC_AHB1SMENR  \ offset: 0xB0 : RCC AHB1 peripheral clock enable in Sleep and Stop modes register
$46020cb4 constant RCC_RCC_AHB2SMENR1  \ offset: 0xB4 : RCC AHB2 peripheral clock enable in Sleep and Stop modes register 1
$46020cb8 constant RCC_RCC_AHB2SMENR2  \ offset: 0xB8 : RCC AHB2 peripheral clock enable in Sleep and Stop modes register 2
$46020cbc constant RCC_RCC_AHB3SMENR  \ offset: 0xBC : RCC AHB3 peripheral clock enable in Sleep and Stop modes register
$46020cc4 constant RCC_RCC_APB1SMENR1  \ offset: 0xC4 : RCC APB1 peripheral clock enable in Sleep and Stop modes register 1
$46020cc8 constant RCC_RCC_APB1SMENR2  \ offset: 0xC8 : RCC APB1 peripheral clocks enable in Sleep and Stop modes register 2
$46020ccc constant RCC_RCC_APB2SMENR  \ offset: 0xCC : RCC APB2 peripheral clocks enable in Sleep and Stop modes register
$46020cd0 constant RCC_RCC_APB3SMENR  \ offset: 0xD0 : RCC APB3 peripheral clock enable in Sleep and Stop modes register
$46020cd8 constant RCC_RCC_SRDAMR  \ offset: 0xD8 : RCC SmartRun domain peripheral autonomous mode register
$46020ce0 constant RCC_RCC_CCIPR1  \ offset: 0xE0 : RCC peripherals independent clock configuration register 1
$46020ce4 constant RCC_RCC_CCIPR2  \ offset: 0xE4 : RCC peripherals independent clock configuration register 2
$46020ce8 constant RCC_RCC_CCIPR3  \ offset: 0xE8 : RCC peripherals independent clock configuration register 3
$46020cf0 constant RCC_RCC_BDCR   \ offset: 0xF0 : RCC backup domain control register
$46020cf4 constant RCC_RCC_CSR    \ offset: 0xF4 : RCC control/status register
$46020d10 constant RCC_RCC_SECCFGR  \ offset: 0x110 : RCC secure configuration register
$46020d14 constant RCC_RCC_PRIVCFGR  \ offset: 0x114 : RCC privilege configuration register

