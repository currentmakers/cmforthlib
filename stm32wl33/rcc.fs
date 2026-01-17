\
\ @file rcc.fs
\ @brief Reset and Clock Controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RCC_DEF

  [ifdef] RCC_CR_DEF
    \
    \ @brief CR register
    \ Address offset: 0x00
    \ Reset value: 0x00001400
    \
    $02 constant RCC_LSION                      \ [0x02] Internal Low Speed oscillator enable Set and reset by software. Reset source only for this field: PORESETn 0: LSI RC oscillator OFF 1: LSI RC oscillator ON
    $03 constant RCC_LSIRDY                     \ [0x03] Internal Low Speed oscillator Ready Set and reset by hardware to indicate when the Low Speed Internal RC oscillator is stable. Reset source only for this field: PORESETn 0: LSI RC oscillator not ready 1: LSI RC oscillator ready
    $04 constant RCC_LSEON                      \ [0x04] External Low Speed Clock enable. Set and reset by software. Reset source only for this field: PORESETn 0: LSE oscillator OFF 1: LSE oscillator ON Note that enablng this bit, the configuration of PB12 and PB13 will be bypassed (whatever DFTMUX or AF selection)
    $05 constant RCC_LSERDY                     \ [0x05] External Low Speed Clock ready flag. Set by hardware to indicate that LSE oscillator is stable. 0: LSE oscillator not ready 1: LSE oscillator ready
    $06 constant RCC_LSEBYP                     \ [0x06] External Low Speed Clock bypass. Set and reset by software. Reset source only for this field: PORESETn 0: LSE oscillator bypass OFF 1: LSE oscillator bypass ON Note that enablng this bit, the configuration of PB13 will be bypassed (whatever DFTMUX or AF selection)
    $07 constant RCC_LOCKDET_NSTOP              \ [0x07 : 3] Lock detector Nstop value When start_stop signal is high; a counter is incremented every 16 MHz clock cycle. When the counter reaches (NSTOP+1) x 64 value, the lock_det signal is set high indicating that the PLL is locked. As soon as the start_stop signal is low the counter is reset to 0.
    $0a constant RCC_HSIRDY                     \ [0x0a] Internal High Speed clock ready flag. Set by hardware to indicate that internal RC 64MHz oscillator is stable. This bit is activated only if the RC is enabled by HSION (it is not activated if the RC is enabled by an IP request). 0: internal RC 64 MHz oscillator not ready 1: internal RC 64 MHz oscillator ready
    $0c constant RCC_HSEPLLBUFON                \ [0x0c] External High Speed Clock Buffer for PLL RF enable. Set and reset by software. 0: HSE PLL Buffer OFF 1: HSE PLL Buffer ON (default)
    $0d constant RCC_HSIPLLON                   \ [0x0d] Internal High Speed Clock PLL enable 0: PLL is OFF 1: PLL is ON
    $0e constant RCC_HSIPLLRDY                  \ [0x0e] Internal High Speed Clock PLL ready flag. 0: PLL is unlocked 1: PLL is locked
    $0f constant RCC_FMRAT                      \ [0x0f] Force MRSUBG accurate clock ready status (for debug purpose) 0: no effect 1: active_transmission is force to '1' whatever the HSIPLLRDY/HSE status
    $10 constant RCC_HSEON                      \ [0x10] External High Speed Clock enable. Set and reset by software. in low power mode, HSE is turned off. HSE is turned ON only when RFSUBG LDO is Ready 0: HSE oscillator OFF 1: HSE oscillator ON
    $11 constant RCC_HSERDY                     \ [0x11] External High Speed Clock ready flag. Set by hardware to indicate that HSE oscillator is stable. 0: HSE oscillator not ready 1: HSE oscillator ready
  [then]


  [ifdef] RCC_ICSCR_DEF
    \
    \ @brief ICSCR register
    \ Address offset: 0x04
    \ Reset value: 0x3F000000
    \
    $00 constant RCC_LSITRIMEN                  \ [0x00] Low Speed oscillator trimming enable Set and reset by software. Reset source only for this field: PORESETn 0: LSI oscillator Bias trimming disabled 1: LSI oscillator Bias trimming enabled
    $01 constant RCC_LSITRIMOK                  \ [0x01] LSITRIMOK: Low Speed oscillator trimming OK Set and reset by hardware to indicate when the Low Speed Internal RC oscillator has reached an optimal trimming of its bias current; this bit is only valid when LSITRIMEN is active. 0: LSI Bias trimming (LSIBW) is not good 1: LSI Bias trimming (LSIBW) value is OK
    $02 constant RCC_LSIBW                      \ [0x02 : 4] Trimming in test mode The value stored is the correspondent Engi Byte and represents the actual value driving the input of the hardware macro. This value is loaded soon after the completion of the Option Byte Loading procedure. This field is directly writeable only in Test Mode.
    $10 constant RCC_HSITRIMOFFSET              \ [0x10 : 3] ICSCR[18:16] = HSITRIMOFFSET[2:0]: High Speed oscillator signed trimming offset 000: 0 (+ 0 MHz / default) 001: 1 (-0.5 MHz) 010: 2 (-1MHz) 011: 3 (-1.5 MHz) 100: -1 (+2 MHz) 101: -2 (+1.5MHz) 110: -3 (+1 MHz) 111: -4 (+0.5 MHz)
    $18 constant RCC_HSITRIM                    \ [0x18 : 6] High Speed Internal clock trimming. This value is loaded soon after the completion of the Option Byte Loading procedure. When max value 0x3f is set, HSI is less than 64MHz
  [then]


  [ifdef] RCC_CFGR_DEF
    \
    \ @brief CFGR register
    \ Address offset: 0x08
    \ Reset value: 0x00000240
    \
    $01 constant RCC_HSESEL                     \ [0x01] Clock source selection request: 0: HSI clock source is requested (default) 1: HSE clock source is requested
    $02 constant RCC_STOPHSI                    \ [0x02] Stop HSI clock source request 0: HSI is enabled (default) 1: disable HSI is requested
    $03 constant RCC_HSESEL_STATUS              \ [0x03] Clock source selection Status 0: HSI clock source is selected 1: HSE clock source is selected Mirror the actual system clock source, depending on clock switching mechanism and limitations
    $05 constant RCC_CLKSYSDIV                  \ [0x05 : 3] system clock frequency selection request 000: div1 (HSI 64M / HSE 48M) 001: div2 (HSI 32M / HSE 24M) 010: div4/div3 (HSI/HSE) (16M) 011: div8/div6 (HSI/HSE) (8M) * 100: div16/div12 (HSI/HSE) (4M) * 101: div32/div24 (HSI/HSE) (2M) * 110: div64/div48 (HSI/HSE) (1M) * Note: behavior depends on depending on CFGR.HSESEL and (*) APB2ENR.MRSUBGEN or LPAWUREN register
    $08 constant RCC_CLKSYSDIV_STATUS           \ [0x08 : 3] system clock frequency selection status 000: div1 (HSI 64M / HSE 48M) 001: div2 (HSI 32M / HSE 24M) 010: div4/div3 (HSI/HSE) (16M) 011: div8/div6 (HSI/HSE) (8M) 100: div16/div12 (HSI/HSE) (4M) 101: div32/div24 (HSI/HSE) (2M) 110: div64/div48 (HSI/HSE) (1M) Note: behavior depends on depending on CFGR.HSESEL and APB2ENR.MRSUBGEN register
    $0c constant RCC_SMPSDIV                    \ [0x0c] SMPS clock prescaling factor to generate 4MHz or 8MHz 0: SMPS clock 8MHz (default ) 1: SMPS clock 4MHz
    $0d constant RCC_LPUCLKSEL                  \ [0x0d] LPUCLKSEL: Selection of LPUART clock 0: 16 MHz peripheral clock (default) 1: LSE clock (Mandatory in LPUART deepstop mode)
    $0f constant RCC_CLKSLOWSEL                 \ [0x0f : 2] slow clock source selection Set by software to select the clock source. This is no glitch free mechanism Reset source only for this field: PORESETn 00: '0' (default) 01: LSE oscillator clock used as slow clock 10: LSI oscillator clock used as slow clock 11:HSI_64M divided by 2048 used as slow clock
    $11 constant RCC_IOBOOSTEN                  \ [0x11] IOBOOSTEN: IO BOOSTER enable 0: IO BOOSTER block is disabled 1: IO BOOSTER block is enabled.
    $13 constant RCC_LCOEN                      \ [0x13] LCOEN: LCO enable on PA10 also in deepstop. 0: LCO output on PA10 is disabled 1: LCO output on PA10 is enabled.
    $16 constant RCC_SPI3I2SCLKSEL              \ [0x16 : 2] SPI3I2SCLKSEL: Selection of I2S clock for SPI3 IP. 00: 32 MHz peripheral clock (default) 01: 16 MHz peripheral clock 10: CLK_SYS 11: CLK_SYS Note: the I2S clock frequency must be higher or equal to the system clock (configured through RCC_CFGR.CLKSYSDIV[2:0] bit field).
    $18 constant RCC_LCOSEL                     \ [0x18 : 2] Low speed Configurable Clock Output Selection. Set and reset by software. Glitches propagation possible. Reset source only for this field: PORESETn 00: LCO output disabled, no clock on LCO 01: not used 10: internal 32 KHz (LSI) oscillator clock selected 11: external 32 KHz (LSE) oscillator clock selected
    $1a constant RCC_MCOSEL                     \ [0x1a : 3] Main Configurable Clock Output Selection. Set and reset by software. Glitches propagation possible. 000: MCO output disabled, no clock on MCO 001: system clock selected 010: na 011: internal RC 64 MHz (HSI) oscillator clock selected 100: external oscillator (HSE) clock selected 101: internal RC 64 MHz (HSI) oscillator divided by 2048 and used as slow clock selected 110: SMPS clock selected 111: AUX ADC ANA clock selected
    $1d constant RCC_CCOPRE                     \ [0x1d : 3] Configurable Clock Output Prescaler. Set and reset by software. Glitches propagation if CCOPRE is modified after CCO output is enabled. 000: CCO clock is divided by 1 001: CCO clock is divided by 2 010: CCO clock is divided by 4 011: CCO clock is divided by 8 100: CCO clock is divided by 16 101: CCO clock is divided by 32 Others: not used
  [then]


  [ifdef] RCC_CSSWCR_DEF
    \
    \ @brief CSSWCR register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSISWTRIMEN                \ [0x00] Low Speed oscillator trimming by SW enable Set and reset by software. Reset source only for this field: PORESETn 0: LSI oscillator Bias trimming by SW disabled 1: LSI oscillator Bias trimming by SW enabled
    $01 constant RCC_LSISWBW                    \ [0x01 : 4] Low Speed Internal clock trimming value to set by SW Reset source only for this field: PORESETn
    $05 constant RCC_LSEDRV                     \ [0x05 : 2] Maximum Crystal gm for Low Speed External XO (to connect to XTDRV of 32kHz LSE XO => into IO V33?) to amplify drinving capacity modulation Set by software. Reset source only for this field: PORESETn 00: 0.0, low drive capability 01: 0.1, medium low drive capability 10: 1.0, medium high drive capability 11: 1.1, highdrive capability
    $17 constant RCC_HSISWTRIMEN                \ [0x17] High Speed oscillator trimming by SW enable Set and reset by software. 0: HSI oscillator Bias trimming by SW disabled 1: HSI oscillator Bias trimming by SW enabled
    $18 constant RCC_HSITRIMSW                  \ [0x18 : 6] High Speed Internal clock trimming value to set by SW.
  [then]


  [ifdef] RCC_KRMR_DEF
    \
    \ @brief KRMR register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RCC_KRM_EN                     \ [0x00] KRM_EN: Variable rate multiplier Enable Reset source only for this field: PORESETn 0: KRM is disabled (default) 1: KRM is enabled.
    $01 constant RCC_KRM                        \ [0x01 : 5] KRM[4:0] :SMPS clock dividing Ratio (CLK_SPMS_KRM frequency= CLK_ROOT frequency (depending on RCC_CFGR.HSESEL) divided by KRM when KRMEN=1) Reset source only for this field: PORESETn - 0x00 to 0x08: SMPS clock frequency equals CLK_ROOT/8 (8.00 MHz / 6.00 MHz) - 0x09: SMPS clock frequency equals CLK_ROOT/9 (7.11 MHz / 5.33 MHz) - 0x0A: SMPS clock frequency equals CLK_ROOT/10 (6.40 MHz / 4.80 MHz) - 0x0B: SMPS clock frequency equals CLK_ROOT/11 (5.82 MHz / 4.36 MHz) - 0x0C: SMPS clock frequency equals CLK_ROOT/12 (5.33 MHz / 4.00 MHz) - 0x0D: SMPS clock frequency equals CLK_ROOT/13 (4.92 MHz / 3.69 MHz) - 0x0E: SMPS clock frequency equals CLK_ROOT/14 (4.57 MHz / 3.43 MHz) - 0x0F: SMPS clock frequency equals CLK_ROOT/15 (4.27 MHz / 3.20 MHz) - 0x10: SMPS clock frequency equals CLK_ROOT/16 (4.00 MHz / 3.00 MHz) - 0x1x: Reserved Note: SMPS clock frequency must be selected in a range [4-8] MHz (depending on RCC_KRMR.KRM and RCC_CFGR.HSESEL).
  [then]


  [ifdef] RCC_CIER_DEF
    \
    \ @brief CIER register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by internal RC 32 kHz oscillator stabilization. 0: LSI ready interrupt disabled 1: LSI ready interrupt enabled
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the external 32 kHz oscillator stabilization. 0: LSE ready interrupt disabled 1: LSE ready interrupt enabled
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the internal RC 64MHz oscillator stabilization. 0: HSI ready interrupt disabled 1: HSI ready interrupt enabled
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE Ready Interrupt Enable Set and reset by software to enable/disable interrupt caused by the external HSE oscillator stabilization. 0: HSE ready interrupt disabled 1: HSE ready interrupt enabled
    $05 constant RCC_HSIPLLRDYIE                \ [0x05] HSI PLL Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the HSI 64MHz PLL locked on HSE. 0: HSI PLL ready interrupt disabled 1: HSI PLL ready interrupt enabled
    $06 constant RCC_HSIPLLUNLOCKDETIE          \ [0x06] HSIPLLUNLOCKDETIE: HSI PLL unlock detection Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the HSI 64MHz PLL unlock. 0: HSI PLL unlock detection interrupt disabled 1: HSI PLL unlock detection interrupt enabled
    $07 constant RCC_RTCRSTIE                   \ [0x07] RTCRSTIE: RTC reset end Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the RTC reset end. 0: HSI PLL unlock detection interrupt disabled 1: HSI PLL unlock detection interrupt enabled
    $08 constant RCC_WDGRSTIE                   \ [0x08] WDGRSTIE: Watchdog reset end Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the watchdog reset end. 0: interrupt disabled 1: interrupt enabled
    $09 constant RCC_LPURSTIE                   \ [0x09] LPURSTIE: LPUART reset end Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the LPUART reset end. 0: interrupt disabled 1: interrupt enabled
    $0a constant RCC_LCDRSTIE                   \ [0x0a] LCDRSTIE: LCD reset end Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the LCD reset end. 0: interrupt disabled 1: interrupt enabled
    $0d constant RCC_LCSCRSTIE                  \ [0x0d] LCSCRSTIE: LCSC reset release interrupt enable. 0: LCSC reset release interrupt is disabled. 1: LCSC reset release interrupt is enabled.
  [then]


  [ifdef] RCC_CIFR_DEF
    \
    \ @brief CIFR register
    \ Address offset: 0x1C
    \ Reset value: 0x00000008
    \
    $00 constant RCC_LSIRDYIF                   \ [0x00] LSI Ready Interrupt flag Set by hardware when LSI clock becomes stable. 0: No clock ready interrupt caused by the internal RC 32 KHz oscillator 1: Clock ready interrupt caused by the internal RC 32 kHz oscillator
    $01 constant RCC_LSERDYIF                   \ [0x01] LSE Ready Interrupt Flag. Set by hardware when LSE clock becomes stable. 0: No clock ready interrupt caused by the LSE oscillator 1: Clock ready interrupt caused by the LSE oscillator
    $03 constant RCC_HSIRDYIF                   \ [0x03] HSI Ready Interrupt Flag. Set by hardware when HSI becomes stable. 0: No clock ready interrupt caused by the HSI oscillator 1: Clock ready interrupt caused by the HSI oscillator
    $04 constant RCC_HSERDYIF                   \ [0x04] HSE Ready Interrupt Flag. Set by hardware when HSE becomes stable. 0: No clock ready interrupt caused by the HSE oscillator 1: Clock ready interrupt caused by the HSE oscillator
    $05 constant RCC_HSIPLLRDYIF                \ [0x05] HSI PLL Ready Interrupt Flag. Set by hardware when HSI PLL 64MHz becomes stable. 0: No clock ready interrupt caused by the HSI PLL64 MHz oscillator 1: Clock ready interrupt caused by the HSI PLL64 MHz oscillator
    $06 constant RCC_HSIPLLUNLOCKDETIF          \ [0x06] HSIPLLUNLOCKDETIF: HSI PLL unlock detection Interrupt Flag.
    $07 constant RCC_RTCRSTIF                   \ [0x07] RTC reset end Interrupt Flag. Raised when reset is released on 32kHz clock
    $08 constant RCC_WDGRSTIF                   \ [0x08] WDG reset end Interrupt Flag. Raised when reset is released on 32kHz clock
    $09 constant RCC_LPURSTIF                   \ [0x09] LPUART reset end Interrupt Flag. Raised when reset is released on 32kHz clock
    $0a constant RCC_LCDRSTIF                   \ [0x0a] LCD reset end Interrupt Flag. Raised when reset is released on 32kHz clock
    $0d constant RCC_LCSCRSTIF                  \ [0x0d] LCSC reset end Interrupt Flag. Raised when reset is released on 32kHz clock
  [then]


  [ifdef] RCC_CSCMDR_DEF
    \
    \ @brief CSCMDR register
    \ Address offset: 0x20
    \ Reset value: 0x00000080
    \
    $00 constant RCC_REQUEST                    \ [0x00] Request for system clock switching Cleared by hardware when system clock frequency switch is done 0: To cancel an ongiong request - still possible until IRQ assertion 1: To update the system clock frequency
    $01 constant RCC_CLKSYSDIV_REQ              \ [0x01 : 3] system clock frequency selection request 000: div1 (HSI 64M / HSE) (48M) 001: div2 (HSI 32M / HSE (24M*) 010: div4/div3 (HSI/HSE) (16M) 011: div8/div6 (HSI/HSE) (8M) * 100: div16/div12 (HSI/HSE) (4M) * 101: div32/div24 (HSI/HSE) (2M) * 110: div64/div48 (HSI/HSE) (1M) * Note: behavior depends on depending on CFGR.HSESEL and (*) APB2ENR.MRSUBGEN or LPAWUREN
    $04 constant RCC_STATUS                     \ [0x04 : 2] Status of clock switch sequence 00: IDLE no switch requested 01: ONGOING clock frequency switch is ongoing 10: DONE clock frequency switch done 11: Reserved
    $06 constant RCC_EOFSEQ_IE                  \ [0x06] End of sequence Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the clock system switch. 0: End of sequence interrupt disabled 1: End of sequence interrupt enabled
    $07 constant RCC_EOFSEQ_IRQ                 \ [0x07] End of Sequence flag Set by hardware when clock system swtich is ended 0: No end of sequence event occured 1: End of sequece event occured
  [then]


  [ifdef] RCC_AHBRSTR_DEF
    \
    \ @brief AHBRSTR register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMARST                     \ [0x00] DMA and DMAMUX reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
    $02 constant RCC_GPIOARST                   \ [0x02] GPIOA reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
    $03 constant RCC_GPIOBRST                   \ [0x03] GPIOB reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
    $0c constant RCC_CRCRST                     \ [0x0c] CRC reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
    $12 constant RCC_RNGRST                     \ [0x12] RNG reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
    $14 constant RCC_AESRST                     \ [0x14] AES reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
  [then]


  [ifdef] RCC_APB0RSTR_DEF
    \
    \ @brief APB0RSTR register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2RST: TIM2 reset. 0: TIM2 IP is not under reset. 1: TIM2 IP is under reset.
    $01 constant RCC_TIM16RST                   \ [0x01] TIM16RST: TIM16 reset. 0: TIM16 IP is not under reset. 1: TIM16 IP is under reset.
    $08 constant RCC_SYSCFGRST                  \ [0x08] SYSCFGRST: system controller reset. 0: system controller IP is not under reset. 1: system controller IP is under reset.
    $09 constant RCC_LCDCRST                    \ [0x09] LCDCRST: LCD controller reset. 0: LCD controller IP is not under reset. 1: LCD controller IP is under reset.
    $0a constant RCC_COMPRST                    \ [0x0a] COMPRST: COMP reset. 0: COMP IP is not under reset. 1: COMP IP is under reset.
    $0b constant RCC_DACRST                     \ [0x0b] DACRST: DAC reset. 0: DAC IP is not under reset. 1: DAC IP is under reset.
    $0c constant RCC_RTCRST                     \ [0x0c] RTCRST: RTC reset. 0: RTC IP is not under reset. 1: RTC IP is under reset.
    $0d constant RCC_LCSCRST                    \ [0x0d] LCSCRST: LCSC reset. 0: LCSC IP is not under reset. 1: LCSC IP is under reset.
    $0e constant RCC_WDGRST                     \ [0x0e] WDGRST: Watchdog reset. 0: Watchdog IP is not under reset. 1: Watchdog IP is under reset.
    $0f constant RCC_DBGMCURST                  \ [0x0f] DBGMCURST: DBGMCU reset. 0: DBGMCU IP is not under reset. 1: DBGMCU IP is under reset.
  [then]


  [ifdef] RCC_APB1RSTR_DEF
    \
    \ @brief APB1RSTR register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI1RST                    \ [0x00] SPI1 reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
    $04 constant RCC_ADCRST                     \ [0x04] ADC reset for Aux-ADC IP Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
    $08 constant RCC_LPUARTRST                  \ [0x08] LPUART reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
    $0a constant RCC_USARTRST                   \ [0x0a] USART reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
    $0e constant RCC_SPI3RST                    \ [0x0e] SPI3 reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
    $17 constant RCC_I2C2RST                    \ [0x17] I2C2 reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
  [then]


  [ifdef] RCC_APB2RSTR_DEF
    \
    \ @brief APB2RSTR register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MRSUBGRST                  \ [0x00] Radio MRSUBG reset. Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
    $03 constant RCC_LPAWURRST                  \ [0x03] Bubble reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
  [then]


  [ifdef] RCC_AHBENR_DEF
    \
    \ @brief AHBENR register
    \ Address offset: 0x50
    \ Reset value: 0x0000000C
    \
    $00 constant RCC_DMAEN                      \ [0x00] DMA and DMAMUX enable Set and enable by software. 0: does not enable 1: enable
    $02 constant RCC_GPIOAEN                    \ [0x02] GPIOA enable. It must be enabled by default
    $03 constant RCC_GPIOBEN                    \ [0x03] GPIOB enable. It must be enabled by default
    $0c constant RCC_CRCEN                      \ [0x0c] CRC enable Set and enable by software. 0: does not enable 1: enable
    $12 constant RCC_RNGEN                      \ [0x12] RNG clock enable Set and enable by software. 0: does not enable 1: enable
    $14 constant RCC_AESEN                      \ [0x14] AESEN: AES clock enable. 0: AES IP is clock gated. 1: AES IP is clocked.
  [then]


  [ifdef] RCC_APB0ENR_DEF
    \
    \ @brief APB0ENR register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2: Advanced Timer clock enable Set and enable by software. 0: clock disable 1: clock enable
    $01 constant RCC_TIM16EN                    \ [0x01] TIM16: Advanced Timer clock enable Set and enable by software. 0: clock disable 1: clock enable
    $08 constant RCC_SYSCFGEN                   \ [0x08] SYSTEM CONFIG clock enable Set and enable by software. 0: clock disable 1: clock enable
    $09 constant RCC_LCDEN                      \ [0x09] LCD clock enable Set and enable by software. 0: clock disable 1: clock enable
    $0a constant RCC_COMPEN                     \ [0x0a] COMP clock enable Set and enable by software. 0: clock disable 1: clock enable
    $0b constant RCC_DACEN                      \ [0x0b] DAC clock enable Set and enable by software. 0: clock disable 1: clock enable
    $0c constant RCC_RTCEN                      \ [0x0c] RTC clock enable Set and enable by software. Reset source only for this field: PORESETn 0: clock disable 1: clock enable
    $0d constant RCC_LCSCEN                     \ [0x0d] LCSC clock enable. Set and enable by software. 0: clock disable 1: clock enable
    $0e constant RCC_WDGEN                      \ [0x0e] Watchdog clock enable. Set and enable by software. 0: clock disable 1: clock enable
    $0f constant RCC_DBGMCUEN                   \ [0x0f] DBG MCU clock enable. Set and enable by software. 0: clock disable 1: clock enable
  [then]


  [ifdef] RCC_APB1ENR_DEF
    \
    \ @brief APB1ENR register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI1EN                     \ [0x00] SPI1 clock enable Set and enable by software. 0: clock disable 1: clock enable
    $04 constant RCC_ADCDIGEN                   \ [0x04] AUXADC clock enable for Aux-ADC digital clock Set and enable by software. 0: clock disable 1: clock enable
    $05 constant RCC_ADCANAEN                   \ [0x05] ADC clock enable for Aux-ADC analog clock Set and enable by software. 0: clock disable 1: clock enable
    $08 constant RCC_LPUARTEN                   \ [0x08] LPUART clock enable Set and enable by software. 0: clock disable 1: clock enable
    $0a constant RCC_USARTEN                    \ [0x0a] USART clock enable Set and enable by software. 0: clock disable 1: clock enable
    $0e constant RCC_SPI3EN                     \ [0x0e] SPI3 clock enable Set and enable by software. 0: clock disable 1: clock enable
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 clock enable Set and enable by software. 0: clock disable 1: clock enable
    $17 constant RCC_I2C2EN                     \ [0x17] I2C2 clock enable Set and enable by software. 0: clock disable 1: clock enable
  [then]


  [ifdef] RCC_APB2ENR_DEF
    \
    \ @brief APB2ENR register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MRSUBGEN                   \ [0x00] MRSUBG clock enable. Note: when this bit is '1', it must prevent clk_sys different from 16, 32, 64. If the configured clock is lower than 16MHz (1, 2, 4 or 8 MHz) or equal to 24MHz, clk_sys must be 16MHz 0: clock disable 1: clock enable
    $03 constant RCC_LPAWUREN                   \ [0x03] Bubble clock enable Set and enable by software. 0: clock disable 1: clock enable
  [then]


  [ifdef] RCC_DBGR_DEF
    \
    \ @brief DBGR register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $13 constant RCC_DBGHSIOFF                  \ [0x13] used for debug or test 0: No effect (default) 1: HSI forced off.
    $14 constant RCC_DBGBYPHSI                  \ [0x14] used for debug mode with HSI bypassed by HSE 0: No effect (default) 1: HSI bypassed HSE.
    $15 constant RCC_DBGXOEXT                   \ [0x15] used for debug mode with HSE bypassed by FXTAL_IN clock and ZIV12 output used. 0: No effect (default) 1: HSE bypassed by FXTAL_IN clock and ZIV12 output used.
    $16 constant RCC_FORCEXO48MREADY            \ [0x16] FORCEXO48MREADY Force XO48M Ready input signal This bit is for debug and force the XO48M ready input, in order to bypass XO48M comparators. 0: No effect (default) 1: Force XOREADY=1
  [then]


  [ifdef] RCC_CSR_DEF
    \
    \ @brief CSR register
    \ Address offset: 0x94
    \ Reset value: 0x0C000000
    \
    $17 constant RCC_RMVF                       \ [0x17] Remove reset flag Set by software to clear the value of the reset flags. It auto clears by HW after clearing reason flags 0: Nothing done 1: Reset the value of the reset flags
    $1a constant RCC_PADRSTF                    \ [0x1a] SYSTEM reset flag Reset by software by writing the RMVF bit. Set by hardware when a reset from pad occurs. 0: No reset from pad occurred 1: Reset from pad occurred
    $1b constant RCC_PORRSTF                    \ [0x1b] POWER reset flag Reset by software by writing the RMVF bit. Set by hardware when a power reset occurs from LPMURESET block. 0: No POWER reset occurred 1: POWER reset occurred
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag Reset by software by writing the RMVF bit. Set by hardware when a software reset occurs. 0: No software reset occurred 1: Software reset occurred
    $1d constant RCC_WDGRSTF                    \ [0x1d] Watchdog reset flag Reset by software by writing the RMVF bit. Set by hardware when a watchdog reset from V33 domain occurs. 0: No watchdog reset occurred 1: Watchdog reset occurred
    $1e constant RCC_LOCKUPRSTF                 \ [0x1e] LOCK UP reset flag from CM0 Reset by software by writing the RMVF bit. Set by hardware from unrecoverable exception CPU. It reset V12i domain, FLASH controller and peripherals. 0: No lockup reset occurred 1: lockup reset occurred
  [then]


  [ifdef] RCC_RFSWHSECR_DEF
    \
    \ @brief RFSWHSECR register
    \ Address offset: 0x98
    \ Reset value: 0x0000803F
    \
    $00 constant RCC_GMC                        \ [0x00 : 7] GMC[6:5]: High speed external XO current control reference 00: 10 uA 01: 20 uA 1x: 40 uA GMC[4:0]: High speed external XO current control multiplying factor IcoreHSE= GMC[4:0] * GMC[6:5] Example: GMC[6:0]=0x1111001 -> IcoreHSE=25*40uA / Default 3F: IcoreHSE= 10uA x 31 = 310uA Note: this value is set only by software.
    $07 constant RCC_SWXOTUNEEN                 \ [0x07] RF-HSE capacitor bank tuning by SW enable Set by software
    $08 constant RCC_SWXOTUNE                   \ [0x08 : 6] RF-HSE capacitor bank tuning value by SW Set by software
    $0e constant RCC_ISTARTUP                   \ [0x0e : 2] RF-HSE Startup current Set by software Default value 2
    $10 constant RCC_AMPLTHRESH                 \ [0x10 : 3] RF-HSE Amplitude Control threshold Set by software Default value 0
  [then]


  [ifdef] RCC_RFHSECR_DEF
    \
    \ @brief RFHSECR register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_XOTUNE                     \ [0x00 : 6] RF-HSE capacitor bank tuning Set by option byte loading soon after Power On Reset.
    $06 constant RCC_AMPLREADY                  \ [0x06] RF-HSE Amplitude Control Ready output
  [then]


  [ifdef] RCC_AHBSMENR_DEF
    \
    \ @brief AHBSMENR register
    \ Address offset: 0xA0
    \ Reset value: 0x0014160F
    \
    $00 constant RCC_DMASMEN                    \ [0x00] DMA clock enable during Sleep mode bit This bit is set and reset by software. - 0: DMA clock disabled in Sleep mode - 1: DMA clock enabled in Sleep mode (if enabled in DMAEN)
    $01 constant RCC_FLASHSMEN                  \ [0x01] Flash clocks enable during Flash Sleep PD and CPU Sleep mode bit This bit is set and reset by software. - 0: Flash clocks are disabled in Flash Sleep PD* and CPU Sleep mode - 1: Flash clocks are enabled in Sleep mode Note: Flash Sleep PD is enabled through nvm_control register CONFIG.SLEEP_PD
    $02 constant RCC_GPIOASMEN                  \ [0x02] GPIOA clock enable during Sleep mode bit This bit is set and reset by software. - 0: GPIOA clock disabled in Sleep mode - 1: GPIOA clock enabled in Sleep mode (if enabled by GPIOAEN)
    $03 constant RCC_GPIOBSMEN                  \ [0x03] GPIOB clock enable during Sleep mode bit This bit is set and reset by software. - 0: GPIOB clock disabled in Sleep mode - 1: GPIOB clock enabled in Sleep mode (if enabled in GPIOBEN)
    $09 constant RCC_SRAM0SMEN                  \ [0x09] SRAM0 clock enable during Sleep mode bit This bit is set and reset by software. - 0: SRAM0 clock disabled in Sleep mode - 1: SRAM0 clock enabled in Sleep mode
    $0a constant RCC_SRAM1SMEN                  \ [0x0a] SRAM1 clock enable during Sleep mode bit This bit is set and reset by software. - 0: SRAM1 clock disabled in Sleep mode - 1: SRAM1 clock enabled in Sleep mode
    $0c constant RCC_CRCSMEN                    \ [0x0c] CRC clock enable during Sleep mode bit This bit is set and reset by software. - 0: CRC clock disabled in Sleep mode - 1: CRC clock enabled in Sleep mode (if enabled in CRCEN)
    $12 constant RCC_RNGSMEN                    \ [0x12] RNG bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: RNG bus clock disabled in Sleep mode - 1: RNG bus clock enabled in Sleep mode (if enabled in RNGEN)
    $14 constant RCC_AESSMEN                    \ [0x14] AES bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: AES bus clock disabled in Sleep mode - 1: AES bus clock enabled in Sleep mode (if enabled in AESEN)
  [then]


  [ifdef] RCC_APB0SMENR_DEF
    \
    \ @brief APB0SMENR register
    \ Address offset: 0xA4
    \ Reset value: 0x0000FF03
    \
    $00 constant RCC_TIM2SMEN                   \ [0x00] TIM2 bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: TIM2 bus clock disabled in Sleep mode - 1: TIM2 bus clock enabled in Sleep mode (if enabled in TIM2EN)
    $01 constant RCC_TIM16SMEN                  \ [0x01] TIM16 bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: TIM16 bus clock disabled in Sleep mode - 1: TIM16 bus clock enabled in Sleep mode (if enabled in TIM16EN)
    $08 constant RCC_SYSCFGSMEN                 \ [0x08] SYSCFG bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: SYSCFG bus clock disabled in Sleep mode - 1: SYSCFG bus clock enabled in Sleep mode (if enabled in SYSCFGEN)
    $09 constant RCC_LCDCSMEN                   \ [0x09] LCDC bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: LCDC bus clock disabled in Sleep mode - 1: LCDC bus clock enabled in Sleep mode (if enabled in LCDCEN)
    $0a constant RCC_COMPSMEN                   \ [0x0a] COMP bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: COMP bus clock disabled in Sleep mode - 1: COMP bus clock enabled in Sleep mode (if enabled in COMPEN)
    $0b constant RCC_DACSMEN                    \ [0x0b] DAC bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: DAC bus clock disabled in Sleep mode - 1: DAC bus clock enabled in Sleep mode (if enabled in DACEN)
    $0c constant RCC_RTCSMEN                    \ [0x0c] RTC bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: RTC bus clock disabled in Sleep mode - 1: RTC bus clock enabled in Sleep mode (if enabled in RTCEN)
    $0d constant RCC_LCSCSMEN                   \ [0x0d] LCSC bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: LCSC bus clock disabled in Sleep mode - 1: LCSC bus clock enabled in Sleep mode (if enabled in LCSCEN)
    $0e constant RCC_WDGSMEN                    \ [0x0e] WDG clock enable during Sleep mode bit This bit is set and reset by software. - 0: WDG clock disabled in Sleep mode - 1: WDG clock enabled in Sleep mode (if enabled in WDGEN)
    $0f constant RCC_DBGMCUSMEN                 \ [0x0f] DBGMCU clock enable during Sleep mode bit This bit is set and reset by software. - 0: DBGMCU clock disabled in Sleep mode - 1: DBGMCU clock enabled in Sleep mode (if enabled in DBGMCUEN)
  [then]


  [ifdef] RCC_APB1SMENR_DEF
    \
    \ @brief APB1SMENR register
    \ Address offset: 0xA8
    \ Reset value: 0x00A04511
    \
    $00 constant RCC_SPI1SMEN                   \ [0x00] SPI1 bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: SPI1 bus clock disabled in Sleep mode - 1: SPI1 bus clock enabled in Sleep mode (if enabled in SPI1EN)
    $04 constant RCC_ADCDIGSMEN                 \ [0x04] ADCDIG bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: ADCDIG bus clock disabled in Sleep mode - 1: ADCDIG bus clock enabled in Sleep mode (if enabled by ADCDIGEN)
    $08 constant RCC_LPUARTSMEN                 \ [0x08] LPUART bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: LPUART bus clock disabled in Sleep mode - 1: LPUART bus clock enabled in Sleep mode (if enabled in LPUARTEN)
    $0a constant RCC_USARTSMEN                  \ [0x0a] USART bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: USART bus clock disabled in Sleep mode - 1: USART bus clock enabled in Sleep mode (if enabled in USARTEN)
    $0e constant RCC_SPI3SMEN                   \ [0x0e] SPI3 bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: SPI3 bus clock disabled in Sleep mode - 1: SPI3 bus clock enabled in Sleep mode (if enabled in SPI3EN)
    $15 constant RCC_I2C1SMEN                   \ [0x15] I2C1 clock enable during Sleep mode bit This bit is set and reset by software. - 0: I2C1 clock disabled in Sleep mode - 1: I2C1 clock enabled in Sleep mode (if enabled in I2C1EN)
    $17 constant RCC_I2C2SMEN                   \ [0x17] I2C2 clock enable during Sleep mode bit This bit is set and reset by software. - 0: I2C2 clock disabled in Sleep mode - 1: I2C2 clock enabled in Sleep mode (if enabled in I2C2EN)
  [then]

  \
  \ @brief Reset and Clock Controller
  \
  $00 constant RCC_CR                   \ CR register
  $04 constant RCC_ICSCR                \ ICSCR register
  $08 constant RCC_CFGR                 \ CFGR register
  $0C constant RCC_CSSWCR               \ CSSWCR register
  $10 constant RCC_KRMR                 \ KRMR register
  $18 constant RCC_CIER                 \ CIER register
  $1C constant RCC_CIFR                 \ CIFR register
  $20 constant RCC_CSCMDR               \ CSCMDR register
  $30 constant RCC_AHBRSTR              \ AHBRSTR register
  $34 constant RCC_APB0RSTR             \ APB0RSTR register
  $38 constant RCC_APB1RSTR             \ APB1RSTR register
  $40 constant RCC_APB2RSTR             \ APB2RSTR register
  $50 constant RCC_AHBENR               \ AHBENR register
  $54 constant RCC_APB0ENR              \ APB0ENR register
  $58 constant RCC_APB1ENR              \ APB1ENR register
  $60 constant RCC_APB2ENR              \ APB2ENR register
  $80 constant RCC_DBGR                 \ DBGR register
  $94 constant RCC_CSR                  \ CSR register
  $98 constant RCC_RFSWHSECR            \ RFSWHSECR register
  $9C constant RCC_RFHSECR              \ RFHSECR register
  $A0 constant RCC_AHBSMENR             \ AHBSMENR register
  $A4 constant RCC_APB0SMENR            \ APB0SMENR register
  $A8 constant RCC_APB1SMENR            \ APB1SMENR register

: RCC_DEF ; [then]
