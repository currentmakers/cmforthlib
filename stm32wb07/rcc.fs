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
    $02 constant RCC_LSION                      \ [0x02] Internal Low Speed oscillator enable Set and reset by software. Reset source only for this field: PORESETn
    $03 constant RCC_LSIRDY                     \ [0x03] Internal Low Speed oscillator Ready Set and reset by hardware to indicate when the Low Speed Internal RC oscillator is stable. Reset source only for this field: PORESETn
    $04 constant RCC_LSEON                      \ [0x04] External Low Speed Clock enable. Set and reset by software. Reset source only for this field: PORESETn
    $05 constant RCC_LSERDY                     \ [0x05] External Low Speed Clock ready flag. Set by hardware to indicate that LSE oscillator is stable.
    $06 constant RCC_LSEBYP                     \ [0x06] External Low Speed Clock bypass. Set and reset by software. Reset source only for this field: PORESETn
    $07 constant RCC_LOCKDET_NSTOP              \ [0x07 : 3] Lock detector Nstop value When start_stop signal is high; a counter is incremented every 16 MHz clock cycle. When the counter reaches (NSTOP+1) x 64 value, the lock_det signal is set high indicating that the PLL is locked. As soon as the start_stop signal is low the counter is reset to 0.
    $0a constant RCC_HSIRDY                     \ [0x0a] Internal High Speed clock ready flag. Set by hardware to indicate that internal RC 64MHz oscillator is stable. This bit is activated only if the RC is enabled by HSION (it is not activated if the RC is enabled by an IP request).
    $0c constant RCC_HSEPLLBUFON                \ [0x0c] External High Speed Clock Buffer for PLL RF2G4 enable. Set and reset by software.
    $0d constant RCC_HSIPLLON                   \ [0x0d] Internal High Speed Clock PLL enable
    $0e constant RCC_HSIPLLRDY                  \ [0x0e] Internal High Speed Clock PLL ready flag.
    $10 constant RCC_HSEON                      \ [0x10] External High Speed Clock enable. Set and reset by software. in low power mode, HSE is turned off.
    $11 constant RCC_HSERDY                     \ [0x11] External High Speed Clock ready flag. Set by hardware to indicate that HSE oscillator is stable.
  [then]


  [ifdef] RCC_CFGR_DEF
    \
    \ @brief CFGR register
    \ Address offset: 0x08
    \ Reset value: 0x00000240
    \
    $00 constant RCC_SMPSINV                    \ [0x00] bit to control inversion of the SMPS clock
    $01 constant RCC_HSESEL                     \ [0x01] Clock source selection request:
    $02 constant RCC_STOPHSI                    \ [0x02] Stop HSI clock source request
    $05 constant RCC_CLKSYSDIV                  \ [0x05 : 3] CLKSYSDIV: system clock divided factor from HSI_64M.
    $0c constant RCC_SMPSDIV                    \ [0x0c] SMPS clock prescaling factor to generate 4MHz or 8MHz
    $0f constant RCC_CLKSLOWSEL                 \ [0x0f : 2] slow clock source selection Set by software to select the clock source. This is no glitch free mechanism Reset source only for this field: PORESETn
    $11 constant RCC_IOBOOSTEN                  \ [0x11] IO BOOSTER enable Set and reset by software.
    $16 constant RCC_SPI3I2SCLKSEL              \ [0x16] Selection of I2S1 clock: 1x:64MHz peripheral clock
    $17 constant RCC_SPI2I2SCLKSEL              \ [0x17] Selection of I2S clock: 1x:64MHz peripheral clock
    $18 constant RCC_LCOSEL                     \ [0x18 : 2] Low speed Configurable Clock Output Selection. Set and reset by software. Glitches propagation possible. Reset source only for this field: PORESETn
    $1a constant RCC_MCOSEL                     \ [0x1a : 3] Main Configurable Clock Output Selection. Set and reset by software. Glitches propagation possible.
    $1d constant RCC_CCOPRE                     \ [0x1d : 3] Configurable Clock Output Prescaler. Set and reset by software. Glitches propagation if CCOPRE is modified after CCO output is enabled. Others: not used
  [then]


  [ifdef] RCC_CIER_DEF
    \
    \ @brief CIER register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by internal RC 32 kHz oscillator stabilization.
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the external 32 kHz oscillator stabilization.
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the internal RC 64MHz oscillator stabilization.
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE Ready Interrupt Enable Set and reset by software to enable/disable interrupt caused by the external HSE oscillator stabilization.
    $05 constant RCC_HSIPLLRDYIE                \ [0x05] HSI PLL Ready Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the HSI 64MHz PLL locked on HSE.
    $06 constant RCC_HSIPLLUNLOCKDETIE          \ [0x06] HSIPLLUNLOCKDETIE: HSI PLL unlock detection Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the HSI 64MHz PLL unlock.
    $07 constant RCC_RTCRSTIE                   \ [0x07] RTCRSTIE: RTC reset end Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the RTC reset end.
    $08 constant RCC_WDGRSTIE                   \ [0x08] WDGRSTIE: Watchdog reset end Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the watchdog reset end.
  [then]


  [ifdef] RCC_CIFR_DEF
    \
    \ @brief CIFR register
    \ Address offset: 0x1C
    \ Reset value: 0x00000008
    \
    $00 constant RCC_LSIRDYIF                   \ [0x00] LSI Ready Interrupt flag Set by hardware when LSI clock becomes stable.
    $01 constant RCC_LSERDYIF                   \ [0x01] LSE Ready Interrupt Flag. Set by hardware when LSE clock becomes stable.
    $03 constant RCC_HSIRDYIF                   \ [0x03] HSI Ready Interrupt Flag. Set by hardware when HSI becomes stable.
    $04 constant RCC_HSERDYIF                   \ [0x04] HSE Ready Interrupt Flag. Set by hardware when HSE becomes stable.
    $05 constant RCC_HSIPLLRDYIF                \ [0x05] HSI PLL Ready Interrupt Flag. Set by hardware when HSI PLL 64MHz becomes stable.
    $06 constant RCC_HSIPLLUNLOCKDETIF          \ [0x06] HSIPLLUNLOCKDETIF: HSI PLL unlock detection Interrupt Flag.
    $07 constant RCC_RTCRSTIF                   \ [0x07] RTC reset end Interrupt Flag. Raised when reset is released on 32kHz clock
    $08 constant RCC_WDGRSTIF                   \ [0x08] WDG reset end Interrupt Flag. Raised when reset is released on 32kHz clock
  [then]


  [ifdef] RCC_CSCMDR_DEF
    \
    \ @brief CSCMDR register
    \ Address offset: 0x20
    \ Reset value: 0x00000080
    \
    $00 constant RCC_REQUEST                    \ [0x00] Request for system clock switching Cleared by hardware when system clock frequency switch is done
    $01 constant RCC_CLKSYSDIV_REQ              \ [0x01 : 3] system clock dividing factor from HSI_64M requested Note: behavior depends on BLEEN in APB2ENR register
    $04 constant RCC_STATUS                     \ [0x04 : 2] Status of clock switch sequence
    $06 constant RCC_EOFSEQ_IE                  \ [0x06] End of sequence Interrupt Enable. Set and reset by software to enable/disable interrupt caused by the clock system switch.
    $07 constant RCC_EOFSEQ_IRQ                 \ [0x07] End of Sequence flag Set by hardware when clock system swtich is ended
  [then]


  [ifdef] RCC_AHBRSTR_DEF
    \
    \ @brief AHBRSTR register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMARST                     \ [0x00] DMA and DMAMUX reset Set and reset by software.
    $02 constant RCC_GPIOARST                   \ [0x02] GPIOA reset Set and reset by software.
    $03 constant RCC_GPIOBRST                   \ [0x03] GPIOB reset Set and reset by software.
    $0c constant RCC_CRCRST                     \ [0x0c] CRC reset Set and reset by software.
    $10 constant RCC_PKARST                     \ [0x10] PKA reset Set and reset by software.
    $12 constant RCC_RNGRST                     \ [0x12] RNG reset Set and reset by software.
  [then]


  [ifdef] RCC_APB0RSTR_DEF
    \
    \ @brief APB0RSTR register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1RST                    \ [0x00] TIM1: Advanced Timer reset Set and reset by software.
    $08 constant RCC_SYSCFGRST                  \ [0x08] SYSTEM CONFIG reset Set and reset by software.
    $0c constant RCC_RTCRST                     \ [0x0c] RTC reset Set and reset by software.
    $0e constant RCC_WDGRST                     \ [0x0e] WATCHDOG reset Set and reset by software.
  [then]


  [ifdef] RCC_APB1RSTR_DEF
    \
    \ @brief APB1RSTR register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI1RST                    \ [0x00] SPI1 reset
    $04 constant RCC_ADCRST                     \ [0x04] ADC reset.
    $08 constant RCC_LPUARTRST                  \ [0x08] LPUART reset Set and reset by software.
    $0a constant RCC_USARTRST                   \ [0x0a] USART reset Set and reset by software.
    $0c constant RCC_SPI2RST                    \ [0x0c] SPI2 reset.
    $0e constant RCC_SPI3RST                    \ [0x0e] SPI3 reset Set and reset by software.
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset Set and reset by software.
    $17 constant RCC_I2C2RST                    \ [0x17] 2C2 reset.
  [then]


  [ifdef] RCC_APB2RSTR_DEF
    \
    \ @brief APB2RSTR register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MRBLERST                   \ [0x00] MR_BLE (Bluetooth radio) reset.
  [then]


  [ifdef] RCC_AHBENR_DEF
    \
    \ @brief AHBENR register
    \ Address offset: 0x50
    \ Reset value: 0x0000000C
    \
    $00 constant RCC_DMAEN                      \ [0x00] DMA and DMAMUX enable Set and enable by software.
    $02 constant RCC_GPIOAEN                    \ [0x02] GPIOA enable. It must be enabled by default
    $03 constant RCC_GPIOBEN                    \ [0x03] GPIOB enable. It must be enabled by default
    $0c constant RCC_CRCEN                      \ [0x0c] CRC enable Set and enable by software.
    $10 constant RCC_PKAEN                      \ [0x10] PKA clock enable Set and enable by software.
    $12 constant RCC_RNGEN                      \ [0x12] RNG clock enable Set and enable by software.
  [then]


  [ifdef] RCC_APB0ENR_DEF
    \
    \ @brief APB0ENR register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1EN                     \ [0x00] TIM1 enable
    $08 constant RCC_SYSCFGEN                   \ [0x08] SYSTEM CONFIG enable Set and enable by software.
    $0c constant RCC_RTCEN                      \ [0x0c] RTC clock enable Set and enable by software. Reset source only for this field: PORESETn
    $0e constant RCC_WDGEN                      \ [0x0e] Watchdog clock enable. Set and enable by software.
  [then]


  [ifdef] RCC_APB1ENR_DEF
    \
    \ @brief APB1ENR register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI1EN                     \ [0x00] SPI1 enable.
    $04 constant RCC_ADCDIGEN                   \ [0x04] ADC clock enable for digital part of the ADC block.
    $05 constant RCC_ADCANAEN                   \ [0x05] ADC clock enable for the analog part of the ADC block.
    $08 constant RCC_LPUARTEN                   \ [0x08] LPUART clock enable Set and enable by software.
    $0a constant RCC_USART1EN                   \ [0x0a] USART clock enable Set and enable by software.
    $0c constant RCC_SPI2EN                     \ [0x0c] SPI2 enable
    $0e constant RCC_SPI3EN                     \ [0x0e] SPI3 clock enable Set and enable by software.
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 clock enable Set and enable by software.
    $17 constant RCC_I2C2EN                     \ [0x17] I2C2 enable.
  [then]


  [ifdef] RCC_APB2ENR_DEF
    \
    \ @brief APB2ENR register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MRBLEEN                    \ [0x00] MR_BLE enable
    $02 constant RCC_CLKBLEDIV                  \ [0x02] MR_BLE clock frequency selection when RCC_APB2ENR.MRBLEEN=1
  [then]


  [ifdef] RCC_CSR_DEF
    \
    \ @brief CSR register
    \ Address offset: 0x94
    \ Reset value: 0x0C000000
    \
    $17 constant RCC_RMVF                       \ [0x17] Remove reset flag Set by software to clear the value of the reset flags. It auto clears by HW after clearing reason flags
    $1a constant RCC_PADRSTF                    \ [0x1a] SYSTEM reset flag Reset by software by writing the RMVF bit. Set by hardware when a reset from pad occurs.
    $1b constant RCC_PORRSTF                    \ [0x1b] POWER reset flag Reset by software by writing the RMVF bit. Set by hardware when a power reset occurs from LPMURESET block.
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag Reset by software by writing the RMVF bit. Set by hardware when a software reset occurs.
    $1d constant RCC_WDGRSTF                    \ [0x1d] Watchdog reset flag Reset by software by writing the RMVF bit. Set by hardware when a watchdog reset from V33 domain occurs.
    $1e constant RCC_LOCKUPRSTF                 \ [0x1e] LOCK UP reset flag from CM0 Reset by software by writing the RMVF bit. Set by hardware from unrecoverable exception CPU. It reset V12i domain, FLASH controller and peripherals.
  [then]


  [ifdef] RCC_RFSWHSECR_DEF
    \
    \ @brief RFSWHSECR register
    \ Address offset: 0x98
    \ Reset value: 0x00000030
    \
    $03 constant RCC_SATRG                      \ [0x03] Sense Amplifier threshold Set by software.
    $04 constant RCC_GMC                        \ [0x04 : 3] High Speed External XO current control Set by software.
    $07 constant RCC_SWXOTUNEEN                 \ [0x07] RF-HSE capacitor bank tuning by SW enable Set by software
    $08 constant RCC_SWXOTUNE                   \ [0x08 : 6] RF-HSE capacitor bank tuning value by SW Set by software
  [then]


  [ifdef] RCC_RFHSECR_DEF
    \
    \ @brief RFHSECR register
    \ Address offset: 0x9C
    \ Reset value: 0x    NULL
    \
    $00 constant RCC_XOTUNE                     \ [0x00 : 6] RF-HSE capacitor bank tuning Set by option byte loading soon after Power On Reset.
  [then]

  \
  \ @brief Reset and Clock Controller
  \
  $00 constant RCC_CR                   \ CR register
  $08 constant RCC_CFGR                 \ CFGR register
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
  $94 constant RCC_CSR                  \ CSR register
  $98 constant RCC_RFSWHSECR            \ RFSWHSECR register
  $9C constant RCC_RFHSECR              \ RFHSECR register

: RCC_DEF ; [then]
