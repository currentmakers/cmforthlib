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

$00000004 constant RCC_CR_LSION                                     \ Internal Low Speed oscillator enable Set and reset by software. Reset source only for this field: PORESETn
$00000008 constant RCC_CR_LSIRDY                                    \ Internal Low Speed oscillator Ready Set and reset by hardware to indicate when the Low Speed Internal RC oscillator is stable. Reset source only for this field: PORESETn
$00000010 constant RCC_CR_LSEON                                     \ External Low Speed Clock enable. Set and reset by software. Reset source only for this field: PORESETn
$00000020 constant RCC_CR_LSERDY                                    \ External Low Speed Clock ready flag. Set by hardware to indicate that LSE oscillator is stable.
$00000040 constant RCC_CR_LSEBYP                                    \ External Low Speed Clock bypass. Set and reset by software. Reset source only for this field: PORESETn
$00000380 constant RCC_CR_LOCKDET_NSTOP                             \ Lock detector Nstop value When start_stop signal is high; a counter is incremented every 16 MHz clock cycle. When the counter reaches (NSTOP+1) x 64 value, the lock_det signal is set high indicating that the PLL is locked. As soon as the start_stop signal is low the counter is reset to 0.
$00000400 constant RCC_CR_HSIRDY                                    \ Internal High Speed clock ready flag. Set by hardware to indicate that internal RC 64MHz oscillator is stable. This bit is activated only if the RC is enabled by HSION (it is not activated if the RC is enabled by an IP request).
$00001000 constant RCC_CR_HSEPLLBUFON                               \ External High Speed Clock Buffer for PLL RF2G4 enable. Set and reset by software.
$00002000 constant RCC_CR_HSIPLLON                                  \ Internal High Speed Clock PLL enable
$00004000 constant RCC_CR_HSIPLLRDY                                 \ Internal High Speed Clock PLL ready flag.
$00010000 constant RCC_CR_HSEON                                     \ External High Speed Clock enable. Set and reset by software. in low power mode, HSE is turned off.
$00020000 constant RCC_CR_HSERDY                                    \ External High Speed Clock ready flag. Set by hardware to indicate that HSE oscillator is stable.


\
\ @brief CFGR register
\ Address offset: 0x08
\ Reset value: 0x00000240
\

$00000001 constant RCC_CFGR_SMPSINV                                 \ bit to control inversion of the SMPS clock
$00000002 constant RCC_CFGR_HSESEL                                  \ Clock source selection request:
$00000004 constant RCC_CFGR_STOPHSI                                 \ Stop HSI clock source request
$000000e0 constant RCC_CFGR_CLKSYSDIV                               \ CLKSYSDIV: system clock divided factor from HSI_64M.
$00001000 constant RCC_CFGR_SMPSDIV                                 \ SMPS clock prescaling factor to generate 4MHz or 8MHz
$00018000 constant RCC_CFGR_CLKSLOWSEL                              \ slow clock source selection Set by software to select the clock source. This is no glitch free mechanism Reset source only for this field: PORESETn
$00020000 constant RCC_CFGR_IOBOOSTEN                               \ IO BOOSTER enable Set and reset by software.
$00400000 constant RCC_CFGR_SPI3I2SCLKSEL                           \ Selection of I2S1 clock: 1x:64MHz peripheral clock
$00800000 constant RCC_CFGR_SPI2I2SCLKSEL                           \ Selection of I2S clock: 1x:64MHz peripheral clock
$03000000 constant RCC_CFGR_LCOSEL                                  \ Low speed Configurable Clock Output Selection. Set and reset by software. Glitches propagation possible. Reset source only for this field: PORESETn
$1c000000 constant RCC_CFGR_MCOSEL                                  \ Main Configurable Clock Output Selection. Set and reset by software. Glitches propagation possible.
$e0000000 constant RCC_CFGR_CCOPRE                                  \ Configurable Clock Output Prescaler. Set and reset by software. Glitches propagation if CCOPRE is modified after CCO output is enabled. Others: not used


\
\ @brief CIER register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIER_LSIRDYIE                                \ LSI Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by internal RC 32 kHz oscillator stabilization.
$00000002 constant RCC_CIER_LSERDYIE                                \ LSE Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the external 32 kHz oscillator stabilization.
$00000008 constant RCC_CIER_HSIRDYIE                                \ HSI Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the internal RC 64MHz oscillator stabilization.
$00000010 constant RCC_CIER_HSERDYIE                                \ HSE Ready Interrupt Enable Set and reset by software to enable/disable interrupt caused by the external HSE oscillator stabilization.
$00000020 constant RCC_CIER_HSIPLLRDYIE                             \ HSI PLL Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the HSI 64MHz PLL locked on HSE.
$00000040 constant RCC_CIER_HSIPLLUNLOCKDETIE                       \ HSIPLLUNLOCKDETIE: HSI PLL unlock detection Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the HSI 64MHz PLL unlock.
$00000080 constant RCC_CIER_RTCRSTIE                                \ RTCRSTIE: RTC reset end Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the RTC reset end.
$00000100 constant RCC_CIER_WDGRSTIE                                \ WDGRSTIE: Watchdog reset end Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the watchdog reset end.


\
\ @brief CIFR register
\ Address offset: 0x1C
\ Reset value: 0x00000008
\

$00000001 constant RCC_CIFR_LSIRDYIF                                \ LSI Ready Interrupt flag Set by hardware when LSI clock becomes stable.
$00000002 constant RCC_CIFR_LSERDYIF                                \ LSE Ready Interrupt Flag. Set by hardware when LSE clock becomes stable.
$00000008 constant RCC_CIFR_HSIRDYIF                                \ HSI Ready Interrupt Flag. Set by hardware when HSI becomes stable.
$00000010 constant RCC_CIFR_HSERDYIF                                \ HSE Ready Interrupt Flag. Set by hardware when HSE becomes stable.
$00000020 constant RCC_CIFR_HSIPLLRDYIF                             \ HSI PLL Ready Interrupt Flag. Set by hardware when HSI PLL 64MHz becomes stable.
$00000040 constant RCC_CIFR_HSIPLLUNLOCKDETIF                       \ HSIPLLUNLOCKDETIF: HSI PLL unlock detection Interrupt Flag.
$00000080 constant RCC_CIFR_RTCRSTIF                                \ RTC reset end Interrupt Flag. Raised when reset is released on 32kHz clock
$00000100 constant RCC_CIFR_WDGRSTIF                                \ WDG reset end Interrupt Flag. Raised when reset is released on 32kHz clock


\
\ @brief CSCMDR register
\ Address offset: 0x20
\ Reset value: 0x00000080
\

$00000001 constant RCC_CSCMDR_REQUEST                               \ Request for system clock switching Cleared by hardware when system clock frequency switch is done
$0000000e constant RCC_CSCMDR_CLKSYSDIV_REQ                         \ system clock dividing factor from HSI_64M requested Note: behavior depends on BLEEN in APB2ENR register
$00000030 constant RCC_CSCMDR_STATUS                                \ Status of clock switch sequence
$00000040 constant RCC_CSCMDR_EOFSEQ_IE                             \ End of sequence Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the clock system switch.
$00000080 constant RCC_CSCMDR_EOFSEQ_IRQ                            \ End of Sequence flag Set by hardware when clock system swtich is ended


\
\ @brief AHBRSTR register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHBRSTR_DMARST                               \ DMA and DMAMUX reset Set and reset by software.
$00000004 constant RCC_AHBRSTR_GPIOARST                             \ GPIOA reset Set and reset by software.
$00000008 constant RCC_AHBRSTR_GPIOBRST                             \ GPIOB reset Set and reset by software.
$00001000 constant RCC_AHBRSTR_CRCRST                               \ CRC reset Set and reset by software.
$00010000 constant RCC_AHBRSTR_PKARST                               \ PKA reset Set and reset by software.
$00040000 constant RCC_AHBRSTR_RNGRST                               \ RNG reset Set and reset by software.


\
\ @brief APB0RSTR register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB0RSTR_TIM1RST                             \ TIM1: Advanced Timer reset Set and reset by software.
$00000100 constant RCC_APB0RSTR_SYSCFGRST                           \ SYSTEM CONFIG reset Set and reset by software.
$00001000 constant RCC_APB0RSTR_RTCRST                              \ RTC reset Set and reset by software.
$00004000 constant RCC_APB0RSTR_WDGRST                              \ WATCHDOG reset Set and reset by software.


\
\ @brief APB1RSTR register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1RSTR_SPI1RST                             \ SPI1 reset
$00000010 constant RCC_APB1RSTR_ADCRST                              \ ADC reset.
$00000100 constant RCC_APB1RSTR_LPUARTRST                           \ LPUART reset Set and reset by software.
$00000400 constant RCC_APB1RSTR_USARTRST                            \ USART reset Set and reset by software.
$00001000 constant RCC_APB1RSTR_SPI2RST                             \ SPI2 reset.
$00004000 constant RCC_APB1RSTR_SPI3RST                             \ SPI3 reset Set and reset by software.
$00200000 constant RCC_APB1RSTR_I2C1RST                             \ I2C1 reset Set and reset by software.
$00800000 constant RCC_APB1RSTR_I2C2RST                             \ 2C2 reset.


\
\ @brief APB2RSTR register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2RSTR_MRBLERST                            \ MR_BLE (Bluetooth radio) reset.


\
\ @brief AHBENR register
\ Address offset: 0x50
\ Reset value: 0x0000000C
\

$00000001 constant RCC_AHBENR_DMAEN                                 \ DMA and DMAMUX enable Set and enable by software.
$00000004 constant RCC_AHBENR_GPIOAEN                               \ GPIOA enable. It must be enabled by default
$00000008 constant RCC_AHBENR_GPIOBEN                               \ GPIOB enable. It must be enabled by default
$00001000 constant RCC_AHBENR_CRCEN                                 \ CRC enable Set and enable by software.
$00010000 constant RCC_AHBENR_PKAEN                                 \ PKA clock enable Set and enable by software.
$00040000 constant RCC_AHBENR_RNGEN                                 \ RNG clock enable Set and enable by software.


\
\ @brief APB0ENR register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB0ENR_TIM1EN                               \ TIM1 enable
$00000100 constant RCC_APB0ENR_SYSCFGEN                             \ SYSTEM CONFIG enable Set and enable by software.
$00001000 constant RCC_APB0ENR_RTCEN                                \ RTC clock enable Set and enable by software. Reset source only for this field: PORESETn
$00004000 constant RCC_APB0ENR_WDGEN                                \ Watchdog clock enable. Set and enable by software.


\
\ @brief APB1ENR register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1ENR_SPI1EN                               \ SPI1 enable.
$00000010 constant RCC_APB1ENR_ADCDIGEN                             \ ADC clock enable for digital part of the ADC block.
$00000020 constant RCC_APB1ENR_ADCANAEN                             \ ADC clock enable for the analog part of the ADC block.
$00000100 constant RCC_APB1ENR_LPUARTEN                             \ LPUART clock enable Set and enable by software.
$00000400 constant RCC_APB1ENR_USART1EN                             \ USART clock enable Set and enable by software.
$00001000 constant RCC_APB1ENR_SPI2EN                               \ SPI2 enable
$00004000 constant RCC_APB1ENR_SPI3EN                               \ SPI3 clock enable Set and enable by software.
$00200000 constant RCC_APB1ENR_I2C1EN                               \ I2C1 clock enable Set and enable by software.
$00800000 constant RCC_APB1ENR_I2C2EN                               \ I2C2 enable.


\
\ @brief APB2ENR register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2ENR_MRBLEEN                              \ MR_BLE enable
$00000004 constant RCC_APB2ENR_CLKBLEDIV                            \ MR_BLE clock frequency selection when RCC_APB2ENR.MRBLEEN=1


\
\ @brief CSR register
\ Address offset: 0x94
\ Reset value: 0x0C000000
\

$00800000 constant RCC_CSR_RMVF                                     \ Remove reset flag Set by software to clear the value of the reset flags. It auto clears by HW after clearing reason flags
$04000000 constant RCC_CSR_PADRSTF                                  \ SYSTEM reset flag Reset by software by writing the RMVF bit. Set by hardware when a reset from pad occurs.
$08000000 constant RCC_CSR_PORRSTF                                  \ POWER reset flag Reset by software by writing the RMVF bit. Set by hardware when a power reset occurs from LPMURESET block.
$10000000 constant RCC_CSR_SFTRSTF                                  \ Software reset flag Reset by software by writing the RMVF bit. Set by hardware when a software reset occurs.
$20000000 constant RCC_CSR_WDGRSTF                                  \ Watchdog reset flag Reset by software by writing the RMVF bit. Set by hardware when a watchdog reset from V33 domain occurs.
$40000000 constant RCC_CSR_LOCKUPRSTF                               \ LOCK UP reset flag from CM0 Reset by software by writing the RMVF bit. Set by hardware from unrecoverable exception CPU. It reset V12i domain, FLASH controller and peripherals.


\
\ @brief RFSWHSECR register
\ Address offset: 0x98
\ Reset value: 0x00000030
\

$00000008 constant RCC_RFSWHSECR_SATRG                              \ Sense Amplifier threshold Set by software.
$00000070 constant RCC_RFSWHSECR_GMC                                \ High Speed External XO current control Set by software.
$00000080 constant RCC_RFSWHSECR_SWXOTUNEEN                         \ RF-HSE capacitor bank tuning by SW enable Set by software
$00003f00 constant RCC_RFSWHSECR_SWXOTUNE                           \ RF-HSE capacitor bank tuning value by SW Set by software


\
\ @brief RFHSECR register
\ Address offset: 0x9C
\ Reset value: 0x    NULL
\

$0000003f constant RCC_RFHSECR_XOTUNE                               \ RF-HSE capacitor bank tuning Set by option byte loading soon after Power On Reset.


\
\ @brief Reset and Clock Controller
\
$48400000 constant RCC_CR         \ offset: 0x00 : CR register
$48400008 constant RCC_CFGR       \ offset: 0x08 : CFGR register
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
$48400094 constant RCC_CSR        \ offset: 0x94 : CSR register
$48400098 constant RCC_RFSWHSECR  \ offset: 0x98 : RFSWHSECR register
$4840009c constant RCC_RFHSECR    \ offset: 0x9C : RFHSECR register

