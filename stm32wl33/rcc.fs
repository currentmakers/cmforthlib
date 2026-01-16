\
\ @file rcc.fs
\ @brief Reset and Clock Controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CR register
\ Address offset: 0x00
\ Reset value: 0x00001400
\

$00000004 constant RCC_CR_LSION                                     \ Internal Low Speed oscillator enable Set and reset by software. Reset source only for this field: PORESETn 0: LSI RC oscillator OFF 1: LSI RC oscillator ON
$00000008 constant RCC_CR_LSIRDY                                    \ Internal Low Speed oscillator Ready Set and reset by hardware to indicate when the Low Speed Internal RC oscillator is stable. Reset source only for this field: PORESETn 0: LSI RC oscillator not ready 1: LSI RC oscillator ready
$00000010 constant RCC_CR_LSEON                                     \ External Low Speed Clock enable. Set and reset by software. Reset source only for this field: PORESETn 0: LSE oscillator OFF 1: LSE oscillator ON Note that enablng this bit, the configuration of PB12 and PB13 will be bypassed (whatever DFTMUX or AF selection)
$00000020 constant RCC_CR_LSERDY                                    \ External Low Speed Clock ready flag. Set by hardware to indicate that LSE oscillator is stable. 0: LSE oscillator not ready 1: LSE oscillator ready
$00000040 constant RCC_CR_LSEBYP                                    \ External Low Speed Clock bypass. Set and reset by software. Reset source only for this field: PORESETn 0: LSE oscillator bypass OFF 1: LSE oscillator bypass ON Note that enablng this bit, the configuration of PB13 will be bypassed (whatever DFTMUX or AF selection)
$00000380 constant RCC_CR_LOCKDET_NSTOP                             \ Lock detector Nstop value When start_stop signal is high; a counter is incremented every 16 MHz clock cycle. When the counter reaches (NSTOP+1) x 64 value, the lock_det signal is set high indicating that the PLL is locked. As soon as the start_stop signal is low the counter is reset to 0.
$00000400 constant RCC_CR_HSIRDY                                    \ Internal High Speed clock ready flag. Set by hardware to indicate that internal RC 64MHz oscillator is stable. This bit is activated only if the RC is enabled by HSION (it is not activated if the RC is enabled by an IP request). 0: internal RC 64 MHz oscillator not ready 1: internal RC 64 MHz oscillator ready
$00001000 constant RCC_CR_HSEPLLBUFON                               \ External High Speed Clock Buffer for PLL RF enable. Set and reset by software. 0: HSE PLL Buffer OFF 1: HSE PLL Buffer ON (default)
$00002000 constant RCC_CR_HSIPLLON                                  \ Internal High Speed Clock PLL enable 0: PLL is OFF 1: PLL is ON
$00004000 constant RCC_CR_HSIPLLRDY                                 \ Internal High Speed Clock PLL ready flag. 0: PLL is unlocked 1: PLL is locked
$00008000 constant RCC_CR_FMRAT                                     \ Force MRSUBG accurate clock ready status (for debug purpose) 0: no effect 1: active_transmission is force to '1' whatever the HSIPLLRDY/HSE status
$00010000 constant RCC_CR_HSEON                                     \ External High Speed Clock enable. Set and reset by software. in low power mode, HSE is turned off. HSE is turned ON only when RFSUBG LDO is Ready 0: HSE oscillator OFF 1: HSE oscillator ON
$00020000 constant RCC_CR_HSERDY                                    \ External High Speed Clock ready flag. Set by hardware to indicate that HSE oscillator is stable. 0: HSE oscillator not ready 1: HSE oscillator ready


\
\ @brief ICSCR register
\ Address offset: 0x04
\ Reset value: 0x3F000000
\

$00000001 constant RCC_ICSCR_LSITRIMEN                              \ Low Speed oscillator trimming enable Set and reset by software. Reset source only for this field: PORESETn 0: LSI oscillator Bias trimming disabled 1: LSI oscillator Bias trimming enabled
$00000002 constant RCC_ICSCR_LSITRIMOK                              \ LSITRIMOK: Low Speed oscillator trimming OK Set and reset by hardware to indicate when the Low Speed Internal RC oscillator has reached an optimal trimming of its bias current; this bit is only valid when LSITRIMEN is active. 0: LSI Bias trimming (LSIBW) is not good 1: LSI Bias trimming (LSIBW) value is OK
$0000003c constant RCC_ICSCR_LSIBW                                  \ Trimming in test mode The value stored is the correspondent Engi Byte and represents the actual value driving the input of the hardware macro. This value is loaded soon after the completion of the Option Byte Loading procedure. This field is directly writeable only in Test Mode.
$00070000 constant RCC_ICSCR_HSITRIMOFFSET                          \ ICSCR[18:16] = HSITRIMOFFSET[2:0]: High Speed oscillator signed trimming offset 000: 0 (+ 0 MHz / default) 001: 1 (-0.5 MHz) 010: 2 (-1MHz) 011: 3 (-1.5 MHz) 100: -1 (+2 MHz) 101: -2 (+1.5MHz) 110: -3 (+1 MHz) 111: -4 (+0.5 MHz)
$3f000000 constant RCC_ICSCR_HSITRIM                                \ High Speed Internal clock trimming. This value is loaded soon after the completion of the Option Byte Loading procedure. When max value 0x3f is set, HSI is less than 64MHz


\
\ @brief CFGR register
\ Address offset: 0x08
\ Reset value: 0x00000240
\

$00000002 constant RCC_CFGR_HSESEL                                  \ Clock source selection request: 0: HSI clock source is requested (default) 1: HSE clock source is requested
$00000004 constant RCC_CFGR_STOPHSI                                 \ Stop HSI clock source request 0: HSI is enabled (default) 1: disable HSI is requested
$00000008 constant RCC_CFGR_HSESEL_STATUS                           \ Clock source selection Status 0: HSI clock source is selected 1: HSE clock source is selected Mirror the actual system clock source, depending on clock switching mechanism and limitations
$000000e0 constant RCC_CFGR_CLKSYSDIV                               \ system clock frequency selection request 000: div1 (HSI 64M / HSE 48M) 001: div2 (HSI 32M / HSE 24M) 010: div4/div3 (HSI/HSE) (16M) 011: div8/div6 (HSI/HSE) (8M) * 100: div16/div12 (HSI/HSE) (4M) * 101: div32/div24 (HSI/HSE) (2M) * 110: div64/div48 (HSI/HSE) (1M) * Note: behavior depends on depending on CFGR.HSESEL and (*) APB2ENR.MRSUBGEN or LPAWUREN register
$00000700 constant RCC_CFGR_CLKSYSDIV_STATUS                        \ system clock frequency selection status 000: div1 (HSI 64M / HSE 48M) 001: div2 (HSI 32M / HSE 24M) 010: div4/div3 (HSI/HSE) (16M) 011: div8/div6 (HSI/HSE) (8M) 100: div16/div12 (HSI/HSE) (4M) 101: div32/div24 (HSI/HSE) (2M) 110: div64/div48 (HSI/HSE) (1M) Note: behavior depends on depending on CFGR.HSESEL and APB2ENR.MRSUBGEN register
$00001000 constant RCC_CFGR_SMPSDIV                                 \ SMPS clock prescaling factor to generate 4MHz or 8MHz 0: SMPS clock 8MHz (default ) 1: SMPS clock 4MHz
$00002000 constant RCC_CFGR_LPUCLKSEL                               \ LPUCLKSEL: Selection of LPUART clock 0: 16 MHz peripheral clock (default) 1: LSE clock (Mandatory in LPUART deepstop mode)
$00018000 constant RCC_CFGR_CLKSLOWSEL                              \ slow clock source selection Set by software to select the clock source. This is no glitch free mechanism Reset source only for this field: PORESETn 00: '0' (default) 01: LSE oscillator clock used as slow clock 10: LSI oscillator clock used as slow clock 11:HSI_64M divided by 2048 used as slow clock
$00020000 constant RCC_CFGR_IOBOOSTEN                               \ IOBOOSTEN: IO BOOSTER enable 0: IO BOOSTER block is disabled 1: IO BOOSTER block is enabled.
$00080000 constant RCC_CFGR_LCOEN                                   \ LCOEN: LCO enable on PA10 also in deepstop. 0: LCO output on PA10 is disabled 1: LCO output on PA10 is enabled.
$00c00000 constant RCC_CFGR_SPI3I2SCLKSEL                           \ SPI3I2SCLKSEL: Selection of I2S clock for SPI3 IP. 00: 32 MHz peripheral clock (default) 01: 16 MHz peripheral clock 10: CLK_SYS 11: CLK_SYS Note: the I2S clock frequency must be higher or equal to the system clock (configured through RCC_CFGR.CLKSYSDIV[2:0] bit field).
$03000000 constant RCC_CFGR_LCOSEL                                  \ Low speed Configurable Clock Output Selection. Set and reset by software. Glitches propagation possible. Reset source only for this field: PORESETn 00: LCO output disabled, no clock on LCO 01: not used 10: internal 32 KHz (LSI) oscillator clock selected 11: external 32 KHz (LSE) oscillator clock selected
$1c000000 constant RCC_CFGR_MCOSEL                                  \ Main Configurable Clock Output Selection. Set and reset by software. Glitches propagation possible. 000: MCO output disabled, no clock on MCO 001: system clock selected 010: na 011: internal RC 64 MHz (HSI) oscillator clock selected 100: external oscillator (HSE) clock selected 101: internal RC 64 MHz (HSI) oscillator divided by 2048 and used as slow clock selected 110: SMPS clock selected 111: AUX ADC ANA clock selected
$e0000000 constant RCC_CFGR_CCOPRE                                  \ Configurable Clock Output Prescaler. Set and reset by software. Glitches propagation if CCOPRE is modified after CCO output is enabled. 000: CCO clock is divided by 1 001: CCO clock is divided by 2 010: CCO clock is divided by 4 011: CCO clock is divided by 8 100: CCO clock is divided by 16 101: CCO clock is divided by 32 Others: not used


\
\ @brief CSSWCR register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant RCC_CSSWCR_LSISWTRIMEN                           \ Low Speed oscillator trimming by SW enable Set and reset by software. Reset source only for this field: PORESETn 0: LSI oscillator Bias trimming by SW disabled 1: LSI oscillator Bias trimming by SW enabled
$0000001e constant RCC_CSSWCR_LSISWBW                               \ Low Speed Internal clock trimming value to set by SW Reset source only for this field: PORESETn
$00000060 constant RCC_CSSWCR_LSEDRV                                \ Maximum Crystal gm for Low Speed External XO (to connect to XTDRV of 32kHz LSE XO => into IO V33?) to amplify drinving capacity modulation Set by software. Reset source only for this field: PORESETn 00: 0.0, low drive capability 01: 0.1, medium low drive capability 10: 1.0, medium high drive capability 11: 1.1, highdrive capability
$00800000 constant RCC_CSSWCR_HSISWTRIMEN                           \ High Speed oscillator trimming by SW enable Set and reset by software. 0: HSI oscillator Bias trimming by SW disabled 1: HSI oscillator Bias trimming by SW enabled
$3f000000 constant RCC_CSSWCR_HSITRIMSW                             \ High Speed Internal clock trimming value to set by SW.


\
\ @brief KRMR register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant RCC_KRMR_KRM_EN                                  \ KRM_EN: Variable rate multiplier Enable Reset source only for this field: PORESETn 0: KRM is disabled (default) 1: KRM is enabled.
$0000003e constant RCC_KRMR_KRM                                     \ KRM[4:0] :SMPS clock dividing Ratio (CLK_SPMS_KRM frequency= CLK_ROOT frequency (depending on RCC_CFGR.HSESEL) divided by KRM when KRMEN=1) Reset source only for this field: PORESETn - 0x00 to 0x08: SMPS clock frequency equals CLK_ROOT/8 (8.00 MHz / 6.00 MHz) - 0x09: SMPS clock frequency equals CLK_ROOT/9 (7.11 MHz / 5.33 MHz) - 0x0A: SMPS clock frequency equals CLK_ROOT/10 (6.40 MHz / 4.80 MHz) - 0x0B: SMPS clock frequency equals CLK_ROOT/11 (5.82 MHz / 4.36 MHz) - 0x0C: SMPS clock frequency equals CLK_ROOT/12 (5.33 MHz / 4.00 MHz) - 0x0D: SMPS clock frequency equals CLK_ROOT/13 (4.92 MHz / 3.69 MHz) - 0x0E: SMPS clock frequency equals CLK_ROOT/14 (4.57 MHz / 3.43 MHz) - 0x0F: SMPS clock frequency equals CLK_ROOT/15 (4.27 MHz / 3.20 MHz) - 0x10: SMPS clock frequency equals CLK_ROOT/16 (4.00 MHz / 3.00 MHz) - 0x1x: Reserved Note: SMPS clock frequency must be selected in a range [4-8] MHz (depending on RCC_KRMR.KRM and RCC_CFGR.HSESEL).


\
\ @brief CIER register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIER_LSIRDYIE                                \ LSI Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by internal RC 32 kHz oscillator stabilization. 0: LSI ready interrupt disabled 1: LSI ready interrupt enabled
$00000002 constant RCC_CIER_LSERDYIE                                \ LSE Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the external 32 kHz oscillator stabilization. 0: LSE ready interrupt disabled 1: LSE ready interrupt enabled
$00000008 constant RCC_CIER_HSIRDYIE                                \ HSI Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the internal RC 64MHz oscillator stabilization. 0: HSI ready interrupt disabled 1: HSI ready interrupt enabled
$00000010 constant RCC_CIER_HSERDYIE                                \ HSE Ready Interrupt Enable Set and reset by software to enable/disable interrupt caused by the external HSE oscillator stabilization. 0: HSE ready interrupt disabled 1: HSE ready interrupt enabled
$00000020 constant RCC_CIER_HSIPLLRDYIE                             \ HSI PLL Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the HSI 64MHz PLL locked on HSE. 0: HSI PLL ready interrupt disabled 1: HSI PLL ready interrupt enabled
$00000040 constant RCC_CIER_HSIPLLUNLOCKDETIE                       \ HSIPLLUNLOCKDETIE: HSI PLL unlock detection Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the HSI 64MHz PLL unlock. 0: HSI PLL unlock detection interrupt disabled 1: HSI PLL unlock detection interrupt enabled
$00000080 constant RCC_CIER_RTCRSTIE                                \ RTCRSTIE: RTC reset end Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the RTC reset end. 0: HSI PLL unlock detection interrupt disabled 1: HSI PLL unlock detection interrupt enabled
$00000100 constant RCC_CIER_WDGRSTIE                                \ WDGRSTIE: Watchdog reset end Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the watchdog reset end. 0: interrupt disabled 1: interrupt enabled
$00000200 constant RCC_CIER_LPURSTIE                                \ LPURSTIE: LPUART reset end Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the LPUART reset end. 0: interrupt disabled 1: interrupt enabled
$00000400 constant RCC_CIER_LCDRSTIE                                \ LCDRSTIE: LCD reset end Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the LCD reset end. 0: interrupt disabled 1: interrupt enabled
$00002000 constant RCC_CIER_LCSCRSTIE                               \ LCSCRSTIE: LCSC reset release interrupt enable. 0: LCSC reset release interrupt is disabled. 1: LCSC reset release interrupt is enabled.


\
\ @brief CIFR register
\ Address offset: 0x1C
\ Reset value: 0x00000008
\

$00000001 constant RCC_CIFR_LSIRDYIF                                \ LSI Ready Interrupt flag Set by hardware when LSI clock becomes stable. 0: No clock ready interrupt caused by the internal RC 32 KHz oscillator 1: Clock ready interrupt caused by the internal RC 32 kHz oscillator
$00000002 constant RCC_CIFR_LSERDYIF                                \ LSE Ready Interrupt Flag. Set by hardware when LSE clock becomes stable. 0: No clock ready interrupt caused by the LSE oscillator 1: Clock ready interrupt caused by the LSE oscillator
$00000008 constant RCC_CIFR_HSIRDYIF                                \ HSI Ready Interrupt Flag. Set by hardware when HSI becomes stable. 0: No clock ready interrupt caused by the HSI oscillator 1: Clock ready interrupt caused by the HSI oscillator
$00000010 constant RCC_CIFR_HSERDYIF                                \ HSE Ready Interrupt Flag. Set by hardware when HSE becomes stable. 0: No clock ready interrupt caused by the HSE oscillator 1: Clock ready interrupt caused by the HSE oscillator
$00000020 constant RCC_CIFR_HSIPLLRDYIF                             \ HSI PLL Ready Interrupt Flag. Set by hardware when HSI PLL 64MHz becomes stable. 0: No clock ready interrupt caused by the HSI PLL64 MHz oscillator 1: Clock ready interrupt caused by the HSI PLL64 MHz oscillator
$00000040 constant RCC_CIFR_HSIPLLUNLOCKDETIF                       \ HSIPLLUNLOCKDETIF: HSI PLL unlock detection Interrupt Flag.
$00000080 constant RCC_CIFR_RTCRSTIF                                \ RTC reset end Interrupt Flag. Raised when reset is released on 32kHz clock
$00000100 constant RCC_CIFR_WDGRSTIF                                \ WDG reset end Interrupt Flag. Raised when reset is released on 32kHz clock
$00000200 constant RCC_CIFR_LPURSTIF                                \ LPUART reset end Interrupt Flag. Raised when reset is released on 32kHz clock
$00000400 constant RCC_CIFR_LCDRSTIF                                \ LCD reset end Interrupt Flag. Raised when reset is released on 32kHz clock
$00002000 constant RCC_CIFR_LCSCRSTIF                               \ LCSC reset end Interrupt Flag. Raised when reset is released on 32kHz clock


\
\ @brief CSCMDR register
\ Address offset: 0x20
\ Reset value: 0x00000080
\

$00000001 constant RCC_CSCMDR_REQUEST                               \ Request for system clock switching Cleared by hardware when system clock frequency switch is done 0: To cancel an ongiong request - still possible until IRQ assertion 1: To update the system clock frequency
$0000000e constant RCC_CSCMDR_CLKSYSDIV_REQ                         \ system clock frequency selection request 000: div1 (HSI 64M / HSE) (48M) 001: div2 (HSI 32M / HSE (24M*) 010: div4/div3 (HSI/HSE) (16M) 011: div8/div6 (HSI/HSE) (8M) * 100: div16/div12 (HSI/HSE) (4M) * 101: div32/div24 (HSI/HSE) (2M) * 110: div64/div48 (HSI/HSE) (1M) * Note: behavior depends on depending on CFGR.HSESEL and (*) APB2ENR.MRSUBGEN or LPAWUREN
$00000030 constant RCC_CSCMDR_STATUS                                \ Status of clock switch sequence 00: IDLE no switch requested 01: ONGOING clock frequency switch is ongoing 10: DONE clock frequency switch done 11: Reserved
$00000040 constant RCC_CSCMDR_EOFSEQ_IE                             \ End of sequence Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the clock system switch. 0: End of sequence interrupt disabled 1: End of sequence interrupt enabled
$00000080 constant RCC_CSCMDR_EOFSEQ_IRQ                            \ End of Sequence flag Set by hardware when clock system swtich is ended 0: No end of sequence event occured 1: End of sequece event occured


\
\ @brief AHBRSTR register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHBRSTR_DMARST                               \ DMA and DMAMUX reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
$00000004 constant RCC_AHBRSTR_GPIOARST                             \ GPIOA reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
$00000008 constant RCC_AHBRSTR_GPIOBRST                             \ GPIOB reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
$00001000 constant RCC_AHBRSTR_CRCRST                               \ CRC reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
$00040000 constant RCC_AHBRSTR_RNGRST                               \ RNG reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
$00100000 constant RCC_AHBRSTR_AESRST                               \ AES reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.


\
\ @brief APB0RSTR register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB0RSTR_TIM2RST                             \ TIM2RST: TIM2 reset. 0: TIM2 IP is not under reset. 1: TIM2 IP is under reset.
$00000002 constant RCC_APB0RSTR_TIM16RST                            \ TIM16RST: TIM16 reset. 0: TIM16 IP is not under reset. 1: TIM16 IP is under reset.
$00000100 constant RCC_APB0RSTR_SYSCFGRST                           \ SYSCFGRST: system controller reset. 0: system controller IP is not under reset. 1: system controller IP is under reset.
$00000200 constant RCC_APB0RSTR_LCDCRST                             \ LCDCRST: LCD controller reset. 0: LCD controller IP is not under reset. 1: LCD controller IP is under reset.
$00000400 constant RCC_APB0RSTR_COMPRST                             \ COMPRST: COMP reset. 0: COMP IP is not under reset. 1: COMP IP is under reset.
$00000800 constant RCC_APB0RSTR_DACRST                              \ DACRST: DAC reset. 0: DAC IP is not under reset. 1: DAC IP is under reset.
$00001000 constant RCC_APB0RSTR_RTCRST                              \ RTCRST: RTC reset. 0: RTC IP is not under reset. 1: RTC IP is under reset.
$00002000 constant RCC_APB0RSTR_LCSCRST                             \ LCSCRST: LCSC reset. 0: LCSC IP is not under reset. 1: LCSC IP is under reset.
$00004000 constant RCC_APB0RSTR_WDGRST                              \ WDGRST: Watchdog reset. 0: Watchdog IP is not under reset. 1: Watchdog IP is under reset.
$00008000 constant RCC_APB0RSTR_DBGMCURST                           \ DBGMCURST: DBGMCU reset. 0: DBGMCU IP is not under reset. 1: DBGMCU IP is under reset.


\
\ @brief APB1RSTR register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1RSTR_SPI1RST                             \ SPI1 reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
$00000010 constant RCC_APB1RSTR_ADCRST                              \ ADC reset for Aux-ADC IP Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
$00000100 constant RCC_APB1RSTR_LPUARTRST                           \ LPUART reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
$00000400 constant RCC_APB1RSTR_USARTRST                            \ USART reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
$00004000 constant RCC_APB1RSTR_SPI3RST                             \ SPI3 reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
$00200000 constant RCC_APB1RSTR_I2C1RST                             \ I2C1 reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
$00800000 constant RCC_APB1RSTR_I2C2RST                             \ I2C2 reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.


\
\ @brief APB2RSTR register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2RSTR_MRSUBGRST                           \ Radio MRSUBG reset. Set and reset by software. 0: IP is not under reset. 1: IP is under reset.
$00000008 constant RCC_APB2RSTR_LPAWURRST                           \ Bubble reset Set and reset by software. 0: IP is not under reset. 1: IP is under reset.


\
\ @brief AHBENR register
\ Address offset: 0x50
\ Reset value: 0x0000000C
\

$00000001 constant RCC_AHBENR_DMAEN                                 \ DMA and DMAMUX enable Set and enable by software. 0: does not enable 1: enable
$00000004 constant RCC_AHBENR_GPIOAEN                               \ GPIOA enable. It must be enabled by default
$00000008 constant RCC_AHBENR_GPIOBEN                               \ GPIOB enable. It must be enabled by default
$00001000 constant RCC_AHBENR_CRCEN                                 \ CRC enable Set and enable by software. 0: does not enable 1: enable
$00040000 constant RCC_AHBENR_RNGEN                                 \ RNG clock enable Set and enable by software. 0: does not enable 1: enable
$00100000 constant RCC_AHBENR_AESEN                                 \ AESEN: AES clock enable. 0: AES IP is clock gated. 1: AES IP is clocked.


\
\ @brief APB0ENR register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB0ENR_TIM2EN                               \ TIM2: Advanced Timer clock enable Set and enable by software. 0: clock disable 1: clock enable
$00000002 constant RCC_APB0ENR_TIM16EN                              \ TIM16: Advanced Timer clock enable Set and enable by software. 0: clock disable 1: clock enable
$00000100 constant RCC_APB0ENR_SYSCFGEN                             \ SYSTEM CONFIG clock enable Set and enable by software. 0: clock disable 1: clock enable
$00000200 constant RCC_APB0ENR_LCDEN                                \ LCD clock enable Set and enable by software. 0: clock disable 1: clock enable
$00000400 constant RCC_APB0ENR_COMPEN                               \ COMP clock enable Set and enable by software. 0: clock disable 1: clock enable
$00000800 constant RCC_APB0ENR_DACEN                                \ DAC clock enable Set and enable by software. 0: clock disable 1: clock enable
$00001000 constant RCC_APB0ENR_RTCEN                                \ RTC clock enable Set and enable by software. Reset source only for this field: PORESETn 0: clock disable 1: clock enable
$00002000 constant RCC_APB0ENR_LCSCEN                               \ LCSC clock enable. Set and enable by software. 0: clock disable 1: clock enable
$00004000 constant RCC_APB0ENR_WDGEN                                \ Watchdog clock enable. Set and enable by software. 0: clock disable 1: clock enable
$00008000 constant RCC_APB0ENR_DBGMCUEN                             \ DBG MCU clock enable. Set and enable by software. 0: clock disable 1: clock enable


\
\ @brief APB1ENR register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1ENR_SPI1EN                               \ SPI1 clock enable Set and enable by software. 0: clock disable 1: clock enable
$00000010 constant RCC_APB1ENR_ADCDIGEN                             \ AUXADC clock enable for Aux-ADC digital clock Set and enable by software. 0: clock disable 1: clock enable
$00000020 constant RCC_APB1ENR_ADCANAEN                             \ ADC clock enable for Aux-ADC analog clock Set and enable by software. 0: clock disable 1: clock enable
$00000100 constant RCC_APB1ENR_LPUARTEN                             \ LPUART clock enable Set and enable by software. 0: clock disable 1: clock enable
$00000400 constant RCC_APB1ENR_USARTEN                              \ USART clock enable Set and enable by software. 0: clock disable 1: clock enable
$00004000 constant RCC_APB1ENR_SPI3EN                               \ SPI3 clock enable Set and enable by software. 0: clock disable 1: clock enable
$00200000 constant RCC_APB1ENR_I2C1EN                               \ I2C1 clock enable Set and enable by software. 0: clock disable 1: clock enable
$00800000 constant RCC_APB1ENR_I2C2EN                               \ I2C2 clock enable Set and enable by software. 0: clock disable 1: clock enable


\
\ @brief APB2ENR register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2ENR_MRSUBGEN                             \ MRSUBG clock enable. Note: when this bit is '1', it must prevent clk_sys different from 16, 32, 64. If the configured clock is lower than 16MHz (1, 2, 4 or 8 MHz) or equal to 24MHz, clk_sys must be 16MHz 0: clock disable 1: clock enable
$00000008 constant RCC_APB2ENR_LPAWUREN                             \ Bubble clock enable Set and enable by software. 0: clock disable 1: clock enable


\
\ @brief DBGR register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00080000 constant RCC_DBGR_DBGHSIOFF                               \ used for debug or test 0: No effect (default) 1: HSI forced off.
$00100000 constant RCC_DBGR_DBGBYPHSI                               \ used for debug mode with HSI bypassed by HSE 0: No effect (default) 1: HSI bypassed HSE.
$00200000 constant RCC_DBGR_DBGXOEXT                                \ used for debug mode with HSE bypassed by FXTAL_IN clock and ZIV12 output used. 0: No effect (default) 1: HSE bypassed by FXTAL_IN clock and ZIV12 output used.
$00400000 constant RCC_DBGR_FORCEXO48MREADY                         \ FORCEXO48MREADY Force XO48M Ready input signal This bit is for debug and force the XO48M ready input, in order to bypass XO48M comparators. 0: No effect (default) 1: Force XOREADY=1


\
\ @brief CSR register
\ Address offset: 0x94
\ Reset value: 0x0C000000
\

$00800000 constant RCC_CSR_RMVF                                     \ Remove reset flag Set by software to clear the value of the reset flags. It auto clears by HW after clearing reason flags 0: Nothing done 1: Reset the value of the reset flags
$04000000 constant RCC_CSR_PADRSTF                                  \ SYSTEM reset flag Reset by software by writing the RMVF bit. Set by hardware when a reset from pad occurs. 0: No reset from pad occurred 1: Reset from pad occurred
$08000000 constant RCC_CSR_PORRSTF                                  \ POWER reset flag Reset by software by writing the RMVF bit. Set by hardware when a power reset occurs from LPMURESET block. 0: No POWER reset occurred 1: POWER reset occurred
$10000000 constant RCC_CSR_SFTRSTF                                  \ Software reset flag Reset by software by writing the RMVF bit. Set by hardware when a software reset occurs. 0: No software reset occurred 1: Software reset occurred
$20000000 constant RCC_CSR_WDGRSTF                                  \ Watchdog reset flag Reset by software by writing the RMVF bit. Set by hardware when a watchdog reset from V33 domain occurs. 0: No watchdog reset occurred 1: Watchdog reset occurred
$40000000 constant RCC_CSR_LOCKUPRSTF                               \ LOCK UP reset flag from CM0 Reset by software by writing the RMVF bit. Set by hardware from unrecoverable exception CPU. It reset V12i domain, FLASH controller and peripherals. 0: No lockup reset occurred 1: lockup reset occurred


\
\ @brief RFSWHSECR register
\ Address offset: 0x98
\ Reset value: 0x0000803F
\

$0000007f constant RCC_RFSWHSECR_GMC                                \ GMC[6:5]: High speed external XO current control reference 00: 10 uA 01: 20 uA 1x: 40 uA GMC[4:0]: High speed external XO current control multiplying factor IcoreHSE= GMC[4:0] * GMC[6:5] Example: GMC[6:0]=0x1111001 -> IcoreHSE=25*40uA / Default 3F: IcoreHSE= 10uA x 31 = 310uA Note: this value is set only by software.
$00000080 constant RCC_RFSWHSECR_SWXOTUNEEN                         \ RF-HSE capacitor bank tuning by SW enable Set by software
$00003f00 constant RCC_RFSWHSECR_SWXOTUNE                           \ RF-HSE capacitor bank tuning value by SW Set by software
$0000c000 constant RCC_RFSWHSECR_ISTARTUP                           \ RF-HSE Startup current Set by software Default value 2
$00070000 constant RCC_RFSWHSECR_AMPLTHRESH                         \ RF-HSE Amplitude Control threshold Set by software Default value 0


\
\ @brief RFHSECR register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$0000003f constant RCC_RFHSECR_XOTUNE                               \ RF-HSE capacitor bank tuning Set by option byte loading soon after Power On Reset.
$00000040 constant RCC_RFHSECR_AMPLREADY                            \ RF-HSE Amplitude Control Ready output


\
\ @brief AHBSMENR register
\ Address offset: 0xA0
\ Reset value: 0x0014160F
\

$00000001 constant RCC_AHBSMENR_DMASMEN                             \ DMA clock enable during Sleep mode bit This bit is set and reset by software. - 0: DMA clock disabled in Sleep mode - 1: DMA clock enabled in Sleep mode (if enabled in DMAEN)
$00000002 constant RCC_AHBSMENR_FLASHSMEN                           \ Flash clocks enable during Flash Sleep PD and CPU Sleep mode bit This bit is set and reset by software. - 0: Flash clocks are disabled in Flash Sleep PD* and CPU Sleep mode - 1: Flash clocks are enabled in Sleep mode Note: Flash Sleep PD is enabled through nvm_control register CONFIG.SLEEP_PD
$00000004 constant RCC_AHBSMENR_GPIOASMEN                           \ GPIOA clock enable during Sleep mode bit This bit is set and reset by software. - 0: GPIOA clock disabled in Sleep mode - 1: GPIOA clock enabled in Sleep mode (if enabled by GPIOAEN)
$00000008 constant RCC_AHBSMENR_GPIOBSMEN                           \ GPIOB clock enable during Sleep mode bit This bit is set and reset by software. - 0: GPIOB clock disabled in Sleep mode - 1: GPIOB clock enabled in Sleep mode (if enabled in GPIOBEN)
$00000200 constant RCC_AHBSMENR_SRAM0SMEN                           \ SRAM0 clock enable during Sleep mode bit This bit is set and reset by software. - 0: SRAM0 clock disabled in Sleep mode - 1: SRAM0 clock enabled in Sleep mode
$00000400 constant RCC_AHBSMENR_SRAM1SMEN                           \ SRAM1 clock enable during Sleep mode bit This bit is set and reset by software. - 0: SRAM1 clock disabled in Sleep mode - 1: SRAM1 clock enabled in Sleep mode
$00001000 constant RCC_AHBSMENR_CRCSMEN                             \ CRC clock enable during Sleep mode bit This bit is set and reset by software. - 0: CRC clock disabled in Sleep mode - 1: CRC clock enabled in Sleep mode (if enabled in CRCEN)
$00040000 constant RCC_AHBSMENR_RNGSMEN                             \ RNG bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: RNG bus clock disabled in Sleep mode - 1: RNG bus clock enabled in Sleep mode (if enabled in RNGEN)
$00100000 constant RCC_AHBSMENR_AESSMEN                             \ AES bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: AES bus clock disabled in Sleep mode - 1: AES bus clock enabled in Sleep mode (if enabled in AESEN)


\
\ @brief APB0SMENR register
\ Address offset: 0xA4
\ Reset value: 0x0000FF03
\

$00000001 constant RCC_APB0SMENR_TIM2SMEN                           \ TIM2 bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: TIM2 bus clock disabled in Sleep mode - 1: TIM2 bus clock enabled in Sleep mode (if enabled in TIM2EN)
$00000002 constant RCC_APB0SMENR_TIM16SMEN                          \ TIM16 bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: TIM16 bus clock disabled in Sleep mode - 1: TIM16 bus clock enabled in Sleep mode (if enabled in TIM16EN)
$00000100 constant RCC_APB0SMENR_SYSCFGSMEN                         \ SYSCFG bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: SYSCFG bus clock disabled in Sleep mode - 1: SYSCFG bus clock enabled in Sleep mode (if enabled in SYSCFGEN)
$00000200 constant RCC_APB0SMENR_LCDCSMEN                           \ LCDC bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: LCDC bus clock disabled in Sleep mode - 1: LCDC bus clock enabled in Sleep mode (if enabled in LCDCEN)
$00000400 constant RCC_APB0SMENR_COMPSMEN                           \ COMP bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: COMP bus clock disabled in Sleep mode - 1: COMP bus clock enabled in Sleep mode (if enabled in COMPEN)
$00000800 constant RCC_APB0SMENR_DACSMEN                            \ DAC bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: DAC bus clock disabled in Sleep mode - 1: DAC bus clock enabled in Sleep mode (if enabled in DACEN)
$00001000 constant RCC_APB0SMENR_RTCSMEN                            \ RTC bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: RTC bus clock disabled in Sleep mode - 1: RTC bus clock enabled in Sleep mode (if enabled in RTCEN)
$00002000 constant RCC_APB0SMENR_LCSCSMEN                           \ LCSC bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: LCSC bus clock disabled in Sleep mode - 1: LCSC bus clock enabled in Sleep mode (if enabled in LCSCEN)
$00004000 constant RCC_APB0SMENR_WDGSMEN                            \ WDG clock enable during Sleep mode bit This bit is set and reset by software. - 0: WDG clock disabled in Sleep mode - 1: WDG clock enabled in Sleep mode (if enabled in WDGEN)
$00008000 constant RCC_APB0SMENR_DBGMCUSMEN                         \ DBGMCU clock enable during Sleep mode bit This bit is set and reset by software. - 0: DBGMCU clock disabled in Sleep mode - 1: DBGMCU clock enabled in Sleep mode (if enabled in DBGMCUEN)


\
\ @brief APB1SMENR register
\ Address offset: 0xA8
\ Reset value: 0x00A04511
\

$00000001 constant RCC_APB1SMENR_SPI1SMEN                           \ SPI1 bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: SPI1 bus clock disabled in Sleep mode - 1: SPI1 bus clock enabled in Sleep mode (if enabled in SPI1EN)
$00000010 constant RCC_APB1SMENR_ADCDIGSMEN                         \ ADCDIG bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: ADCDIG bus clock disabled in Sleep mode - 1: ADCDIG bus clock enabled in Sleep mode (if enabled by ADCDIGEN)
$00000100 constant RCC_APB1SMENR_LPUARTSMEN                         \ LPUART bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: LPUART bus clock disabled in Sleep mode - 1: LPUART bus clock enabled in Sleep mode (if enabled in LPUARTEN)
$00000400 constant RCC_APB1SMENR_USARTSMEN                          \ USART bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: USART bus clock disabled in Sleep mode - 1: USART bus clock enabled in Sleep mode (if enabled in USARTEN)
$00004000 constant RCC_APB1SMENR_SPI3SMEN                           \ SPI3 bus clock enable during Sleep mode bit This bit is set and reset by software. - 0: SPI3 bus clock disabled in Sleep mode - 1: SPI3 bus clock enabled in Sleep mode (if enabled in SPI3EN)
$00200000 constant RCC_APB1SMENR_I2C1SMEN                           \ I2C1 clock enable during Sleep mode bit This bit is set and reset by software. - 0: I2C1 clock disabled in Sleep mode - 1: I2C1 clock enabled in Sleep mode (if enabled in I2C1EN)
$00800000 constant RCC_APB1SMENR_I2C2SMEN                           \ I2C2 clock enable during Sleep mode bit This bit is set and reset by software. - 0: I2C2 clock disabled in Sleep mode - 1: I2C2 clock enabled in Sleep mode (if enabled in I2C2EN)


\
\ @brief Reset and Clock Controller
\
$48400000 constant RCC_CR         \ offset: 0x00 : CR register
$48400004 constant RCC_ICSCR      \ offset: 0x04 : ICSCR register
$48400008 constant RCC_CFGR       \ offset: 0x08 : CFGR register
$4840000c constant RCC_CSSWCR     \ offset: 0x0C : CSSWCR register
$48400010 constant RCC_KRMR       \ offset: 0x10 : KRMR register
$48400018 constant RCC_CIER       \ offset: 0x18 : CIER register
$4840001c constant RCC_CIFR       \ offset: 0x1C : CIFR register
$48400020 constant RCC_CSCMDR     \ offset: 0x20 : CSCMDR register
$48400030 constant RCC_AHBRSTR    \ offset: 0x30 : AHBRSTR register
$48400034 constant RCC_APB0RSTR   \ offset: 0x34 : APB0RSTR register
$48400038 constant RCC_APB1RSTR   \ offset: 0x38 : APB1RSTR register
$48400040 constant RCC_APB2RSTR   \ offset: 0x40 : APB2RSTR register
$48400050 constant RCC_AHBENR     \ offset: 0x50 : AHBENR register
$48400054 constant RCC_APB0ENR    \ offset: 0x54 : APB0ENR register
$48400058 constant RCC_APB1ENR    \ offset: 0x58 : APB1ENR register
$48400060 constant RCC_APB2ENR    \ offset: 0x60 : APB2ENR register
$48400080 constant RCC_DBGR       \ offset: 0x80 : DBGR register
$48400094 constant RCC_CSR        \ offset: 0x94 : CSR register
$48400098 constant RCC_RFSWHSECR  \ offset: 0x98 : RFSWHSECR register
$4840009c constant RCC_RFHSECR    \ offset: 0x9C : RFHSECR register
$484000a0 constant RCC_AHBSMENR   \ offset: 0xA0 : AHBSMENR register
$484000a4 constant RCC_APB0SMENR  \ offset: 0xA4 : APB0SMENR register
$484000a8 constant RCC_APB1SMENR  \ offset: 0xA8 : APB1SMENR register

